using eTraining.BussinessModels;
using eTraining.BussinessObjects;
using eTraining.DataObjects;
using eTraining.Helpers.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class TestController : AdminController
    {
        // GET: User
        public TestController()
        {
            IsAllowAddUpdate = true;
            TableName = "tblTest";
        }
        // GET: User

        [HttpPost]
        public JsonResult GetSingle(long id = 0)
        {
            object[] parms = new object[] { "@tableName", TableName };
            DataTable table = new SqlFieldFilterAutoDao().GetDataTable(parms, "cofTableRenderAuto_GetAllColumnForFilter");
            List<FieldAddUpdateAuto> fieldAU = new List<FieldAddUpdateAuto>();
            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row["FieldType"] != null)
                    {
                        FieldAddUpdateAuto field = new FieldAddUpdateAuto()
                        {
                            FieldName = row["COLUMN_NAME"].ToString(),
                            FieldType = row["FieldType"].ToString()
                        };
                        fieldAU.Add(field);
                    }
                }
            }
            Test Test = new SqlTestDao().GetSingle(id);
            EditTableField fieldId = new EditTableField() { FieldName = "ID", FieldType = 0, FieldValue = id.ToString() };
            List<EditTableField> editFields = Mapper.MapObjectToEditModel<Test>(Test, fieldAU);
            editFields.Add(fieldId);
            return Json(editFields, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult AddUpdate(Test model)
        {
            model.Status = model.ID > 0 ? model.Status : (short)1;
            model.CreatedDate = DateTime.Now;
            if (new SqlTestDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("/Admin/Test");
        }
    }
}
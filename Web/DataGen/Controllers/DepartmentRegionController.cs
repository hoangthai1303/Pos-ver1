using eTraining.BussinessObjects;
using eTraining.DataObjects;
using System;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class DepartmentRegionController : AdminController
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.TableName = "tblDepartmentRegion";
            return View();
        }

        [HttpPost]
        public ActionResult AddUpdate(DepartmentRegion model)
        {
            model.Status = 1;
            model.CreatedDate = DateTime.Now;
            if (new SqlDepartmentRegionDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("/Admin/DepartmentRegion");
        }
    }
}
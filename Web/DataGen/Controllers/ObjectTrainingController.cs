using eTraining.BussinessObjects;
using eTraining.DataObjects;
using System;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class ObjectTrainingController : AdminController
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.TableName = "tblObjectTraining";
            return View();
        }

        [HttpPost]
        public ActionResult AddUpdate(ObjectTraining model)
        {
            model.Status = 1;
            model.CreatedDate = DateTime.Now;
            if (new SqlObjectTrainingDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("/Admin/ObjectTraining");
        }
    }
}
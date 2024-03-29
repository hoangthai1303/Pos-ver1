using eTraining.BussinessObjects;
using eTraining.DataObjects;
using System;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class TrainingTypeController : AdminController
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.TableName = "tblTrainingType";
            return View();
        }

        [HttpPost]
        public ActionResult AddUpdate(TrainingType model)
        {
            model.Status = 1;
            model.CreatedDate = DateTime.Now;
            if (new SqlTrainingTypeDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("/Admin/TrainingType");
        }
    }
}
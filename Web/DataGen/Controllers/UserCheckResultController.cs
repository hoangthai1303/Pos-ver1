using eTraining.BussinessObjects;
using eTraining.DataObjects;
using System;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class UserCheckResultController : AdminController
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.TableName = "tblUserCheckResult";
            return View();
        }

        [HttpPost]
        public ActionResult AddUpdate(UserCheckResult model)
        {
            model.Status = 1;
            model.CreatedDate = DateTime.Now;
            if (new SqlUserCheckResultDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("/Admin/UserCheckResult");
        }
    }
}
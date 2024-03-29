using eTraining.BussinessObjects;
using eTraining.DataObjects;
using System;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class UserTitleController : AdminController
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.TableName = "tblUserTitle";
            return View();
        }

        [HttpPost]
        public ActionResult AddUpdate(UserTitle model)
        {
            model.Status = 1;
            model.CreatedDate = DateTime.Now;
            if (new SqlUserTitleDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("/Admin/UserTitle");
        }
    }
}
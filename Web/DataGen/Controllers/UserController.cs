using eTraining.BussinessObjects;
using eTraining.DataObjects;
using System;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class UserController : AdminController
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.TableName = "tblUser";
            return View();
        }

        [HttpPost]
        public ActionResult AddUpdate(User model)
        {
            model.Status = 1;
            model.CreatedDate = DateTime.Now;
            if (new SqlUserDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("/Admin/User");
        }
    }
}
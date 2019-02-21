using eTraining.BussinessObjects;
using eTraining.DataObjects;
using System;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class CheckController : AdminController
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.TableName = "tblCheck";
            return View();
        }

        [HttpPost]
        public ActionResult AddUpdate(Check model)
        {
            model.Status = 1;
            model.CreatedDate = DateTime.Now;
            if (new SqlCheckDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("/Admin/Check");
        }
    }
}
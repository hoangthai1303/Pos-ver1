using eTraining.BussinessObjects;
using eTraining.DataObjects;
using System;
using System.Web.Mvc;

namespace .Controllers
{
    public class RegionController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.TableName = "tblRegion";
            return View();
        }

        [HttpPost]
        public ActionResult AddUpdate(Region model)
        {
            model.Status = 1;
            model.CreatedDate = DateTime.Now;
            if (new SqlRegionDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("//Region");
        }
    }
}
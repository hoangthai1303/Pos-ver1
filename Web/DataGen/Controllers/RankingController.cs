using eTraining.BussinessObjects;
using eTraining.DataObjects;
using System;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class RankingController : AdminController
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.TableName = "tblRanking";
            return View();
        }

        [HttpPost]
        public ActionResult AddUpdate(Ranking model)
        {
            model.Status = 1;
            model.CreatedDate = DateTime.Now;
            if (new SqlRankingDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("/Admin/Ranking");
        }
    }
}
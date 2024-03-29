using eTraining.BussinessObjects;
using eTraining.DataObjects;
using System;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class TitleController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            DefaultListModel model = new DefaultListModel()
            {
                TableName = "tblUser",
                TargetArea = Request.RequestContext.RouteData.DataTokens["area"].ToString(),
                ControllerName = Request.RequestContext.RouteData.Values["controller"].ToString(),
                IsAllowAddUpdate = IsAllowAddUpdate
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult AddUpdate(Title model)
        {
            model.Status = 1;
            model.CreatedDate = DateTime.Now;
            if (new SqlTitleDao().Insert(model))
            {
                TempData["success"] = "Cập nhật thành công";
            }
            else
            {
                TempData["error"] = "Cập nhật thất bại";
            }
            return Redirect("//Title");
        }
    }
}
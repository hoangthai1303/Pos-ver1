﻿using System.Web.Mvc;

namespace Web.Areas.Categories
{
    public class CategoriesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Categories";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
               "Categories_default",
               "Categories/{controller}/{action}/{id}",
               new { action = "Index", id = UrlParameter.Optional },
               namespaces: new string[] { "Categories.Controllers" }
           );
        }
    }
}
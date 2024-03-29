﻿using System.Web.Mvc;

namespace eTraining.Web.Areas.TaskList
{
    public class TaskListAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TaskList";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
               "TaskList_default",
               "TaskList/{controller}/{action}/{id}",
               new { action = "Index", id = UrlParameter.Optional },
               namespaces: new string[] { "TaskList.Controllers" }
           );
        }
    }
}
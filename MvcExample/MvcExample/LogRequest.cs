using System;
using System.Diagnostics;
using System.IO;
using System.Web.Mvc;
using NLog;

namespace MvcExample
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Info($"You call Action: {filterContext.ActionDescriptor.ActionName} on Controller: " +
                        $"{filterContext.ActionDescriptor.ControllerDescriptor.ControllerName}");
        }
    }
}
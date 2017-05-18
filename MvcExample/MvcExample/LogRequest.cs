using System;
using System.Diagnostics;
using System.IO;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using NLog;

namespace MvcExample
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Info($"You call Action: {filterContext.ActionDescriptor.ActionName} on Controller: " +
                        $"{filterContext.ActionDescriptor.ControllerDescriptor.ControllerName}");
        }
    }

    public class ErrorFilterAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Fatal($"Message: {filterContext.Exception.Message}\r" +
                        $"{filterContext.Exception.StackTrace}");

            filterContext.Result = new ContentResult
            {
                Content = "Exception was throw"
            };

            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.StatusCode = 500;
            filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
        }
    }

    public class AuthFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {

            bool isUserAuth = filterContext.HttpContext.User.Identity.IsAuthenticated;

            if (!isUserAuth)
            {
                filterContext.Result = new ContentResult
                {
                    Content = "Please enter another login"
                };


                filterContext.HttpContext.Response.Clear();
                filterContext.HttpContext.Response.StatusCode = 401;
                filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
            }
        }
    }
}
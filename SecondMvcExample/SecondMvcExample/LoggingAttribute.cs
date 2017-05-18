using System.Linq;
using System.Web.Mvc;

namespace SecondMvcExample
{
    public class LoggingAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string actionName = filterContext.ActionDescriptor.ActionName;
        }
    }
}
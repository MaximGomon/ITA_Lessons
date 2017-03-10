using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcExample.Models;

namespace MvcExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static List<TableItem> Items = new List<TableItem>(); 
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_End()
        {
            
        }

        protected void Begin_Request()
        {

        }

        protected void End_Request()
        {

        }
    }
}

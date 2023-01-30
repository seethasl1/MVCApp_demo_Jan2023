using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCApp_demo_new
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "registration",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "CustRegi", id = UrlParameter.Optional }
            );
        }
    }
}

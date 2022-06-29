using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication10
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


          
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{n}",
                defaults: new { controller = "Home", action = "Index", n = UrlParameter.Optional }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AddBooks",
                url: "Home/AddBooks",
                defaults: new { controller = "Home", action = "AddBooks", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "showBooks",
                url: "Home/showBooks",
                defaults: new { controller = "Home", action = "showBooks", id = UrlParameter.Optional }
                );


            routes.MapRoute(
                name: "home",
                url: "Home",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

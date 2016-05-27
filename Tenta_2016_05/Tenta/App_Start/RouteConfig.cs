using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tenta
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Hexa",
                url: "SpriteController/Hexa/{id}",
                defaults: new { controller = "Sprite", action = "Hexa", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Octa",
                url: "SpriteController/Octa/{id}",
                defaults: new { controller = "Sprite", action = "Octa", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TentaASP.NET
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
    name: "Hands",
    url: "CreamController/Hands/{id}",
    defaults: new { controller = "Cream", action = "Hands", id = UrlParameter.Optional }
);
            routes.MapRoute(
                name: "Facial",
                url: "CreamController/Facial/{id}",
                defaults: new { controller = "Cream", action = "Facial", id = UrlParameter.Optional }

            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );
        }
    }
}

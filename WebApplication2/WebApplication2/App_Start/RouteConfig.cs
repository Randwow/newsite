﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //routes.MapRoute(
            //    name: "Register",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    name: "Contact",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //     name: "Test",
            //     url: "{controller}/{action}/{id}",
            //     defaults: new { controller = "Test", action = "Test", id = UrlParameter.Optional }
            //);
        }
    }
}

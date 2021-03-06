﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TareaDeCiudades
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "CiudadList",
                "Home/Ciudades/List/{ProvinciaId}",
                new { controller = "Home", action = "CiudadList", ProvinciaId = "" }
                );

            routes.MapRoute(
                "ProvinciaList",
                "Home/Provincias/List",
                new { controller = "Home", action = "ProvinciaList" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

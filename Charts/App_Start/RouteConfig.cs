﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using System.Web.Http;

namespace Charts
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            RouteTable.Routes.MapHttpRoute(
                       name: "DefaultApi",
                       routeTemplate: "api/{controller}/{action}/{id}",
                       defaults: new { id = System.Web.Http.RouteParameter.Optional }
                   );
        }
    }
}

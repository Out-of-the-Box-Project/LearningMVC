using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AddressBook
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Create Contact",
                url: "contacts/create-contact",
                defaults: new { controller = "Contacts", action = "CreateContact" }
            );

            routes.MapRoute(
                name: "Contacts",
                url: "contacts",
                defaults: new { controller = "Contacts", action = "Index" }
            );

            routes.MapRoute(
                name: "ViewContact",
                url: "contacts/{id}",
                defaults: new { controller = "Contacts", action = "ViewContact", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace API
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{id1}/{id2}/{id3}/{id4}/{id5}/{id6}/{id7}/{id8}/{id9}/{id10}/{id11}",
                defaults: new { controller = "PACIENTE", action = "GetPACIENTE", 
                    id = UrlParameter.Optional,
                    id1 = UrlParameter.Optional,
                    id2 = UrlParameter.Optional,
                    id3 = UrlParameter.Optional,
                    id4 = UrlParameter.Optional,
                    id5= UrlParameter.Optional,
                    id6 = UrlParameter.Optional,
                    id7 = UrlParameter.Optional,
                    id8 = UrlParameter.Optional,
                    id9 = UrlParameter.Optional,
                    id10 = UrlParameter.Optional,
                    id11 = UrlParameter.Optional,
                }
            );
        }
    }
}

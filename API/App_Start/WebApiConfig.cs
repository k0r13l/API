using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}/{id1}/{id2}/{id3}/{id4}/{id5}/{id6}/{id7}/{id8}/{id9}/{id10}/{id11}",
                defaults: new { 
                    id = RouteParameter.Optional,
                    id1 = RouteParameter.Optional,
                    id2 = RouteParameter.Optional,
                    id3 = RouteParameter.Optional,
                    id4 = RouteParameter.Optional,
                    id5 = RouteParameter.Optional,
                    id6 = RouteParameter.Optional,
                    id7 = RouteParameter.Optional,
                    id8 = RouteParameter.Optional,
                    id9 = RouteParameter.Optional,
                    id10 = RouteParameter.Optional,
                    id11 = RouteParameter.Optional
                }
            );
        }
    }
}

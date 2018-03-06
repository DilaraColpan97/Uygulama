using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlogA
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
            routes.MapRoute("Home", "", new { controller = "Posts", action="Index"});
            //This line describs that, home page will be responsed by Posts Controller's Index Action
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" });
        }
    }
}

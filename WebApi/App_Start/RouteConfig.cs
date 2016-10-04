using System.Web.Mvc;
using System.Web.Routing;

namespace WebApi
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

//            routes.MapRoute(
//                name: "Users",
//                url: "api/users/{id}",
//                defaults: new { controller = "Users", action = "Index", id = UrlParameter.Optional }
//            );
//
//            routes.MapRoute(
//                name: "Posts",
//                url: "api/posts/{id}",
//                defaults: new { controller = "Posts", action = "Index", id = UrlParameter.Optional }
//            );
        }
    }
}

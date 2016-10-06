using Microsoft.Owin.Security.OAuth;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Users",
                routeTemplate: "api/users",
                defaults: new { controller = "users"}
            );

            config.Routes.MapHttpRoute(
                name: "Posts",
                routeTemplate: "api/posts/{userId}",
                defaults: new { controller = "posts", userId = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Comments",
                routeTemplate: "api/posts/{postId}/comments/{id}",
                defaults: new { controller = "posts", id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}

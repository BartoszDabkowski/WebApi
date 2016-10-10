using Microsoft.Owin.Security.OAuth;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using WebApi.Services;

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
                name: "Users",
                routeTemplate: "api/users/{userId}",
                defaults: new { controller = "users", userId = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Posts",
                routeTemplate: "api/posts/{postId}",
                defaults: new { controller = "posts", postId = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "UsersPosts",
                routeTemplate: "api/users/{userId}/posts/{postId}",
                defaults: new { controller = "posts", postId = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Comments",
                routeTemplate: "api/posts/{postId}/comments",
                defaults: new { controller = "comments"}
            );

            config.Routes.MapHttpRoute(
                name: "UsersComments",
                routeTemplate: "api/users/{userId}/posts/{postId}/comments",
                defaults: new { controller = "comments"}
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.Services.Replace(typeof(IHttpControllerSelector), new WebApiControllerSelector(config));

#if !DEBUG
            // Force HTTPS on entire API
            config.Filters.Add(new RequireHttpsAttribute());
#endif
        }
    }
}

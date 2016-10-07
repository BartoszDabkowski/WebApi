using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace WebApi.Services
{
    public class WebApiControllerSelector : DefaultHttpControllerSelector
    {
        private HttpConfiguration _configuration;

        public WebApiControllerSelector(HttpConfiguration configuration)
            :base(configuration)
        {
            _configuration = configuration;
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            var controller = GetControllerMapping();

            var routeData = request.GetRouteData();

            var controllerName = (string) routeData.Values["controller"];

            HttpControllerDescriptor descriptor;

            if (controller.TryGetValue(controllerName, out descriptor))
            {
                var version = GetVersionFromQueryString(request);

                var newName = string.Concat(controllerName, "V", version);

                HttpControllerDescriptor versionDescriptor;

                if (controller.TryGetValue(newName, out versionDescriptor))
                {
                    return versionDescriptor;
                }

                return descriptor;
            }

            return null;
        }

        private string GetVersionFromQueryString(HttpRequestMessage request)
        {
            var query = HttpUtility.ParseQueryString(request.RequestUri.Query);

            var version = query["v"];

            if (version != null)
            {
                return version;
            }

            return "1";
        }
    }
}
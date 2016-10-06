using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Controllers;
//using WebMatrix.WebData;

namespace WebApi.Filter
{
    public class WebApiAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authHeader = actionContext.Request.Headers.Authorization;

            if (authHeader != null)
            {
                if(authHeader.Scheme.Equals("basic", StringComparison.OrdinalIgnoreCase) && 
                    !string.IsNullOrWhiteSpace(authHeader.Parameter))
                {
                    var rawCredentials = authHeader.Parameter;
                    var encoding = Encoding.GetEncoding("iso-8859-1");
                    var credentials = encoding.GetString(Convert.FromBase64String(rawCredentials));
                    var split = credentials.Split(':');
                    var username = split[0];
                    var password = split[1];

//                    if (WebSecurity.Login(username, password))
//                    {
//                        var principal = new GenericPrincipal(new GenericIdentity(username), null);
//                        Thread.CurrentPrincipal = principal;
//                        return;
//                    }
                }
            }
            HandleUnauthorizedRequest(actionContext);
        }

        //TODO: calculate url -- remove of localhost:50400
        private void NewMethod(HttpActionContext actionContext)
        {
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            actionContext.Response.Headers.Add("WWW-Authenticate",
                "Basic Scheme='WebApi' location='http://localhost:50400/account/login'");


        }
    }
}
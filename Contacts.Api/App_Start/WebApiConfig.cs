using Newtonsoft.Json;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Contacts.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API routes
            var cors = new EnableCorsAttribute("*", "*", "*");

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Re‌​ferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //config.Formatters.Add(config.Formatters.XmlFormatter);
            config.EnableCors(cors);
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional, message = RouteParameter.Optional }
            );

        }
    }
}
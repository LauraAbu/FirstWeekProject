using Newtonsoft.Json;
using Owin;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Contacts.Api
{
    public static class WebApiConfig
    {
        public static void Register(IAppBuilder app,HttpConfiguration config)
        {

            // Web API routes

            var cors = new EnableCorsAttribute("*", "*", "*") { SupportsCredentials = true }; //cookies is Angular

            config.Formatters.JsonFormatter.SerializerSettings.Re‌​ferenceLoopHandling = ReferenceLoopHandling.Ignore;
            config.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

            config.EnableCors(cors);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional}
            );

            app.UseWebApi(config);

        }

    }
}
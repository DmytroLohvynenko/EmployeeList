using System.Net.Http.Headers;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace EmployeeListOnAngular
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var formatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            formatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            formatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

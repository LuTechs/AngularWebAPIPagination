using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AngularWebAPIPagination
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            json.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            json.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new {id = RouteParameter.Optional}
                );
        }
    }
}
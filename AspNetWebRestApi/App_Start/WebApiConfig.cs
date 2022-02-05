using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AspNetWebRestApi
{
    public static class WebApiConfig
    {
        //WebApiConfig-Web Api için yapılandırma dosyasıdır. 
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
            name: "Temperature",
            routeTemplate: "api/temperature/{id}",
            defaults: new { controller = "temperature", id = RouteParameter.Optional },
            constraints: new { id = "/d+" }
        );   


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.Remove(config.Formatters.XmlFormatter); // XML formatında olmasın onu bir kaldır. 
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver(); //camel case olablir
            config.Formatters.JsonFormatter.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc; //json formatına dönüştür |utc saatini kullanır 
 

        }
    }
}

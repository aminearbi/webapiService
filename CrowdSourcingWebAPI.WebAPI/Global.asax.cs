using CrowdSourcingWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Xml.Serialization;

namespace CrowdSourcingWebAPI.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            /*
            var config = GlobalConfiguration.Configuration;
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.JsonFormatter);
            var xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            xml.UseXmlSerializer = true;
            
            */
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

            //xml.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
            /*
            xml.SetSerializer<Comment>(new XmlSerializer(typeof(Comment)));
            xml.SetSerializer<Idea>(new XmlSerializer(typeof(Idea)));
           
            GlobalConfiguration.Configuration.Formatters.Clear();
            GlobalConfiguration.Configuration.Formatters.Add(new System.Net.Http.Formatting.XmlMediaTypeFormatter());
            */

        }
    }
}

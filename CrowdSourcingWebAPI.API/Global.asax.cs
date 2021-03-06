﻿using CrowdSourcingWebAPI.API.HTTPHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CrowdSourcingWebAPI.API
    {
    public class WebApiApplication : System.Web.HttpApplication
        {
        protected void Application_Start ()
            {
                  /*  
                GlobalConfiguration.Configuration.MessageHandlers.Clear();
                GlobalConfiguration.Configuration.MessageHandlers.Add(new BasicAuthMessageHandler()
                {
                    PrincipalProvider = new DummyPrincipalProvider()
                });
            */

            AreaRegistration.RegisterAllAreas ();
            GlobalConfiguration.Configure (WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters (GlobalFilters.Filters);
            RouteConfig.RegisterRoutes (RouteTable.Routes);
            BundleConfig.RegisterBundles (BundleTable.Bundles);
            
            var json = GlobalConfiguration.Configuration.Formatters;
            json.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            json.JsonFormatter.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            json.Remove (GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            json.JsonFormatter.SupportedMediaTypes.Add (new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue ("text/plain"));
            




            }
        }
    }

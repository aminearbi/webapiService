using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace CrowdSourcingWebAPI.WebAPI.Utils
    {
    public static class XmlExtension
        {
        public static string Serialize<T> ( this T value )
            {
            if (value == null) return string.Empty;

            var xmlserializer = new XmlSerializer (typeof (T));

            using (StringWriter stringWriter = new StringWriter ())
                {
                using (var writer = XmlWriter.Create (stringWriter, new XmlWriterSettings { Indent = true }))
                    {
                    xmlserializer.Serialize (writer, value);
                    return stringWriter.ToString ();
                    }
                }
            }
        }
    }
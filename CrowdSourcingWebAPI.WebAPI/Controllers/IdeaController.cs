using CrowdSourcingWebAPI.Domain.Entities;
using CrowdSourcingWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrowdSourcingWebAPI.WebAPI.Utils;

namespace CrowdSourcingWebAPI.WebAPI.Controllers
{
    public class IdeaController : ApiController
    {
        CrowdService service;
        public IdeaController ()
        {
            service = new CrowdService();
            
        }
        protected override void Dispose ( bool disposing )
            {
            if (disposing)
                {
                service.Dispose ();
                }
            base.Dispose (disposing);
            }
        // GET: api/Idea
        public string Get()
        {
        Idea a = new Idea ();
        a.CategoryId=1;
        a.TenanMail="helloworld";
        a.Subject="luckyluck";
        return a.Serialize (); ;
        }

        // GET: api/Idea/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Idea
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Idea/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Idea/5
        public void Delete(int id)
        {
        }
    }
}

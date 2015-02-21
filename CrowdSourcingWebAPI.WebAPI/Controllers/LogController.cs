using CrowdSourcingWebAPI.Domain.Entities;
using CrowdSourcingWebAPI.Service;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrowdSourcingWebAPI.WebAPI.Controllers
{
    public class LogController : ApiController
    {
        CrowdService service;
        public LogController()
        {
            service = new CrowdService();
        }
        // GET: api/Log
        /*
        public HttpResponseException Get()
        {
            throw new HttpResponseException(HttpStatusCode.Forbidden);
        }
        */
        // GET: api/Log/email
        [HttpPost]
        [Route("api/log/email")]
        public IEnumerable<Log> GetLogsForTenant(JObject o)
        {
            string tenantemail = o["email"].ToObject<string>();
            if (tenantemail != null)
            {
                IEnumerable<Log> logs = service.GetLogByTenant(tenantemail);
                return logs;

            }
            else throw new HttpResponseException(HttpStatusCode.NotFound);


        }

        // content must be sent as a json array with email attribute. Encoding MUST be set to text/plain
        /*
        [HttpPost]
        [Route("api/log/email")]
        public IEnumerable<Log> GetLogsForTenant(JObject o)
        {
            string tenantemail = o["email"].ToObject<string>();
            if (tenantemail != null)
            {
                IEnumerable<Log> logs = service.GetLogByTenant(tenantemail);
                return logs;

            }
            else throw new HttpResponseException(HttpStatusCode.NotFound);
            

        }
        */


        [HttpPost]
        
        // POST: api/Log
        public HttpResponseMessage Post(Log log)
        {
            if (log != null)
            {
                service.CreateLog(log);
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            else
                throw new HttpResponseException(HttpStatusCode.NoContent);
        }

        // PUT: api/Log/5
        public HttpResponseException Put()
        {
            throw new HttpResponseException(HttpStatusCode.Forbidden);
        }

        // DELETE: api/Log/5
        public HttpResponseException Delete(int id)
        {
            throw new HttpResponseException(HttpStatusCode.Forbidden);
        }
    }
}

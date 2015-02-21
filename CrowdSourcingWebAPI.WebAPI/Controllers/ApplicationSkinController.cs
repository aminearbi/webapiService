using CrowdSourcingWebAPI.Domain.Entities;
using CrowdSourcingWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrowdSourcingWebAPI.WebAPI.Controllers
{
    public class ApplicationSkinController : ApiController
    {
        CrowdService service;
        public ApplicationSkinController()
        {
            service = new CrowdService();
        }
        // GET: api/ApplicationSkin
        public HttpResponseException Get()
        {
            throw new HttpResponseException(HttpStatusCode.Forbidden);
        }

        // GET: api/ApplicationSkin/5
        [Route("api/applicationskin/{tenantemail}/")]
        public ApplicationSkin Get(string tenantemail)
        {
            ApplicationSkin a = service.GetSkinByTenant(tenantemail);
            if (a != null)
                return a;
            else throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        // POST: api/ApplicationSkin
        public HttpResponseMessage Post(ApplicationSkin skin)
        {
            if (skin != null)
            {
                service.CreateSkin(skin);
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            else throw new HttpResponseException(HttpStatusCode.NoContent);
        }

        // PUT: api/ApplicationSkin/5
        public HttpResponseMessage Put(ApplicationSkin skin)
        {
            if (skin != null)
            {
                service.EditSkin(skin);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else throw new HttpResponseException(HttpStatusCode.NoContent);
        }

        // DELETE: api/ApplicationSkin/5
        public HttpResponseMessage Delete(int id)
        {
            throw new HttpResponseException(HttpStatusCode.Forbidden);
        }
    }
}

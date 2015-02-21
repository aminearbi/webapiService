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
    [RoutePrefix("api/Idea")]
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
        [Route("GetIdeaById/{id}")]
        public Idea GetIdeaById ( int id )
        {
        Idea a = service.GetIdeaById (id);
        return a ;
        }

        [Route ("GetIdeaByCategory/{id}")]
        public IEnumerable<Idea> GetIdeaByCategory ( int id )
        {
        
        Category c = service.GetCategoryById (id);

        return service.GetIdeasByCategory (c);
        }

        [Route ("GetIdeaByTenant/{tenant}/")]
        [HttpGet]
        public IEnumerable<Idea> GetIdeaByTenant ( string tenant)
            {
            
            return service.GetLatestIdeas(tenant);
            }

        // POST: api/Idea
        public HttpResponseMessage Post ( Idea idea )
        {
        if (idea!=null)
            {
            service.CreateIdea (idea);
            return new HttpResponseMessage(HttpStatusCode.Created);
            }
        else throw new HttpResponseException (HttpStatusCode.NoContent);
            
        }

        // PUT: api/Idea/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Idea/5
        public HttpResponseMessage Delete(int id)
        {
        if (id!=0)
            {
            Idea i= service.GetIdeaById (id);
            service.DeleteIdea (i);
            return new HttpResponseMessage (HttpStatusCode.Accepted);
            
            }
        else
            {
            throw new HttpResponseException (HttpStatusCode.NotFound);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrowdSourcingWebAPI.Domain.Entities;
using CrowdSourcingWebAPI.Service;
using System.Web.Mvc;
namespace CrowdSourcingWebAPI.WebAPI.Controllers
{
    [RoutePrefix("api/Category")]
    public class CategoryController : ApiController
    {
        CrowdService service;
        public CategoryController()
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
        // GET: api/Category
        [Route("GetByTenant/{tenant}/")]
        public IEnumerable<Category> Get(string tenant)
        {
        return service.GetCategoriesByTenant (tenant);
        }

        [Route ("GetById/{id}/")]
        public Category GetCategory(int id)
        {
            Category c = service.GetCategoryById(id);
            return c;
        }

        // POST: api/Category
        [HttpPost]
        public HttpResponseMessage PostCategory(Category c)
        {
            if (c.Title != null)
            {
            if (service.CheckCategory (c)==false) { 
                service.CreateCategory(c);

            }
            return new HttpResponseMessage (HttpStatusCode.Accepted);
                
            }
            else
                throw new HttpResponseException(HttpStatusCode.NoContent);
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Category/5
        public HttpResponseMessage Delete ( int id )
        {
        if (id!=0) { 
            Category c= service.GetCategoryById(id);
            service.DeleteCategory (c);
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
        else { 
            throw new HttpResponseException (HttpStatusCode.NoContent);
            }
               
           
        }
    }
}

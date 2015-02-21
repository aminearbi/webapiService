using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrowdSourcingWebAPI.Domain.Entities;
using CrowdSourcingWebAPI.Service;
namespace CrowdSourcingWebAPI.WebAPI.Controllers
{
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
        
        public IEnumerable<Category> Get(string tenant)
        {
        return service.GetCategoriesByTenant (tenant);
        }

        // GET: api/Category/5
        public Category GetCategory(int id)
        {
            Category c = service.GetCategoryById(id);
            return c;
        }

        // POST: api/Category
        public HttpResponseMessage PostCategory(Category c)
        {
            if (c.Title != null)
            {
            if (service.CheckCategory (c)==false) { 
                service.CreateCategory(c);
            }
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            else
                throw new HttpResponseException(HttpStatusCode.NoContent);
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
            Category c= service.GetCategoryById(id);
            service.DeleteCategory (c);
        }
    }
}

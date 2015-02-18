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
        // GET: api/Category
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
                service.CreateCategory(c);
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
        }
    }
}

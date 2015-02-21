using CrowdSourcingWebAPI.Domain.Entities;
using CrowdSourcingWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrowdSourcingWebAPI.API.Controllers
{
    public class LikeController : ApiController
        {
        CrowdService service;
        public LikeController ()
            {
            service = new CrowdService ();
            }
        // GET: api/Like
        public HttpResponseException Get ()
            {
            throw new HttpResponseException (HttpStatusCode.Forbidden);
            }

        // GET: api/Like/5
        public IEnumerable<Like> Get ( int id )
            {
            Idea idea = service.GetIdeaById (id);
            if (idea != null && idea.IdeaId != 0)
                {
                IEnumerable<Like> likes = service.GetLikeByIdea (idea);
                int count = likes.Cast<object> ().Count ();
                if (count != 0)
                    return likes;
                else throw new HttpResponseException (HttpStatusCode.NoContent);
                }
            else
                throw new HttpResponseException (HttpStatusCode.NotFound);
            }

        // POST: api/Like
        public HttpResponseMessage Post ( Like like )
            {
            like.Idea = service.GetIdeaById (like.IdeaId);
            if (like.Idea != null)
                {
                if (!service.CheckLike (like))
                    {
                    service.CreateLike (like);
                    return new HttpResponseMessage (HttpStatusCode.Created);
                    }
                else
                    throw new HttpResponseException (HttpStatusCode.Found);
                }
            else
                throw new HttpResponseException (HttpStatusCode.NotFound);

            }

        // PUT: api/Like/5
        public HttpResponseException Put ()
            {
            throw new HttpResponseException (HttpStatusCode.Forbidden);
            }

        // DELETE: api/Like/5
        public HttpResponseMessage Delete ( int id )
            {
            Like like = service.GetLikeById (id);
            if (service.CheckLike (like))
                {
                service.DeleteLike (like);
                return new HttpResponseMessage (HttpStatusCode.OK);
                }
            else
                throw new HttpResponseException (HttpStatusCode.NotFound);


            }
    }
}

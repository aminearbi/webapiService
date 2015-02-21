using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrowdSourcingWebAPI.Service;
using CrowdSourcingWebAPI.Domain.Entities;
using System.Net.Http.Formatting;
namespace CrowdSourcingWebAPI.WebAPI.Controllers
{
    public class CommentController : ApiController
    {
        CrowdService service;

        public CommentController()
        {
            service = new CrowdService();
        }
        // GET: api/Comment
        // gets comments for a certain idea
        
        public IEnumerable<Comment> GetCommentsForIdea(int id)
        {
            
            Idea idea = service.GetIdeaById(id);
            IEnumerable<Comment> comments = service.GetCommentsByIdea(idea) ;
            if (comments.Count() != 0)
                return comments;
             
            
           else throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        
        // GET: api/Comment/5
        /*
        public Comment GetComment(int id)
        {
            Comment c = service.GetCommentById(id);
            return c;
            //throw new HttpResponseException(HttpStatusCode.MovedPermanently);
        }
        */
        // POST: api/Comment
        public HttpResponseMessage PostComment(Comment comment)
        {
            
            //comment.CommentId = 4;
            comment.DatePosted = DateTime.Now;
            comment.Idea = service.GetIdeaById(comment.IdeaId);
            //comment.Text = "nothing at all";
            //comment.IdeaId = 4;
            //comment.WriterMail = "bullshit@crap.shit";

            if (comment != null)
            {

                service.CreateComment(comment);
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            else return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        // PUT: api/Comment/5
        public HttpResponseException Put(int id, [FromBody]string value)
        {
            throw new HttpResponseException(HttpStatusCode.Forbidden);
        }

        // DELETE: api/Comment/5
        public HttpResponseMessage DeleteComment(int id)
        {
            Comment comment = service.GetCommentById(id);
            if (comment.CommentId != 0)
            {
                service.DeleteComment(comment);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
    }
}

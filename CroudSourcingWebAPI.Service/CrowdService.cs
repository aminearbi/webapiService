using CrowdSourcingWebAPI.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrowdSourcingWebAPI.Domain.Entities;

namespace CrowdSourcingWebAPI.Service
    {
    public class CrowdService:ICrowdService
        {
        DatabaseFactory dbFactory;
        UnitOfWork utofwork;
        public CrowdService ()
            {
            this.dbFactory = new DatabaseFactory ();
            this.utofwork = new UnitOfWork (dbFactory);
            }
        public void Dispose ()
            {
            utofwork.Dispose ();
            }

        public void CreateCategory ( Category category )
            {
                
            }

        public void CreateIdea ( Idea idea )
            {
                
            }

        public void CreateComment ( Comment comment )
            {
                utofwork.CommentRepository.Add(comment);
                utofwork.Commit();
            }

        public void CreateLog ( Log log )
            {
            throw new NotImplementedException ();
            }

        public Idea GetIdea ( int ideaId )
            {
            throw new NotImplementedException ();
            }

        public Category GetCategory ( int categoryId )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Category> GetCategories ()
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Idea> GetIdeas ()
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Idea> GetIdeasByCategory ( int CategoryId )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Comment> GetComments ()
            {
                IEnumerable<Comment> comments = utofwork.CommentRepository.GetAll();
                return comments;
            }

        public IEnumerable<Comment> GetCommentsByIdea ( int IdeaId )
            {
                Idea i = utofwork.IdeaRepository.GetById(IdeaId);
                IEnumerable<Comment> comments = utofwork.IdeaRepository.GetMany(Where)
            }

        public IEnumerable<Log> GetLogs ()
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Log> GetLogsByUser ( int userId )
            {
            throw new NotImplementedException ();
            }


        public void EditCategory ( Category category )
            {
            throw new NotImplementedException ();
            }

        public void DeleteCategory ( Category category )
            {
            throw new NotImplementedException ();
            }

        public void CheckCategory ( Category category )
            {
            throw new NotImplementedException ();
            }

        public Category GetCategoryById ( int id )
            {
            throw new NotImplementedException ();
            }

        public void DeleteIdea ( Idea idea )
            {
            throw new NotImplementedException ();
            }

        public Idea GetIdeaById ( int id )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Idea> GetLatestIdeas ( string tenantMail )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Idea> GetIdeasByCategory ( Category category )
            {
            throw new NotImplementedException ();
            }

        public void ChangeIdeaState ( Idea idea )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Idea> GetIdeasByState ( Category category )
            {
            throw new NotImplementedException ();
            }

        public int CalculateScore ( Idea idea )
            {
            throw new NotImplementedException ();
            }

        public void DeleteComment ( Comment comment )
            {
            throw new NotImplementedException ();
            }

        public void CheckComment ( Comment comment )
            {
            throw new NotImplementedException ();
            }

        public Comment GetCommentById ( int id )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Comment> GetCommentsByIdea ( Idea idea )
            {
            throw new NotImplementedException ();
            }

        public void CreateSkin ( ApplicationSkin skin )
            {
            throw new NotImplementedException ();
            }

        public void EditSkin ( ApplicationSkin skin )
            {
            throw new NotImplementedException ();
            }

        public ApplicationSkin GetSkinByTenant ( string tenantmail )
            {
            throw new NotImplementedException ();
            }

        public void CreateLike ( Like like )
            {
            throw new NotImplementedException ();
            }

        public void DeleteLike ( Like like )
            {
            throw new NotImplementedException ();
            }

        public void CheckLike ( Like like )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Like> GetLikeByIdea ( Idea idea )
            {
            throw new NotImplementedException ();
            }

        public void CheckLog ( Log log )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Log> GetLogByTenant ( string tenantmail )
            {
            throw new NotImplementedException ();
            }
        }
    }

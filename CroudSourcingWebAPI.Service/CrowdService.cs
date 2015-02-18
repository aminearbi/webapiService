using CrowdSourcingWebAPI.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void CreateCategory ( Domain.Entities.Category category )
            {
            
            }

        public void CreateIdea ( Domain.Entities.Idea idea )
            {
                
            }

        public void CreateComment ( Domain.Entities.Comment comment )
            {
            throw new NotImplementedException ();
            }

        public void CreateLog ( Domain.Entities.Log log )
            {
            throw new NotImplementedException ();
            }

        public Domain.Entities.Idea GetIdea ( int ideaId )
            {
            throw new NotImplementedException ();
            }

        public Domain.Entities.Category GetCategory ( int categoryId )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Category> GetCategories ()
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Idea> GetIdeas ()
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Idea> GetIdeasByCategory ( int CategoryId )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Comment> GetComments ()
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Comment> GetCommentsByIdea ( int IdeaId )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Log> GetLogs ()
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Log> GetLogsByUser ( int userId )
            {
            throw new NotImplementedException ();
            }


        public void EditCategory ( Domain.Entities.Category category )
            {
            throw new NotImplementedException ();
            }

        public void DeleteCategory ( Domain.Entities.Category category )
            {
            throw new NotImplementedException ();
            }

        public void CheckCategory ( Domain.Entities.Category category )
            {
            throw new NotImplementedException ();
            }

        public Domain.Entities.Category GetCategoryById ( int id )
            {
            throw new NotImplementedException ();
            }

        public void DeleteIdea ( Domain.Entities.Idea idea )
            {
            throw new NotImplementedException ();
            }

        public Domain.Entities.Idea GetIdeaById ( int id )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Idea> GetLatestIdeas ( string tenantMail )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Idea> GetIdeasByCategory ( Domain.Entities.Category category )
            {
            throw new NotImplementedException ();
            }

        public void ChangeIdeaState ( Domain.Entities.Idea idea )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Idea> GetIdeasByState ( Domain.Entities.Category category )
            {
            throw new NotImplementedException ();
            }

        public int CalculateScore ( Domain.Entities.Idea idea )
            {
            throw new NotImplementedException ();
            }

        public void DeleteComment ( Domain.Entities.Comment comment )
            {
            throw new NotImplementedException ();
            }

        public void CheckComment ( Domain.Entities.Comment comment )
            {
            throw new NotImplementedException ();
            }

        public Domain.Entities.Comment GetCommentById ( int id )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Comment> GetCommentsByIdea ( Domain.Entities.Idea idea )
            {
            throw new NotImplementedException ();
            }

        public void CreateSkin ( Domain.Entities.ApplicationSkin skin )
            {
            throw new NotImplementedException ();
            }

        public void EditSkin ( Domain.Entities.ApplicationSkin skin )
            {
            throw new NotImplementedException ();
            }

        public Domain.Entities.ApplicationSkin GetSkinByTenant ( string tenantmail )
            {
            throw new NotImplementedException ();
            }

        public void CreateLike ( Domain.Entities.Like like )
            {
            throw new NotImplementedException ();
            }

        public void DeleteLike ( Domain.Entities.Like like )
            {
            throw new NotImplementedException ();
            }

        public void CheckLike ( Domain.Entities.Like like )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Like> GetLikeByIdea ( Domain.Entities.Idea idea )
            {
            throw new NotImplementedException ();
            }

        public void CheckLog ( Domain.Entities.Log log )
            {
            throw new NotImplementedException ();
            }

        public IEnumerable<Domain.Entities.Log> GetLogByTenant ( string tenantmail )
            {
            throw new NotImplementedException ();
            }
        }
    }

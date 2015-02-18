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
            throw new NotImplementedException ();
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
        }
    }

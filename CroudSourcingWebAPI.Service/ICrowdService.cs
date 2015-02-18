using CrowdSourcingWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Service
    {
    public interface ICrowdService
        {
        void CreateCategory ( Category category );
        void CreateIdea ( Idea idea );
        void CreateComment ( Comment comment );
       
        void CreateLog ( Log log );

        Idea GetIdea ( int ideaId );

        Category GetCategory ( int categoryId );
        IEnumerable<Category> GetCategories ();
        

        IEnumerable<Idea> GetIdeas ();
        IEnumerable<Idea> GetIdeasByCategory (int CategoryId);
        IEnumerable<Comment> GetComments ();
        IEnumerable<Comment> GetCommentsByIdea (int IdeaId);

       

        IEnumerable<Log> GetLogs ();
        IEnumerable<Log> GetLogsByUser (int userId);





        }
    }

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
        //Categories
        void CreateCategory ( Category category );
        void EditCategory ( Category category );

        void DeleteCategory ( Category category );
        void CheckCategory ( Category category );
        Category GetCategoryById ( int id );
        IEnumerable<Category> GetCategories ();

        //Ideas
        void CreateIdea ( Idea idea );
        void DeleteIdea ( Idea idea );
        Idea GetIdeaById ( int id );
        IEnumerable<Idea> GetLatestIdeas (string tenantMail);
        IEnumerable<Idea> GetIdeasByCategory(Category category);
        void ChangeIdeaState ( Idea idea );
        IEnumerable<Idea> GetIdeasByState ( Category category );
        int CalculateScore (Idea idea);
        
        //Comments
        void CreateComment ( Comment comment );
        void DeleteComment ( Comment comment );
        void CheckComment ( Comment comment );
        Comment GetCommentById ( int id );
        IEnumerable<Comment> GetCommentsByIdea ( Idea idea );

        //ApplicationSkin
        
        void CreateSkin ( ApplicationSkin skin );
        void EditSkin ( ApplicationSkin skin );
        ApplicationSkin GetSkinByTenant ( string tenantmail );
        

        //Like
        void CreateLike ( Like like );
        void DeleteLike ( Like like );
        void CheckLike ( Like like );
        IEnumerable<Like> GetLikeByIdea(Idea idea);
        

        //Log
        void CreateLog ( Log log );
        void CheckLog ( Log log );
        IEnumerable<Log> GetLogByTenant ( string tenantmail );










        }
    }

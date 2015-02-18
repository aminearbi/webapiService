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


        // Internity Start
        public void CreateCategory ( Category category )
            {
            utofwork.CategoryRepository.Add (category);
            utofwork.Commit ();
            }

        public void EditCategory ( Category category )
            {
            utofwork.CategoryRepository.Update (category);
            utofwork.Commit ();

            }

        public void DeleteCategory ( Category category )
            {
            utofwork.CategoryRepository.Delete (category);
            utofwork.Commit ();
            }

        public bool CheckCategory ( Category category )
            {
            bool tester = false;
            if (utofwork.CategoryRepository.GetMany (i => i.TenantMail.Equals (category.TenantMail) & i.Title.Equals (category.Title))!=null)
                {
                tester = true;
                }
                
          
            return tester;

            }

        public Category GetCategoryById ( Category category)
            {
            return utofwork.CategoryRepository.GetById (category.CategoryId);
            }

        public IEnumerable<Category> GetCategoriesByTenant (string tenantmail)
            {
            return utofwork.CategoryRepository.GetMany (i => i.TenantMail.Equals (tenantmail));
            }

        public void CreateIdea ( Idea idea )
            {
            utofwork.IdeaRepository.Add (idea);
            utofwork.Commit ();
            }

        public void DeleteIdea ( Idea idea )
            {
            utofwork.IdeaRepository.Delete (idea);
            utofwork.Commit ();
            }

        public Idea GetIdeaById ( Idea idea )
            {
            return utofwork.IdeaRepository.GetById (idea.IdeaId);
            }

        public IEnumerable<Idea> GetLatestIdeas ( string tenantMail )
            {
            return utofwork.IdeaRepository.GetMany (i => i.TenanMail.Equals (tenantMail));
            }

        public IEnumerable<Idea> GetIdeasByCategory ( Category category )
            {
            return utofwork.IdeaRepository.GetMany (i => i.CategoryId==category.CategoryId);
            }

        public void ChangeIdeaState ( Idea idea )
            {
            utofwork.IdeaRepository.Update (idea);
            }

        public IEnumerable<Idea> GetIdeasByState ( Category category, string state )
            {
            return utofwork.IdeaRepository.GetMany (i => i.CategoryId==category.CategoryId & i.State.Equals(state));
            }

        public int CalculateScore ( Idea idea )
            {
            return utofwork.CommentRepository.GetMany (c => c.IdeaId==idea.IdeaId).Count();
            }

        //internity finish

        public void CreateComment ( Comment comment )
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

        public void CreateLog ( Log log )
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

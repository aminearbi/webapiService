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

        public IEnumerable<Category> GetCategories ()
            {
            throw new NotImplementedException ();
            }

        public void CreateIdea ( Idea idea )
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

        //internity finish

        public void CreateComment ( Comment comment )
            {
                utofwork.CommentRepository.Add(comment);
                utofwork.Commit();
            }

        public void DeleteComment ( Comment comment )
            {
                utofwork.CommentRepository.Delete(comment);
                utofwork.Commit();
            }


        public Comment GetCommentById ( int id )
            {
                Comment c = utofwork.CommentRepository.GetById(id);
                return c;
            }

        public IEnumerable<Comment> GetCommentsByIdea ( Idea idea )
            {
                IEnumerable<Comment> comments = utofwork.CommentRepository.GetMany(i => i.IdeaId == idea.IdeaId);
                return comments;
            }

        public void CreateSkin ( ApplicationSkin skin )
            {
                utofwork.ApplicationSkinRepository.Add(skin);
                utofwork.Commit();
            }

        public void EditSkin ( ApplicationSkin skin )
            {
                utofwork.ApplicationSkinRepository.Update(skin);
                utofwork.Commit();
            }

        public ApplicationSkin GetSkinByTenant ( string tenantmail )
            {
                ApplicationSkin a = utofwork.ApplicationSkinRepository.Get(app => app.TenantMail.Equals(tenantmail));
                return a;
            }

        public void CreateLike ( Like like )
            {
                utofwork.LikeRepository.Add(like);
                utofwork.Commit();
            }

        public void DeleteLike ( Like like )
            {
                utofwork.LikeRepository.Delete(like);
                utofwork.Commit();
            }

        public bool CheckLike ( Like like )
            {
                IEnumerable<Like> list = utofwork.LikeRepository.GetMany(l => l.IdeaId == like.IdeaId & l.WriterMail == like.WriterMail);
                if (list.Cast<object>().Count() != 0)
                    return true;
                else 
                    return false;
            }

        public IEnumerable<Like> GetLikeByIdea ( Idea idea )
            {
                IEnumerable<Like> likes = utofwork.LikeRepository.GetMany(l => l.IdeaId == idea.IdeaId);
                return likes;
            }

        public void CreateLog ( Log log )
            {
                utofwork.LogRepository.Add(log);
                utofwork.Commit();
            }
        /*
        public void CheckLog ( Log log )
            {
                
            }
        */
        public IEnumerable<Log> GetLogByTenant ( string tenantmail )
            {
                IEnumerable<Log> logs = utofwork.LogRepository.GetMany(t => t.TenantMail.Equals(tenantmail));
                return logs;
            }
        }
    }

﻿using CrowdSourcingWebAPI.Data.Infrastructure;
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
            IEnumerable<Category> ss = utofwork.CategoryRepository.GetAll ();
            foreach (Category c in ss)
                {
                if (c.Title.Equals(category.Title) )
                 tester = true;
                }
            
                
          
            return tester;

            }

        public Category GetCategoryById ( int c)
            {
            return utofwork.CategoryRepository.GetById(c);
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

        public Idea GetIdeaById ( int id )
            {
            return utofwork.IdeaRepository.GetById (id);
            }

        public IEnumerable<Idea> GetLatestIdeas ( string tenantMail )
            {
            return utofwork.IdeaRepository.GetMany (i => i.TenanMail.Equals (tenantMail));
            }

        public IEnumerable<Idea> GetIdeasByCategory ( Category category )
            {
            return utofwork.IdeaRepository.GetMany (i => i.CategoryId==category.CategoryId);
            }

        public IEnumerable<Idea> GetIdeasByTenant(string tenantemail)
        {
            return utofwork.IdeaRepository.GetMany(i => i.TenanMail == tenantemail);
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
        public Like GetLikeById(int id)
        {
            Like like = utofwork.LikeRepository.GetById(id);
            return like;
        }

        public IEnumerable<Like> GetLikeByIdea ( Idea idea )
            {
                IEnumerable<Like> likes = utofwork.LikeRepository.GetMany(l => l.IdeaId == idea.IdeaId);
                return likes;
            }

        public void CreateLog ( Log log )
            {
                log.EventDate = DateTime.Now;
                utofwork.LogRepository.Add(log);
                utofwork.Commit();
            }
        
        public void CheckLog ( Log log )
            {
                
            }
        
        public IEnumerable<Log> GetLogByTenant ( string tenantmail )
            {
                IEnumerable<Log> logs = utofwork.LogRepository.GetMany(t => t.TenantMail.Equals(tenantmail));
                return logs;
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrowdSourcingWebAPI.Data.Repositories;

namespace CrowdSourcingWebAPI.Data.Infrastructure
    {
    public class UnitOfWork : IUnitOfWork
        {
        private CrowdSourcingWebAPIContext dataContext;
        IDatabaseFactory dbFactory;
        public UnitOfWork ( IDatabaseFactory dbFactory )
            {
            this.dbFactory = dbFactory;
            }
        protected CrowdSourcingWebAPIContext DataContext
            {
            get
                {
                return dataContext = dbFactory.DataContext;
                }
            }

        public void Commit ()
            {
            DataContext.SaveChanges ();
            }
       
        private IIdeaRepository ideaRepository;
        public IIdeaRepository IdeaRepository
            {
            get { return ideaRepository = new IdeaRepository (dbFactory); }
            }
        private ICommentRepository commentRepository;
        public ICommentRepository CommentRepository
            {
            get { return commentRepository= new CommentRepository (dbFactory); }
            }
        private ICategoryRepository categoryRepository;
        public ICategoryRepository CategoryRepository
            {
            get {return categoryRepository= new CategoryRepository (dbFactory); }
            }
       
        private ILogRepository logRepository;
        public ILogRepository LogRepository
            {
            get { return logRepository = new LogRepository (dbFactory); }
            }

        public void Dispose ()
            {
            dbFactory.Dispose ();
            }
        }
    }

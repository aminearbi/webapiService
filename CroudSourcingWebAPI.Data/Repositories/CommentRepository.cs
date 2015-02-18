using CrowdSourcingWebAPI.Data.Infrastructure;
using CrowdSourcingWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Data.Repositories
    {
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
        {
        public CommentRepository ( IDatabaseFactory dbFactory )
            : base (dbFactory)
            {

            }
        
        }
    public interface ICommentRepository : IRepository<Comment> { }
    }

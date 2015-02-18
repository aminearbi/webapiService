using CrowdSourcingWebAPI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Data.Infrastructure
    {
    public interface IUnitOfWork:IDisposable
        {
        void Commit ();
        
        IIdeaRepository IdeaRepository { get; }
        ICommentRepository CommentRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ILogRepository LogRepository { get; }
        ILikeRepository LikeRepository { get; }
        IApplicationSkinRepository ApplicationSkinRepository { get; }

        
        }
    }

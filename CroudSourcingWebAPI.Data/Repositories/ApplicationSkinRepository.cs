using CrowdSourcingWebAPI.Data.Infrastructure;
using CrowdSourcingWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Data.Repositories
    {
    public class ApplicationSkinRepository : RepositoryBase<ApplicationSkin>, IApplicationSkinRepository
        {
        public ApplicationSkinRepository ( IDatabaseFactory dbFactory )
            : base (dbFactory)
            {

            }
        }
    public interface IApplicationSkinRepository : IRepository<ApplicationSkin> { }
    }

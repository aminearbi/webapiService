﻿using CrowdSourcingWebAPI.Data.Infrastructure;
using CrowdSourcingWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Data.Repositories
    {
    public class LogRepository : RepositoryBase<Log>, ILogRepository
        {
        public LogRepository ( IDatabaseFactory dbFactory )
            : base (dbFactory)
            {

            }

        }
    public interface ILogRepository : IRepository<Log> { }
    }

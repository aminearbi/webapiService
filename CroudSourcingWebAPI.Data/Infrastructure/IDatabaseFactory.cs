using CrowdSourcingWebAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Data.Infrastructure
    {
    public interface IDatabaseFactory:IDisposable
        {
        CrowdSourcingWebAPIContext DataContext { get; }
        }
    }

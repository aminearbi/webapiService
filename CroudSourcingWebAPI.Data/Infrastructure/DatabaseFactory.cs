using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Data.Infrastructure
    {
    public class DatabaseFactory : Disposable, IDatabaseFactory
        {
        private CrowdSourcingWebAPIContext dataContext;
        public CrowdSourcingWebAPIContext DataContext { get { return dataContext; } }

        public DatabaseFactory ()
            {
            dataContext = new CrowdSourcingWebAPIContext ();// espace mémoire vide au début
            }
        protected override void DisposeCore () //dispose: meth pour libérer tt l'espace mémoire
            {
            if (DataContext != null)
                DataContext.Dispose ();
            }

        }
    }

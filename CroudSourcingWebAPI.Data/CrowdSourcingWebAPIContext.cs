using CrowdSourcingWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CrowdSourcingWebAPI.Data
    {
    public class CrowdSourcingWebAPIContext : DbContext
        {
        public CrowdSourcingWebAPIContext ():base("name=DefaultConnection")

            {

            }
        
        public DbSet<ApplicationSkin> ApplicationSkins { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        }
    }

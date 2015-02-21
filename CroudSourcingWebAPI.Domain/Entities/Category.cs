using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Domain.Entities
    {
    public class Category
        {
            [Key]
            public int CategoryId { get; set; }
            [Required(AllowEmptyStrings=false)]
            
            public string Title { get; set; }
            public string TenantMail { get; set; }
            public override int GetHashCode ()
                {
                return base.GetHashCode ();
                }

           
            
        }
    }

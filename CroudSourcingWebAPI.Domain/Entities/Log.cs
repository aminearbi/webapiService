using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Domain.Entities
    {
    public class Log
        {
        [Key]
        public int LogId { get; set; }
        // public DateTime LogDate { get; set; } // moved to event date
        public DateTime? LoginDate { get; set; }
        [Required (AllowEmptyStrings = false)]
        public string Event { get; set; }
        public string EventType { get; set; }
        public string TenantMail { get; set; }
        }
    }

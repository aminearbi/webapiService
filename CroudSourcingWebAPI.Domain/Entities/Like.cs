﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Domain.Entities
    {
    public class Like
        {
        public int LikeId { get; set; }
        [ForeignKey ("IdeaId")]
        public virtual Idea Idea { get; set; }
        public int IdeaId { get; set; }
        public string WriterMail { get; set; }
        }
    }

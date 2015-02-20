﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CrowdSourcingWebAPI.Domain.Entities
    {
    
    public class Comment
        {
        [Key]
        public int CommentId { get; set; }
        [Required(AllowEmptyStrings=false)]
        public string Text { get; set; }
        public DateTime DatePosted { get; set; }
        [ForeignKey ("IdeaId")]
        public virtual Idea Idea { get; set; }
        public int IdeaId { get; set; }
        public string WriterMail { get; set; }
        }
    }

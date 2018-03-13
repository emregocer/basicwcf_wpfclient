using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfTest3.Core
{
    public class Post : BaseEntity
    {
        public string Subject { get; set; }
        public string SentBy { get; set; }
        public DateTime SentAt { get; set; }
        public string Body { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual Collection<Comment> Comments { get; set; } 
    }
}

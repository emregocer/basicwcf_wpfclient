using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfTest3.Core
{
    public class Comment : BaseEntity
    {
        public string Body { get; set; }
        public DateTime SentAt { get; set; }
        public string SentBy { get; set; }

        public int? PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}

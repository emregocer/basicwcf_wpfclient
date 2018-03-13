using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfTest3.Core.WcfContracts
{
    [DataContract]
    public class PostContract : BaseContract
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string SentBy { get; set; }
        [DataMember]
        public DateTime SentAt { get; set; }
        [DataMember]
        public string Body { get; set; }
        [DataMember]
        public CategoryContract Category { get; set; }
        [DataMember]
        public Collection<CommentContract> Comments { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Notice
    {
        public System.Guid ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Creater { get; set; }
        public Nullable<System.DateTime> Createtime { get; set; }
        public Nullable<System.DateTime> Activetime { get; set; }
        public string Status { get; set; }
    }
}

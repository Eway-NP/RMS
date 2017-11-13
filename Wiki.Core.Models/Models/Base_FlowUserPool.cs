using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_FlowUserPool
    {
        public System.Guid ID { get; set; }
        public string GroupType { get; set; }
        public string Department { get; set; }
        public string UserList { get; set; }
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public string Attr3 { get; set; }
    }
}

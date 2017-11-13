using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_RoleFileRight
    {
        public System.Guid ID { get; set; }
        public System.Guid RoleFileRightID { get; set; }
        public System.Guid FileID { get; set; }
        public System.Guid RoleID { get; set; }
        public System.Guid FileRightID { get; set; }
        public string Remark { get; set; }
    }
}

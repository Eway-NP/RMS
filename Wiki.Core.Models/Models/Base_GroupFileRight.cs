using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_GroupFileRight
    {
        public System.Guid ID { get; set; }
        public System.Guid FileID { get; set; }
        public System.Guid GroupID { get; set; }
        public System.Guid FileRightID { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
    }
}

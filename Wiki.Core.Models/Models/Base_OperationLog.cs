using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_OperationLog
    {
        public System.Guid ID { get; set; }
        public Nullable<int> OptType { get; set; }
        public Nullable<int> OptUserID { get; set; }
        public string OptUserName { get; set; }
        public string OptContent { get; set; }
        public string OptContentEN { get; set; }
        public Nullable<System.DateTime> OptTime { get; set; }
        public string OptRemark { get; set; }
        public Nullable<int> AngentID { get; set; }
        public Nullable<int> CompanyID { get; set; }
    }
}

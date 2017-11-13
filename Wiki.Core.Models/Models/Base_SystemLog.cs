using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_SystemLog
    {
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> RecordTime { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> OperUserID { get; set; }
        public Nullable<int> OperType { get; set; }
        public Nullable<int> OperResult { get; set; }
        public string OperContent { get; set; }
        public string OperArgu { get; set; }
        public string OperSource { get; set; }
        public string OperRemark { get; set; }
    }
}

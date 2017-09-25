using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_ExceptionLog
    {
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> RecordTime { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> ExceptionUserID { get; set; }
        public string ExceptionContent { get; set; }
        public string ExceptionContentToXML { get; set; }
    }
}

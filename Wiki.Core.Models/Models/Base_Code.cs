using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Code
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public string CodeName { get; set; }
        public string CodeNameEn { get; set; }
        public int CodeTypeID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string CodeOrderNo { get; set; }
        public string CodeDescribe { get; set; }
        public System.TimeSpan Rowversion { get; set; }
        public Nullable<bool> IsValid { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Company
    {
        public System.Guid ID { get; set; }
        public int CompanyID { get; set; }
        public string Plant { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public string Remark { get; set; }
    }
}

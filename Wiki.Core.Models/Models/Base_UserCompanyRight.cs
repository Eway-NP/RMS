using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_UserCompanyRight
    {
        public System.Guid ID { get; set; }
        public string UserID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<bool> IsDefault { get; set; }
    }
}

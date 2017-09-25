using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_CompanyInfo
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Nullable<bool> IsDelted { get; set; }
        public string Remark { get; set; }
    }
}

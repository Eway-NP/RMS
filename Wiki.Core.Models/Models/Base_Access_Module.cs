using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Access_Module
    {
        public System.Guid ModuleId { get; set; }
        public string ModuleName { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
        public Nullable<int> OrderID { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_CodeInfo
    {
        public System.Guid CodeId { get; set; }
        public string CodeName { get; set; }
        public System.Guid CodeTypeId { get; set; }
        public byte[] RowVersion { get; set; }
        public bool IsValid { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public string Remark { get; set; }
        public int CompanyId { get; set; }
    }
}

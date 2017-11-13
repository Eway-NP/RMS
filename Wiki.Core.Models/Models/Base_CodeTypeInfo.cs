using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_CodeTypeInfo
    {
        public System.Guid CodeTypeId { get; set; }
        public string CodeTypeName { get; set; }
        public byte[] RowVersion { get; set; }
        public bool IsValid { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public string Remark { get; set; }
        public int CompanyId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_CodeType
    {
        public System.Guid ID { get; set; }
        public int CodeTypeID { get; set; }
        public string CodeTypeName { get; set; }
        public string CodeTypeNameEn { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string CodeTypeOrderNo { get; set; }
        public Nullable<int> ParentTypeID { get; set; }
        public string CodeTypeDescribe { get; set; }
        public byte[] Rowversion { get; set; }
        public Nullable<bool> IsValid { get; set; }
    }
}

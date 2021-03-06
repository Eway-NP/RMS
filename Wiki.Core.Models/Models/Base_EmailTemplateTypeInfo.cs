using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_EmailTemplateTypeInfo
    {
        public System.Guid Id { get; set; }
        public string TemplateTypeName { get; set; }
        public string TemplateTypeRemark { get; set; }
        public System.Guid CreatedUser { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
    }
}

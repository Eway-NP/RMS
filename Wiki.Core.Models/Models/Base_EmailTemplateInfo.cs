using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_EmailTemplateInfo
    {
        public System.Guid Id { get; set; }
        public System.Guid TemplateTypeId { get; set; }
        public string TemplateContent { get; set; }
        public string TemplateSubject { get; set; }
        public int ParameterCount { get; set; }
        public System.Guid CreatedUser { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
        public int CompanyId { get; set; }
        public string TemplateTypeName { get; set; }
    }
}

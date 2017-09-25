using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_RoleInfo
    {
        public System.Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public byte[] RowVersion { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public int CompanyId { get; set; }
    }
}

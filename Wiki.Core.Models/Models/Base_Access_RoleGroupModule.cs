using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Access_RoleGroupModule
    {
        public System.Guid RoleGroupModuleId { get; set; }
        public System.Guid RoleGroupId { get; set; }
        public System.Guid ModuleId { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
    }
}

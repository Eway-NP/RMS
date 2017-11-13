using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Access_GroupModule
    {
        public System.Guid GroupModuleId { get; set; }
        public System.Guid GroupId { get; set; }
        public System.Guid ModuleId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
    }
}

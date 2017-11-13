using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Access_RoleGroup
    {
        public System.Guid RoleGroupId { get; set; }
        public System.Guid GroupId { get; set; }
        public System.Guid RoleId { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
    }
}

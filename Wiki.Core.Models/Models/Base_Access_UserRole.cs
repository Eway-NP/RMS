using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Access_UserRole
    {
        public System.Guid UserRoleId { get; set; }
        public System.Guid UserId { get; set; }
        public System.Guid RoleId { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
    }
}

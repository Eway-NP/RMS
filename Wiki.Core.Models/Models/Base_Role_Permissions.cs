using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Role_Permissions
    {
        public System.Guid RoleId { get; set; }
        public System.Guid PermissionsId { get; set; }
        public System.Guid Id { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}

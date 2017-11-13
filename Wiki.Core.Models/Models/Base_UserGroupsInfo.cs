using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_UserGroupsInfo
    {
        public System.Guid UserGroupsId { get; set; }
        public string UserGroupsName { get; set; }
        public Nullable<System.Guid> ParentUserGroupsId { get; set; }
        public byte[] RowVersion { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}

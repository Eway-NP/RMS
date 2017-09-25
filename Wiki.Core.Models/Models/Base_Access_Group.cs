using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Access_Group
    {
        public System.Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
    }
}

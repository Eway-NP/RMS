using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Access_Role
    {
        public System.Guid ID { get; set; }
        public string RoleName { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
    }
}

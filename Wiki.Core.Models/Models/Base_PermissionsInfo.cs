using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_PermissionsInfo
    {
        public System.Guid PermissionsId { get; set; }
        public string PermissionsType { get; set; }
        public byte[] RowVersion { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public int CompanyId { get; set; }
    }
}

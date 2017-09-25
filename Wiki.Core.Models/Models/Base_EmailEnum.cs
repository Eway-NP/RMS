using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_EmailEnum
    {
        public System.Guid ID { get; set; }
        public string SysMenuID { get; set; }
        public string SysMenuName { get; set; }
        public string TypeID { get; set; }
        public string TypeName { get; set; }
    }
}

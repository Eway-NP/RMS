using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Agents_Menu
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> MID { get; set; }
        public Nullable<System.Guid> MenuID { get; set; }
        public int SysNo { get; set; }
    }
}

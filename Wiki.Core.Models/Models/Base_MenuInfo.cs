using System;
using System.Collections.Generic;
using Wiki.Component.Tools;

namespace Wiki.Core.Models.Models
{
    public partial class Base_MenuInfo:EntityBase<Guid>

    {
        public System.Guid MenuId { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string RightIConClass { get; set; }
        public string LeftIConClass { get; set; }
        public int? OrderID { get; set; }
        public bool? IsValid { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
        public string LangKey { get; set; }
    }
}

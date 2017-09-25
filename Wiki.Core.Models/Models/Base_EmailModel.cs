using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_EmailModel
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> ModelID { get; set; }
        public string SysMenuID { get; set; }
        public string SysMenuName { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string ModiUser { get; set; }
        public Nullable<System.DateTime> ModiTime { get; set; }
        public string TemplateParameters { get; set; }
    }
}

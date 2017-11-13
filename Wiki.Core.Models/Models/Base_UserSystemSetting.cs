using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_UserSystemSetting
    {
        public System.Guid SystemSetId { get; set; }
        public System.Guid UserId { get; set; }
        public int ScreenTime { get; set; }
        public int DefaultCommpanyId { get; set; }
        public string DefaultLang { get; set; }
        public string Remark { get; set; }
        public string RemeberAccount { get; set; }
    }
}

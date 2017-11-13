using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Agents
    {
        public System.Guid ID { get; set; }
        public int SysNo { get; set; }
        public Nullable<System.DateTime> BeginTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<System.Guid> AgentUserID { get; set; }
        public Nullable<System.Guid> OriginUser { get; set; }
        public Nullable<bool> IsSendMail { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Nullable<System.DateTime> CancleTime { get; set; }
        public string AgentEmail { get; set; }
        public string AgentName { get; set; }
        public string Remark { get; set; }
    }
}

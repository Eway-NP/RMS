using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_MainFlowTemplate
    {
        public System.Guid ID { get; set; }
        public string ModuleType { get; set; }
        public string NodeName { get; set; }
        public string ClassNo { get; set; }
        public string Approveuser { get; set; }
        public string Agent { get; set; }
        public string ApproveTo { get; set; }
        public string RejectTo { get; set; }
        public string ReturnTo { get; set; }
        public string IsClose { get; set; }
        public Nullable<bool> IsParallelapproval { get; set; }
        public Nullable<bool> Ifconditionnode { get; set; }
        public string Condition { get; set; }
        public Nullable<bool> Choosereturn { get; set; }
        public string CreateUser { get; set; }
        public string CreateTime { get; set; }
        public string CompanyID { get; set; }
    }
}

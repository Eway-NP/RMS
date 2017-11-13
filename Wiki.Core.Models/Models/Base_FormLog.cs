using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_FormLog
    {
        public System.Guid Id { get; set; }
        public System.Guid FormId { get; set; }
        public string FormType { get; set; }
        public string OperatorEmail { get; set; }
        public System.DateTime OperatorDate { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
    }
}

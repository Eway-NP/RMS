using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_WorkflowFile
    {
        public System.Guid WorkflowFileId { get; set; }
        public System.Guid WorkflowFormId { get; set; }
        public System.Guid FileId { get; set; }
        public string WorkflowAreaId { get; set; }
    }
}

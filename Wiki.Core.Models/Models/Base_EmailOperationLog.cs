using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_EmailOperationLog
    {
        public System.Guid ID { get; set; }
        public string SendUser { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public string CC { get; set; }
        public Nullable<bool> SendState { get; set; }
        public string ErrorMessage { get; set; }
    }
}

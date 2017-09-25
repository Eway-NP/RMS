using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_OperationInfo
    {
        public System.Guid OperationId { get; set; }
        public string OperationName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid CreatedUser { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
    }
}

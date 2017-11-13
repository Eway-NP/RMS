using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_RightOperation
    {
        public System.Guid Id { get; set; }
        public System.Guid OperationId { get; set; }
        public System.Guid RightId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Remark { get; set; }
    }
}

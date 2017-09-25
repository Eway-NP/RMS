using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_FileOperationLog
    {
        public System.Guid FileLogID { get; set; }
        public System.Guid FileID { get; set; }
        public System.Guid OperationUserID { get; set; }
        public string OperationContent { get; set; }
        public string OperationType { get; set; }
        public System.DateTime OperationDate { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
        public bool IsSuccess { get; set; }
        public Nullable<int> OrderBy { get; set; }
    }
}

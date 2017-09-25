using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_SnapshotInfo
    {
        public System.Guid SnapshotId { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string FormModel { get; set; }
        public System.Guid CreatedUserId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public string Remark { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_FileRight
    {
        public System.Guid FileRightID { get; set; }
        public System.Guid FileId { get; set; }
        public System.Guid RightId { get; set; }
        public byte[] RowVersion { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Remark { get; set; }
    }
}

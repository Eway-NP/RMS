using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_UserManual
    {
        public int ID { get; set; }
        public string FileID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpUser { get; set; }
    }
}

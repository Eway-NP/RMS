using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Dept
    {
        public System.Guid ID { get; set; }
        public string DeptID { get; set; }
        public string DeptName { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CompanyID { get; set; }
    }
}

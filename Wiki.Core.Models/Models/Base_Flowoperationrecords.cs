using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_Flowoperationrecords
    {
        public System.Guid ID { get; set; }
        public string Formid { get; set; }
        public string Formmoduletype { get; set; }
        public string Operatingdata { get; set; }
        public string Operatinguser { get; set; }
        public Nullable<System.DateTime> Operatingtime { get; set; }
        public Nullable<int> Sort { get; set; }
    }
}

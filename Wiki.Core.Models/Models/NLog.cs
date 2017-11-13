using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class NLog
    {
        public int ID { get; set; }
        public string MachineName { get; set; }
        public string SiteName { get; set; }
        public System.DateTime Logged { get; set; }
        public string Level { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
        public string Logger { get; set; }
        public string Properties { get; set; }
        public string ServerName { get; set; }
        public string Port { get; set; }
        public string Url { get; set; }
        public Nullable<bool> Https { get; set; }
        public string ServerAddress { get; set; }
        public string RemoteAddress { get; set; }
        public string Callsite { get; set; }
        public string Exception { get; set; }
    }
}

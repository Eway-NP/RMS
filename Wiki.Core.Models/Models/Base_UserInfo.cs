using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_UserInfo
    {
        public System.Guid UserId { get; set; }
        public string DeptID { get; set; }
        public string ProfitCenter { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string WorkNo { get; set; }
        public string MobilePhone { get; set; }
        public string LockScreenPassword { get; set; }
        public string ChineseName { get; set; }
        public string EnglishName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Telephone { get; set; }
        public System.DateTime RegistrationTime { get; set; }
        public bool IsValid { get; set; }
        public string TechnicalTitle { get; set; }
        public string SeniorManager { get; set; }
        public string CostCenter { get; set; }
        public string Remark { get; set; }
        public string UserImage { get; set; }
    }
}

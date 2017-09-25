using System;
using System.Collections.Generic;

namespace Wiki.Core.Models.Models
{
    public partial class Base_FileInfo
    {
        public System.Guid FileID { get; set; }
        public string PhysicalPath { get; set; }
        public string DownLoadPath { get; set; }
        public string OriginalName { get; set; }
        public string CurrentName { get; set; }
        public string FileType { get; set; }
        public double FileSize { get; set; }
        public string FileLang { get; set; }
        public int DownLoadCount { get; set; }
        public Nullable<System.Guid> UpLoadUserID { get; set; }
        public System.DateTime UploadDate { get; set; }
        public byte[] RowVersion { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string ShortRemark { get; set; }
        public string Remark { get; set; }
        public string FileOpenness { get; set; }
        public Nullable<int> OrderBy { get; set; }
        public string ProjectNo { get; set; }
        public string FileVersion { get; set; }
        public string FlowType { get; set; }
        public string FileNo { get; set; }
        public string ProjectNo_In { get; set; }
        public string FileNo_In { get; set; }
        public string UpLoadUserEmail { get; set; }
        public int IndexNo { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_FileInfoMap : EntityTypeConfiguration<Base_FileInfo>
    {
        public Base_FileInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.FileID);

            // Properties
            this.Property(t => t.PhysicalPath)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.DownLoadPath)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OriginalName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CurrentName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.FileType)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.FileLang)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            this.Property(t => t.ShortRemark)
                .HasMaxLength(500);

            this.Property(t => t.FileOpenness)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ProjectNo)
                .HasMaxLength(50);

            this.Property(t => t.FileVersion)
                .HasMaxLength(50);

            this.Property(t => t.FlowType)
                .HasMaxLength(50);

            this.Property(t => t.FileNo)
                .HasMaxLength(50);

            this.Property(t => t.ProjectNo_In)
                .HasMaxLength(50);

            this.Property(t => t.FileNo_In)
                .HasMaxLength(50);

            this.Property(t => t.UpLoadUserEmail)
                .HasMaxLength(50);

            this.Property(t => t.IndexNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("Base_FileInfo");
            this.Property(t => t.FileID).HasColumnName("FileID");
            this.Property(t => t.PhysicalPath).HasColumnName("PhysicalPath");
            this.Property(t => t.DownLoadPath).HasColumnName("DownLoadPath");
            this.Property(t => t.OriginalName).HasColumnName("OriginalName");
            this.Property(t => t.CurrentName).HasColumnName("CurrentName");
            this.Property(t => t.FileType).HasColumnName("FileType");
            this.Property(t => t.FileSize).HasColumnName("FileSize");
            this.Property(t => t.FileLang).HasColumnName("FileLang");
            this.Property(t => t.DownLoadCount).HasColumnName("DownLoadCount");
            this.Property(t => t.UpLoadUserID).HasColumnName("UpLoadUserID");
            this.Property(t => t.UploadDate).HasColumnName("UploadDate");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.ShortRemark).HasColumnName("ShortRemark");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.FileOpenness).HasColumnName("FileOpenness");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.ProjectNo).HasColumnName("ProjectNo");
            this.Property(t => t.FileVersion).HasColumnName("FileVersion");
            this.Property(t => t.FlowType).HasColumnName("FlowType");
            this.Property(t => t.FileNo).HasColumnName("FileNo");
            this.Property(t => t.ProjectNo_In).HasColumnName("ProjectNo_In");
            this.Property(t => t.FileNo_In).HasColumnName("FileNo_In");
            this.Property(t => t.UpLoadUserEmail).HasColumnName("UpLoadUserEmail");
            this.Property(t => t.IndexNo).HasColumnName("IndexNo");
        }
    }
}

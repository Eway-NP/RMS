using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_FileOperationLogMap : EntityTypeConfiguration<Base_FileOperationLog>
    {
        public Base_FileOperationLogMap()
        {
            // Primary Key
            this.HasKey(t => t.FileLogID);

            // Properties
            this.Property(t => t.OperationContent)
                .IsRequired();

            this.Property(t => t.OperationType)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_FileOperationLog");
            this.Property(t => t.FileLogID).HasColumnName("FileLogID");
            this.Property(t => t.FileID).HasColumnName("FileID");
            this.Property(t => t.OperationUserID).HasColumnName("OperationUserID");
            this.Property(t => t.OperationContent).HasColumnName("OperationContent");
            this.Property(t => t.OperationType).HasColumnName("OperationType");
            this.Property(t => t.OperationDate).HasColumnName("OperationDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsSuccess).HasColumnName("IsSuccess");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
        }
    }
}

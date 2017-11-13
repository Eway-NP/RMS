using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_OperationInfoMap : EntityTypeConfiguration<Base_OperationInfo>
    {
        public Base_OperationInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.OperationId);

            // Properties
            this.Property(t => t.OperationName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_OperationInfo");
            this.Property(t => t.OperationId).HasColumnName("OperationId");
            this.Property(t => t.OperationName).HasColumnName("OperationName");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

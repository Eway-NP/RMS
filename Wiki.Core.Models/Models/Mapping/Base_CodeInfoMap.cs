using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_CodeInfoMap : EntityTypeConfiguration<Base_CodeInfo>
    {
        public Base_CodeInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.CodeId);

            // Properties
            this.Property(t => t.CodeName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_CodeInfo");
            this.Property(t => t.CodeId).HasColumnName("CodeId");
            this.Property(t => t.CodeName).HasColumnName("CodeName");
            this.Property(t => t.CodeTypeId).HasColumnName("CodeTypeId");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_CodeTypeInfoMap : EntityTypeConfiguration<Base_CodeTypeInfo>
    {
        public Base_CodeTypeInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.CodeTypeId);

            // Properties
            this.Property(t => t.CodeTypeName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_CodeTypeInfo");
            this.Property(t => t.CodeTypeId).HasColumnName("CodeTypeId");
            this.Property(t => t.CodeTypeName).HasColumnName("CodeTypeName");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_EmailTemplateTypeInfoMap : EntityTypeConfiguration<Base_EmailTemplateTypeInfo>
    {
        public Base_EmailTemplateTypeInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TemplateTypeName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_EmailTemplateTypeInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TemplateTypeName).HasColumnName("TemplateTypeName");
            this.Property(t => t.TemplateTypeRemark).HasColumnName("TemplateTypeRemark");
            this.Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

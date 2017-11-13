using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_EmailTemplateInfoMap : EntityTypeConfiguration<Base_EmailTemplateInfo>
    {
        public Base_EmailTemplateInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TemplateContent)
                .IsRequired();

            this.Property(t => t.TemplateSubject)
                .HasMaxLength(200);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            this.Property(t => t.TemplateTypeName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Base_EmailTemplateInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TemplateTypeId).HasColumnName("TemplateTypeId");
            this.Property(t => t.TemplateContent).HasColumnName("TemplateContent");
            this.Property(t => t.TemplateSubject).HasColumnName("TemplateSubject");
            this.Property(t => t.ParameterCount).HasColumnName("ParameterCount");
            this.Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.TemplateTypeName).HasColumnName("TemplateTypeName");
        }
    }
}

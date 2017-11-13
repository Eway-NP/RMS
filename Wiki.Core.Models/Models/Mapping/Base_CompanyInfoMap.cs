using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_CompanyInfoMap : EntityTypeConfiguration<Base_CompanyInfo>
    {
        public Base_CompanyInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.CompanyId);

            // Properties
            this.Property(t => t.CompanyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Base_CompanyInfo");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.IsDelted).HasColumnName("IsDelted");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

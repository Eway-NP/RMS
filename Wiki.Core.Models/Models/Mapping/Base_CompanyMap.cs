using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_CompanyMap : EntityTypeConfiguration<Base_Company>
    {
        public Base_CompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Plant)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Remark)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Base_Company");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

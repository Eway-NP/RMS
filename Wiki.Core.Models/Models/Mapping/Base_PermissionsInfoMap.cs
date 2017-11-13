using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_PermissionsInfoMap : EntityTypeConfiguration<Base_PermissionsInfo>
    {
        public Base_PermissionsInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.PermissionsId);

            // Properties
            this.Property(t => t.PermissionsType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_PermissionsInfo");
            this.Property(t => t.PermissionsId).HasColumnName("PermissionsId");
            this.Property(t => t.PermissionsType).HasColumnName("PermissionsType");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
        }
    }
}

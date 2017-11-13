using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Access_RoleMap : EntityTypeConfiguration<Base_Access_Role>
    {
        public Base_Access_RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_Access_Role");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Access_UserRoleMap : EntityTypeConfiguration<Base_Access_UserRole>
    {
        public Base_Access_UserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.UserRoleId);

            // Properties
            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_Access_UserRole");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

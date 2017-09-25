using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Access_RoleGroupModuleMap : EntityTypeConfiguration<Base_Access_RoleGroupModule>
    {
        public Base_Access_RoleGroupModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleGroupModuleId);

            // Properties
            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_Access_RoleGroupModule");
            this.Property(t => t.RoleGroupModuleId).HasColumnName("RoleGroupModuleId");
            this.Property(t => t.RoleGroupId).HasColumnName("RoleGroupId");
            this.Property(t => t.ModuleId).HasColumnName("ModuleId");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Role_PermissionsMap : EntityTypeConfiguration<Base_Role_Permissions>
    {
        public Base_Role_PermissionsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Base_Role_Permissions");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.PermissionsId).HasColumnName("PermissionsId");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}

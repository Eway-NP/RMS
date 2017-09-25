using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Permissions_MenuMap : EntityTypeConfiguration<Base_Permissions_Menu>
    {
        public Base_Permissions_MenuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PermissionsId, t.MenuId });

            // Properties
            // Table & Column Mappings
            this.ToTable("Base_Permissions_Menu");
            this.Property(t => t.PermissionsId).HasColumnName("PermissionsId");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
        }
    }
}

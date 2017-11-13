using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_User_RoleMap : EntityTypeConfiguration<Base_User_Role>
    {
        public Base_User_RoleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserId, t.RoleId });

            // Properties
            // Table & Column Mappings
            this.ToTable("Base_User_Role");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
        }
    }
}

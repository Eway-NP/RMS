using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Groups_RoleMap : EntityTypeConfiguration<Base_Groups_Role>
    {
        public Base_Groups_RoleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserGroupsId, t.RoleId });

            // Properties
            // Table & Column Mappings
            this.ToTable("Base_Groups_Role");
            this.Property(t => t.UserGroupsId).HasColumnName("UserGroupsId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
        }
    }
}

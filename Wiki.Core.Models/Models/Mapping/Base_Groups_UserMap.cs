using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Groups_UserMap : EntityTypeConfiguration<Base_Groups_User>
    {
        public Base_Groups_UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Base_Groups_User");
            this.Property(t => t.UserGroupsId).HasColumnName("UserGroupsId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}

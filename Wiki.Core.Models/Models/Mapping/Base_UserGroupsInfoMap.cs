using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_UserGroupsInfoMap : EntityTypeConfiguration<Base_UserGroupsInfo>
    {
        public Base_UserGroupsInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.UserGroupsId);

            // Properties
            this.Property(t => t.UserGroupsName)
                .HasMaxLength(50);

            this.Property(t => t.RowVersion)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_UserGroupsInfo");
            this.Property(t => t.UserGroupsId).HasColumnName("UserGroupsId");
            this.Property(t => t.UserGroupsName).HasColumnName("UserGroupsName");
            this.Property(t => t.ParentUserGroupsId).HasColumnName("ParentUserGroupsId");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}

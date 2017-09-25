using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Access_RoleGroupMap : EntityTypeConfiguration<Base_Access_RoleGroup>
    {
        public Base_Access_RoleGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleGroupId);

            // Properties
            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_Access_RoleGroup");
            this.Property(t => t.RoleGroupId).HasColumnName("RoleGroupId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

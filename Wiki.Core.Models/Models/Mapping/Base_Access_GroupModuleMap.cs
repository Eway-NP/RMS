using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Access_GroupModuleMap : EntityTypeConfiguration<Base_Access_GroupModule>
    {
        public Base_Access_GroupModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupModuleId);

            // Properties
            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_Access_GroupModule");
            this.Property(t => t.GroupModuleId).HasColumnName("GroupModuleId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.ModuleId).HasColumnName("ModuleId");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

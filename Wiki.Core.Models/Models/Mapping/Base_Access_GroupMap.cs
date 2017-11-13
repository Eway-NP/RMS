using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Access_GroupMap : EntityTypeConfiguration<Base_Access_Group>
    {
        public Base_Access_GroupMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupId);

            // Properties
            this.Property(t => t.GroupName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_Access_Group");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

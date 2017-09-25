using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_EmailEnumMap : EntityTypeConfiguration<Base_EmailEnum>
    {
        public Base_EmailEnumMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SysMenuID)
                .HasMaxLength(50);

            this.Property(t => t.SysMenuName)
                .HasMaxLength(500);

            this.Property(t => t.TypeID)
                .HasMaxLength(50);

            this.Property(t => t.TypeName)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Base_EmailEnum");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SysMenuID).HasColumnName("SysMenuID");
            this.Property(t => t.SysMenuName).HasColumnName("SysMenuName");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
        }
    }
}

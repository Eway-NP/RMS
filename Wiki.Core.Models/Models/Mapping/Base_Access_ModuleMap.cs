using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Access_ModuleMap : EntityTypeConfiguration<Base_Access_Module>
    {
        public Base_Access_ModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.ModuleId);

            // Properties
            this.Property(t => t.ModuleName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_Access_Module");
            this.Property(t => t.ModuleId).HasColumnName("ModuleId");
            this.Property(t => t.ModuleName).HasColumnName("ModuleName");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
        }
    }
}

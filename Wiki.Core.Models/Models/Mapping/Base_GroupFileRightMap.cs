using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_GroupFileRightMap : EntityTypeConfiguration<Base_GroupFileRight>
    {
        public Base_GroupFileRightMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_GroupFileRight");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FileID).HasColumnName("FileID");
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.FileRightID).HasColumnName("FileRightID");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_FileRightMap : EntityTypeConfiguration<Base_FileRight>
    {
        public Base_FileRightMap()
        {
            // Primary Key
            this.HasKey(t => t.FileRightID);

            // Properties
            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_FileRight");
            this.Property(t => t.FileRightID).HasColumnName("FileRightID");
            this.Property(t => t.FileId).HasColumnName("FileId");
            this.Property(t => t.RightId).HasColumnName("RightId");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

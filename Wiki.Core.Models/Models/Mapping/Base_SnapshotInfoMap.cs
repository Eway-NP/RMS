using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_SnapshotInfoMap : EntityTypeConfiguration<Base_SnapshotInfo>
    {
        public Base_SnapshotInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.SnapshotId);

            // Properties
            this.Property(t => t.Controller)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Action)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FormModel)
                .IsRequired();

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_SnapshotInfo");
            this.Property(t => t.SnapshotId).HasColumnName("SnapshotId");
            this.Property(t => t.Controller).HasColumnName("Controller");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.FormModel).HasColumnName("FormModel");
            this.Property(t => t.CreatedUserId).HasColumnName("CreatedUserId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

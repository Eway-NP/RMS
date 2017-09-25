using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_UserManualMap : EntityTypeConfiguration<Base_UserManual>
    {
        public Base_UserManualMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FileID)
                .HasMaxLength(50);

            this.Property(t => t.UpUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Base_UserManual");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FileID).HasColumnName("FileID");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpUser).HasColumnName("UpUser");
        }
    }
}

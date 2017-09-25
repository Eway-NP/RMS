using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_FileDeptMap : EntityTypeConfiguration<Base_FileDept>
    {
        public Base_FileDeptMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeptName)
                .HasMaxLength(50);

            this.Property(t => t.PID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Base_FileDept");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DeptName).HasColumnName("DeptName");
            this.Property(t => t.PID).HasColumnName("PID");
        }
    }
}

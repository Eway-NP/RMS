using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_DeptMap : EntityTypeConfiguration<Base_Dept>
    {
        public Base_DeptMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DeptID)
                .HasMaxLength(50);

            this.Property(t => t.DeptName)
                .HasMaxLength(100);

            this.Property(t => t.CompanyID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Base_Dept");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DeptID).HasColumnName("DeptID");
            this.Property(t => t.DeptName).HasColumnName("DeptName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_RoleFileRightMap : EntityTypeConfiguration<Base_RoleFileRight>
    {
        public Base_RoleFileRightMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Base_RoleFileRight");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RoleFileRightID).HasColumnName("RoleFileRightID");
            this.Property(t => t.FileID).HasColumnName("FileID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.FileRightID).HasColumnName("FileRightID");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_OperationLogMap : EntityTypeConfiguration<Base_OperationLog>
    {
        public Base_OperationLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.OptUserName)
                .HasMaxLength(50);

            this.Property(t => t.OptContent)
                .HasMaxLength(500);

            this.Property(t => t.OptContentEN)
                .HasMaxLength(500);

            this.Property(t => t.OptRemark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Base_OperationLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OptType).HasColumnName("OptType");
            this.Property(t => t.OptUserID).HasColumnName("OptUserID");
            this.Property(t => t.OptUserName).HasColumnName("OptUserName");
            this.Property(t => t.OptContent).HasColumnName("OptContent");
            this.Property(t => t.OptContentEN).HasColumnName("OptContentEN");
            this.Property(t => t.OptTime).HasColumnName("OptTime");
            this.Property(t => t.OptRemark).HasColumnName("OptRemark");
            this.Property(t => t.AngentID).HasColumnName("AngentID");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_UserCompanyRightMap : EntityTypeConfiguration<Base_UserCompanyRight>
    {
        public Base_UserCompanyRightMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UserID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Base_UserCompanyRight");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
        }
    }
}

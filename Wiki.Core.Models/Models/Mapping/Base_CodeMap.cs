using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_CodeMap : EntityTypeConfiguration<Base_Code>
    {
        public Base_CodeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CodeName)
                .HasMaxLength(200);

            this.Property(t => t.CodeNameEn)
                .HasMaxLength(200);

            this.Property(t => t.CodeOrderNo)
                .HasMaxLength(50);

            this.Property(t => t.CodeDescribe)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Base_Code");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.CodeName).HasColumnName("CodeName");
            this.Property(t => t.CodeNameEn).HasColumnName("CodeNameEn");
            this.Property(t => t.CodeTypeID).HasColumnName("CodeTypeID");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.CodeOrderNo).HasColumnName("CodeOrderNo");
            this.Property(t => t.CodeDescribe).HasColumnName("CodeDescribe");
            this.Property(t => t.Rowversion).HasColumnName("Rowversion");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_CodeTypeMap : EntityTypeConfiguration<Base_CodeType>
    {
        public Base_CodeTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CodeTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CodeTypeName)
                .HasMaxLength(200);

            this.Property(t => t.CodeTypeNameEn)
                .HasMaxLength(200);

            this.Property(t => t.CodeTypeOrderNo)
                .HasMaxLength(50);

            this.Property(t => t.CodeTypeDescribe)
                .HasMaxLength(200);

            this.Property(t => t.Rowversion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Base_CodeType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CodeTypeID).HasColumnName("CodeTypeID");
            this.Property(t => t.CodeTypeName).HasColumnName("CodeTypeName");
            this.Property(t => t.CodeTypeNameEn).HasColumnName("CodeTypeNameEn");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.CodeTypeOrderNo).HasColumnName("CodeTypeOrderNo");
            this.Property(t => t.ParentTypeID).HasColumnName("ParentTypeID");
            this.Property(t => t.CodeTypeDescribe).HasColumnName("CodeTypeDescribe");
            this.Property(t => t.Rowversion).HasColumnName("Rowversion");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
        }
    }
}

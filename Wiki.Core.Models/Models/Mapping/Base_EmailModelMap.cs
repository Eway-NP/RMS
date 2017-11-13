using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_EmailModelMap : EntityTypeConfiguration<Base_EmailModel>
    {
        public Base_EmailModelMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SysMenuID)
                .HasMaxLength(50);

            this.Property(t => t.SysMenuName)
                .HasMaxLength(500);

            this.Property(t => t.Name)
                .HasMaxLength(500);

            this.Property(t => t.Subject)
                .HasMaxLength(500);

            this.Property(t => t.ModiUser)
                .HasMaxLength(50);

            this.Property(t => t.TemplateParameters)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Base_EmailModel");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ModelID).HasColumnName("ModelID");
            this.Property(t => t.SysMenuID).HasColumnName("SysMenuID");
            this.Property(t => t.SysMenuName).HasColumnName("SysMenuName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.ModiUser).HasColumnName("ModiUser");
            this.Property(t => t.ModiTime).HasColumnName("ModiTime");
            this.Property(t => t.TemplateParameters).HasColumnName("TemplateParameters");
        }
    }
}

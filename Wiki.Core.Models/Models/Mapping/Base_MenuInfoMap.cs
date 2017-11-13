using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_MenuInfoMap : EntityTypeConfiguration<Base_MenuInfo>
    {
        public Base_MenuInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Action)
                .HasMaxLength(250);

            this.Property(t => t.Controller)
                .HasMaxLength(100);

            this.Property(t => t.RightIConClass)
                .HasMaxLength(50);

            this.Property(t => t.LeftIConClass)
                .HasMaxLength(50);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            this.Property(t => t.LangKey)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Base_MenuInfo");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.Controller).HasColumnName("Controller");
            this.Property(t => t.RightIConClass).HasColumnName("RightIConClass");
            this.Property(t => t.LeftIConClass).HasColumnName("LeftIConClass");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.LangKey).HasColumnName("LangKey");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_Agents_MenuMap : EntityTypeConfiguration<Base_Agents_Menu>
    {
        public Base_Agents_MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SysNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("Base_Agents_Menu");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MID).HasColumnName("MID");
            this.Property(t => t.MenuID).HasColumnName("MenuID");
            this.Property(t => t.SysNo).HasColumnName("SysNo");
        }
    }
}

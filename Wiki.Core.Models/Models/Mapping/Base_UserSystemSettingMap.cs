using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_UserSystemSettingMap : EntityTypeConfiguration<Base_UserSystemSetting>
    {
        public Base_UserSystemSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.SystemSetId);

            // Properties
            this.Property(t => t.DefaultLang)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RemeberAccount)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Base_UserSystemSetting");
            this.Property(t => t.SystemSetId).HasColumnName("SystemSetId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ScreenTime).HasColumnName("ScreenTime");
            this.Property(t => t.DefaultCommpanyId).HasColumnName("DefaultCommpanyId");
            this.Property(t => t.DefaultLang).HasColumnName("DefaultLang");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.RemeberAccount).HasColumnName("RemeberAccount");
        }
    }
}

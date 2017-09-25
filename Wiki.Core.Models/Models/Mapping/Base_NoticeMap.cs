using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_NoticeMap : EntityTypeConfiguration<Base_Notice>
    {
        public Base_NoticeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(200);

            this.Property(t => t.Content)
                .HasMaxLength(5000);

            this.Property(t => t.Creater)
                .HasMaxLength(200);

            this.Property(t => t.Status)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Base_Notice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Creater).HasColumnName("Creater");
            this.Property(t => t.Createtime).HasColumnName("Createtime");
            this.Property(t => t.Activetime).HasColumnName("Activetime");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}

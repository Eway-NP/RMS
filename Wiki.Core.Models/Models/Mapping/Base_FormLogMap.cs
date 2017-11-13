using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_FormLogMap : EntityTypeConfiguration<Base_FormLog>
    {
        public Base_FormLogMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FormType)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OperatorEmail)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Base_FormLog");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.FormType).HasColumnName("FormType");
            this.Property(t => t.OperatorEmail).HasColumnName("OperatorEmail");
            this.Property(t => t.OperatorDate).HasColumnName("OperatorDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

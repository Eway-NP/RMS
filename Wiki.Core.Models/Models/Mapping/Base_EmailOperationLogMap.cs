using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_EmailOperationLogMap : EntityTypeConfiguration<Base_EmailOperationLog>
    {
        public Base_EmailOperationLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SendUser)
                .HasMaxLength(500);

            this.Property(t => t.Subject)
                .HasMaxLength(500);

            this.Property(t => t.CC)
                .HasMaxLength(500);

            this.Property(t => t.ErrorMessage)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Base_EmailOperationLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SendUser).HasColumnName("SendUser");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.SendTime).HasColumnName("SendTime");
            this.Property(t => t.CC).HasColumnName("CC");
            this.Property(t => t.SendState).HasColumnName("SendState");
            this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage");
        }
    }
}

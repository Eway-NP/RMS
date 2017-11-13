using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_ExceptionLogMap : EntityTypeConfiguration<Base_ExceptionLog>
    {
        public Base_ExceptionLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ExceptionContent)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Base_ExceptionLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecordTime).HasColumnName("RecordTime");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.ExceptionUserID).HasColumnName("ExceptionUserID");
            this.Property(t => t.ExceptionContent).HasColumnName("ExceptionContent");
            this.Property(t => t.ExceptionContentToXML).HasColumnName("ExceptionContentToXML");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_SystemLogMap : EntityTypeConfiguration<Base_SystemLog>
    {
        public Base_SystemLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.OperContent)
                .HasMaxLength(1000);

            this.Property(t => t.OperArgu)
                .HasMaxLength(1000);

            this.Property(t => t.OperSource)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Base_SystemLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecordTime).HasColumnName("RecordTime");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.OperUserID).HasColumnName("OperUserID");
            this.Property(t => t.OperType).HasColumnName("OperType");
            this.Property(t => t.OperResult).HasColumnName("OperResult");
            this.Property(t => t.OperContent).HasColumnName("OperContent");
            this.Property(t => t.OperArgu).HasColumnName("OperArgu");
            this.Property(t => t.OperSource).HasColumnName("OperSource");
            this.Property(t => t.OperRemark).HasColumnName("OperRemark");
        }
    }
}

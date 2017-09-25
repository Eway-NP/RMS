using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_FlowoperationrecordsMap : EntityTypeConfiguration<Base_Flowoperationrecords>
    {
        public Base_FlowoperationrecordsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Formid)
                .HasMaxLength(200);

            this.Property(t => t.Formmoduletype)
                .HasMaxLength(1000);

            this.Property(t => t.Operatingdata)
                .HasMaxLength(8000);

            this.Property(t => t.Operatinguser)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Base_Flowoperationrecords");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Formid).HasColumnName("Formid");
            this.Property(t => t.Formmoduletype).HasColumnName("Formmoduletype");
            this.Property(t => t.Operatingdata).HasColumnName("Operatingdata");
            this.Property(t => t.Operatinguser).HasColumnName("Operatinguser");
            this.Property(t => t.Operatingtime).HasColumnName("Operatingtime");
            this.Property(t => t.Sort).HasColumnName("Sort");
        }
    }
}

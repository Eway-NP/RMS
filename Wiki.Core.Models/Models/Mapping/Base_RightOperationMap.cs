using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_RightOperationMap : EntityTypeConfiguration<Base_RightOperation>
    {
        public Base_RightOperationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Base_RightOperation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OperationId).HasColumnName("OperationId");
            this.Property(t => t.RightId).HasColumnName("RightId");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

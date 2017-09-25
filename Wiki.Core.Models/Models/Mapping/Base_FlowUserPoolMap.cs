using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_FlowUserPoolMap : EntityTypeConfiguration<Base_FlowUserPool>
    {
        public Base_FlowUserPoolMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.GroupType)
                .HasMaxLength(200);

            this.Property(t => t.Department)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Base_FlowUserPool");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GroupType).HasColumnName("GroupType");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.UserList).HasColumnName("UserList");
            this.Property(t => t.Attr1).HasColumnName("Attr1");
            this.Property(t => t.Attr2).HasColumnName("Attr2");
            this.Property(t => t.Attr3).HasColumnName("Attr3");
        }
    }
}

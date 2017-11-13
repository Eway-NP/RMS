using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_WorkflowFileMap : EntityTypeConfiguration<Base_WorkflowFile>
    {
        public Base_WorkflowFileMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkflowFileId);

            // Properties
            this.Property(t => t.WorkflowAreaId)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Base_WorkflowFile");
            this.Property(t => t.WorkflowFileId).HasColumnName("WorkflowFileId");
            this.Property(t => t.WorkflowFormId).HasColumnName("WorkflowFormId");
            this.Property(t => t.FileId).HasColumnName("FileId");
            this.Property(t => t.WorkflowAreaId).HasColumnName("WorkflowAreaId");
        }
    }
}

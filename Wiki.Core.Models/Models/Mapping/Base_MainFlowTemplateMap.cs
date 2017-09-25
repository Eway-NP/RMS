using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_MainFlowTemplateMap : EntityTypeConfiguration<Base_MainFlowTemplate>
    {
        public Base_MainFlowTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ModuleType)
                .HasMaxLength(50);

            this.Property(t => t.ClassNo)
                .HasMaxLength(50);

            this.Property(t => t.Approveuser)
                .HasMaxLength(1000);

            this.Property(t => t.Agent)
                .HasMaxLength(1000);

            this.Property(t => t.ApproveTo)
                .HasMaxLength(50);

            this.Property(t => t.RejectTo)
                .HasMaxLength(50);

            this.Property(t => t.ReturnTo)
                .HasMaxLength(50);

            this.Property(t => t.IsClose)
                .HasMaxLength(50);

            this.Property(t => t.Condition)
                .HasMaxLength(1000);

            this.Property(t => t.CreateUser)
                .HasMaxLength(200);

            this.Property(t => t.CreateTime)
                .HasMaxLength(200);

            this.Property(t => t.CompanyID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Base_MainFlowTemplate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ModuleType).HasColumnName("ModuleType");
            this.Property(t => t.NodeName).HasColumnName("NodeName");
            this.Property(t => t.ClassNo).HasColumnName("ClassNo");
            this.Property(t => t.Approveuser).HasColumnName("Approveuser");
            this.Property(t => t.Agent).HasColumnName("Agent");
            this.Property(t => t.ApproveTo).HasColumnName("ApproveTo");
            this.Property(t => t.RejectTo).HasColumnName("RejectTo");
            this.Property(t => t.ReturnTo).HasColumnName("ReturnTo");
            this.Property(t => t.IsClose).HasColumnName("IsClose");
            this.Property(t => t.IsParallelapproval).HasColumnName("IsParallelapproval");
            this.Property(t => t.Ifconditionnode).HasColumnName("Ifconditionnode");
            this.Property(t => t.Condition).HasColumnName("Condition");
            this.Property(t => t.Choosereturn).HasColumnName("Choosereturn");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
        }
    }
}

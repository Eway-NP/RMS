using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_AgentsMap : EntityTypeConfiguration<Base_Agents>
    {
        public Base_AgentsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SysNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.AgentEmail)
                .HasMaxLength(50);

            this.Property(t => t.AgentName)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Base_Agents");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SysNo).HasColumnName("SysNo");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.AgentUserID).HasColumnName("AgentUserID");
            this.Property(t => t.OriginUser).HasColumnName("OriginUser");
            this.Property(t => t.IsSendMail).HasColumnName("IsSendMail");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.CancleTime).HasColumnName("CancleTime");
            this.Property(t => t.AgentEmail).HasColumnName("AgentEmail");
            this.Property(t => t.AgentName).HasColumnName("AgentName");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}

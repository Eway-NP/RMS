using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class NLogMap : EntityTypeConfiguration<NLog>
    {
        public NLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MachineName)
                .HasMaxLength(200);

            this.Property(t => t.SiteName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Level)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.UserName)
                .HasMaxLength(200);

            this.Property(t => t.Message)
                .IsRequired();

            this.Property(t => t.Logger)
                .HasMaxLength(300);

            this.Property(t => t.ServerName)
                .HasMaxLength(200);

            this.Property(t => t.Port)
                .HasMaxLength(100);

            this.Property(t => t.Url)
                .HasMaxLength(2000);

            this.Property(t => t.ServerAddress)
                .HasMaxLength(100);

            this.Property(t => t.RemoteAddress)
                .HasMaxLength(100);

            this.Property(t => t.Callsite)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("NLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.SiteName).HasColumnName("SiteName");
            this.Property(t => t.Logged).HasColumnName("Logged");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.Logger).HasColumnName("Logger");
            this.Property(t => t.Properties).HasColumnName("Properties");
            this.Property(t => t.ServerName).HasColumnName("ServerName");
            this.Property(t => t.Port).HasColumnName("Port");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Https).HasColumnName("Https");
            this.Property(t => t.ServerAddress).HasColumnName("ServerAddress");
            this.Property(t => t.RemoteAddress).HasColumnName("RemoteAddress");
            this.Property(t => t.Callsite).HasColumnName("Callsite");
            this.Property(t => t.Exception).HasColumnName("Exception");
        }
    }
}

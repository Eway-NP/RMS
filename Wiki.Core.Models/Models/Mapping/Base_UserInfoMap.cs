using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Wiki.Core.Models.Models.Mapping
{
    public class Base_UserInfoMap : EntityTypeConfiguration<Base_UserInfo>
    {
        public Base_UserInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.DeptID)
                .HasMaxLength(50);

            this.Property(t => t.ProfitCenter)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WorkNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MobilePhone)
                .HasMaxLength(50);

            this.Property(t => t.LockScreenPassword)
                .HasMaxLength(50);

            this.Property(t => t.ChineseName)
                .HasMaxLength(50);

            this.Property(t => t.EnglishName)
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .HasMaxLength(50);

            this.Property(t => t.Birthday)
                .HasMaxLength(10);

            this.Property(t => t.Telephone)
                .HasMaxLength(50);

            this.Property(t => t.TechnicalTitle)
                .HasMaxLength(50);

            this.Property(t => t.SeniorManager)
                .HasMaxLength(50);

            this.Property(t => t.CostCenter)
                .HasMaxLength(50);

            this.Property(t => t.UserImage)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Base_UserInfo");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.DeptID).HasColumnName("DeptID");
            this.Property(t => t.ProfitCenter).HasColumnName("ProfitCenter");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.WorkNo).HasColumnName("WorkNo");
            this.Property(t => t.MobilePhone).HasColumnName("MobilePhone");
            this.Property(t => t.LockScreenPassword).HasColumnName("LockScreenPassword");
            this.Property(t => t.ChineseName).HasColumnName("ChineseName");
            this.Property(t => t.EnglishName).HasColumnName("EnglishName");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.Telephone).HasColumnName("Telephone");
            this.Property(t => t.RegistrationTime).HasColumnName("RegistrationTime");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.TechnicalTitle).HasColumnName("TechnicalTitle");
            this.Property(t => t.SeniorManager).HasColumnName("SeniorManager");
            this.Property(t => t.CostCenter).HasColumnName("CostCenter");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.UserImage).HasColumnName("UserImage");
        }
    }
}

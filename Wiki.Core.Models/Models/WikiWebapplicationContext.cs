using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Wiki.Core.Models.Models.Mapping;

namespace Wiki.Core.Models.Models
{
    public partial class WikiWebapplicationContext : DbContext
    {
        static WikiWebapplicationContext()
        {
            Database.SetInitializer<WikiWebapplicationContext>(null);
        }

        public WikiWebapplicationContext()
            : base("Name=WikiWebapplicationContext")
        {
        }

        public DbSet<Base_Access_Group> Base_Access_Group { get; set; }
        public DbSet<Base_Access_GroupModule> Base_Access_GroupModule { get; set; }
        public DbSet<Base_Access_Module> Base_Access_Module { get; set; }
        public DbSet<Base_Access_Role> Base_Access_Role { get; set; }
        public DbSet<Base_Access_RoleGroup> Base_Access_RoleGroup { get; set; }
        public DbSet<Base_Access_RoleGroupModule> Base_Access_RoleGroupModule { get; set; }
        public DbSet<Base_Access_UserRole> Base_Access_UserRole { get; set; }
        public DbSet<Base_Agents> Base_Agents { get; set; }
        public DbSet<Base_Agents_Menu> Base_Agents_Menu { get; set; }
        public DbSet<Base_Code> Base_Code { get; set; }
        public DbSet<Base_CodeInfo> Base_CodeInfo { get; set; }
        public DbSet<Base_CodeType> Base_CodeType { get; set; }
        public DbSet<Base_CodeTypeInfo> Base_CodeTypeInfo { get; set; }
        public DbSet<Base_Company> Base_Company { get; set; }
        public DbSet<Base_CompanyInfo> Base_CompanyInfo { get; set; }
        public DbSet<Base_Dept> Base_Dept { get; set; }
        public DbSet<Base_EmailEnum> Base_EmailEnum { get; set; }
        public DbSet<Base_EmailModel> Base_EmailModel { get; set; }
        public DbSet<Base_EmailOperationLog> Base_EmailOperationLog { get; set; }
        public DbSet<Base_EmailTemplateInfo> Base_EmailTemplateInfo { get; set; }
        public DbSet<Base_EmailTemplateTypeInfo> Base_EmailTemplateTypeInfo { get; set; }
        public DbSet<Base_ExceptionLog> Base_ExceptionLog { get; set; }
        public DbSet<Base_FileDept> Base_FileDept { get; set; }
        public DbSet<Base_FileInfo> Base_FileInfo { get; set; }
        public DbSet<Base_FileOperationLog> Base_FileOperationLog { get; set; }
        public DbSet<Base_FileRight> Base_FileRight { get; set; }
        public DbSet<Base_Flowoperationrecords> Base_Flowoperationrecords { get; set; }
        public DbSet<Base_FlowUserPool> Base_FlowUserPool { get; set; }
        public DbSet<Base_FormLog> Base_FormLog { get; set; }
        public DbSet<Base_GroupFileRight> Base_GroupFileRight { get; set; }
        public DbSet<Base_Groups_Role> Base_Groups_Role { get; set; }
        public DbSet<Base_Groups_User> Base_Groups_User { get; set; }
        public DbSet<Base_MainFlow> Base_MainFlow { get; set; }
        public DbSet<Base_MainFlowTemplate> Base_MainFlowTemplate { get; set; }
        public DbSet<Base_MenuInfo> Base_MenuInfo { get; set; }
        public DbSet<Base_Notice> Base_Notice { get; set; }
        public DbSet<Base_OperationInfo> Base_OperationInfo { get; set; }
        public DbSet<Base_OperationLog> Base_OperationLog { get; set; }
        public DbSet<Base_Permissions_Menu> Base_Permissions_Menu { get; set; }
        public DbSet<Base_PermissionsInfo> Base_PermissionsInfo { get; set; }
        public DbSet<Base_RightOperation> Base_RightOperation { get; set; }
        public DbSet<Base_Role_Permissions> Base_Role_Permissions { get; set; }
        public DbSet<Base_RoleFileRight> Base_RoleFileRight { get; set; }
        public DbSet<Base_RoleInfo> Base_RoleInfo { get; set; }
        public DbSet<Base_SnapshotInfo> Base_SnapshotInfo { get; set; }
        public DbSet<Base_SystemLog> Base_SystemLog { get; set; }
        public DbSet<Base_User_Role> Base_User_Role { get; set; }
        public DbSet<Base_UserCompanyRight> Base_UserCompanyRight { get; set; }
        public DbSet<Base_UserGroupsInfo> Base_UserGroupsInfo { get; set; }
        public DbSet<Base_UserInfo> Base_UserInfo { get; set; }
        public DbSet<Base_UserManual> Base_UserManual { get; set; }
        public DbSet<Base_UserSystemSetting> Base_UserSystemSetting { get; set; }
        public DbSet<Base_WorkflowFile> Base_WorkflowFile { get; set; }
        public DbSet<NLog> NLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Base_Access_GroupMap());
            modelBuilder.Configurations.Add(new Base_Access_GroupModuleMap());
            modelBuilder.Configurations.Add(new Base_Access_ModuleMap());
            modelBuilder.Configurations.Add(new Base_Access_RoleMap());
            modelBuilder.Configurations.Add(new Base_Access_RoleGroupMap());
            modelBuilder.Configurations.Add(new Base_Access_RoleGroupModuleMap());
            modelBuilder.Configurations.Add(new Base_Access_UserRoleMap());
            modelBuilder.Configurations.Add(new Base_AgentsMap());
            modelBuilder.Configurations.Add(new Base_Agents_MenuMap());
            modelBuilder.Configurations.Add(new Base_CodeMap());
            modelBuilder.Configurations.Add(new Base_CodeInfoMap());
            modelBuilder.Configurations.Add(new Base_CodeTypeMap());
            modelBuilder.Configurations.Add(new Base_CodeTypeInfoMap());
            modelBuilder.Configurations.Add(new Base_CompanyMap());
            modelBuilder.Configurations.Add(new Base_CompanyInfoMap());
            modelBuilder.Configurations.Add(new Base_DeptMap());
            modelBuilder.Configurations.Add(new Base_EmailEnumMap());
            modelBuilder.Configurations.Add(new Base_EmailModelMap());
            modelBuilder.Configurations.Add(new Base_EmailOperationLogMap());
            modelBuilder.Configurations.Add(new Base_EmailTemplateInfoMap());
            modelBuilder.Configurations.Add(new Base_EmailTemplateTypeInfoMap());
            modelBuilder.Configurations.Add(new Base_ExceptionLogMap());
            modelBuilder.Configurations.Add(new Base_FileDeptMap());
            modelBuilder.Configurations.Add(new Base_FileInfoMap());
            modelBuilder.Configurations.Add(new Base_FileOperationLogMap());
            modelBuilder.Configurations.Add(new Base_FileRightMap());
            modelBuilder.Configurations.Add(new Base_FlowoperationrecordsMap());
            modelBuilder.Configurations.Add(new Base_FlowUserPoolMap());
            modelBuilder.Configurations.Add(new Base_FormLogMap());
            modelBuilder.Configurations.Add(new Base_GroupFileRightMap());
            modelBuilder.Configurations.Add(new Base_Groups_RoleMap());
            modelBuilder.Configurations.Add(new Base_Groups_UserMap());
            modelBuilder.Configurations.Add(new Base_MainFlowMap());
            modelBuilder.Configurations.Add(new Base_MainFlowTemplateMap());
            modelBuilder.Configurations.Add(new Base_MenuInfoMap());
            modelBuilder.Configurations.Add(new Base_NoticeMap());
            modelBuilder.Configurations.Add(new Base_OperationInfoMap());
            modelBuilder.Configurations.Add(new Base_OperationLogMap());
            modelBuilder.Configurations.Add(new Base_Permissions_MenuMap());
            modelBuilder.Configurations.Add(new Base_PermissionsInfoMap());
            modelBuilder.Configurations.Add(new Base_RightOperationMap());
            modelBuilder.Configurations.Add(new Base_Role_PermissionsMap());
            modelBuilder.Configurations.Add(new Base_RoleFileRightMap());
            modelBuilder.Configurations.Add(new Base_RoleInfoMap());
            modelBuilder.Configurations.Add(new Base_SnapshotInfoMap());
            modelBuilder.Configurations.Add(new Base_SystemLogMap());
            modelBuilder.Configurations.Add(new Base_User_RoleMap());
            modelBuilder.Configurations.Add(new Base_UserCompanyRightMap());
            modelBuilder.Configurations.Add(new Base_UserGroupsInfoMap());
            modelBuilder.Configurations.Add(new Base_UserInfoMap());
            modelBuilder.Configurations.Add(new Base_UserManualMap());
            modelBuilder.Configurations.Add(new Base_UserSystemSettingMap());
            modelBuilder.Configurations.Add(new Base_WorkflowFileMap());
            modelBuilder.Configurations.Add(new NLogMap());
        }
    }
}

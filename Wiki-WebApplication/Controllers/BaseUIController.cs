//using EwayFramework.BaseController.Filter;
//using EwayFramework.Models.Models;
//using EwayFramework.Respoistories.Interfaces;
//using EwayFramework.Services.CommonServices.RoleServices.Implements;
//using EwayFramework.Services.CommonServices.RoleServices.Interfaces;
//using EwayFramework.Services.CommonServices.SystemSettingServices.Implements;
//using EwayFramework.Services.CommonServices.SystemSettingServices.Interfaces;
//using EwayFramework.Services.CommonServices.UserServices.Implements;
//using EwayFramework.Services.CommonServices.UserServices.Interfaces;
//using EwayFramework.Services.Components.Objects;
using EwayFramework.Utils.UriHelper.Static;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
//using EwayFramework.Services.CommonServices.FileUploadServices.Implements;
//using EwayFramework.Services.CommonServices.FileUploadServices.Interfaces;
using Wiki.Component.Data.Interface;
using Wiki.Core.Models.Models;

namespace EwayFramework.BasePresentation.BaseController
{
    //[AuthorizeFilter]
    //[ExceptionHandleError]
    public abstract class BaseUIController : Controller
    {
        #region 权限接口
        //private IUserServices _userService = null;
        //private IRoleServices _roleServices = null;
        //private IUserSettingService _userSettingServices = null;
        protected IUnitOfWork _contextWork = null;
        //private IWorkflowFileService _iworkFlowService = null;
        #endregion
        public BaseUIController(IUnitOfWork contextWork)
        {

            _contextWork = contextWork;
            //_userService = new UserServicesImpl(contextWork);
            //_roleServices = new RoleServices(contextWork);
            //_userSettingServices = new UserSettingServiceImpl(contextWork);
            //_iworkFlowService = new FileUploadService(contextWork);
            UriHelper.GetRootUri();
        }
        #region 当前用户配置

        //private Guid _userId
        //{
        //    get
        //    {
        //        if (User != null && User.Identity != null && User.Identity.IsAuthenticated && string.IsNullOrWhiteSpace(User.Identity.Name))
        //        {
        //            Session["ADEmail"] = User.Identity.Name;
        //        }
        //        if (Session["ADEmail"] != null && !string.IsNullOrWhiteSpace(Session["ADEmail"].ToString()))
        //        {
        //            Base_UserInfo userInfo = _userService.GetUserInfoByEmail(Session["ADEmail"].ToString());
        //            return userInfo.UserId;
        //        }
        //        if (!string.IsNullOrWhiteSpace(Action) && !string.IsNullOrWhiteSpace(Controller))
        //        {
        //            return new Guid();
        //        }
        //        else
        //        {
        //            throw new Exception("无法识别你的身份.");
        //        }

        //        //Guid Id = new Guid();
        //        //if (Session["ADEmail"] != null && !string.IsNullOrWhiteSpace(Session["ADEmail"].ToString()))
        //        //{
        //        //    Base_UserInfo userInfo = _userService.GetUserInfoByEmail(Session["ADEmail"].ToString());
        //        //    Id = userInfo.UserId;
        //        //}
        //        //return Id;
        //    }
        //}


        /// <summary>
        /// 获取当前的action
        /// </summary>
        public string Action
        {
            get
            {
                string action = null;
                if (RouteData != null && RouteData.Values["action"] != null)
                    action = RouteData.Values["action"].ToString();
                return action;
            }
        }
        /// <summary>
        /// 获取当前的controller
        /// </summary>
        public string Controller
        {
            get
            {
                string controller = null;
                if (RouteData != null && RouteData.Values["controller"] != null)
                    controller = RouteData.Values["controller"].ToString();
                return controller;
            }
        }


        public string WebSiteUri
        {
            get
            {
                return UriHelper.GetRootUri();
            }

        }


        /// <summary>
        /// 获取当前的用户
        /// </summary>
        //public Base_UserInfo UserInfo
        //{
        //    get { return _userService.GetModelByUserIDandCompanyID(_userId); }
        //    //get
        //    //{
        //    //    Base_UserInfo userInfo = null;
        //    //    if (Session["ADEmail"] != null && !string.IsNullOrWhiteSpace(Session["ADEmail"].ToString()))
        //    //    {
        //    //        userInfo = _userService.GetUserInfoByEmail(Session["ADEmail"].ToString());
        //    //    }
        //    //    return userInfo;
        //    //}
        //}



        /// <summary>
        /// 获取用户的系统设置
        /// </summary>
        /// <summary>
        /// 获取用户的系统设置
        /// </summary>
        //public Base_UserSystemSetting Setting
        //{
        //    get
        //    {
        //        Base_UserSystemSetting buss = null;
        //        var userSet = HttpContext.Request.Cookies.Get("UserSetting");
        //        if (userSet != null && userSet.Value != null)
        //        {
        //            buss = JsonConvert.DeserializeObject<Base_UserSystemSetting>(userSet.Value);
        //        }
        //        else
        //        {
        //            if (_userId.Equals(new Guid()))
        //            {

        //                buss = new Base_UserSystemSetting()
        //                {
        //                    DefaultCommpanyId = -1,
        //                    DefaultLang = "zh-CN",
        //                    ScreenTime = 10,
        //                    SystemSetId = new Guid(),
        //                    UserId = new Guid(),
        //                    RemeberAccount = UserInfo == null ? "" : UserInfo.Email,
        //                };

        //            }
        //            else
        //            {
        //                buss = _userSettingServices.GetSystemSettingByUserId(_userId);
        //                if (buss == null)
        //                {
        //                    buss = new Base_UserSystemSetting()
        //                    {
        //                        DefaultCommpanyId = -1,
        //                        DefaultLang = "zh-CN",
        //                        ScreenTime = 10,
        //                        SystemSetId = Guid.NewGuid(),
        //                        UserId = _userId,
        //                        RemeberAccount = UserInfo == null ? "" : UserInfo.Email,
        //                    };
        //                    _userSettingServices.AddSystemSetting(buss);
        //                    _userSettingServices.CommiteChanges();
        //                }
        //            }
        //        }
        //        return buss;
        //    }
        //}
        //private void SetUserSetting(Base_UserSystemSetting value)
        //{
        //    if (value != null)
        //    {

        //        Base_UserSystemSetting buss = null;

        //        buss = _userSettingServices.GetSystemSettingByUserId(value.UserId);
        //        if (buss != null)
        //        {
        //            if (value.ScreenTime != buss.ScreenTime ||
        //                value.RemeberAccount != buss.RemeberAccount ||
        //                value.UserId != buss.UserId ||
        //                value.DefaultLang != buss.DefaultLang ||
        //                value.DefaultCommpanyId != buss.DefaultCommpanyId)
        //            {
        //                _userSettingServices.Remove(d => d.SystemSetId == buss.SystemSetId);
        //            }
        //            else
        //            {
        //                return;
        //            }
        //        }
        //        buss = value;
        //        _userSettingServices.AddSystemSetting(buss);
        //        _userSettingServices.CommiteChanges();
        //    }
        //}


        public void RegisterToContext(Base_UserInfo user, Base_UserSystemSetting setting)
        {
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, user.Email,
            DateTime.Now, DateTime.Now.AddDays(7), true, user.Email);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
            HttpContext.Response.Cookies.Add(cookie);
            HttpContext.Session["ADEmail"] = user.Email;
            //SetUserSetting(setting);

            //FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, user.Email,
            //DateTime.Now, DateTime.Now.AddDays(7), true, user.Email);
            //HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
            //cookie.Expires = DateTime.Now.AddDays(7);
            //HttpContext.Response.Cookies.Add(cookie);
            //HttpContext.Session["ADEmail"] = user.Email;
            //SetUserSetting(setting);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        #endregion

        /// <summary>
        /// 附件绑定
        /// </summary>
        /// <param name="a">附件ID</param>
        /// <returns>返回obeject</returns>
        //public object AttachmentBinding(string a)
        //{
        //    object query = null;
        //    if (!string.IsNullOrWhiteSpace(a))
        //    {
        //        string[] filesid = a.Split(',');
        //        Dictionary<string, Guid> dic = new Dictionary<string, Guid>();
        //        for (int b = 0; b < filesid.Length; b++)
        //        {
        //            dic.Add(Guid.NewGuid().ToString(), new Guid(filesid[b]));
        //        }
        //        IEnumerable<Base_FileInfo> Types = _iworkFlowService.GetFilesByFileId(dic);

        //        if (Types != null)
        //        {
        //            query = (from c in Types
        //                     select new UploadValue
        //                     {
        //                         FileDownPath = c.DownLoadPath,
        //                         FileId = c.FileID,
        //                         FileName = c.OriginalName,
        //                         Uploader = _userService.GetUserInfoByUserId(Guid.Parse(c.UpLoadUserID.ToString())).Email,
        //                         UploadDate = c.UploadDate.ToString(),
        //                         FileType = c.FileType,
        //                         //Source = c.,
        //                     }).ToList();
        //        }
        //    }
        //    return query;
        //}
    }
}

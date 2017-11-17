using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using EwayFramework.PresentationUI.App_Start;

namespace Wiki_WebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            //var baseControl = Assembly.Load("Wiki-WebApplication");
            //Autofac IOC容器注册
            AutoFacConfig.RegisterService();
            Application.Lock();
            Application["OnLine"] = 0;
            Application.UnLock();
        }
        protected void Application_End(object sender, EventArgs e)
        {
            //不是每次请求都调用
            //在应用程序关闭时运行的代码，在最后一个HttpApplication销毁之后执行
            //比如IIS重启，文件更新，进程回收导致应用程序转换到另一个应用程序域
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //不是每次请求都调用
            //会话开始时执行
            ////
            //在线人员添加
            ////
            Application.Lock();
            Application["OnLine"] = (int)Application["OnLine"] + 1;
            Application.UnLock();
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //不是每次请求都调用
            //会话结束或过期时执行
            //不管在代码中显式的清空Session或者Session超时自动过期，此方法都将被调用
            Application.Lock();
            Application["OnLine"] = (int)Application["OnLine"] - 1;
            Application.UnLock();
        }

        protected void Application_Init(object sender, EventArgs e)
        {
            //不是每次请求都调用
            //在每一个HttpApplication实例初始化的时候执行
        }

        protected void Application_Disposed(object sender, EventArgs e)
        {
            //不是每次请求都调用
            //在应用程序被关闭一段时间之后，在.net垃圾回收器准备回收它占用的内存的时候被调用。
            //在每一个HttpApplication实例被销毁之前执行
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //不是每次请求都调用
            //所有没有处理的错误都会导致这个方法的执行
        }


        /*********************************************************************/
        //每次请求都会按照顺序执行以下事件
        /*********************************************************************/

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //每次请求时第一个出发的事件，这个方法第一个执行
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            //在执行验证前发生，这是创建验证逻辑的起点
        }

        protected void Application_AuthorizeRequest(object sender, EventArgs e)
        {
            //当安全模块已经验证了当前用户的授权时执行
        }

        protected void Application_ResolveRequestCache(object sender, EventArgs e)
        {
            //当ASP.NET完成授权事件以使缓存模块从缓存中为请求提供服务时发生，从而跳过处理程序（页面或者是WebService）的执行。
            //这样做可以改善网站的性能，这个事件还可以用来判断正文是不是从Cache中得到的。
        }

        //------------------------------------------------------------------------
        //在这个时候，请求将被转交给合适程序。例如：web窗体将被编译并完成实例化
        //------------------------------------------------------------------------

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            //读取了Session所需的特定信息并且在把这些信息填充到Session之前执行
        }

        protected void Application_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            //在合适的处理程序执行请求前调用
            //这个时候，Session就可以用了
        }

        //-------------------------------------------------
        //在这个时候，页面代码将会被执行，页面呈现为HTML
        //-------------------------------------------------

        protected void Application_PostRequestHandlerExecute(object sender, EventArgs e)
        {
            //当处理程序完成对请求的处理后被调用。
        }

        protected void Application_ReleaseRequestState(object sender, EventArgs e)
        {
            //释放请求状态
        }

        protected void Application_UpdateRequestCache(object sender, EventArgs e)
        {
            //为了后续的请求，更新响应缓存时被调用
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            //EndRequest是在响应Request时最后一个触发的事件
            //但在对象被释放或者从新建立以前，适合在这个时候清理代码
        }

        protected void Application_PreSendRequestHeaders(object sender, EventArgs e)
        {
            //向客户端发送Http标头之前被调用
        }

        protected void Application_PreSendRequestContent(object sender, EventArgs e)
        {
            //向客户端发送Http正文之前被调用
        }
    }
}

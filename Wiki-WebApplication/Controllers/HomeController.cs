using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using EwayFramework.BasePresentation.BaseController;
using Wiki.Component.Data.Interface;
using Wiki.Component.Tools.Logging;
using Wiki.Core.Models.Models;
using Wiki.Core.Services.Implement;
using Wiki.Core.Services.Interface;

namespace Wiki_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMenuServices _menubll;

        public HomeController(IUnitOfWork iunitofwork)
        {
            _menubll =new MenuServicesImpl(iunitofwork);
        }

        public ActionResult Index()
        {
            Base_MenuInfo menu = new Base_MenuInfo
            {
                MenuId = Guid.NewGuid(),
                ParentId = Guid.NewGuid(),
                Name = "主页",
                Action = "",
                Controller = "",
                RightIConClass = "",
                LeftIConClass = "",
                OrderID = 0,
                IsValid = true,
                Remark = "",
                LangKey = ""
            };
            _menubll.SaveMenuInfo(menu);
            return View();
        }

        public ActionResult About()
        {
            try
            {
                ViewBag.Message = "Your application description page.";
                NLogHandler.Instance.Warn(null);
                NLogHandler.Instance.Fatal(null);
                string va = null;
                var strings = va.Split(';');
            }
            catch (Exception ex)
            {
                NLogHandler.Instance.Log(LogLevel.Error, ex);
                //throw;
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
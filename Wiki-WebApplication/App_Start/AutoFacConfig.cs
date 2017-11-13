using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using Wiki.Component.Data;
using Wiki.Component.Data.Implement;
using Wiki.Component.Data.Interface;
using Wiki.Core.Models.Models;

namespace EwayFramework.PresentationUI.App_Start
{
    using Autofac;
    using Autofac.Integration.Mvc;
    using System.Reflection;
    using System.Web.Mvc;
    public class AutoFacConfig
    {
        /// <summary>
        /// 注册服务
        /// </summary>
        public static void RegisterService()
        {

            var builder = new ContainerBuilder();
            var loadAssemblys = BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToList();
            foreach (var assembly in loadAssemblys)
            {
                builder.RegisterControllers(assembly);
            }
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterGeneric(typeof(EFRepositoryBase<,>)).As(typeof(IRepository<,>));
            builder.RegisterType<EFUnitOfWorkContext>().As<IUnitOfWork>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //ContainerBuilder builder = new ContainerBuilder();
            //Type baseType = typeof(IDependency);
            ////var assemblys = AppDomain.CurrentDomain.GetAssemblies().ToList();
            //var assemblys = BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToList();
            ////var allservices = assemblys.SelectMany(s => s.GetTypes())
            ////    .Where(p => baseType.IsAssignableFrom(p) && p != baseType);
            ////builder.RegisterGeneric(typeof(EFRepositoryBase<,>)).As(typeof(IRepository<,>));
            //builder.RegisterControllers(assemblys.ToArray());
            //// 获取所有相关类库的程序集
            //builder.RegisterAssemblyTypes(assemblys.ToArray())
            //    .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
            //    .AsImplementedInterfaces().InstancePerLifetimeScope();//!type.IsAbstract//InstancePerLifetimeScope 保证对象生命周期基于请求
            //IContainer container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
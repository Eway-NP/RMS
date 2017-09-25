/********************************************************************************
** 源文件头信息：
** <copyright file="EFUnitOfWorkContext.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Data.Implement
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/25 9:59:53
** </copyright>
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Wiki.Component.Tools.Extensions;
using Wiki.Core.Models.Models;

namespace Wiki.Component.Data.Implement
{
    public class EFUnitOfWorkContext : UnitOfWorkContextBase
    {
        /// <inheritdoc />
        /// <summary>
        ///     获取 当前使用的数据访问上下文对象
        /// </summary>
        protected override DbContext Context
        {
            get
            {
                return EFDbContext;
            }
        }

        private DbContext EFDbContext
        {
            get
            {
                DbContext dbContext = CallContext.GetData("DbContext") as DbContext;
                if (dbContext == null)  //线程在数据槽里面没有此上下文
                {
                    dbContext = new WikiWebapplicationContext(); //如果不存在上下文的话，创建一个EF上下文
                    //我们在创建一个，放到数据槽中去
                    CallContext.SetData("DbContext", dbContext);
                }
                return dbContext;
            }
        }
    }
}

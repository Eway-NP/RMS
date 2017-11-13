/********************************************************************************
** 源文件头信息：
** <copyright file="TransactionalBehavior.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Data
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/23 23:26:23
** </copyright>
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki.Component.Data
{
    /// <summary>
    /// 在执行数据库命令或查询期间控制事务创建行为。
    /// </summary>
    public enum TransactionalBehavior
    {
        /// <summary>
        /// 如果存在现有事务，则使用它，否则在没有事务的情况下执行命令或查询。
        /// </summary>
        DoNotEnsureTransaction,

        /// <summary>
        /// 如果不存在任何事务，则使用新事务进行操作。
        /// </summary>
        EnsureTransaction
    }
}

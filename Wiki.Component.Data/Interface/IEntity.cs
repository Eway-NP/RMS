/********************************************************************************
** 源文件头信息：
** <copyright file="IEntity.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Data.Interface
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/23 23:30:59
** </copyright>
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki.Component.Data.Interface
{
    /// <summary>
    /// 数据模型接口
    /// </summary>
    public interface IEntity<out TKey> where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// 获取 实体唯一标识，主键
        /// </summary>
        TKey Id { get; }
    }
}

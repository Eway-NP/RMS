/********************************************************************************
** 源文件头信息：
** <copyright file="IUnitOfWorkContext.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Data.Interface
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/25 9:43:47
** </copyright>
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Wiki.Component.Tools;

namespace Wiki.Component.Data.Interface
{
    /// <inheritdoc cref="IUnitOfWork" />
    /// <summary>
    ///     数据单元操作接口
    /// </summary>
    public interface IUnitOfWorkContext : IUnitOfWork, IDisposable
    {
        /// <summary>
        ///   注册一个新的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"> 要注册的类型 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="entity"> 要注册的对象 </param>
        void RegisterNew<TEntity, TKey>(TEntity entity) where TEntity : EntityBase<TKey>;

        /// <summary>
        ///   批量注册多个新的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"> 要注册的类型 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="entities"> 要注册的对象集合 </param>
        void RegisterNew<TEntity, TKey>(IEnumerable<TEntity> entities) where TEntity : EntityBase<TKey>;

        /// <summary>
        ///   注册一个更改的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"> 要注册的类型 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="entity"> 要注册的对象 </param>
        void RegisterModified<TEntity, TKey>(TEntity entity) where TEntity : EntityBase<TKey>;

        /// <summary>
        /// 使用指定的属性表达式指定注册更改的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity">要注册的类型</typeparam>
        /// <typeparam name="TKey">主键类型</typeparam>
        /// <param name="propertyExpression">属性表达式，包含要更新的实体属性</param>
        /// <param name="entity">附带新值的实体信息，必须包含主键</param>
        void RegisterModified<TEntity, TKey>(Expression<Func<TEntity, object>> propertyExpression, TEntity entity) where TEntity : EntityBase<TKey>;

        /// <summary>
        ///   注册一个删除的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"> 要注册的类型 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="entity"> 要注册的对象 </param>
        void RegisterDeleted<TEntity, TKey>(TEntity entity) where TEntity : EntityBase<TKey>;

        /// <summary>
        ///   批量注册多个删除的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"> 要注册的类型 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="entities"> 要注册的对象集合 </param>
        void RegisterDeleted<TEntity, TKey>(IEnumerable<TEntity> entities) where TEntity : EntityBase<TKey>;
    }
}

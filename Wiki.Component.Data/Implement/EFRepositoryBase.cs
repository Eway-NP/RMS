/********************************************************************************
** 源文件头信息：
** <copyright file="EFRepositoryBase.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Data.Implement
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/18 9:23:52
** </copyright>
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Wiki.Component.Data.Interface;
using Wiki.Component.Tools;
using Wiki.Component.Tools.Exception;
using Wiki.Component.Tools.Helper;

namespace Wiki.Component.Data.Implement
{
    /// <summary>
    ///     EntityFramework仓储操作基类
    /// </summary>
    /// <typeparam name="TEntity">动态实体类型</typeparam>
    /// <typeparam name="TKey">实体主键类型</typeparam>
    public abstract class EFRepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : EntityBase<TKey>
    {
        #region 属性

        /// <summary>
        ///     获取 仓储上下文的实例
        /// </summary>
        public IUnitOfWork UnitOfWork { get; set; }

        public EFRepositoryBase(IUnitOfWork iunitofwork)
        {
            UnitOfWork = iunitofwork;
        }

        /// <summary>
        ///     获取 EntityFramework的数据仓储上下文
        /// </summary>
        protected UnitOfWorkContextBase EFContext
        {
            get
            {
                var @base = UnitOfWork as UnitOfWorkContextBase;
                if (@base != null)
                {
                    return @base;
                }
                throw new DataAccessException(string.Format("数据仓储上下文对象类型不正确，应为UnitOfWorkContextBase，实际为 {0}", UnitOfWork.GetType().Name));
            }
        }

        /// <inheritdoc />
        /// <summary>
        ///     获取 当前实体的查询数据集
        /// </summary>
        public virtual IQueryable<TEntity> Entities
        {
            get { return EFContext.Set<TEntity, TKey>(); }
        }

        #endregion

        #region 公共方法
        /// <inheritdoc />
        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式</param>
        /// <param name="id">编辑的实体标识</param>
        /// <returns>是否存在</returns>
        public bool CheckExists(Expression<Func<TEntity, bool>> predicate, TKey id = default(TKey))
        {
            PublicHelper.CheckArgument(predicate, "predicate");
            TKey defaultId = default(TKey);
            var entity = Entities.Where(predicate).Select(m => new { m.Id }).FirstOrDefault();
            bool exists = (!typeof(TKey).IsValueType && id.Equals(null)) || id.Equals(defaultId)
                ? entity != null
                : entity != null && !entity.Id.Equals(id);
            return exists;
        }
        /// <inheritdoc />
        /// <summary>
        ///     插入实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public virtual int Insert(TEntity entity, bool isSave = true)
        {
            PublicHelper.CheckArgument(entity, "entity");
            EFContext.RegisterNew<TEntity, TKey>(entity);
            return isSave ? EFContext.Commit() : 0;
        }

        /// <inheritdoc />
        /// <summary>
        ///     批量插入实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public virtual int Insert(IEnumerable<TEntity> entities, bool isSave = true)
        {
            PublicHelper.CheckArgument(entities, "entities");
            //EFContext.RegisterNew<TEntity, TKey>(entities);
            //ef 6.0新增方法
            EFContext.Set<TEntity, TKey>().AddRange(entities);
            return isSave ? EFContext.Commit() : 0;
        }

        /// <inheritdoc />
        /// <summary>
        ///     删除指定编号的记录
        /// </summary>
        /// <param name="id"> 实体记录编号 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public virtual int Delete(TKey id, bool isSave = true)
        {
            PublicHelper.CheckArgument(id, "id");
            TEntity entity = EFContext.Set<TEntity, TKey>().Find(id);
            return entity != null ? Delete(entity, isSave) : 0;
        }

        /// <inheritdoc />
        /// <summary>
        ///     删除实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public virtual int Delete(TEntity entity, bool isSave = true)
        {
            PublicHelper.CheckArgument(entity, "entity");
            EFContext.RegisterDeleted<TEntity, TKey>(entity);
            return isSave ? EFContext.Commit() : 0;
        }

        /// <inheritdoc />
        /// <summary>
        ///     删除实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public virtual int Delete(IEnumerable<TEntity> entities, bool isSave = true)
        {
            PublicHelper.CheckArgument(entities, "entities");
            //EFContext.RegisterDeleted<TEntity, TKey>(entities);
            //ef 6.0新增方法
            EFContext.Set<TEntity, TKey>().RemoveRange(entities);
            return isSave ? EFContext.Commit() : 0;
        }

        /// <inheritdoc />
        /// <summary>
        ///     删除所有符合特定表达式的数据
        /// </summary>
        /// <param name="predicate"> 查询条件谓语表达式 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public virtual int Delete(Expression<Func<TEntity, bool>> predicate, bool isSave = true)
        {
            PublicHelper.CheckArgument(predicate, "predicate");
            List<TEntity> entities = EFContext.Set<TEntity, TKey>().Where(predicate).ToList();
            return entities.Count > 0 ? Delete(entities, isSave) : 0;
        }

        /// <inheritdoc />
        /// <summary>
        ///     更新实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public virtual int Update(TEntity entity, bool isSave = true)
        {
            PublicHelper.CheckArgument(entity, "entity");
            EFContext.RegisterModified<TEntity, TKey>(entity);
            return isSave ? EFContext.Commit() : 0;
        }

        /// <inheritdoc />
        /// <summary>
        /// 使用附带新值的实体信息更新指定实体属性的值
        /// </summary>
        /// <param name="propertyExpression">属性表达式</param>
        /// <param name="isSave">是否执行保存</param>
        /// <param name="entity">附带新值的实体信息，必须包含主键</param>
        /// <returns>操作影响的行数</returns>
        public int Update(Expression<Func<TEntity, object>> propertyExpression, TEntity entity, bool isSave = true)
        {
            throw new NotSupportedException("上下文公用，不支持按需更新功能。");
            PublicHelper.CheckArgument(propertyExpression, "propertyExpression");
            PublicHelper.CheckArgument(entity, "entity");
            EFContext.RegisterModified<TEntity, TKey>(propertyExpression, entity);
            if (isSave)
            {
                var dbSet = EFContext.Set<TEntity, TKey>();
                dbSet.Local.Clear();
                var entry = EFContext.DbContext.Entry(entity);
                return EFContext.Commit(false);
            }
            return 0;
        }

        /// <inheritdoc />
        /// <summary>
        ///     查找指定主键的实体记录
        /// </summary>
        /// <param name="key"> 指定主键 </param>
        /// <returns> 符合编号的记录，不存在返回null </returns>
        public virtual TEntity GetByKey(TKey key)
        {
            PublicHelper.CheckArgument(key, "key");
            return EFContext.Set<TEntity, TKey>().Find(key);
        }
        /// <inheritdoc />
        /// <summary>
        /// 创建一个原始 SQL 查询，该查询将返回此集中的实体。 
        /// 默认情况下，上下文会跟踪返回的实体；可通过对返回的 DbRawSqlQuery 调用 AsNoTracking 来更改此设置。 请注意返回实体的类型始终是此集的类型，而不会是派生的类型。 如果查询的一个或多个表可能包含其他实体类型的数据，则必须编写适当的 SQL 查询以确保只返回适当类型的实体。 与接受 SQL 的任何 API 一样，对任何用户输入进行参数化以便避免 SQL 注入攻击是十分重要的。 您可以在 SQL 查询字符串中包含参数占位符，然后将参数值作为附加参数提供。 您提供的任何参数值都将自动转换为 DbParameter。 context.Set(typeof(Blog)).SqlQuery("SELECT * FROM dbo.Posts WHERE Author = @p0", userSuppliedAuthor); 或者，您还可以构造一个 DbParameter 并将它提供给 SqlQuery。 这允许您在 SQL 查询字符串中使用命名参数。 context.Set(typeof(Blog)).SqlQuery("SELECT * FROM dbo.Posts WHERE Author = @author", new SqlParameter("@author", userSuppliedAuthor));
        /// </summary>
        /// <param name="trackEnabled">是否跟踪返回实体</param>
        /// <param name="sql">SQL 查询字符串。</param>
        /// <param name="parameters">要应用于 SQL 查询字符串的参数。 如果使用输出参数，则它们的值在完全读取结果之前不可用。 这是由于 DbDataReader 的基础行为而导致的，有关详细信息，请参见 http://go.microsoft.com/fwlink/?LinkID=398589。</param>
        /// <returns></returns>
        public IEnumerable<TEntity> SqlQuery(string sql, bool trackEnabled = true, params object[] parameters)
        {
            return trackEnabled
                ? EFContext.Set<TEntity, TKey>().SqlQuery(sql, parameters)
                : EFContext.Set<TEntity, TKey>().SqlQuery(sql, parameters).AsNoTracking();
        }
        public void SqlQuery(Type elementType  ,string sql, params object[] parameters)
        {
             EFContext.DbContext.Database.SqlQuery(elementType,sql,parameters);
        }
        public int ExecuteSqlCommand(string sql)
        {
            return EFContext.DbContext.Database.ExecuteSqlCommand(sql);
        }

        #endregion
    }
}

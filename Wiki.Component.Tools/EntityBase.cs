/********************************************************************************
** 源文件头信息：
** <copyright file="EntityBase.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.239
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Data
** 最后修改人：Wiki.tomato
** 最后修改时间：2017/9/14 9:44:37
** </copyright>
*********************************************************************************/

using System;
using System.ComponentModel.DataAnnotations;

namespace Wiki.Component.Tools
{
    /// <summary>
    ///     可持久到数据库的领域模型的基类。
    /// </summary>
    [Serializable]
    public abstract class EntityBase<TKey>
    {
        #region 构造函数

        /// <summary>
        ///     数据实体基类
        /// </summary>
        protected EntityBase()
        {
            IsDeleted = false;
            AddDate = DateTime.Now;
        }

        #endregion

        #region 属性

        [Key]
        public TKey Id { get; set; }

        /// <summary>
        ///     获取或设置 获取或设置是否禁用，逻辑上的删除，非物理删除
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        ///     获取或设置 添加时间
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime AddDate { get; set; }

        #endregion
    }
}

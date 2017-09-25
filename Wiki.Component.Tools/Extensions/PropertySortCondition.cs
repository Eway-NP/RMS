/********************************************************************************
** 源文件头信息：
** <copyright file="PropertySortCondition.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.239
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Tools.Extensions
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/14 9:42:22
** </copyright>
*********************************************************************************/

using System.ComponentModel;

namespace Wiki.Component.Tools.Extensions
{
    /// <summary>
    ///     属性排序条件信息类
    /// </summary>
    public class PropertySortCondition
    {
        /// <inheritdoc />
        /// <summary>
        ///     构造一个指定属性名称的升序排序的排序条件
        /// </summary>
        /// <param name="propertyName">排序属性名称</param>
        public PropertySortCondition(string propertyName)
            : this(propertyName, ListSortDirection.Ascending) { }

        /// <summary>
        ///     构造一个排序属性名称和排序方式的排序条件
        /// </summary>
        /// <param name="propertyName">排序属性名称</param>
        /// <param name="listSortDirection">排序方式</param>
        public PropertySortCondition(string propertyName, ListSortDirection listSortDirection)
        {
            PropertyName = propertyName;
            ListSortDirection = listSortDirection;
        }

        /// <summary>
        ///     获取或设置 排序属性名称
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        ///     获取或设置 排序方向
        /// </summary>
        public ListSortDirection ListSortDirection { get; set; }
    }
}

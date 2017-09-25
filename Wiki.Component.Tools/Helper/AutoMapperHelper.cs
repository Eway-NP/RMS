/********************************************************************************
** 源文件头信息：
** <copyright file="AutoMapperHelper.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Tools.Helper
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/18 17:27:28
** </copyright>
*********************************************************************************/

using System.Collections;
using System.Collections.Generic;
using System.Data;
using AutoMapper;

namespace Wiki.Component.Tools.Helper
{
    /// <summary>
    /// AutoMapper扩展帮助类
    /// </summary>
    public static class AutoMapperHelper
    {
        /// <summary>
        ///  类型映射
        /// </summary>
        public static T MapTo<T>(this object obj)
        {
            if (obj == null) return default(T);
            Mapper.Initialize(x => x.CreateMap(obj.GetType(), typeof(T)));
            return Mapper.Map<T>(obj);
        }
        /// <summary>
        /// 集合列表类型映射
        /// </summary>
        public static List<TDestination> MapToList<TDestination>(this IEnumerable source)
        {
            foreach (var first in source)
            {
                var type = first.GetType();
                Mapper.Initialize(x => x.CreateMap(type, typeof(TDestination)));
                break;
            }
            return Mapper.Map<List<TDestination>>(source);
        }
        /// <summary>
        /// 集合列表类型映射
        /// </summary>
        public static List<TDestination> MapToList<TSource, TDestination>(this IEnumerable<TSource> source)
        {
            //IEnumerable<T> 类型需要创建元素的映射
            Mapper.Initialize(m => m.CreateMap<TSource, TDestination>());
            return Mapper.Map<List<TDestination>>(source);
        }
        /// <summary>
        /// 类型映射
        /// </summary>
        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination, System.Action<IMapperConfigurationExpression> config = null)
            where TSource : class
            where TDestination : class
        {
            if (source == null) return destination;
            if (config != null)
                Mapper.Initialize(config);
            else
                Mapper.Initialize(k => k.CreateMap<TSource, TDestination>());
            return Mapper.Map(source, destination);
        }
        /// <summary>
        /// DataReader映射
        /// </summary>
        public static IEnumerable<T> DataReaderMapTo<T>(this IDataReader reader)
        {

            Mapper.Initialize(m => m.CreateMap<IDataReader, IEnumerable<T>>());
            return Mapper.Map<IDataReader, IEnumerable<T>>(reader);
        }
    }
}

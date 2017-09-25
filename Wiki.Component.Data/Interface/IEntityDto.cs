/********************************************************************************
** 源文件头信息：
** <copyright file="IEntityDto.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Data.Interface
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/23 23:32:55
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
    /// 定义输入DTO
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IInputDto<TKey>
    {
        /// <summary>
        /// 获取或设置 主键，唯一标识
        /// </summary>
        TKey Id { get; set; }
    }


    /// <summary>
    /// 定义输出DTO
    /// </summary>
    public interface IOutputDto
    { }
}

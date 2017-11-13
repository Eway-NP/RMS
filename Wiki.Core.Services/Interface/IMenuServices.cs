/********************************************************************************
** 源文件头信息：
** <copyright file="IMenuServices.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Core.Services
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/22 11:14:37
** </copyright>
*********************************************************************************/

using System;
using System.Collections.Generic;
using Wiki.Component.Data.Interface;
using Wiki.Core.Models.Models;

namespace Wiki.Core.Services.Interface
{
    public interface IMenuServices : IRepository<Base_MenuInfo,Guid>
    {
        #region 直接获取数据库的菜单模型
        /// <summary>
        /// 获取菜单（通过角色编号）
        /// </summary>
        /// <param name="roleId">角色编号</param>
        /// <returns>菜单集合</returns>
        IEnumerable<Base_MenuInfo> GetMenusByRoleId(Guid roleId, int companyId);
        /// <summary>
        /// 获取菜单（通过用户编号）
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>菜单集合</returns>
        IEnumerable<Base_MenuInfo> GetMenusByUserId(Guid userId, int companyId);
        /// <summary>
        /// 获取菜单（通过用户编号）
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>菜单集合</returns>
        IEnumerable<Base_MenuInfo> GetMenusByUserId(Guid userId);

        #endregion

        #region 获取菜单DTO

        /// <summary>
        /// 获取菜单DTO（通过角色编号，产别编号）
        /// </summary>
        /// <returns>菜单集合</returns>
        /// <summary>
        /// 获取菜单DTO（通过用户编号）
        /// </summary>
        /// <returns>菜单集合</returns>
        /// <summary>
        /// 获取所有的菜单
        /// </summary>
        /// <returns></returns>
        IEnumerable<Base_MenuInfo> GetMenuInfo();


        /// <summary>
        /// 获取所有的菜单
        /// </summary>
        /// <returns></returns>
        //IEnumerable<MenuDTO> GetAllMenusDTO();

        /// <summary>
        /// 添加菜单信息
        /// </summary>
        /// <param name="menu">菜单模型</param>
        /// <returns>成功/失败</returns>
        bool SaveMenuInfo(Base_MenuInfo menu);

        /// <summary>
        /// 修改菜单信息
        /// </summary>
        /// <param name="menu">调用FirstOfDefault查询到的model</param>
        /// <returns>成功/失败</returns>
        bool UpdateMenuInfo(Base_MenuInfo menu);

        /// <summary>
        /// 删除一个菜单
        /// </summary>
        /// <param name="menuid">菜单ID</param>
        /// <returns>成功/失败</returns>
        bool DeleteMenuInfo(Guid menuid);


        /// <summary>//20160227廖
        /// 通过CA获取模型
        /// </summary>
        /// <param name="ca">控制器、Action</param>
        /// <returns></returns>
        Base_MenuInfo GetMenuInfo_CA(string ca);

        /// <summary>//20160227廖
        /// 通过Pid获取模型
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        Base_MenuInfo GetMenuInfo_Pid(Guid pid);

        /// <summary>//20160227廖
        /// 通过Pid获取模型
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        Base_MenuInfo GetMenuInfo_C(string c);

        #endregion

    }
}

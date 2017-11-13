/********************************************************************************
** 源文件头信息：
** <copyright file="MenuServicesImpl.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Core.Services.Implement
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/22 12:23:10
** </copyright>
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiki.Component.Data.Implement;
using Wiki.Component.Data.Interface;
using Wiki.Core.Models.Models;
using Wiki.Core.Services.Interface;

namespace Wiki.Core.Services.Implement
{
    public class MenuServicesImpl : EFRepositoryBase<Base_MenuInfo, Guid>,IMenuServices
    {
        public MenuServicesImpl(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
          
        }

        public IEnumerable<Base_MenuInfo> GetMenusByRoleId(Guid roleId, int companyId)
        {

            throw new NotImplementedException();
        }

        public IEnumerable<Base_MenuInfo> GetMenusByUserId(Guid userId, int companyId)
        {

            throw new NotImplementedException();
        }

        public IEnumerable<Base_MenuInfo> GetMenusByUserId(Guid userId)
        {

            throw new NotImplementedException();
        }

        public IEnumerable<Base_MenuInfo> GetMenuInfo()
        {
            throw new NotImplementedException();
        }

        public bool SaveMenuInfo(Base_MenuInfo menu)
        {
            return base.Insert(menu) > 0;
            //var b = new WikiWebapplicationContext();
            //b.Base_MenuInfo.Add(menu);
            //return b.SaveChanges()>0;
            //throw new NotImplementedException();
        }

        public bool UpdateMenuInfo(Base_MenuInfo menu)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMenuInfo(Guid menuid)
        {
            throw new NotImplementedException();
        }

        public Base_MenuInfo GetMenuInfo_CA(string ca)
        {
            throw new NotImplementedException();
        }

        public Base_MenuInfo GetMenuInfo_Pid(Guid pid)
        {
            throw new NotImplementedException();
        }

        public Base_MenuInfo GetMenuInfo_C(string c)
        {
            throw new NotImplementedException();
        }
    }
}

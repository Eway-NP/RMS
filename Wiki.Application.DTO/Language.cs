/********************************************************************************
** 源文件头信息：
** <copyright file="Language.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Application.DTO
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/19 13:48:49
** </copyright>
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki.Application.DTO
{
    class Language
    {
        public string LangName { get; set; }
        public string LangKey { get; set; }
        public string Image { get; set; }
        public string LangAddress { get; set; }
        public string LangTag { get; set; }
    }
}

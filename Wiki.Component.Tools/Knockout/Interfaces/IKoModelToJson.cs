/********************************************************************************
** 源文件头信息：
** <copyright file="KoModelToJson.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Tools.Knockout
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/25 19:40:47
** </copyright>
*********************************************************************************/

using Newtonsoft.Json;

namespace Wiki.Component.Tools.Knockout.Interfaces
{
    interface IKoModelToJson
    {
        string ToKnockoutJSByMapping_Wiki<T>(T model, JsonSerializerSettings jsonsetting = null,
            string viewModelName = "viewModel", bool isValidate = false, string errorElementClass = "errorElementClass",
            string errorMessageClass = "errorMessageClass", int tier = 2, bool multilanguage = false);
    }
}

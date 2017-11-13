/********************************************************************************
** 源文件头信息：
** <copyright file="KoModeltoJsonHandle.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Component.Tools.Knockout.Implements
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/25 19:45:05
** </copyright>
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wiki.Component.Tools.Knockout.Interfaces;
using Wiki.Component.Tools.Language.Extended;

namespace Wiki.Component.Tools.Knockout.Implements
{
    class KoModeltoJsonHandle : IKoModelToJson
    {
        public string ToKnockoutJSByMapping_Wiki<T>(T model, JsonSerializerSettings jsonsetting = null, string viewModelName = "viewModel", bool isValidate = false, string errorElementClass = "errorElementClass", string errorMessageClass = "errorMessageClass", int tier = 2, bool multilanguage = false)
        {
            StringBuilder builder = new StringBuilder();
            if (jsonsetting == null)
            {
                jsonsetting = new JsonSerializerSettings();
                jsonsetting.NullValueHandling = NullValueHandling.Ignore;
                jsonsetting.DateFormatString = "yyyy-MM-dd";
            }
            if (model != null)
            {

                builder.Append(string.Format("var {0}= ko.mapping.fromJS({1});", viewModelName, JsonConvert.SerializeObject(model, jsonsetting)));
                if (isValidate)
                {
                    var type = model.GetType();
                    //insertMessages: " + isValidate.ToString().ToLower() + @",//不自动插入错误消息
                    builder.AppendLine(@"ko.validation.configure({//ko.validation相关配置
                insertMessages:false,
                errorElementClass: '" + errorElementClass + @"',/*元素的ＣＳＳ样式*/
                errorMessageClass: '" + errorMessageClass + @"',/*提示信息ＣＳＳ的样式*/
                });");

                    StringBuilder extendBilder = new StringBuilder();

                    foreach (var c in type.GetProperties())
                    {
                        if (tier == 1)
                        {
                            extendBilder.AppendFormat("{0}.{1}.extend(", viewModelName, c.Name).AppendLine("{");
                            Ko_Validation(extendBilder, c, multilanguage);
                            extendBilder.Remove(extendBilder.Length - 1, 1);
                            extendBilder.Append("});").AppendLine();
                        }
                        else
                        {
                            foreach (var c1 in c.PropertyType.GetProperties())
                            {
                                extendBilder.AppendFormat("{0}.{1}.{2}.extend(", viewModelName, c.Name, c1.Name).AppendLine("{");
                                Ko_Validation(extendBilder, c1, multilanguage);
                                extendBilder.Remove(extendBilder.Length - 1, 1);
                                extendBilder.Append("});").AppendLine();
                            }
                            extendBilder.AppendFormat(" {0}.{1}.errors = ko.validation.group({0}.{1});", viewModelName, c.Name).AppendLine();
                        }


                    }
                    builder.AppendLine(extendBilder.ToString());
                }
                builder.AppendLine().AppendFormat(" ko.applyBindings({0});", viewModelName);
            }
            return builder.ToString();
        }
        /// <summary>
        /// 20170731 wiki ko.vaildation校验参数
        /// </summary>
        /// <param name="extendBilder">string Bilder</param>
        /// <param name="pi">反射</param>
        /// <param name="multilanguage">是否需要多语言，默认为否</param>
        public void Ko_Validation(StringBuilder extendBilder, System.Reflection.PropertyInfo pi, bool multilanguage = false)
        {
            var customAttr = pi.GetCustomAttributes(false);
            if (!customAttr.Any())
            {
                return;
            }
            foreach (var attr in customAttr)
            {
                var requiredAttribute = attr as RequiredAttribute;
                if (requiredAttribute != null)
                {
                    //extendBilder.Append("  required:{ params: true, message:\"" +
                    //                    TranslatorHelper.Translator(
                    //                        ((RequiredAttribute) attr).ErrorMessage) + "\"}");
                    extendBilder.Append("  required:{ params: true, message:\"" +
                        (multilanguage ? TranslatorHelper.Translator(requiredAttribute.ErrorMessage) : requiredAttribute.ErrorMessage) + "\"}");
                }
                var lengthAttribute = attr as StringLengthAttribute;
                if (lengthAttribute != null)
                {
                    extendBilder.AppendLine("  maxLength:{params:" +
                                            lengthAttribute.MaximumLength +
                                            ", message:\"" +

                                            (multilanguage ? TranslatorHelper.Translator(lengthAttribute.ErrorMessage) : lengthAttribute.ErrorMessage) + "\"}");
                }
                var rangeAttribute = attr as RangeAttribute;
                if (rangeAttribute != null)
                {

                    extendBilder.AppendLine("   min: { params: " + rangeAttribute.Minimum +
                                            ", message: \"" +

                                                rangeAttribute.ErrorMessage + "\" }");
                    extendBilder.Append(",");
                    extendBilder.AppendLine("   max: { params: " + rangeAttribute.Maximum +
                                            ", message: \"" +

                                            (multilanguage ? TranslatorHelper.Translator(rangeAttribute.ErrorMessage) : rangeAttribute.ErrorMessage) + "\" }");
                }
                var maxLengthAttribute = attr as MaxLengthAttribute;
                if (maxLengthAttribute != null)
                {

                    extendBilder.AppendLine("  maxLength:{params:" +
                                            maxLengthAttribute.Length +
                                            ", message:\"" +

                                            (multilanguage ? TranslatorHelper.Translator(maxLengthAttribute.ErrorMessage) : maxLengthAttribute.ErrorMessage) + "\"}");
                }
                var minLengthAttribute = attr as MinLengthAttribute;
                if (minLengthAttribute != null)
                {

                    extendBilder.AppendLine("  minLength:{params:" +
                                            minLengthAttribute.Length +
                                            ", message:\"" +

                                            (multilanguage ? TranslatorHelper.Translator(minLengthAttribute.ErrorMessage) : minLengthAttribute.ErrorMessage) + "\"}");
                }

                var attribute = attr as RegularExpressionAttribute;
                if (attribute != null)
                {

                    extendBilder.AppendLine("  pattern:{params:'" +
                                            attribute.Pattern +
                                            "', message:\""
                                            + (multilanguage ? TranslatorHelper.Translator(attribute.ErrorMessage) : attribute.ErrorMessage) +
                                            "\"}");
                }
                var emailaddressAttribute = attr as EmailAddressAttribute
                     ;
                if (emailaddressAttribute != null)
                {

                    extendBilder.AppendLine("  email:{params:true, message:\"" +

                        (multilanguage ? TranslatorHelper.Translator(emailaddressAttribute.ErrorMessage) : emailaddressAttribute.ErrorMessage) + "\"}");
                }
                var phoneAttribute = attr as PhoneAttribute;
                if (phoneAttribute != null)
                {

                    extendBilder.AppendLine("  phoneUS:{params:true, message:\"" +

                        (multilanguage ? TranslatorHelper.Translator(phoneAttribute.ErrorMessage) : phoneAttribute.ErrorMessage) + "\"}");
                }
                extendBilder.Append(",");
            }
        }
    }
}

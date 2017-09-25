/********************************************************************************
** 源文件头信息：
** <copyright file="AccountLoginDTO.cs">
** Copyright(c)2016-2017 Wiki.All rights reserved.
** CLR版本：4.0.30319.18408
** 开发人员：Wiki.tomato
** 个人博客：http://www.cnblogs.com/Wtomato/
** 所属工程：Wiki.Application.DTO
** 最后修改人：Wiki.tomato
** 最后修改世间：2017/9/19 13:31:14
** </copyright>
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Wiki.Application.DTO
{
    class AccountLoginDto
    {

        [Required(ErrorMessage = "account_RequiredError")]
        [RegularExpression("^[a-z0-9]+([._\\-]*[a-z0-9])*@([a-z0-9]+[-a-z0-9]*[a-z0-9]+.){1,63}[a-z0-9]+$", ErrorMessage = "账号格式不正确.")]
        public string Account { get; set; }

        [Required(ErrorMessage = "password_RequiredError")]
        [MaxLength(20, ErrorMessage = "password_MaxLengthError")]
        [MinLength(1, ErrorMessage = "password_MinLengthError")]
        public string Password { get; set; }
        public bool IsRemember { get; set; }

        public List<string> Passwords { get; set; }

        public List<Language> Langs { get; set; }
        public Language Default { get; set; }

        public string ReturnUrl { get; set; }
    }
}

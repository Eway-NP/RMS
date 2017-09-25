using System;
using System.Web;
using System.Web.Mvc;

namespace Wiki.Component.Tools.Token
{
    public static class HtmlTokenHelper
    {
        /// <summary>
        /// 自动生成隐藏控件
        /// </summary>
        /// <param name="htmlhelper"></param>
        /// <param name="id">表单唯一标识ID</param>
        /// <returns></returns>
        public static MvcHtmlString GenerateVerficationToken(this HtmlHelper htmlhelper,dynamic id)
        {
            string formValue = SessionPageTokenView.Encrypt(HttpContext.Current.Session.SessionID + DateTime.Now.Ticks.ToString());
            string sessionname = HttpContext.Current.Request.Path + htmlhelper.ViewData[id];
            HttpContext.Current.Session[sessionname] = formValue;
            string fieldName = PageTokenViewBase.HiddenTokenName;
            TagBuilder builder = new TagBuilder("input");
            builder.Attributes["type"] = "hidden";
            builder.Attributes["name"] = fieldName;
            builder.Attributes["value"] = formValue;
            return new MvcHtmlString(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Web;
using EwayFramework.Utils.GlobalConfig.Implements.Language;
using Wiki.Component.Tools.Language.Extended;

namespace Wiki.Component.Tools.Language.Objects
{
    public class Language
    {
        public string LangName { get; set; }
        public string LangKey { get; set; }
        public string Image { get; set; }
        public string LangAddress { get; set; }
        public string LangTag { get; set; }

        public static IEnumerable<Language> GetAllLanguage(string callBackUri = null, string rootUri = null)
        {
            if (string.IsNullOrWhiteSpace(rootUri))
            {
                rootUri = EwayFramework.Utils.UriHelper.Static.UriHelper.GetAbsoultUri("/Content/images/flag/");
            }
            LanguageConfig config = (LanguageConfig)HttpContext.Current.Cache.Get("LanguageConfig");
            config.ChangeLangUri = EwayFramework.Utils.UriHelper.Static.UriHelper.GetAbsoultUri(config.ChangeLangUri); ;

            List<Language> list = new List<Language>();
            
            list.Add(new Language() { Image = rootUri + "cn.png", LangName = "简体中文", LangTag = "Lang_CN", LangKey = "zh-CN", LangAddress = config.ChangeLangUri + "?lang=zh-CN&callBack=" + callBackUri ?? "" });
            list.Add(new Language() { Image = rootUri + "us.png", LangName = "英文", LangTag = "Lang_US", LangKey = "en-us", LangAddress = config.ChangeLangUri + "?lang=en-us&callBack=" + callBackUri ?? "" });
            list.Add(new Language() { Image = rootUri + "fr.png", LangName = "法语", LangTag = "Lang_FR", LangKey = "fr-fr", LangAddress = config.ChangeLangUri + "?lang=fr-fr&callBack=" + callBackUri ?? "" });
            foreach (var c in list)
            {

                c.LangName = TranslatorHelper.Translator(c.LangTag);
            }
            return list;
        }

        public static bool IsExist(string langKey)
        {
            return GetAllLanguage().Any(d => d.LangKey.ToLower() == langKey.Trim().ToLower());
        }
        public static Language GetAddressByKey(string langKey)
        {
            return GetAllLanguage().FirstOrDefault(d => d.LangKey.ToLower() == langKey.ToLower());
        }
    }


}

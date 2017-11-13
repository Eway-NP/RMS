using System.Web;
using EwayFramework.Utils.GlobalConfig.Implements.Language;
using Wiki.Component.Tools.Language.Implements;
using Wiki.Component.Tools.Language.Interfaces;

namespace Wiki.Component.Tools.Language.Extended
{
    public static class TranslatorHelper
    {

        public static string Translator(this string key, object _targetLanguagePackUri)
        {
            ITranslator trans = new LanguageTranslator();
            string targetLanguagePackUri = _targetLanguagePackUri.ToString();
            if (!string.IsNullOrWhiteSpace(targetLanguagePackUri))
                trans.TargetLanguagePackUri = targetLanguagePackUri;
            return trans.Translator(key, targetLanguagePackUri);
        }
        public static string Translator(this string key)
        {
            var cacheConfig = HttpContext.Current.Cache.Get("LanguageConfig");
            if (cacheConfig == null)
                throw new System.Exception("多语言未配置,请检查配置文件.");
            ITranslator trans = new LanguageTranslator();
            string language=null;
            var lang = HttpContext.Current.Session["Lang"] ;
            if (lang == null || lang == "")
            {
                var langCk = HttpContext.Current.Request.Cookies.Get("LangCookie");
                if (langCk != null && langCk.Value != null)
                {
                    language = langCk.Value;
                }
            }
            else
            {
                language = lang.ToString();
            }
            LanguageConfig config = (LanguageConfig)cacheConfig;
            string targetLanguagePackUri = config.LangUri + (!string.IsNullOrWhiteSpace(language) ? lang + ".xml" : config.DefaultLang).ToString();

            if (!string.IsNullOrWhiteSpace(targetLanguagePackUri))
                trans.TargetLanguagePackUri = targetLanguagePackUri;
            return trans.Translator(key, targetLanguagePackUri);
        }
    }
}

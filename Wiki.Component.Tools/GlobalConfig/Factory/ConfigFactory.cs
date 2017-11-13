using EwayFramework.Utils.GlobalConfig.Implements.Language;
using Wiki.Component.Tools.GlobalConfig.Interfaces;
using System.Configuration;
using Wiki.Component.Tools.GlobalConfig.Implements.Email;


namespace Wiki.Component.Tools.GlobalConfig.Factory
{
    /// <summary>
    /// 配置文件工厂
    /// </summary>
    public class ConfigFactory
    {

        /// <summary>
        /// 生产配置接口
        /// </summary>
        /// <param name="key">不区分大小写
        /// Key=Email 生产 EmailConfig
        /// Key=FileUpload 生产 FileUploadConfig
        /// 
        /// 
        /// </param>
        /// <returns>IConfig 接口</returns>
        public static IConfig Manufacture(string productKey)
        {
            IConfig _config = null;
            switch (productKey.ToLower())
            {
                case "email":
                    _config = new EmailConfig();
                    break;
                case "fileupload":
                    _config = new EmailConfig();
                    break;
                case "languageconfig":
                    _config = new LanguageConfig();
                    break;
                default: throw new System.Exception("没有指定 productKey（产品的key）工厂无法进行生产.");
            }
            return _config;

        }
        public static string AppSettings(string appSettingKey)
        {
            return ConfigurationManager.AppSettings[appSettingKey];
        }
    }
}

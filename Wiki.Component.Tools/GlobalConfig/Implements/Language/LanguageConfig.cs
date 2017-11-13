using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Wiki.Component.Tools.GlobalConfig.Interfaces;

namespace EwayFramework.Utils.GlobalConfig.Implements.Language
{
    /// <summary>
    /// 多语言配置类
    /// </summary>
    public class LanguageConfig : IConfig
    {

        public string LangUri { get; set; }
        public bool IsPhysicsUri { get; set; }
        public string DefaultLang { get; set; }
        public string ChangeLangUri { get; set; }
        public dynamic InitConfig(dynamic _config, string appSettingKey = null)
        {
            _config = null;
            string config = ConfigurationManager.AppSettings[appSettingKey ?? "LanguageConfig"];
            if (!string.IsNullOrWhiteSpace(config))
            {
                _config = JsonConvert.DeserializeObject<LanguageConfig>(config);
            }
           
            return _config;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiki.Component.Tools.GlobalConfig.Interfaces;


namespace EwayFramework.Utils.GlobalConfig.Implements.FileUpload
{
    /// <summary>
    /// 文件上传配置
    /// </summary>
    public class FileUploadConfig : IConfig
    {
        private string tempUri;
        /// <summary>
        /// 临时文件存放路径
        /// </summary>
        public string TempUri
        {
            get { return tempUri; }
            set { tempUri = value; }
        }

        private string saveUri;
        /// <summary>
        /// 文件真正的存放路径
        /// </summary>
        public string SaveUri
        {
            get { return saveUri; }
            set { saveUri = value; }
        }

        public dynamic InitConfig(dynamic _config, string appappSettingKey = null)
        {
            string config = ConfigurationManager.AppSettings[appappSettingKey ?? "FileUploadConfig"].ToString();
            if (!string.IsNullOrWhiteSpace(config))
            {
                _config = JsonConvert.DeserializeObject<FileUploadConfig>(config);
            }
            else
            {
                throw new Exception("文件上传尚未配置");
            }
            return _config;
        }


    }
}

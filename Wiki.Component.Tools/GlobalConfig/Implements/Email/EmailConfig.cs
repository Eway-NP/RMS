using System.Configuration;
using Newtonsoft.Json;
using Wiki.Component.Tools.GlobalConfig.Interfaces;

namespace Wiki.Component.Tools.GlobalConfig.Implements.Email
{
    /// <summary>
    /// 邮件配置类
    /// </summary>
    public class EmailConfig : IConfig
    {
        private int _port;
        /// <summary>
        /// smtp服务器端口号
        /// </summary>
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        private string _smtpHost;
        /// <summary>
        /// smtp服务器地址
        /// </summary>
        public string SmtpHost
        {
            get { return _smtpHost; }
            set { _smtpHost = value; }
        }

        private string _senderEmail;
        /// <summary>
        /// 发件人邮箱地址
        /// </summary>
        public string SenderEmail
        {
            get { return _senderEmail; }
            set { _senderEmail = value; }
        }
        private string _testEmail;
        /// <summary>
        /// 测试模式邮箱地址（如果填写此项所有邮件将发送至此邮箱）
        /// </summary>
        public string TestEmail
        {
            get { return _testEmail; }
            set { _testEmail = value; }
        }
        private string _senderName;
        /// <summary>
        /// 发件人姓名
        /// </summary>
        public string SenderName
        {
            get { return _senderName; }
            set { _senderName = value; }
        }

        private string _senderPassword;
        /// <summary>
        /// 发件人密码
        /// </summary>
        public string SenderPassword
        {
            get { return _senderPassword; }
            set { _senderPassword = value; }
        }

        /// <summary>
        /// 初始化 邮件配置
        /// </summary>
        /// <param name="_config">待初始化的对象</param>
        /// <param name="appappSettingKey">配置文件 appSettings 中的Key 默认:EmailConfig</param>
        public dynamic InitConfig(dynamic _config, string appSettingKey = null)
        {
            _config = null;
            string config = ConfigurationManager.AppSettings[appSettingKey ?? "EmailConfig"];
            if (!string.IsNullOrWhiteSpace(config))
            {
                _config = JsonConvert.DeserializeObject<EmailConfig>(config);
            }
            return _config;
        }
    }
}

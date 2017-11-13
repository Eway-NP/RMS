namespace Wiki.Component.Tools.GlobalConfig.Interfaces
{
    public interface IConfig
    {
        /// <summary>
        /// 初始化 配置
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="appSettingKey">配置文件 appSettings 中的Key</param>
        /// 返回配置类
        dynamic InitConfig(dynamic obj, string appSettingKey = null);
    }
}

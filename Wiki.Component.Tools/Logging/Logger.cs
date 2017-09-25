using System;
using NLog;

namespace Wiki.Component.Tools.Logging
{
    public class NLogHandler
    {

        private NLogHandler()
        {
            logger = NLog.LogManager.GetCurrentClassLogger();
        }
        private static Logger logger;

        private static readonly Lazy<NLogHandler> lazy =
            new Lazy<NLogHandler>(() => new NLogHandler());
        public static NLogHandler Instance { get { return lazy.Value; } }

        public void Error(System.Exception ex)
        {
            logger.Error(ex);
        }
        public void Debug(string ex)
        {
            logger.Debug("调试", ex);
        }
        public void Log(string obj)
        {
            logger.Info("操作日志", obj);
        }
        public void Warn(string obj)
        {
            logger.Warn("警告", obj);
        }
        public void Fatal(System.Exception ex)
        {
            logger.Fatal("出现致命的错误", ex);
        }

        public void Log(LogLevel llevel, System.Exception exception)
        {
            switch (llevel)
            {
                case LogLevel.Error:
                    Error( exception);
                    break;
                case LogLevel.Fatal:
                    Fatal(exception);
                    break;
            }

        }
    }
}

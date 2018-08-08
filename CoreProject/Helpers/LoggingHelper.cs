using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace CoreProject.Helpers
{
    public static class LoggingHelper
    {
        public static readonly ILog log;

        static LoggingHelper()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}

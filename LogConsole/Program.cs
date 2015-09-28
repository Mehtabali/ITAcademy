using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogConsole
{
    public static class LogFactory
    {
        public const string Log4NetConfig = "log4net.config";

        public static ILog GetLogger()
        {
            var uri = new Uri(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase), Log4NetConfig));
            var configFile = new FileInfo(Path.GetFullPath(uri.LocalPath));
            XmlConfigurator.ConfigureAndWatch(configFile);
            ILog log = LogManager.GetLogger(typeof(LogFactory));
            return log;
        }
    }
    class Program
    {
       // private static readonly ILog Log = LogFactory.GetLogger();
        static void Main(string[] args)
        {
            //log4net.Config.BasicConfigurator.Configure();
            //ILog log = log4net.LogManager.GetLogger(typeof(Program));
            ILog log = LogFactory.GetLogger();
            log.Debug("This is a debug message");
            log.Warn("This is a warn message");
            log.Error("This is a error message");
            log.Fatal("This is a fatal message");
            log.Info("Test 123");
        }
    }
}

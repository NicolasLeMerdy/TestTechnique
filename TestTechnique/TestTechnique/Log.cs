using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTechnique {
    public class Log {

        private static ILog _logger;
        private static ILog Logger {
            get {
                if (_logger == null) {
                    _logger = LogManager.GetLogger(typeof(Log));
                    log4net.Config.XmlConfigurator.Configure();
                }
                return _logger;
            }
        }

        public static void LogError(string msg, Exception ex) {
            Logger.Error(msg, ex);
        }

        public static void LogResponse(string msg) {
            Logger.Info(msg);
        }
    }
}
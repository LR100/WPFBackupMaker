using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupMaker.Logger
{
    internal class FileLogger : ILogger
    {
        // The NLog logger instance
        private NLog.Logger _logger;
        // Use NLog for logging
        public FileLogger(string loggerName)
        {
            // Get current datetime formated to yyyy-mm-dd hour-min-sec
            string date = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string logFileName = "logs/" + loggerName + "-" + date + ".log";
            // Get the current configuration NLog
            LoggingConfiguration? config = LogManager.Configuration;
            config ??= new LoggingConfiguration();
            // Create file target
            // Exception layout with prefix only if there is an exception
            string exceptionLayout = "${when:when=length('${exception}')>0:inner=${newline}${exception:format=tostring}}";

            var fileTarget = new FileTarget(loggerName)
            {
                FileName = logFileName,
                Layout = "${longdate} - ${logger} - [${uppercase:${level}}] : ${message} " + exceptionLayout
            };

            // Add the file target to the configuration
            config.AddTarget(loggerName, fileTarget);

            // Define the logging rules
            config.AddRuleForAllLevels(fileTarget);

            // Activate the configuration
            LogManager.Configuration = config;

            // Get the logger
            _logger = LogManager.GetLogger(loggerName);

        }

        public void Trace(string message, params object[] args)
        {
            _logger.Trace(message, args);
        }

        public void Trace(string message, Exception? ex = null, params object[] args)
        {
            _logger.Trace(ex, message, args);
        }
        public void Debug(string message, params object[] args)
        {
            _logger.Debug(message, args);
        }

        public void Debug(string message, Exception? ex = null, params object[] args)
        {
            _logger.Debug(ex, message, args);
        }

        public void Info(string message, params object[] args)
        {
            _logger.Info(message, args);
        }

        public void Info(string message, Exception? ex = null, params object[] args)
        {
            _logger.Info(ex, message, args);
        }

        public void Warn(string message, params object[] args)
        {
            _logger.Warn(message, args);
        }

        public void Warn(string message, Exception? ex = null, params object[] args)
        {
            _logger.Warn(ex, message, args);
        }

        public void Error(string message, params object[] args)
        {
            _logger.Error(message, args);
        }

        public void Error(string message, Exception? ex = null, params object[] args)
        {
            _logger.Error(ex, message, args);
        }

        public void Fatal(string message, params object[] args)
        {
            _logger.Fatal(message, args);
        }

        public void Fatal(string message, Exception? ex = null, params object[] args)
        {
            _logger.Fatal(ex, message, args);
        }
    }
}

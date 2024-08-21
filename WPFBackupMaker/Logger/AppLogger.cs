using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupMaker.Logger
{
    public class AppLogger
    {
        private static ILogger? _logger;

        private AppLogger() { }

        public static void Initialize()
        {
            _logger = new FileLogger("Application");
        }

        public static void Trace(string message, Exception? ex = null, params object[] args)
        {
            _logger?.Trace(message, ex, args);
        }

        public static void Trace(string message, params object[] args)
        {
            _logger?.Trace(message, args);
        }

        public static void Debug(string message, Exception? ex = null, params object[] args)
        {
            _logger?.Debug(message, ex, args);
        }

        public static void Debug(string message, params object[] args)
        {
            _logger?.Debug(message, args);
        }

        public static void Info(string message, Exception? ex = null, params object[] args)
        {
            _logger?.Info(message, ex, args);
        }

        public static void Info(string message, params object[] args)
        {
            _logger?.Info(message, args);
        }

        public static void Error(string message, Exception? ex = null, params object[] args)
        {
            _logger?.Error(message, ex, args);
        }

        public static void Error(string message, params object[] args)
        {
            _logger?.Error(message, args);
        }

        public static void Fatal(string message, Exception? ex = null, params object[] args)
        {
            _logger?.Fatal(message, ex, args);
        }

        public static void Fatal(string message, params object[] args)
        {
            _logger?.Fatal(message, args);
        }

        public static void Warn(string message, Exception? ex = null, params object[] args)
        {
            _logger?.Warn(message, ex, args);
        }

        public static void Warn(string message, params object[] args)
        {
            _logger?.Warn(message, args);
        }
    }
}

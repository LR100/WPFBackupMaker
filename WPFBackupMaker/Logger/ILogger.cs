using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupMaker.Logger
{
    /// <summary>
    /// Basic logging interface implementing Microsoft's ILogger
    /// </summary>
    public interface ILogger
    {
        // Trace 
        public void Trace(string message, params object[] args);
        public void Trace(string message, Exception? ex = null, params object[] args);

        // Debug
        public void Debug(string message, params object[] args);
        public void Debug(string message, Exception? ex = null, params object[] args);

        // Info
        public void Info(string message, params object[] args);
        public void Info(string message, Exception? ex = null, params object[] args);

        // Warn
        public void Warn(string message, params object[] args);
        public void Warn(string message, Exception? ex = null, params object[] args);

        // Error
        public void Error(string message, params object[] args);
        public void Error(string message, Exception? ex = null, params object[] args);

        // Fatal
        public void Fatal(string message, params object[] args);
        public void Fatal(string message, Exception? ex = null, params object[] args);
    }
}

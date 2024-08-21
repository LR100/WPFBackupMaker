using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBackupMaker.Core
{
    public class AppInfo
    {
        public static string AppName { get; } = "Backup Maker"; // Application Name
        public static string AppVersion { get; } = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "";
    }
}

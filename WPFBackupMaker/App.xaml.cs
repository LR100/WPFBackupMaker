using BackupMaker.Logger;
using System.Windows;
using WPFBackupMaker;


namespace BackupMaker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application // WPF Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Initialize the logger
            AppLogger.Initialize();
            // Log the application startup
            AppLogger.Info("Start");
            // Create the Main Window and it's ViewModel
            MainWindow mainWindow = new();
            MainWindowViewModel mainWindowViewModel = new();
            mainWindow.DataContext = mainWindowViewModel;
            // Link the application MainWindow to the mainWindow object
            MainWindow = mainWindow;
            // Show the MainWindow
            mainWindow.Show();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            AppLogger.Info("Exit");
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            // Log Fatal
            AppLogger.Fatal("Unhandled Exception", e.Exception);
        }
    }

}

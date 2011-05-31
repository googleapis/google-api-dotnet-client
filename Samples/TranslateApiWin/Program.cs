using System;
using System.Windows.Forms;

using Google.Apis.Samples.TranslateApiWin.Controllers;

namespace Google.Apis.Samples.TranslateApiWin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Catch unhandled exceptions to help the user a little bit
            //AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs)
            //                                              =>
            //        {
            //            // Show the user a helpful error message
            //            MessageBox.Show(eventArgs.ExceptionObject.ToString(),
            //                            "An unhandled exception has occured",
            //                            MessageBoxButtons.OK,
            //                            MessageBoxIcon.Error);
            //            Environment.Exit(-1);
            //        };

            // Set WinForms default settings
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and execute the controller
            var controller = new TranslateController();
            controller.ExecuteExample();
        }
    }
}
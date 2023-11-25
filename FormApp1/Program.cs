using System.Runtime.InteropServices;

namespace FormApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            string key = "1";
            key = key.Trim();
            //class Value = null;

            if (key is null || key == string.Empty)
            {
            }

            if (typeof(this) is class)
            {
            }
            */
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmTest1());
            Application.Run(new frmReportOLAP());
        }
    }
}
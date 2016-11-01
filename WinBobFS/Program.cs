using System;
using System.Windows.Forms;

namespace WinBobFS
{
    internal static class Program
    {
        public const int VersionCode = 2;
        public const string VersionName = "0.2.0";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

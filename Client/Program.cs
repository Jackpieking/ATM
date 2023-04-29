using Client.Helper;
using System;
using System.Windows.Forms;

namespace Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(CachedFormContainer.Get().GetLoginForm());
        }
    }
}
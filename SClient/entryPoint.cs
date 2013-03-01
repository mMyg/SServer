using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SClient
{
    static class entryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SClient());
        }
    }
}

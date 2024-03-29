﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public static class Program
    {
        public static bool OpenDetailFormOnClose { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenDetailFormOnClose = false;
            Application.Run(new Login());
            if (OpenDetailFormOnClose)
            {
                Application.Run(new WorkerDashboard());
            }
        }
    }
}

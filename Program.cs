﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Management_System_Final
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// Trying
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginScreen());
            DBConnector.InitializeDB();
        }
    }
}
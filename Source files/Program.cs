﻿using System;
using System.Windows.Forms;

namespace Sanchez.Patcher
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new pForm());
        }
    }
}

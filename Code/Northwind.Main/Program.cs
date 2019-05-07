using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EAS.Data.ORM;

namespace Northwind.Main
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EAS.Windows.Application.Upgrade();
            EAS.WinClient.Application.Start();
        }
    }
}

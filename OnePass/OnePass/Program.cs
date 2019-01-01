using Azylee.Core.AppUtils;
using OnePass.Commons;
using OnePass.Views.MainViews;
using System;
using System.Windows.Forms;

namespace OnePass
{
    static class Program
    {
        static AppUnique AppUnique = new AppUnique();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //解决进程互斥
            if (!AppUnique.IsUnique(R.AppName)) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            R.MainUI = new MainForm();
            Application.Run(R.MainUI);
        }
    }
}

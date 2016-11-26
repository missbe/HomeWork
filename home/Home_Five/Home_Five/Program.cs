using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Home_Five
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
            Application.Run(new home_form());
            //Application.Run(new UserForm());   
            //Application.Run(new login_form());
        }
    }
}

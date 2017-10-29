using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ThermometerExample
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //I add this line 171029:19:58
            //dljlj add
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ThermometerExample());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using thongke;

namespace CleanArchQLNH
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fLogin());
            //Application.Run(new Form1());
            //Application.Run(new fThongKe());
            // Application.Run(new fAdmin());
            // Application.Run(new fAccountProfile());
            //  Application.Run(new fTableManager());
            //Application.Run(new fInHoaDon());
        }
    }
}

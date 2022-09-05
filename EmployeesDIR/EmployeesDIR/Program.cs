using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesDIR
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

#if DEBUG
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();
#endif
        [STAThread]
        static void Main()
        {
            General.logger.Info("Entering application.");

#if DEBUG
            //AllocConsole();
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            //Shell.Shell.WriteLine("Info:infotest");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeesDIR());
            General.logger.Info("Exiting application.");
            //FreeConsole();
        }
    }
}

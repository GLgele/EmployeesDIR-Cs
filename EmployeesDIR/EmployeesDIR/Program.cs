using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesDIR
{
    static partial class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {
            Program.logger.Info("Entering application.");
#if DEBUG
            //AllocConsole();
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            
#endif
#if !DEBUG
            if (!args.Contains("--debug"))
                FreeConsole();
#endif
            if (args.Contains("--debug"))
            {
                Program.logger.Warn("Debug Mode On!");
                Config.isRDebug = true;
                AllocConsole();
            }
            //Shell.Shell.WriteLine("Info:infotest");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeesDIR());
            Program.logger.Info("Exiting application.");
            //FreeConsole();
        }
    }
}

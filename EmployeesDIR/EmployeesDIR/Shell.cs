using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;

namespace Shell
{
    /// <summary>  
    /// 与控制台交互  
    /// </summary>  
    static class Shell
    {
        /// <summary>  
        /// 输出信息  
        /// </summary>  
        /// <param name="format"></param>  
        /// <param name="args"></param>  
        public static void WriteLine(string format, params object[] args)
        {
            WriteLine(string.Format(format, args));
        }

        /// <summary>  
        /// 输出信息  
        /// </summary>  
        /// <param name="output"></param>  
        public static void WriteLine(string output)
        {
            Console.ForegroundColor = GetConsoleColor(output);
            Console.WriteLine(@"[{0}]{1}", DateTimeOffset.Now, output);
        }

        /// <summary>  
        /// 根据输出文本选择控制台文字颜色  
        /// </summary>  
        /// <param name="output"></param>  
        /// <returns></returns>  
        private static ConsoleColor GetConsoleColor(string output)
        {
            if (output.StartsWith("WARN")) return ConsoleColor.Yellow;
            if (output.StartsWith("ERROR")) return ConsoleColor.Red;
            if (output.StartsWith("FATAL")) return ConsoleColor.Red;
            if (output.StartsWith("INFO")) return ConsoleColor.Green;
            return ConsoleColor.Gray;
        }
    }
}

namespace Mylog
{
    class Mylog
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(EmployeesDIR.Program));

        public Mylog()
        {
            
            log4net.Config.BasicConfigurator.Configure();
#if DEBUG
            ((log4net.Repository.Hierarchy.Hierarchy)LogManager.GetRepository()).Root.Level = log4net.Core.Level.Debug;
#else
            ((log4net.Repository.Hierarchy.Hierarchy)LogManager.GetRepository()).Root.Level = log4net.Core.Level.Info;
#endif
        }
        public void Info(string msg) { log.Info(msg); /*Shell.Shell.WriteLine(msg);*/ }
        public void InfoFormat(string format, params object[] args) { log.InfoFormat(format, args); /*Shell.Shell.WriteLine(format,args);*/ }
        public void Debug(string msg) { log.Debug(msg); /*Shell.Shell.WriteLine(msg); */}
        public void DebugFormat(string format, params object[] args) { log.DebugFormat(format, args); /*Shell.Shell.WriteLine(format, args); */}
        public void Warn(string msg) { log.Warn(msg); /*Shell.Shell.WriteLine(msg); */}
        public void WarnFormat(string format, params object[] args) { log.WarnFormat(format, args); /*Shell.Shell.WriteLine(format, args);*/ }
        public void Error(string msg) { log.Error(msg); /*Shell.Shell.WriteLine(msg);*/ }
        public void ErrorFormat(string format, params object[] args) { log.ErrorFormat(format, args); /*Shell.Shell.WriteLine(format, args); */}
        public void Fatal(string msg) { log.Fatal(msg); /*Shell.Shell.WriteLine(msg);*/ }
        public void FatalFormat(string format, params object[] args) { log.FatalFormat(format, args); /*Shell.Shell.WriteLine(format, args);*/ }
    }
            
    
}

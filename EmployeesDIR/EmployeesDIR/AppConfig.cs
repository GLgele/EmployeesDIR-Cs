using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;

// start $(SolutionDir)tools\ReleaseVer\ReleaseVer.exe $(ProjectDir)Properties\AssemblyInfo.cs

namespace EmployeesDIR
{
    public class Language
    {
        public string lang { get; set; }
    }
    public class Update
    {
        public string source { get; set; }
        public bool autoCheck { get; set; }
    }
    class AppConfig
    {
        static AppConfig Instance;

        public Language Language { get; set; }
        public Update Update { get; set; }

        public AppConfig() { }
        public static AppConfig Get()
        {
            //if (Instance != null) return Instance;
            try
            {
                Instance = new ConfigurationBuilder()
                                .AddIniFile(Config.iniFilePath)
                                .Build()
                                .Get<AppConfig>();
            }
            catch(IOException e)
            {
                Instance = new ConfigurationBuilder()
                                .Build()
                                .Get<AppConfig>();
            }
            return Instance;
        }
    }
}

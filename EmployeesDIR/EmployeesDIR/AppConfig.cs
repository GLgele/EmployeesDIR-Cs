using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;

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

            Instance = new ConfigurationBuilder()
                .AddIniFile(General.iniFilePath)
                .Build()
                .Get<AppConfig>();

            return Instance;
        }
    }
}

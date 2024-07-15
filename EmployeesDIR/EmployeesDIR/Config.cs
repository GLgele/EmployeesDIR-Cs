using System;
using System.Runtime.InteropServices;
using System.Text;

namespace EmployeesDIR
{
    class Config
    {
        public static bool isRDebug = false;
        private static readonly string[] scver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString().Split('.');
        public static readonly Version cver = new Version(Convert.ToInt32(scver[0]), Convert.ToInt32(scver[1]), Convert.ToInt32(scver[2]));
        public static readonly string title = $"EmployeesDIR - {cver.Major}.{cver.Minor}";
        public static string iniFilePath = "config.ini";
        public static AppConfig config = AppConfig.Get();

        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public static void CheckUpdate(bool f=false)
        {
            switch (Config.config.Update.source)
            {
                case "Github":
                {
                    GitHubUpdater.UpdateClient client = new GitHubUpdater.UpdateClient() { Author = "GLgele", RepositoryName = "EmployeesDIR-Cs", CurrentInstalledVersion = Config.cver };
                    client.CheckIfLatest(f);
                    break;
                }
                case "Gitee":
                {
                    GitHubUpdater.UpdateClient client = new GitHubUpdater.UpdateClient() { Author = "GLgele", RepositoryName = "EmployeesDIR-Cs", CurrentInstalledVersion = Config.cver, BaseUrl = "https://gitee.com/api/v5/" };
                    client.CheckIfLatest(f);
                    break;
                }
            }
            
        }

        public static void CheckUpdate(object sender, EventArgs e)
        {
            CheckUpdate(true);
        }
    }
}
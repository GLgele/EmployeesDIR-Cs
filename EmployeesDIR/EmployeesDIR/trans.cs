using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace EmployeesDIR
{
    [Obsolete]
    /// <summary>
    /// 不再使用 改为winform多语言
    /// </summary>
    class trans:General
    {
        private static string lang;
        private string source;
        private StreamReader file;
        private Dictionary<string, string> dict = new Dictionary<string, string>();
        public trans()
        {
            try
            {
                file = new StreamReader(new FileStream(lang + ".json", FileMode.Open, FileAccess.Read, FileShare.Read));
            }
            catch(IOException)
            {
                file = new StreamReader(new FileStream("en_us.json", FileMode.Open, FileAccess.Read, FileShare.Read));
            }
            catch(Exception)
            {
                General.logger.Fatal("Can't load language file!");
                ErrorForm form = new ErrorForm("Can't load language file!");
            }
            lang = IniReadValue(iniFilePath, "lang", "lang");
            file.ReadToEnd();
            file.Close();
            source = file.ToString();
            JsonTextReader reader = new JsonTextReader(new StringReader(source));
            string tmp1 = "";
            string tmp2 = "";
            int cnt = 0;
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    //Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                    if(reader.TokenType == JsonToken.String)
                    {
                        cnt++;
                        if(cnt % 2 == 1)
                        {
                            tmp1 = reader.Value.ToString();
                        }
                        else
                        {
                            tmp2 = reader.Value.ToString();
                            dict[tmp1] = tmp2;
                            tmp1 = "";
                            tmp2 = "";
                        }
                    }
                }
                else
                {
                    //Console.WriteLine("Token: {0}", reader.TokenType);
                }
            }
        }
        ~trans()
        {
            file.Dispose();
        }
        public string tr(string s)
        {
            return dict[s];
        }
    }
}

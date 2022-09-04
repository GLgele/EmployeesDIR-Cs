using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EmployeesDIR
{
    //[Obsolete]
    /// </summary>
    /// 不再使用 改为winform多语言
    /// </summary>
    class trans : General
    {
        private static string lang;
        private string source;
        private StreamReader file;
        private Dictionary<string, string> dict = new Dictionary<string, string>();
        public trans()
        {
            try
            {
                file = new StreamReader(new FileStream("lang/" + lang + ".json", FileMode.Open, FileAccess.Read, FileShare.Read));
            }
            catch (IOException)
            {
                file = new StreamReader(new FileStream("lang/en_us.json", FileMode.Open, FileAccess.Read, FileShare.Read));
                General.logger.Error("Can't find settings.ini!");
            }
            catch (Exception)
            {
                General.logger.Fatal("Can't load language file!");
                ErrorForm form = new ErrorForm("Can't load language file!");
            }
            lang = IniReadValue(iniFilePath, "lang", "lang");
            source = file.ReadToEnd();
            file.Close();
            source = source.Replace("\r", "").Replace("\n", "").Replace("\t", "");
            //source = file.ToString();
            JsonTextReader reader = new JsonTextReader(new StringReader(source));
            string tmp1 = "";
            string tmp2 = "";
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    //Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                    if (reader.TokenType == JsonToken.PropertyName)
                    {
                        tmp1 = reader.Value.ToString();
                    }
                    else if (reader.TokenType == JsonToken.String)
                    {
                        tmp2 = reader.Value.ToString();
                        dict[tmp1] = tmp2;
                        tmp1 = "";
                        tmp2 = "";
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
            try
            {
                return dict[s];
            }
            catch (Exception)
            {
                General.logger.WarnFormat("Translate string not found! Source:({0})", s);
                return s;
            }
        }
        public void Init(Form form)
        {
            foreach (Control control in form.Controls)
            {
                try
                {
                    control.Text = tr("Form.Control".Replace("Form", form.Name).Replace("Control", control.Name));
                }
                catch (Exception)
                {
                    //Actually we do nothing if we catch an exception.
                }
            }
        }
    }
}

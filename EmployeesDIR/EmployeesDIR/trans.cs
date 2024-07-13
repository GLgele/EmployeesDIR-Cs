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
    /// <summary>
    /// 不再使用 改为winform多语言
    /// </summary>
    class Trans : General
    {
        public static readonly Dictionary<string, string> langDict = new Dictionary<string, string>() { { "中文（简体）", "zh_cn" }, { "English", "en_us" } };
        public static readonly Dictionary<string, string> langDict2 = langDict.ToDictionary(k => k.Value, p => p.Key);
        private static string lang;
        private string source;
        private StreamReader file;
        private Dictionary<string, string> dict = new Dictionary<string, string>();
        public Trans()
        {
            lang = config.Language.lang;
            //lang = langDict[lang];
            logger.DebugFormat("Language:{0}", langDict2[lang]);
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
            source = file.ReadToEnd();
            file.Close();
            source = source.Replace("\r", "").Replace("\n", "").Replace("\t", "");
            //source = file.ToString();
            #region Obsolete deserialize json function
            /*
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
            */
            #endregion
            dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(source);
        }
        ~Trans()
        {
            file.Dispose();
        }
        public string tr(string s)
        {
            //List<string> except = new List<string> { "debug", "namelabel", "sexlabel", "numberlabel", "commentlabel", "emaillabel", "edulabel", "salarylabel" };
            if (!(s.Contains("DNT") || s.ToLower().Contains("debug")))
            {
                try
                {
                    return dict[s];
                }
                catch (Exception)
                {
                    General.logger.WarnFormat("Translate string not found! Source:({0})", s);
                    if (!s.Contains(".")) return s;
                    return "";
                }
            }
            return "";
        }
        public void Init(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if(!(control.Tag is null)) { if (control.Tag.ToString().Contains("DNT")) continue; }
                else
                {
                    string tmp = tr("Form.Control".Replace("Form", form.Name).Replace("Control", control.Name));
                    if (tmp != "")
                    {
                        control.Text = tmp;
                    }
                }
            }
            if (form is EmployeesDIR)
            {
                foreach (ToolStripMenuItem menuItem in form.MainMenuStrip.Items)
                {
                    foreach (ToolStripItem item in menuItem.DropDownItems)
                    {
                        string tmps = tr("Form.Item".Replace("Form", form.Name).Replace("Item", item.Name));
                        if (tmps != "")
                        {
                            item.Text = tmps;
                        }
                    }
                    string tmp = tr("Form.Item".Replace("Form", form.Name).Replace("Item", menuItem.Name));
                    if (tmp != "")
                    {
                        menuItem.Text = tmp;
                    }
                }
            }
        }
    }
}

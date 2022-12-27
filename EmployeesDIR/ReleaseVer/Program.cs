using System;
using System.IO;
using System.Xml;

namespace AutoUpdateVersion
{
    class Program
    {
        public static string curVer = "";
        public static string curRevi = "";
        static void UpdateVersion(ref string line, bool f = false)
        {
            var first = line.IndexOf('"');
            var second = line.LastIndexOf('"');
            var sVersion = line.Substring(first + 1, second - first - 1);
            var arrVersion = sVersion.Split('.');
            if (arrVersion.Length < 4) return;
            var major = Convert.ToInt32(arrVersion[0]);
            var minor = Convert.ToInt32(arrVersion[1]);
            var build = Convert.ToInt32(arrVersion[2]);
            int amendment = Convert.ToInt32(curRevi);
            var samendment = arrVersion[3];
            /*if (f)
            {
                var tmp = samendment.Substring(0, samendment.IndexOf('('));
                amendment = Convert.ToInt32(tmp);
            }
            else
            {
                amendment = Convert.ToInt32(arrVersion[3]);
            }*/
            amendment++;
            if (f)
            {
                samendment = $"{amendment}({DateTime.Now.ToString("yyyyMMdd")})";
            }
            else
            {
                samendment = amendment.ToString();
            }
            /*
            if (++amendment > 999) ++build;
            if (build > 99) ++minor;
            if (minor > 9) ++major;
            */
            var sNewVersion = $"{major}.{minor}.{build}.{samendment}";
            line = line.Replace(sVersion, sNewVersion);
            Console.WriteLine($"New version {sNewVersion}");
        }

        static void ReadCsproj(string path)
        {
            // Read xml and find label ApplicationRevision C#
            //
            // The following code can be used to read an XML file and find the label "ApplicationRevision":
            // 
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList nodes = doc.GetElementsByTagName("ApplicationRevision");
            foreach (XmlNode node in nodes)
            {
                curRevi = node.InnerText;
                //Console.WriteLine("ApplicationRevision: {0}", value);
            }
            nodes = doc.GetElementsByTagName("ApplicationVersion");
            foreach (XmlNode node in nodes)
            {
                curVer = node.InnerText;
                //Console.WriteLine("ApplicationRevision: {0}", value);
            }
            curVer = curVer.Replace("%2a", curRevi);
            Console.WriteLine("Current Version: {0}", curVer);
        }

        static void Main(string[] args)
        {
            if (args.Length != 1 || !File.Exists(args[0])) return;
            var lines = File.ReadAllLines(args[0]);
            ReadCsproj("../../EmployeesDIR.csproj");
            for (int i = lines.Length - 1; i >= 0; i--)
            {
                if (lines[i].Contains("assembly: AssemblyFileVersion"))
                {
                    UpdateVersion(ref lines[i], true);
                }
                if (lines[i].Contains("assembly: AssemblyVersion") && !lines[i].Contains("*"))
                {
                    UpdateVersion(ref lines[i]);
                    break;
                }
            }
            File.WriteAllLines(args[0], lines);
        }
    }
}
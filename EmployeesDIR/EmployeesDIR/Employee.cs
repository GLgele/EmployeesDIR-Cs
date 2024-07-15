using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

using Mylog;
//using Ilog;

namespace EmployeesDIR
{
    class Employee
    {
        private int id;
        private string name;
        private string sex;
        private string number;
        private string comment;
        private string email;
        private string edu;
        private string salary;

        public Employee() { }
        public Employee(int id, string name, string sex, string number, string comment, string email, string edu, string salary)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.number = number;
            this.comment = comment;
            this.email = email;
            this.edu = edu;
            this.salary = salary;
        }
        [Obsolete] public int GetId() { return id; }
        public List<string> GetInfo() { List<string> lst = new List<string> { name, sex, number, comment, email, edu, salary }; return lst; }
        public void ChangeInfo(string name, string sex, string number, string comment, string email, string edu, string salary)
        { this.name = name; this.sex = sex; this.number = number; this.comment = comment; this.email = email; this.edu = edu; this.salary = salary; }
        public void ChangeInfo(List<string> lst) { ChangeInfo(lst[0], lst[1], lst[2], lst[3], lst[4], lst[5], lst[6]); }
    }

    partial class Program
    {
        public static readonly Mylog.Mylog logger = new Mylog.Mylog() /*LogManager.GetLogger(typeof(Program))*/;
        public static List<Employee> employees = new List<Employee>();
        public static Trans trans = new Trans();

        public static void SaveData()
        {
            // http://t.zoukankan.com/yanglang-p-7151321.html
            //初始化一个OpenFileDialog类
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = @"Employees(*.employees)|*.employees|All files(*.*)|*.*";
            //fileDialog.CheckFileExists = false;
            //判断用户是否正确的选择了文件
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //在这里就可以写获取到正确文件后的代码了
                var path = fileDialog.FileName;
                Program.logger.DebugFormat("SaveFileDialog path:{0}", path);
                SaveData(path);
            }
        }

        public static void SaveData(string path)
        {
            Program.logger.InfoFormat("Saving file. Path: {0}", path);
            try
            {
                BinaryWriter file = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write));
                file.Write(employees.Count());
                file.Write("\n");
                foreach (Employee emp in Program.employees)
                {
                    List<string> lst = emp.GetInfo();
                    foreach (string s in lst)
                    {
                        file.Write(s + " ");
                        //Console.WriteLine(s);
                    }
                    file.Write("\n");
                }
                file.Close();
            }
            catch (Exception e)
            {
                Program.logger.ErrorFormat("Exception: {0}", e);
                ErrorForm error = new ErrorForm(e.Message);
                error.Show();
            }
        }
        
        public static void OpenData()
        {
            // http://t.zoukankan.com/yanglang-p-7151321.html
            //初始化一个OpenFileDialog类
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = @"Employees(*.employees)|*.employees|All files(*.*)|*.*";
            //fileDialog.CheckFileExists = false;
            //判断用户是否正确的选择了文件
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //在这里就可以写获取到正确文件后的代码了
                var path = fileDialog.FileName;
                Program.logger.DebugFormat("OpenFileDialog path:{0}", path);
                OpenData(path);
            }
        }

        public static void OpenData(string path)
        {
            Program.logger.InfoFormat("Opening file. Path: {0}", path);
            try
            {
                BinaryReader file = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read));
                int n = Convert.ToInt32(file.ReadInt32());
                byte[] fw = file.ReadBytes(2);
                for (int i = 0; i < n; i++)
                {
                    List<string> lst = new List<string>();
                    string tmp = "";
                    char chr = 'A';
                    for (int ii = 0; ii < 7; ii++)
                    {
                        //lst.Add(file.Read());
                        while (chr != ' ')
                        {
                            chr = file.ReadChar();
                            tmp += chr;
                        }
                        tmp = tmp.Substring(1);
                        lst.Add(tmp);
                        tmp = "";
                        chr = '\0';
                    }
                    AppendEmployee(lst);
                }
                file.Close();
            }
            catch (Exception e)
            {
                Program.logger.ErrorFormat("Exception: {0}", e);
                ErrorForm error = new ErrorForm(e.Message);
                error.Show();
            }
        }

        public static void AppendEmployee(/*int id, */string name, string sex, string number, string comment, string email, string edu, string salary)
        {
            int id = 0;
            employees.Add(new Employee(id, name, sex, number, comment, email, edu, salary));
            logger.InfoFormat("New employee:{0},id{1};{2},{3},{4},{5},{6},{7}", name, id, sex, number, comment, email, edu, salary);
        }

        public static void AppendEmployee(List<string> lst)
        {
            AppendEmployee(lst[0], lst[1], lst[2], lst[3], lst[4], lst[5], lst[6]);
        }
    }

    class General
    {
        internal General()
        {

        }

        /*
        /// <summary> 
        /// 写⼊INI⽂件
        /// </summary> 
        /// <param name="iniFilePath">ini文件路径</param>
        /// <param name="field">项⽬名称(如 [TypeName] )</param> 
        /// <param name="Key">键</param> 
        /// <param name="Value">值</param> 
        public static void IniWriteVaule(string iniFilePath, string field, string Key, string Value)
        {
            WritePrivateProfileString(field, Key, Value, iniFilePath);
        }
        /// <summary> 
        /// 读出INI⽂件
        /// </summary> 
        /// <param name="iniPath">ini文件路径</param>
        /// <param name="field">项⽬名称(如 [TypeName] )</param> 
        /// <param name="Key">键</param> 
        public static string IniReadValue(string iniPath, string field, string Key)
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(field, Key, "", temp, 500, iniPath);
            return temp.ToString();
        }
        */
    }
}

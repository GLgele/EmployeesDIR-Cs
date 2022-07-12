using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesDIR
{
    public partial class ErrorForm : Form
    {
        private string errmsg = "";
        public ErrorForm()
        {
            InitializeComponent();
        }

        public ErrorForm(string err)
        {
            errmsg = err;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            General.logger.Debug("Closing form \"Error Form\".");
            this.Close();
            this.Dispose();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(errorLabel.Text);
            General.logger.InfoFormat("Set clipborad text: {0}",errorLabel.Text);
            MessageBox.Show("Message copied.", General.title, MessageBoxButtons.OK);
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            General.logger.DebugFormat("Error Form loaded.Args: {0}",errmsg);
            if(errmsg != "")
            {
                errorLabel.Text = errmsg;
            }
        }

        private void viewLogButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo("explorer.exe");//设置运行的命令行文件问explorer.exe文件，这个文件系统会自己找到
            start.Arguments = "logs\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            start.CreateNoWindow = false;//不显示dos命令行窗口
            start.RedirectStandardOutput = true;//
            start.RedirectStandardInput = true;//
            start.UseShellExecute = false;//是否指定操作系统外壳进程启动程序
            Process p = Process.Start(start);
            General.logger.DebugFormat("Process explorer.exe starting with args {0}.", DateTime.Now.ToString("yyyyMMdd"));
            StreamReader reader = p.StandardOutput;//截取输出流
            string line = reader.ReadLine();//每次读取一行
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
            }
            p.WaitForExit();//等待程序执行完退出进程
            p.Close();//关闭进程
            reader.Close();//关闭流
        }
    }
}

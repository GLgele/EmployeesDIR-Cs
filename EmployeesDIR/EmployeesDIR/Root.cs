using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeesDIR
{
    public partial class EmployeesDIR : Form
    {
        public EmployeesDIR()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form_Closing);
        }

        private void Flush_Window()
        {
            listBox1.Items.Clear();
            foreach (Employee emp in General.employees)
            {
                listBox1.Items.Add(emp.GetInfo()[0]);
            }
            General.trans.Init(this);
        }

        public void Flush_Window(object sender, EventArgs e)
        {
            this.Flush_Window();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                //应用程序要求关闭窗口
                case CloseReason.ApplicationExitCall:
                    e.Cancel = false; //不拦截，响应操作
                    break;
                //自身窗口上的关闭按钮
                case CloseReason.FormOwnerClosing:
                    exitItem_Click(sender,e);
                    e.Cancel = true;//拦截，不响应操作
                    break;
                //MDI窗体关闭事件
                case CloseReason.MdiFormClosing:
                    exitItem_Click(sender, e);
                    e.Cancel = true;//拦截，不响应操作
                    break;
                //不明原因的关闭
                case CloseReason.None:
                    break;
                //任务管理器关闭进程
                case CloseReason.TaskManagerClosing:
                    e.Cancel = false;//不拦截，响应操作
                    break;
                //用户通过UI关闭窗口或者通过Alt+F4关闭窗口
                case CloseReason.UserClosing:
                    exitItem_Click(sender, e);
                    e.Cancel = true;//拦截，不响应操作
                    break;
                //操作系统准备关机
                case CloseReason.WindowsShutDown:
                    e.Cancel = false;//不拦截，响应操作
                    break;
                default:
                    break;
            }
            //if(e.Cancel == false)
            // base.OnFormClosing(e);
        }

        private void ConfigReload()
        {
            General.Config = AppConfig.Get();
            General.trans = new trans();
        }

        private void ConfigReload(object sender ,EventArgs e) 
        {
            ConfigReload();
            Console.WriteLine(General.Config.Language.lang);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EmployeesDIR\nVersion 3.0.0\nCopyright GLgele (c) 2022",General.title);
            //Form errorform = new ErrorForm("aaa");
            //errorform.Show();
        }

        private void EmployeesDIR_Load(object sender, EventArgs e)
        {
            General.logger.InfoFormat("Root winform loading. Event{0}",e.ToString());
#if DEBUG
            testDebugToolStripMenuItem.Enabled = true;
            debugToolStripMenuItem.Enabled = true;
            errorFormDebugToolStripMenuItem.Enabled = true;
#else
            testToolStripMenuItem.Enabled = false;
            debugToolStripMenuItem.Enabled = false;
            errorFormToolStripMenuItem.Enabled = false;
#endif
            Flush_Window();
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(General.trans.tr("Really want to exit?"), General.title, MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            General.saveData();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.AppendEmployee("name","sex","number","comment","email","edu","salary");
            Flush_Window();
        }

        private void openItem_Click(object sender, EventArgs e)
        {
            General.openData();
            Flush_Window();
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.FormClosed += ConfigReload;
            settingsForm.FormClosed += Flush_Window;
            settingsForm.Show();
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void errorFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorForm errorForm = new ErrorForm("err");
            errorForm.Show();
        }

        private void testToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            testToolStripMenuItem_Click(sender,e);
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

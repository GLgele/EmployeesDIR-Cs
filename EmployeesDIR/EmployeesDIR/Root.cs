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
        private string stat = "";
        public EmployeesDIR()
        {

            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form_Closing);
            if (Config.config.Update.autoCheck) this.Shown += new EventHandler(Config.CheckUpdate);
        }
        private void EmployeesDIR_Load(object sender, EventArgs e)
        {
            Program.logger.InfoFormat("Root winform loading. Event{0}", e.ToString());
#if DEBUG
            debugToolStripMenuItem.Available = true;
            /*testDebugToolStripMenuItem.Available = true;
            debugToolStripMenuItem.Available = true;
            errorFormDebugToolStripMenuItem.Available = true;
            loginWindowToolStripMenuItem.Available = true;*/
            //foreach (ToolStripItem item in debugToolStripMenuItem.DropDownItems) {item.Available = true;}
#else
            debugToolStripMenuItem.Available = false;
            /*testDebugToolStripMenuItem.Available = false;
            debugToolStripMenuItem.Available = false;
            errorFormDebugToolStripMenuItem.Available = false;*/
            //foreach (ToolStripItem item in debugToolStripMenuItem.DropDownItems) {item.Available = false;}
#endif
            Flush_Window();
            nameLabel.Text = "";
            sexLabel.Text = "";
            numberLabel.Text = "";
            commentLabel.Text = "";
            emailLabel.Text = "";
            eduLabel.Text = "";
            salaryLabel.Text = "";
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            confirmButton.Hide();
            cancelButton.Hide();
            editButton.Focus();
        }

        private void Flush_Window()
        {
            listBox1.Items.Clear();
            foreach (Employee emp in Program.employees)
            {
                listBox1.Items.Add(emp.GetInfo()[0]);
            }
            Program.trans.Init(this);
            nameLabel.Text = "";
            sexLabel.Text = "";
            numberLabel.Text = "";
            commentLabel.Text = "";
            emailLabel.Text = "";
            eduLabel.Text = "";
            salaryLabel.Text = "";
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
            Config.config = AppConfig.Get();
            Program.trans = new Trans();
        }

        private void ConfigReload(object sender ,EventArgs e) 
        {
            ConfigReload();
            //Console.WriteLine(General.Config.Language.lang);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"EmployeesDIR\nVersion {Config.cver.Major}.{Config.cver.Minor}.{Config.cver.Build}\nCopyright GLgele (c) 2024",Config.title);
            //Form errorform = new ErrorForm("aaa");
            //errorform.Show();
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Program.trans.tr("Really want to exit?"), Config.title, MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            Program.SaveData();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.AppendEmployee("name","sex","number","comment","email","edu","salary");
            Flush_Window();
        }

        private void openItem_Click(object sender, EventArgs e)
        {
            Program.OpenData();
            Flush_Window();
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                nameLabel.Text = Program.trans.tr("name")+": "+Program.employees[listBox1.SelectedIndex].GetInfo()[0];
                sexLabel.Text = Program.trans.tr("sex") + ": " + Program.employees[listBox1.SelectedIndex].GetInfo()[1];
                numberLabel.Text = Program.trans.tr("number") + ": " + Program.employees[listBox1.SelectedIndex].GetInfo()[2];
                commentLabel.Text = Program.trans.tr("comment") + ": " + Program.employees[listBox1.SelectedIndex].GetInfo()[3];
                emailLabel.Text = Program.trans.tr("email") + ": " + Program.employees[listBox1.SelectedIndex].GetInfo()[4];
                eduLabel.Text = Program.trans.tr("edu") + ": " + Program.employees[listBox1.SelectedIndex].GetInfo()[5];
                salaryLabel.Text = Program.trans.tr("salary") + ": " + Program.employees[listBox1.SelectedIndex].GetInfo()[6];
            }
            editButton.Focus();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                confirmButton.Show();
                cancelButton.Show();
                editButton.Hide();
                deleteButton.Hide();
                newEButton.Hide();
                nameLabel.Text = Program.trans.tr("name");
                sexLabel.Text = Program.trans.tr("sex");
                numberLabel.Text = Program.trans.tr("number");
                commentLabel.Text = Program.trans.tr("comment");
                emailLabel.Text = Program.trans.tr("email");
                eduLabel.Text = Program.trans.tr("edu");
                salaryLabel.Text = Program.trans.tr("salary");
                textBox1.Text = Program.employees[listBox1.SelectedIndex].GetInfo()[0];
                textBox2.Text = Program.employees[listBox1.SelectedIndex].GetInfo()[1];
                textBox3.Text = Program.employees[listBox1.SelectedIndex].GetInfo()[2];
                textBox4.Text = Program.employees[listBox1.SelectedIndex].GetInfo()[3];
                textBox5.Text = Program.employees[listBox1.SelectedIndex].GetInfo()[4];
                textBox6.Text = Program.employees[listBox1.SelectedIndex].GetInfo()[5];
                textBox7.Text = Program.employees[listBox1.SelectedIndex].GetInfo()[6];
            }
            stat = "edit";
            confirmButton.Focus();
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
            NewEButton_Click(sender, e);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            List<string> tmp = new List<string> { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, };
            switch (stat)
            {
                case "edit":
                    {
                        Program.employees[listBox1.SelectedIndex].ChangeInfo(tmp);
                        break;
                    }
                case "new":
                    {
                        if(tmp[0]!="") Program.AppendEmployee(tmp);
                        break;
                    }
            }
            
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            confirmButton.Hide();
            cancelButton.Hide();
            editButton.Show();
            deleteButton.Show();
            newEButton.Show();
            listBox1_SelectedIndexChanged(sender, e);
            Flush_Window();
            editButton.Focus();
        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                if (MessageBox.Show(
                        Program.trans.tr("Really want to delete: ") +
                        Program.employees[listBox1.SelectedIndex].GetInfo()[0], Config.title,
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var lst = Program.employees[listBox1.SelectedIndex].GetInfo();
                    Program.logger.InfoFormat("Deleted employee:{0},id{1};{2},{3},{4},{5},{6},{7}", lst[0], Program.employees[listBox1.SelectedIndex].GetId(), lst[1], lst[2], lst[3], lst[4], lst[5], lst[6]);
                    Program.employees.RemoveAt(listBox1.SelectedIndex);
                }
            Flush_Window();
        }

        private void NewEButton_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            textBox5.Show();
            textBox6.Show();
            textBox7.Show();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            confirmButton.Show();
            confirmButton.Focus();
            cancelButton.Show();
            editButton.Hide();
            deleteButton.Hide();
            newEButton.Hide();
            nameLabel.Text = Program.trans.tr("name");
            sexLabel.Text = Program.trans.tr("sex");
            numberLabel.Text = Program.trans.tr("number");
            commentLabel.Text = Program.trans.tr("comment");
            emailLabel.Text = Program.trans.tr("email");
            eduLabel.Text = Program.trans.tr("edu");
            salaryLabel.Text = Program.trans.tr("salary");
            stat = "new";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            confirmButton.Hide();
            cancelButton.Hide();
            editButton.Show();
            deleteButton.Show();
            newEButton.Show();
            listBox1_SelectedIndexChanged(sender, e);
            Flush_Window();
            editButton.Focus();
        }

        private void loginWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // throw new System.NotImplementedException();
           DBConnectForm loginform = new DBConnectForm();
           loginform.Show();
        }
    }
}

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
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EmployeesDIR\nVersion 3.0.0\nCopyright GLgele (c) 2022",General.title);
            Form errorform = new ErrorForm("aaa");
            errorform.Show();
        }

        private void EmployeesDIR_Load(object sender, EventArgs e)
        {
            //General.logger.LogInformation("Root winform loading. Event{0}",e.ToString());
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("真的要退出程序吗？", General.title, MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                this.Close();
                this.Dispose();
                //Application.Exit();
                //System.Environment.Exit(0);
            }
        }
    }
}

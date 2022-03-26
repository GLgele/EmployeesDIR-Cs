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
            this.Close();
            this.Dispose();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(errorLabel.Text);
            MessageBox.Show("Message copied.", General.title, MessageBoxButtons.OK);
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            if(errmsg != "")
            {
                errorLabel.Text = errmsg;
            }
        }
    }
}

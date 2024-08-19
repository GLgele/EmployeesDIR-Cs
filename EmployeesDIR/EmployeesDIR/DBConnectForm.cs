using System;
using System.Data.Entity.Core.EntityClient;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;

namespace EmployeesDIR
{
    public partial class DBConnectForm : Form
    {
        public DBConnectForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            Program.logger.DebugFormat("Login form loaded. Args: {0}",e.ToString());
            Program.trans.Init(this);
            comboBox1.SelectedItem = Config.config.Database.dbType;
            connectionStringTextBox.Text = Config.config.Database.connection;
        }

        private void pathChooseButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"SQLite database files (*.db)|*.db|SQLite database files (*.sqlite)|*.sqlite|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                connectionStringTextBox.Text = saveFileDialog.FileName;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Program.logger.Info("DbConncection form closed.");
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            Program.logger.DebugFormat(
                "Testing database connection. Connection string: {0}",
                connectionStringTextBox.Text
            );
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            Config.config.Database.dbType = comboBox1.SelectedItem.ToString();
            Config.config.Database.connection = connectionStringTextBox.Text;
            Config.SaveConfig();
            cancelButton_Click(sender,e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "SQLite":
                {
                    tabControl1.TabPages[0].Enabled = true;
                    tabControl1.TabPages[1].Enabled = false;
                    break;
                }
                case "MySQL":
                {
                    tabControl1.TabPages[0].Enabled = false;
                    tabControl1.TabPages[1].Enabled = true;
                    break;
                }
            }
        }

        private void connectionStringTextBox_TextChanged(object sender, EventArgs e)
        {
            Config.config.Database.connection = connectionStringTextBox.Text;
            Config.SaveConfig();
            Program.logger.DebugFormat("Connection string changed to {0}",connectionStringTextBox.Text);
            
        }
    }
}
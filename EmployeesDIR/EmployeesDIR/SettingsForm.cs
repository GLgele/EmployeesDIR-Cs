using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesDIR
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            General.logger.Debug("New Settings Form.");
            languageComboBox.SelectedItem = trans.langDict2[IniHelper.Read("Language", "lang", "en_us", General.iniFilePath)];
            downloadComboBox.SelectedItem = IniHelper.Read("Update", "source", "Github", General.iniFilePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            General.logger.Debug("Settings Form closed.");
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //save ini here
            //General.IniWriteVaule(General.iniFilePath, "Language", "lang", languageComboBox.SelectedText);
            //General.IniWriteVaule(General.iniFilePath, "Update", "source", downloadComboBox.SelectedText);
            //Console.WriteLine(languageComboBox.SelectedText);
            IniHelper.Write("Language", "lang", trans.langDict[languageComboBox.SelectedItem.ToString()], General.iniFilePath);
            IniHelper.Write("Update", "source", downloadComboBox.SelectedItem.ToString(),General.iniFilePath);
            cancelButton_Click(sender, e);
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

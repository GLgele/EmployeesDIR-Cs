using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeesDIR
{
    partial class DBConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sqliteTab = new System.Windows.Forms.TabPage();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.pathChooseButton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.mysqlTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.sqliteTab.SuspendLayout();
            this.mysqlTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sqliteTab);
            this.tabControl1.Controls.Add(this.mysqlTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 248);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "DNT";
            // 
            // sqliteTab
            // 
            this.sqliteTab.AutoScroll = true;
            this.sqliteTab.Controls.Add(this.connectionStringTextBox);
            this.sqliteTab.Controls.Add(this.testConnectionButton);
            this.sqliteTab.Controls.Add(this.pathChooseButton);
            this.sqliteTab.Controls.Add(this.filePathLabel);
            this.sqliteTab.Location = new System.Drawing.Point(4, 25);
            this.sqliteTab.Name = "sqliteTab";
            this.sqliteTab.Padding = new System.Windows.Forms.Padding(3);
            this.sqliteTab.Size = new System.Drawing.Size(735, 219);
            this.sqliteTab.TabIndex = 0;
            this.sqliteTab.Text = "SQLite";
            this.sqliteTab.UseVisualStyleBackColor = true;
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Location = new System.Drawing.Point(96, 6);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(630, 25);
            this.connectionStringTextBox.TabIndex = 3;
            this.connectionStringTextBox.Tag = "DNT";
            this.connectionStringTextBox.TextChanged += new System.EventHandler(this.connectionStringTextBox_TextChanged);
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(3, 70);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(161, 30);
            this.testConnectionButton.TabIndex = 2;
            this.testConnectionButton.Text = "Test Conncection";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // pathChooseButton
            // 
            this.pathChooseButton.Location = new System.Drawing.Point(3, 34);
            this.pathChooseButton.Name = "pathChooseButton";
            this.pathChooseButton.Size = new System.Drawing.Size(90, 30);
            this.pathChooseButton.TabIndex = 1;
            this.pathChooseButton.Text = "View";
            this.pathChooseButton.UseVisualStyleBackColor = true;
            this.pathChooseButton.Click += new System.EventHandler(this.pathChooseButton_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.Location = new System.Drawing.Point(6, 9);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(87, 22);
            this.filePathLabel.TabIndex = 0;
            this.filePathLabel.Text = "Path:";
            // 
            // mysqlTab
            // 
            this.mysqlTab.Controls.Add(this.label1);
            this.mysqlTab.Location = new System.Drawing.Point(4, 25);
            this.mysqlTab.Name = "mysqlTab";
            this.mysqlTab.Padding = new System.Windows.Forms.Padding(3);
            this.mysqlTab.Size = new System.Drawing.Size(735, 219);
            this.mysqlTab.TabIndex = 1;
            this.mysqlTab.Text = "MySQL";
            this.mysqlTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 213);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not done yst.";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(649, 289);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(90, 30);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(553, 289);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 30);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database type";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "SQLite", "MySQL" });
            this.comboBox1.Location = new System.Drawing.Point(167, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Tag = "DNT";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DBConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(753, 336);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "DBConnectForm";
            this.Text = "Database Settings";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tabControl1.ResumeLayout(false);
            this.sqliteTab.ResumeLayout(false);
            this.sqliteTab.PerformLayout();
            this.mysqlTab.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox connectionStringTextBox;

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button testConnectionButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Button pathChooseButton;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sqliteTab;
        private System.Windows.Forms.TabPage mysqlTab;

        #endregion
    }
}
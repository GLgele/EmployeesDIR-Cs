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
            this.pathChooseButton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.mysqlTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.sqliteTab.SuspendLayout();
            this.mysqlTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sqliteTab);
            this.tabControl1.Controls.Add(this.mysqlTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 283);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "DNT";
            // 
            // sqliteTab
            // 
            this.sqliteTab.AutoScroll = true;
            this.sqliteTab.Controls.Add(this.pathChooseButton);
            this.sqliteTab.Controls.Add(this.filePathLabel);
            this.sqliteTab.Location = new System.Drawing.Point(4, 25);
            this.sqliteTab.Name = "sqliteTab";
            this.sqliteTab.Padding = new System.Windows.Forms.Padding(3);
            this.sqliteTab.Size = new System.Drawing.Size(735, 254);
            this.sqliteTab.TabIndex = 0;
            this.sqliteTab.Text = "SQLite";
            this.sqliteTab.UseVisualStyleBackColor = true;
            // 
            // pathChooseButton
            // 
            this.pathChooseButton.Location = new System.Drawing.Point(3, 28);
            this.pathChooseButton.Name = "pathChooseButton";
            this.pathChooseButton.Size = new System.Drawing.Size(75, 23);
            this.pathChooseButton.TabIndex = 1;
            this.pathChooseButton.Text = "View";
            this.pathChooseButton.UseVisualStyleBackColor = true;
            this.pathChooseButton.Click += new System.EventHandler(this.pathChooseButton_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.Location = new System.Drawing.Point(3, 3);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(729, 22);
            this.filePathLabel.TabIndex = 0;
            this.filePathLabel.Text = "File Path:";
            // 
            // mysqlTab
            // 
            this.mysqlTab.Controls.Add(this.label1);
            this.mysqlTab.Location = new System.Drawing.Point(4, 25);
            this.mysqlTab.Name = "mysqlTab";
            this.mysqlTab.Padding = new System.Windows.Forms.Padding(3);
            this.mysqlTab.Size = new System.Drawing.Size(735, 254);
            this.mysqlTab.TabIndex = 1;
            this.mysqlTab.Text = "MySQL";
            this.mysqlTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 238);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not done yet.";
            // 
            // DBConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 275);
            this.Controls.Add(this.tabControl1);
            this.Name = "DBConnectForm";
            this.Text = "Database Connect";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tabControl1.ResumeLayout(false);
            this.sqliteTab.ResumeLayout(false);
            this.mysqlTab.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Button pathChooseButton;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sqliteTab;
        private System.Windows.Forms.TabPage mysqlTab;

        #endregion
    }
}
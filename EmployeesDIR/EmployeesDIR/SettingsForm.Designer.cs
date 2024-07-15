
namespace EmployeesDIR
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.updateLabel = new System.Windows.Forms.Label();
            this.checkUpdateButton = new System.Windows.Forms.Button();
            this.checkUpdateBox = new System.Windows.Forms.CheckBox();
            this.downloadComboBox = new System.Windows.Forms.ComboBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.dbLabel = new System.Windows.Forms.Label();
            this.dbSetButton = new System.Windows.Forms.Button();
            this.usingLabel = new System.Windows.Forms.Label();
            this.dbTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.updateLabel.Location = new System.Drawing.Point(12, 9);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(69, 19);
            this.updateLabel.TabIndex = 0;
            this.updateLabel.Text = "Update";
            this.updateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkUpdateButton
            // 
            this.checkUpdateButton.Location = new System.Drawing.Point(340, 31);
            this.checkUpdateButton.Name = "checkUpdateButton";
            this.checkUpdateButton.Size = new System.Drawing.Size(100, 28);
            this.checkUpdateButton.TabIndex = 1;
            this.checkUpdateButton.Text = "Check Now";
            this.checkUpdateButton.UseVisualStyleBackColor = true;
            this.checkUpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkUpdateBox
            // 
            this.checkUpdateBox.AutoSize = true;
            this.checkUpdateBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkUpdateBox.Location = new System.Drawing.Point(16, 31);
            this.checkUpdateBox.Name = "checkUpdateBox";
            this.checkUpdateBox.Size = new System.Drawing.Size(301, 23);
            this.checkUpdateBox.TabIndex = 3;
            this.checkUpdateBox.Text = "Check updates when starting";
            this.checkUpdateBox.UseVisualStyleBackColor = true;
            this.checkUpdateBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // downloadComboBox
            // 
            this.downloadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downloadComboBox.FormattingEnabled = true;
            this.downloadComboBox.Items.AddRange(new object[] { "Github", "Gitee" });
            this.downloadComboBox.Location = new System.Drawing.Point(186, 57);
            this.downloadComboBox.Name = "downloadComboBox";
            this.downloadComboBox.Size = new System.Drawing.Size(121, 23);
            this.downloadComboBox.TabIndex = 4;
            this.downloadComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sourceLabel.Location = new System.Drawing.Point(12, 57);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(159, 19);
            this.sourceLabel.TabIndex = 5;
            this.sourceLabel.Text = "Download Source";
            this.sourceLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(520, 391);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 30);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "Confirm";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(424, 391);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 30);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.languageLabel.Location = new System.Drawing.Point(12, 85);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(89, 19);
            this.languageLabel.TabIndex = 9;
            this.languageLabel.Text = "Language";
            this.languageLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] { "中文（简体）", "English" });
            this.languageComboBox.Location = new System.Drawing.Point(16, 107);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(155, 23);
            this.languageComboBox.TabIndex = 10;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dbLabel.Location = new System.Drawing.Point(12, 145);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(89, 19);
            this.dbLabel.TabIndex = 11;
            this.dbLabel.Text = "Database";
            // 
            // dbSetButton
            // 
            this.dbSetButton.Location = new System.Drawing.Point(12, 195);
            this.dbSetButton.Name = "dbSetButton";
            this.dbSetButton.Size = new System.Drawing.Size(159, 28);
            this.dbSetButton.TabIndex = 12;
            this.dbSetButton.Text = "Database Settings";
            this.dbSetButton.UseVisualStyleBackColor = true;
            this.dbSetButton.Click += new System.EventHandler(this.dbSetButton_Click);
            // 
            // usingLabel
            // 
            this.usingLabel.AutoSize = true;
            this.usingLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usingLabel.Location = new System.Drawing.Point(12, 173);
            this.usingLabel.Name = "usingLabel";
            this.usingLabel.Size = new System.Drawing.Size(79, 19);
            this.usingLabel.TabIndex = 13;
            this.usingLabel.Text = "Using: ";
            // 
            // dbTypeLabel
            // 
            this.dbTypeLabel.AutoSize = true;
            this.dbTypeLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dbTypeLabel.Location = new System.Drawing.Point(132, 173);
            this.dbTypeLabel.Name = "dbTypeLabel";
            this.dbTypeLabel.Size = new System.Drawing.Size(39, 19);
            this.dbTypeLabel.TabIndex = 14;
            this.dbTypeLabel.Tag = "DNT";
            this.dbTypeLabel.Text = "sql";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.dbTypeLabel);
            this.Controls.Add(this.usingLabel);
            this.Controls.Add(this.dbSetButton);
            this.Controls.Add(this.dbLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.downloadComboBox);
            this.Controls.Add(this.checkUpdateBox);
            this.Controls.Add(this.checkUpdateButton);
            this.Controls.Add(this.updateLabel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label usingLabel;

        private System.Windows.Forms.Label dbTypeLabel;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.Button dbSetButton;

        #endregion

        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Button checkUpdateButton;
        private System.Windows.Forms.CheckBox checkUpdateBox;
        private System.Windows.Forms.ComboBox downloadComboBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}
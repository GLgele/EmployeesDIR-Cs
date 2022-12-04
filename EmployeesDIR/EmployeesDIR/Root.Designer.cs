
namespace EmployeesDIR
{
    partial class EmployeesDIR
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorFormDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.eduLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newEButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.opsToolStripMenuItem,
            this.helpMenu,
            this.debugToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(466, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip2";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveItem,
            this.openItem,
            this.settingsItem,
            this.exitItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(39, 21);
            this.fileMenu.Text = "File";
            // 
            // saveItem
            // 
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(122, 22);
            this.saveItem.Text = "Save";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(122, 22);
            this.openItem.Text = "Open";
            this.openItem.Click += new System.EventHandler(this.openItem_Click);
            // 
            // settingsItem
            // 
            this.settingsItem.Name = "settingsItem";
            this.settingsItem.Size = new System.Drawing.Size(122, 22);
            this.settingsItem.Text = "Settings";
            this.settingsItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(122, 22);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // opsToolStripMenuItem
            // 
            this.opsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEmployeeToolStripMenuItem,
            this.editInfoToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.opsToolStripMenuItem.Name = "opsToolStripMenuItem";
            this.opsToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.opsToolStripMenuItem.Text = "Operations";
            this.opsToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // newEmployeeToolStripMenuItem
            // 
            this.newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            this.newEmployeeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newEmployeeToolStripMenuItem.Text = "New Employee";
            this.newEmployeeToolStripMenuItem.Click += new System.EventHandler(this.newEmployeeToolStripMenuItem_Click);
            // 
            // editInfoToolStripMenuItem
            // 
            this.editInfoToolStripMenuItem.Name = "editInfoToolStripMenuItem";
            this.editInfoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.editInfoToolStripMenuItem.Text = "Edit Info";
            this.editInfoToolStripMenuItem.Click += new System.EventHandler(this.editInfoToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(47, 21);
            this.helpMenu.Text = "Help";
            this.helpMenu.Click += new System.EventHandler(this.helpMenu_Click);
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(111, 22);
            this.aboutItem.Text = "About";
            this.aboutItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testDebugToolStripMenuItem,
            this.errorFormDebugToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // testDebugToolStripMenuItem
            // 
            this.testDebugToolStripMenuItem.Name = "testDebugToolStripMenuItem";
            this.testDebugToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.testDebugToolStripMenuItem.Text = "Test";
            this.testDebugToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click_1);
            // 
            // errorFormDebugToolStripMenuItem
            // 
            this.errorFormDebugToolStripMenuItem.Name = "errorFormDebugToolStripMenuItem";
            this.errorFormDebugToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.errorFormDebugToolStripMenuItem.Text = "ErrorForm";
            this.errorFormDebugToolStripMenuItem.Click += new System.EventHandler(this.errorFormToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(10, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 292);
            this.listBox1.TabIndex = 1;
            this.listBox1.Tag = "DNT";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(135, 306);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(169, 40);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 12);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Tag = "DNT";
            this.nameLabel.Text = "name";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(169, 64);
            this.sexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(23, 12);
            this.sexLabel.TabIndex = 4;
            this.sexLabel.Tag = "DNT";
            this.sexLabel.Text = "sex";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(169, 88);
            this.numberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(41, 12);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Tag = "DNT";
            this.numberLabel.Text = "number";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(169, 112);
            this.commentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(47, 12);
            this.commentLabel.TabIndex = 6;
            this.commentLabel.Tag = "DNT";
            this.commentLabel.Text = "comment";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(169, 136);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 12);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Tag = "DNT";
            this.emailLabel.Text = "email";
            // 
            // eduLabel
            // 
            this.eduLabel.AutoSize = true;
            this.eduLabel.Location = new System.Drawing.Point(169, 160);
            this.eduLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eduLabel.Name = "eduLabel";
            this.eduLabel.Size = new System.Drawing.Size(23, 12);
            this.eduLabel.TabIndex = 8;
            this.eduLabel.Tag = "DNT";
            this.eduLabel.Text = "edu";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(169, 184);
            this.salaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(41, 12);
            this.salaryLabel.TabIndex = 9;
            this.salaryLabel.Tag = "DNT";
            this.salaryLabel.Text = "salary";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 21);
            this.textBox1.TabIndex = 10;
            this.textBox1.Tag = "DNT";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 62);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 21);
            this.textBox2.TabIndex = 11;
            this.textBox2.Tag = "DNT";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(248, 86);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 21);
            this.textBox3.TabIndex = 12;
            this.textBox3.Tag = "DNT";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(248, 110);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 21);
            this.textBox4.TabIndex = 13;
            this.textBox4.Tag = "DNT";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(248, 134);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 21);
            this.textBox5.TabIndex = 14;
            this.textBox5.Tag = "DNT";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(248, 158);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 21);
            this.textBox6.TabIndex = 15;
            this.textBox6.Tag = "DNT";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(248, 182);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(76, 21);
            this.textBox7.TabIndex = 16;
            this.textBox7.Tag = "DNT";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(216, 276);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 17;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(297, 306);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newEButton
            // 
            this.newEButton.Location = new System.Drawing.Point(216, 306);
            this.newEButton.Name = "newEButton";
            this.newEButton.Size = new System.Drawing.Size(75, 23);
            this.newEButton.TabIndex = 19;
            this.newEButton.Text = "New";
            this.newEButton.UseVisualStyleBackColor = true;
            this.newEButton.Click += new System.EventHandler(this.NewEButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(297, 276);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EmployeesDIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 346);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newEButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.eduLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeesDIR";
            this.Text = "EmployeesDIR - 3.2";
            this.Load += new System.EventHandler(this.EmployeesDIR_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem opsToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem newEmployeeToolStripMenuItem;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ToolStripMenuItem settingsItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testDebugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorFormDebugToolStripMenuItem;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label eduLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ToolStripMenuItem editInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button newEButton;
        private System.Windows.Forms.Button cancelButton;
    }
}


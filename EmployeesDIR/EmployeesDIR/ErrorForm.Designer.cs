
namespace EmployeesDIR
{
    partial class ErrorForm
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.viewLogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(8, 8);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(247, 15);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Our program run into an error:";
            this.infoLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(8, 32);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(47, 15);
            this.errorLabel.TabIndex = 1;
            this.errorLabel.Text = "Error";
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(12, 456);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 45);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(175, 456);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(78, 45);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // viewLogButton
            // 
            this.viewLogButton.Location = new System.Drawing.Point(93, 456);
            this.viewLogButton.Name = "viewLogButton";
            this.viewLogButton.Size = new System.Drawing.Size(76, 45);
            this.viewLogButton.TabIndex = 4;
            this.viewLogButton.Text = "View log";
            this.viewLogButton.UseVisualStyleBackColor = true;
            this.viewLogButton.Click += new System.EventHandler(this.viewLogButton_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 513);
            this.Controls.Add(this.viewLogButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.infoLabel);
            this.Name = "ErrorForm";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button viewLogButton;
    }
}

namespace Payroll_Management_System
{
    partial class ChangePassword
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.newpasswordTextbox = new System.Windows.Forms.TextBox();
            this.changePasswordgroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.changePasswordgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(102, 82);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(88, 24);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Username";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(65, 128);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(125, 24);
            this.newPasswordLabel.TabIndex = 1;
            this.newPasswordLabel.Text = "New password";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(38, 188);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(152, 24);
            this.confirmPasswordLabel.TabIndex = 2;
            this.confirmPasswordLabel.Text = "Confirm password";
            this.confirmPasswordLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(260, 79);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(168, 30);
            this.usernameTextbox.TabIndex = 3;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(168, 30);
            this.textBox2.TabIndex = 4;
            // 
            // newpasswordTextbox
            // 
            this.newpasswordTextbox.Location = new System.Drawing.Point(260, 128);
            this.newpasswordTextbox.Name = "newpasswordTextbox";
            this.newpasswordTextbox.PasswordChar = '*';
            this.newpasswordTextbox.Size = new System.Drawing.Size(168, 30);
            this.newpasswordTextbox.TabIndex = 5;
            // 
            // changePasswordgroupBox
            // 
            this.changePasswordgroupBox.Controls.Add(this.saveButton);
            this.changePasswordgroupBox.Controls.Add(this.newpasswordTextbox);
            this.changePasswordgroupBox.Controls.Add(this.userNameLabel);
            this.changePasswordgroupBox.Controls.Add(this.textBox2);
            this.changePasswordgroupBox.Controls.Add(this.newPasswordLabel);
            this.changePasswordgroupBox.Controls.Add(this.usernameTextbox);
            this.changePasswordgroupBox.Controls.Add(this.confirmPasswordLabel);
            this.changePasswordgroupBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordgroupBox.Location = new System.Drawing.Point(66, 62);
            this.changePasswordgroupBox.Name = "changePasswordgroupBox";
            this.changePasswordgroupBox.Size = new System.Drawing.Size(497, 327);
            this.changePasswordgroupBox.TabIndex = 6;
            this.changePasswordgroupBox.TabStop = false;
            this.changePasswordgroupBox.Text = "ChangePassword";
            this.changePasswordgroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(260, 252);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 38);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changePasswordgroupBox);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassword_FormClosing);
            this.changePasswordgroupBox.ResumeLayout(false);
            this.changePasswordgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox newpasswordTextbox;
        private System.Windows.Forms.GroupBox changePasswordgroupBox;
        private System.Windows.Forms.Button saveButton;
    }
}
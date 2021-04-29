
namespace Payroll_Management_System
{
    partial class LogInForm
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTextbox1 = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.LogIngroupBox = new System.Windows.Forms.GroupBox();
            this.logInbutton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.LogIngroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(62, 59);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(88, 24);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(62, 118);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 24);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // userNameTextbox1
            // 
            this.userNameTextbox1.Location = new System.Drawing.Point(166, 56);
            this.userNameTextbox1.Name = "userNameTextbox1";
            this.userNameTextbox1.Size = new System.Drawing.Size(150, 30);
            this.userNameTextbox1.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(166, 118);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(150, 30);
            this.passwordTextbox.TabIndex = 3;
            // 
            // LogIngroupBox
            // 
            this.LogIngroupBox.Controls.Add(this.createAccountButton);
            this.LogIngroupBox.Controls.Add(this.logInbutton);
            this.LogIngroupBox.Controls.Add(this.userNameTextbox1);
            this.LogIngroupBox.Controls.Add(this.passwordTextbox);
            this.LogIngroupBox.Controls.Add(this.userNameLabel);
            this.LogIngroupBox.Controls.Add(this.passwordLabel);
            this.LogIngroupBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIngroupBox.Location = new System.Drawing.Point(42, 74);
            this.LogIngroupBox.Name = "LogIngroupBox";
            this.LogIngroupBox.Size = new System.Drawing.Size(460, 284);
            this.LogIngroupBox.TabIndex = 4;
            this.LogIngroupBox.TabStop = false;
            this.LogIngroupBox.Text = "LogIn";
            this.LogIngroupBox.Enter += new System.EventHandler(this.LogIngroupBox_Enter);
            // 
            // logInbutton
            // 
            this.logInbutton.Location = new System.Drawing.Point(85, 186);
            this.logInbutton.Name = "logInbutton";
            this.logInbutton.Size = new System.Drawing.Size(107, 39);
            this.logInbutton.TabIndex = 4;
            this.logInbutton.Text = "Log In";
            this.logInbutton.UseVisualStyleBackColor = true;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(219, 186);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(159, 39);
            this.createAccountButton.TabIndex = 5;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.LogIngroupBox);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInForm_FormClosing);
            this.LogIngroupBox.ResumeLayout(false);
            this.LogIngroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameTextbox1;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.GroupBox LogIngroupBox;
        private System.Windows.Forms.Button logInbutton;
        private System.Windows.Forms.Button createAccountButton;
    }
}
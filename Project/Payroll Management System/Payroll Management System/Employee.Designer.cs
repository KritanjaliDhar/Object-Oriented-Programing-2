
namespace Payroll_Management_System
{
    partial class EmployeeForm
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
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.userNameTextbox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.payMethodLabel = new System.Windows.Forms.Label();
            this.positionTextbox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.dateHiredLabel = new System.Windows.Forms.Label();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.dailyRateTextbox = new System.Windows.Forms.TextBox();
            this.dailyRateLabel = new System.Windows.Forms.Label();
            this.contactNoTextbox = new System.Windows.Forms.TextBox();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.activeStatusLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.GroupBox();
            this.statusCombobox = new System.Windows.Forms.ComboBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activeStatusComboBox = new System.Windows.Forms.ComboBox();
            this.payMethodComboBox = new System.Windows.Forms.ComboBox();
            this.dateHiredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.assignedCodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.assignCodeLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedCodeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(54, 141);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(74, 24);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(135, 138);
            this.addressTextbox.Multiline = true;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(148, 105);
            this.addressTextbox.TabIndex = 1;
            this.addressTextbox.TextChanged += new System.EventHandler(this.addressTextbox_TextChanged);
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(454, 47);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(140, 30);
            this.lastNameTextbox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(334, 47);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 24);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last name";
            // 
            // userNameTextbox
            // 
            this.userNameTextbox.Location = new System.Drawing.Point(767, 47);
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.Size = new System.Drawing.Size(142, 30);
            this.userNameTextbox.TabIndex = 7;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(642, 47);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(95, 24);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "User Name";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(134, 102);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(148, 30);
            this.firstNameTextbox.TabIndex = 9;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(36, 102);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(91, 24);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = "First name";
            // 
            // payMethodLabel
            // 
            this.payMethodLabel.AutoSize = true;
            this.payMethodLabel.Location = new System.Drawing.Point(16, 164);
            this.payMethodLabel.Name = "payMethodLabel";
            this.payMethodLabel.Size = new System.Drawing.Size(102, 24);
            this.payMethodLabel.TabIndex = 12;
            this.payMethodLabel.Text = "Pay Method";
            // 
            // positionTextbox
            // 
            this.positionTextbox.Location = new System.Drawing.Point(443, 41);
            this.positionTextbox.Name = "positionTextbox";
            this.positionTextbox.Size = new System.Drawing.Size(140, 30);
            this.positionTextbox.TabIndex = 17;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(352, 44);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(73, 24);
            this.positionLabel.TabIndex = 16;
            this.positionLabel.Text = "Position";
            this.positionLabel.Click += new System.EventHandler(this.positionLabel_Click);
            // 
            // dateHiredLabel
            // 
            this.dateHiredLabel.AutoSize = true;
            this.dateHiredLabel.Location = new System.Drawing.Point(650, 41);
            this.dateHiredLabel.Name = "dateHiredLabel";
            this.dateHiredLabel.Size = new System.Drawing.Size(91, 24);
            this.dateHiredLabel.TabIndex = 18;
            this.dateHiredLabel.Text = "Date Hired";
            this.dateHiredLabel.Click += new System.EventHandler(this.dateHiredLabel_Click);
            // 
            // ageTextbox
            // 
            this.ageTextbox.Location = new System.Drawing.Point(454, 267);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(39, 30);
            this.ageTextbox.TabIndex = 21;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(396, 272);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(40, 24);
            this.ageLabel.TabIndex = 20;
            this.ageLabel.Text = "Age";
            // 
            // dailyRateTextbox
            // 
            this.dailyRateTextbox.Location = new System.Drawing.Point(124, 44);
            this.dailyRateTextbox.Name = "dailyRateTextbox";
            this.dailyRateTextbox.Size = new System.Drawing.Size(148, 30);
            this.dailyRateTextbox.TabIndex = 25;
            // 
            // dailyRateLabel
            // 
            this.dailyRateLabel.AutoSize = true;
            this.dailyRateLabel.Location = new System.Drawing.Point(30, 44);
            this.dailyRateLabel.Name = "dailyRateLabel";
            this.dailyRateLabel.Size = new System.Drawing.Size(88, 24);
            this.dailyRateLabel.TabIndex = 24;
            this.dailyRateLabel.Text = "Daily Rate";
            // 
            // contactNoTextbox
            // 
            this.contactNoTextbox.Location = new System.Drawing.Point(454, 150);
            this.contactNoTextbox.Name = "contactNoTextbox";
            this.contactNoTextbox.Size = new System.Drawing.Size(140, 30);
            this.contactNoTextbox.TabIndex = 27;
            // 
            // contactNoLabel
            // 
            this.contactNoLabel.AutoSize = true;
            this.contactNoLabel.Location = new System.Drawing.Point(334, 153);
            this.contactNoLabel.Name = "contactNoLabel";
            this.contactNoLabel.Size = new System.Drawing.Size(102, 24);
            this.contactNoLabel.TabIndex = 26;
            this.contactNoLabel.Text = "Contact No.";
            // 
            // activeStatusLabel
            // 
            this.activeStatusLabel.AutoSize = true;
            this.activeStatusLabel.Location = new System.Drawing.Point(366, 164);
            this.activeStatusLabel.Name = "activeStatusLabel";
            this.activeStatusLabel.Size = new System.Drawing.Size(59, 24);
            this.activeStatusLabel.TabIndex = 28;
            this.activeStatusLabel.Text = "Status";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.Controls.Add(this.assignedCodeNumericUpDown);
            this.dateOfBirthLabel.Controls.Add(this.assignCodeLabel);
            this.dateOfBirthLabel.Controls.Add(this.statusCombobox);
            this.dateOfBirthLabel.Controls.Add(this.dateOfBirthDateTimePicker);
            this.dateOfBirthLabel.Controls.Add(this.femaleRadioButton);
            this.dateOfBirthLabel.Controls.Add(this.maleRadioButton);
            this.dateOfBirthLabel.Controls.Add(this.label1);
            this.dateOfBirthLabel.Controls.Add(this.genderLabel);
            this.dateOfBirthLabel.Controls.Add(this.statusLabel);
            this.dateOfBirthLabel.Controls.Add(this.firstNameTextbox);
            this.dateOfBirthLabel.Controls.Add(this.FirstNameLabel);
            this.dateOfBirthLabel.Controls.Add(this.lastNameTextbox);
            this.dateOfBirthLabel.Controls.Add(this.ageTextbox);
            this.dateOfBirthLabel.Controls.Add(this.ageLabel);
            this.dateOfBirthLabel.Controls.Add(this.contactNoTextbox);
            this.dateOfBirthLabel.Controls.Add(this.contactNoLabel);
            this.dateOfBirthLabel.Controls.Add(this.lastNameLabel);
            this.dateOfBirthLabel.Controls.Add(this.userNameTextbox);
            this.dateOfBirthLabel.Controls.Add(this.userNameLabel);
            this.dateOfBirthLabel.Controls.Add(this.addressTextbox);
            this.dateOfBirthLabel.Controls.Add(this.addressLabel);
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(22, 30);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(941, 321);
            this.dateOfBirthLabel.TabIndex = 30;
            this.dateOfBirthLabel.TabStop = false;
            this.dateOfBirthLabel.Text = "Personal Information";
            this.dateOfBirthLabel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // statusCombobox
            // 
            this.statusCombobox.FormattingEnabled = true;
            this.statusCombobox.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Others"});
            this.statusCombobox.Location = new System.Drawing.Point(767, 148);
            this.statusCombobox.Name = "statusCombobox";
            this.statusCombobox.Size = new System.Drawing.Size(142, 32);
            this.statusCombobox.TabIndex = 34;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.CustomFormat = "dd MMM yyyy ";
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(786, 265);
            this.dateOfBirthDateTimePicker.MaxDate = new System.DateTime(2021, 4, 29, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(138, 30);
            this.dateOfBirthDateTimePicker.TabIndex = 33;
            this.dateOfBirthDateTimePicker.Value = new System.DateTime(2021, 4, 29, 0, 0, 0, 0);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(197, 270);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(86, 28);
            this.femaleRadioButton.TabIndex = 32;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(134, 270);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(67, 28);
            this.maleRadioButton.TabIndex = 31;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Date of birth";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(61, 272);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(67, 24);
            this.genderLabel.TabIndex = 29;
            this.genderLabel.Text = "Gender";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(693, 151);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(59, 24);
            this.statusLabel.TabIndex = 28;
            this.statusLabel.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activeStatusComboBox);
            this.groupBox1.Controls.Add(this.payMethodComboBox);
            this.groupBox1.Controls.Add(this.dateHiredDateTimePicker);
            this.groupBox1.Controls.Add(this.dailyRateTextbox);
            this.groupBox1.Controls.Add(this.dailyRateLabel);
            this.groupBox1.Controls.Add(this.positionTextbox);
            this.groupBox1.Controls.Add(this.activeStatusLabel);
            this.groupBox1.Controls.Add(this.positionLabel);
            this.groupBox1.Controls.Add(this.dateHiredLabel);
            this.groupBox1.Controls.Add(this.payMethodLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 211);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work Information";
            // 
            // activeStatusComboBox
            // 
            this.activeStatusComboBox.FormattingEnabled = true;
            this.activeStatusComboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.activeStatusComboBox.Location = new System.Drawing.Point(443, 156);
            this.activeStatusComboBox.Name = "activeStatusComboBox";
            this.activeStatusComboBox.Size = new System.Drawing.Size(140, 32);
            this.activeStatusComboBox.TabIndex = 36;
            // 
            // payMethodComboBox
            // 
            this.payMethodComboBox.FormattingEnabled = true;
            this.payMethodComboBox.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.payMethodComboBox.Location = new System.Drawing.Point(124, 156);
            this.payMethodComboBox.Name = "payMethodComboBox";
            this.payMethodComboBox.Size = new System.Drawing.Size(148, 32);
            this.payMethodComboBox.TabIndex = 35;
            // 
            // dateHiredDateTimePicker
            // 
            this.dateHiredDateTimePicker.CustomFormat = "dd MMM yyyy ";
            this.dateHiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHiredDateTimePicker.Location = new System.Drawing.Point(775, 44);
            this.dateHiredDateTimePicker.MaxDate = new System.DateTime(2021, 4, 29, 0, 0, 0, 0);
            this.dateHiredDateTimePicker.Name = "dateHiredDateTimePicker";
            this.dateHiredDateTimePicker.Size = new System.Drawing.Size(138, 30);
            this.dateHiredDateTimePicker.TabIndex = 34;
            this.dateHiredDateTimePicker.Value = new System.DateTime(2021, 4, 29, 0, 0, 0, 0);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(180, 630);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(155, 64);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(461, 630);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(155, 64);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(741, 630);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(155, 64);
            this.newButton.TabIndex = 34;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // assignedCodeNumericUpDown
            // 
            this.assignedCodeNumericUpDown.Location = new System.Drawing.Point(173, 47);
            this.assignedCodeNumericUpDown.Name = "assignedCodeNumericUpDown";
            this.assignedCodeNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.assignedCodeNumericUpDown.TabIndex = 36;
            this.assignedCodeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // assignCodeLabel
            // 
            this.assignCodeLabel.AutoSize = true;
            this.assignCodeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCodeLabel.Location = new System.Drawing.Point(27, 47);
            this.assignCodeLabel.Name = "assignCodeLabel";
            this.assignCodeLabel.Size = new System.Drawing.Size(109, 24);
            this.assignCodeLabel.TabIndex = 35;
            this.assignCodeLabel.Text = "Assign Code";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 840);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.dateOfBirthLabel.ResumeLayout(false);
            this.dateOfBirthLabel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedCodeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox userNameTextbox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label payMethodLabel;
        private System.Windows.Forms.TextBox positionTextbox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label dateHiredLabel;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox dailyRateTextbox;
        private System.Windows.Forms.Label dailyRateLabel;
        private System.Windows.Forms.TextBox contactNoTextbox;
        private System.Windows.Forms.Label contactNoLabel;
        private System.Windows.Forms.Label activeStatusLabel;
        private System.Windows.Forms.GroupBox dateOfBirthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.ComboBox statusCombobox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateHiredDateTimePicker;
        private System.Windows.Forms.ComboBox activeStatusComboBox;
        private System.Windows.Forms.ComboBox payMethodComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.NumericUpDown assignedCodeNumericUpDown;
        private System.Windows.Forms.Label assignCodeLabel;
    }
}


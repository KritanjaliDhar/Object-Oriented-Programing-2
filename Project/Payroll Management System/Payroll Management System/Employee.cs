using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void positionLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateHiredLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (firstNameTextbox.Text == "")
            {
                MessageBox.Show("Give first name");
            }
            else if (lastNameTextbox.Text == "")
            {
                MessageBox.Show("Give last name");
            }
            else if (userNameTextbox.Text == "")
            {
                MessageBox.Show("Give username");
            }
            else if (addressTextbox.Text == "")
            {
                MessageBox.Show("Give address");
            }
            else if (contactNoTextbox.Text == "")
            {
                MessageBox.Show("Give contact number");
            }
            else if (statusCombobox.Text == "")
            {
                MessageBox.Show("Select status");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Select gender");
            }
            else if (ageTextbox.Text=="")
            {
                MessageBox.Show("Give age");
            }
            else if (dateOfBirthDateTimePicker.Text == "")
            {
                MessageBox.Show("Give date of birth");
            }
           
            else if (dailyRateTextbox.Text == "")
            {
                MessageBox.Show("Give daily rate");
            }
            else if (positionTextbox.Text == "")
            {
                MessageBox.Show("Give position");
            }
            else if (dailyRateTextbox.Text == "")
            {
                MessageBox.Show("Give daily rate");
            }
            else if (dateHiredDateTimePicker.Text == "")
            {
                MessageBox.Show("Give hired date");
            }
            else if (activeStatusComboBox.Text == "")
            {
                MessageBox.Show("Select active status");
            }
            else if (payMethodComboBox.Text == "")
            {
                MessageBox.Show("Select pay method");
            }
            else
            {  
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                    connection.Open();
                    string gender = "";
                    if (maleRadioButton.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    string sql = "INSERT INTO Employees(AssignedCode,FirstName,LastName,Username,Address,ContactNo,Status,Gender,Age,DateOfBirth,DailyRate,Position,HiredDate,PayMethod,ActiveStatus) VALUES('"+assignedCodeNumericUpDown.Value+"','" + firstNameTextbox.Text + "','" + lastNameTextbox.Text + "','" + userNameTextbox.Text + "','" + addressTextbox.Text + "','"+Convert.ToInt32(contactNoTextbox.Text)+"','" + statusCombobox.Text + "','" + gender + "','" + Convert.ToInt32(ageTextbox.Text)+ "','" + dateOfBirthDateTimePicker.Text + "','" + Convert.ToDouble(dailyRateTextbox.Text) + "','" + positionTextbox.Text + "','" + dateHiredDateTimePicker.Text + "','" + payMethodComboBox.Text + "','" + activeStatusComboBox.Text + "')";
                    SqlCommand command = new SqlCommand(sql, connection);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("User added");
                       

                    }
                    else
                    {
                        MessageBox.Show("Error");
                        connection.Close();
                    }
                

            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

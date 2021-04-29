using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System
{
    public partial class GenerateSalary : Form
    {
        public GenerateSalary()
        {
            InitializeComponent();
            netIncomeTextbox.Text = "0";
            cashAdvanceTextbox.Text = "0";
            totalTextbox.Text = "0";
        }

        private void GenerateSalary_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void netIncomeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateSalary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void assignCodeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

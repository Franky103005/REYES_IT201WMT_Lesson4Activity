using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REYES_IT201WMT_Lesson4Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Employee Number
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //Number of Dependents
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //Department
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //cancel
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox18.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox19.Clear();
            textBox20.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //First Name
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Middle Name
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Surname
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Civil Status
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Designation
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Paydate
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //Employee Status
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Browse
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select Employee Picture";
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //Basic Pay (Rate/Hour)
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //Basic Pay (No. of hours/cut off)
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //Basic Pay (Income per cut off)
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            //Honorarium (Rate/Hour)
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            //Honorarium (No. of hours/cut off)
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            //Honorarium (Total Honorarium Pay)
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            //Other Income (Rate/Hour)
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            //Other Income (No. of hours/cut off)
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            //Other Income (Total Other Income)
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            //Gross Pay
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            //net Pay
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            //SSS Contribution
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            //PhilHealth Contribution
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            //Pag-IBIG Contribution
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            //Tax
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            //SSS Loan
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            //Pag-IBIG Loan
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            //Faculty Saving Deposit
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            //Faculty Saving Loan
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            //Salary Loan
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //other
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            //other
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            //Total Deductions
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Compute
            if (textBox10.Text == "" ||   // Basic Pay Rate/Hour
       textBox11.Text == "" ||   // Basic Pay Hours
       textBox15.Text == "" ||   // Honorarium Rate/Hour
       textBox14.Text == "" ||   // Honorarium Hours
       textBox18.Text == "" ||   // Other Income Rate/Hour
       textBox17.Text == "")     // Other Income Hours
            {
                MessageBox.Show("Please complete all required fields before calculating.");
                return;
            }

            // BASIC PAY VALIDATION
            if (!double.TryParse(textBox10.Text, out double basicRate))
            {
                MessageBox.Show("Invalid input in Basic Pay Rate/Hour. Numbers only.");
                textBox10.Clear();
                textBox10.Focus();
                return;
            }
            else if (!double.TryParse(textBox11.Text, out double basicHours))
            {
                MessageBox.Show("Invalid input in Basic Pay Hours. Numbers only.");
                textBox11.Clear();
                textBox11.Focus();
                return;
            }

            // HONORARIUM VALIDATION
            else if (!double.TryParse(textBox15.Text, out double honorRate))
            {
                MessageBox.Show("Invalid input in Honorarium Rate/Hour. Numbers only.");
                textBox15.Clear();
                textBox15.Focus();
                return;
            }
            else if (!double.TryParse(textBox14.Text, out double honorHours))
            {
                MessageBox.Show("Invalid input in Honorarium Hours. Numbers only.");
                textBox14.Clear();
                textBox14.Focus();
                return;
            }

            // OTHER INCOME VALIDATION
            else if (!double.TryParse(textBox18.Text, out double otherRate))
            {
                MessageBox.Show("Invalid input in Other Income Rate/Hour. Numbers only.");
                textBox18.Clear();
                textBox18.Focus();
                return;
            }
            else if (!double.TryParse(textBox17.Text, out double otherHours))
            {
                MessageBox.Show("Invalid input in Other Income Hours. Numbers only.");
                textBox17.Clear();
                textBox17.Focus();
                return;
            }
            else
            {
                // COMPUTATIONS
                double basicIncome = basicRate * basicHours;
                double honorIncome = honorRate * honorHours;
                double otherIncome = otherRate * otherHours;

                double grossPay = basicIncome + honorIncome + otherIncome;

                // DISPLAY RESULTS
                textBox12.Text = basicIncome.ToString();
                textBox13.Text = honorIncome.ToString();
                textBox16.Text = otherIncome.ToString();
                textBox19.Text = grossPay.ToString();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    ((TextBox)ctr).Clear();
            }

            // Reset DatePicker
            dateTimePicker1.Value = DateTime.Now;

            // Reset PictureBox
            pictureBox1.Image = null;

            // If ComboBoxes exist
            comboBox1.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //print pay slip
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Preview Pay Slip details

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Exit
            Application.Exit();
        }
    }
}

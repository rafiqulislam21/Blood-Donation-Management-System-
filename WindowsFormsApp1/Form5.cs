using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        Thread objt; //object of multithreading 

        public Form5()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter User Name .");
                if (textBox2.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Password Number .");
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("\nPlease Enter First Name .");
                        if (textBox4.Text == "")
                        {
                            MessageBox.Show("\nPlease Enter Last Name .");
                            if (textBox5.Text == "")
                            {
                                MessageBox.Show("\nPlease Enter Mobile Number .");
                                if (textBox6.Text == "")
                                {
                                    MessageBox.Show("\nPlease Enter Email Address .");
                                    if (textBox8.Text == "")
                                    {
                                        MessageBox.Show("\nPlease Enter Street Name.");
                                        if (textBox9.Text == "")
                                        {
                                            MessageBox.Show("\nPlease Enter Building No .");
                                            if (textBox10.Text == "")
                                            {
                                                MessageBox.Show("\nPlease Enter City .");
                                                if (textBox11.Text == "")
                                                {
                                                    MessageBox.Show("\nPlease Enter Zip .");
                                                    if (bloodGroup.Text == "Select")
                                                    {
                                                        MessageBox.Show("\nPlease Enter Blood Group .");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }


            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("\nPlease Enter Password Number .");
                if (textBox3.Text == "")
                {
                    MessageBox.Show("\nPlease Enter First Name .");
                    if (textBox4.Text == "")
                    {
                        MessageBox.Show("\nPlease Enter Last Name .");
                        if (textBox5.Text == "")
                        {
                            MessageBox.Show("\nPlease Enter Mobile Number .");
                            if (textBox6.Text == "")
                            {
                                MessageBox.Show("\nPlease Enter Email Address .");
                                if (textBox8.Text == "")
                                {
                                    MessageBox.Show("\nPlease Enter Street Name.");
                                    if (textBox9.Text == "")
                                    {
                                        MessageBox.Show("\nPlease Enter Building No .");
                                        if (textBox10.Text == "")
                                        {
                                            MessageBox.Show("\nPlease Enter City .");
                                            if (textBox11.Text == "")
                                            {
                                                MessageBox.Show("\nPlease Enter Zip .");
                                                if (bloodGroup.Text == "Select")
                                                {
                                                    MessageBox.Show("\nPlease Enter Blood Group .");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("\nPlease Enter First Name .");
                if (textBox4.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Last Name .");
                    if (textBox5.Text == "")
                    {
                        MessageBox.Show("\nPlease Enter Mobile Number .");
                        if (textBox6.Text == "")
                        {
                            MessageBox.Show("\nPlease Enter Email Address .");
                            if (textBox8.Text == "")
                            {
                                MessageBox.Show("\nPlease Enter Street Name.");
                                if (textBox9.Text == "")
                                {
                                    MessageBox.Show("\nPlease Enter Building No .");
                                    if (textBox10.Text == "")
                                    {
                                        MessageBox.Show("\nPlease Enter City .");
                                        if (textBox11.Text == "")
                                        {
                                            MessageBox.Show("\nPlease Enter Zip .");
                                            if (bloodGroup.Text == "Select")
                                            {
                                                MessageBox.Show("\nPlease Enter Blood Group .");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("\nPlease Enter Last Name .");
                if (textBox5.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Mobile Number .");
                    if (textBox6.Text == "")
                    {
                        MessageBox.Show("\nPlease Enter Email Address .");
                        if (textBox8.Text == "")
                        {
                            MessageBox.Show("\nPlease Enter Street Name.");
                            if (textBox9.Text == "")
                            {
                                MessageBox.Show("\nPlease Enter Building No .");
                                if (textBox10.Text == "")
                                {
                                    MessageBox.Show("\nPlease Enter City .");
                                    if (textBox11.Text == "")
                                    {
                                        MessageBox.Show("\nPlease Enter Zip .");
                                        if (bloodGroup.Text == "Select")
                                        {
                                            MessageBox.Show("\nPlease Enter Blood Group .");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("\nPlease Enter Mobile Number .");
                if (textBox6.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Email Address .");
                    if (textBox8.Text == "")
                    {
                        MessageBox.Show("\nPlease Enter Street Name.");
                        if (textBox9.Text == "")
                        {
                            MessageBox.Show("\nPlease Enter Building No .");
                            if (textBox10.Text == "")
                            {
                                MessageBox.Show("\nPlease Enter City .");
                                if (textBox11.Text == "")
                                {
                                    MessageBox.Show("\nPlease Enter Zip .");
                                    if (bloodGroup.Text == "Select")
                                    {
                                        MessageBox.Show("\nPlease Enter Blood Group .");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("\nPlease Enter Email Address .");
                if (textBox8.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Street Name.");
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("\nPlease Enter Building No .");
                        if (textBox10.Text == "")
                        {
                            MessageBox.Show("\nPlease Enter City .");
                            if (textBox11.Text == "")
                            {
                                MessageBox.Show("\nPlease Enter Zip .");
                                if (bloodGroup.Text == "Select")
                                {
                                    MessageBox.Show("\nPlease Enter Blood Group .");
                                }
                            }
                        }
                    }
                }
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("\nPlease Enter Street Name.");
                if (textBox9.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Building No .");
                    if (textBox10.Text == "")
                    {
                        MessageBox.Show("\nPlease Enter City .");
                        if (textBox11.Text == "")
                        {
                            MessageBox.Show("\nPlease Enter Zip .");
                            if (bloodGroup.Text == "Select")
                            {
                                MessageBox.Show("\nPlease Enter Blood Group .");
                            }
                        }
                    }
                }
            }
            else if (textBox9.Text == "")
            {
                MessageBox.Show("\nPlease Enter Building No .");
                if (textBox10.Text == "")
                {
                    MessageBox.Show("\nPlease Enter City .");
                    if (textBox11.Text == "")
                    {
                        MessageBox.Show("\nPlease Enter Zip .");
                        if (bloodGroup.Text == "Select")
                        {
                            MessageBox.Show("\nPlease Enter Blood Group .");
                        }
                    }
                }
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("\nPlease Enter City .");
                if (textBox11.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Zip .");
                    if (bloodGroup.Text == "Select")
                    {
                        MessageBox.Show("\nPlease Enter Blood Group .");
                    }
                }
            }
            else if (textBox11.Text == "")
            {
                MessageBox.Show("\nPlease Enter Zip .");
                if (bloodGroup.Text == "Select")
                {
                    MessageBox.Show("\nPlease Enter Blood Group .");
                }
            }
            else if (bloodGroup.Text == "Select")
            {
                MessageBox.Show("\nPlease Enter Blood Group .");
            }

            
            else
            {

                MessageBox.Show("SignUp done successfully !");
                this.Close();
                objt = new Thread(openform2);
                objt.SetApartmentState(ApartmentState.STA);
                objt.Start();
            }
        }
        private void openform1()
        {
            form1 f1 = new form1();
            Application.Run(f1);
        }


        private void openform2()
        {
            Form2 f2 = new Form2();
            Application.Run(f2);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            
            objt = new Thread(openform1);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
            this.Close();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

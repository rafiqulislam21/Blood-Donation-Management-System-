using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //for using multithreading


namespace WindowsFormsApp1
{
   
    public partial class Form8 : Form
    {
        Thread objt;
        
         public Form8()
        {
            InitializeComponent();
        }
        private void openform4()
        {
            Form4 f4 = new Form4();
            Application.Run(f4);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            //obj = new Thread(openform4);
            //obj.SetApartmentState(ApartmentState.STA);
            //obj.Start();
        }

        private void btnaddemp_Click(object sender, EventArgs e)
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
                                                    if (bloodG.Text == "Select")
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
                                                if (bloodG.Text == "Select")
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
                                            if (bloodG.Text == "Select")
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
                                        if (bloodG.Text == "Select")
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
                                    if (bloodG.Text == "Select")
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
                                if (bloodG.Text == "Select")
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
                            if (bloodG.Text == "Select")
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
                        if (bloodG.Text == "Select")
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
                    if (bloodG.Text == "Select")
                    {
                        MessageBox.Show("\nPlease Enter Blood Group .");
                    }
                }
            }
            else if (textBox11.Text == "")
            {
                MessageBox.Show("\nPlease Enter Zip .");
                if (bloodG.Text == "Select")
                {
                    MessageBox.Show("\nPlease Enter Blood Group .");
                }
            }
            else if (bloodG.Text == "Select")
            {
                MessageBox.Show("\nPlease Enter Blood Group .");
            }


            else
            {

                MessageBox.Show("New Donor Added !");
                this.Close();
                //objt = new Thread(openform2);
                //objt.SetApartmentState(ApartmentState.STA);
                //objt.Start();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    
    public partial class form1 : Form
    {
        public static string User;
        public static string Pass;
        Thread obj;
        
        
        public form1()
        {
            InitializeComponent();
        }
        
        public void openform5()
        {
            Form5 f5 = new Form5();
            Application.Run(f5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new Thread(openform5);
            obj.SetApartmentState(ApartmentState.STA);
            obj.Start();
            this.Close();
        }
        private void openform2()
        {
            Form2 f2 = new Form2();
            Application.Run(f2);
        }
        private void openform4()
        {
            Form4 f4 = new Form4();
            Application.Run(f4);
        }

        private void openform11()
        {
            Form11 f11 = new Form11();
            Application.Run(f11);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txtusername.Text == "")
            {
                MessageBox.Show("Please Enter Username !");
                if (txtpassword.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Password !");
                    if (!radioButton1.Checked && !radioButton2.Checked)
                    {
                        MessageBox.Show("\nPlease select user type !");
                    }
                }
                

            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("\nPlease Enter Password !");
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("\nPlease select user type !");
                }
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("\nPlease select user type !");
            }
            // else if (!radioButton1.Checked)
            // {
            //    MessageBox.Show("\nPlease select user type !");
            // }

            else
            {   
                if(radioButton1.Checked)
                {
                    
                    //int records = 0;
                    User = txtusername.Text;
                    Pass = txtpassword.Text;

                    //MessageBox.Show(records.ToString());
                    if ((User == "admin" && Pass =="12345678") || (User == "Admin" && Pass == "12345678"))
                    {
                        MessageBox.Show("Login Successfully Done !");

                        this.Close();
                        obj = new Thread(openform4);
                        obj.SetApartmentState(ApartmentState.STA);
                        obj.Start();
                         
                    }
                    else
                    {

                        MessageBox.Show("User name or Password in incorrect. \n Please try again.");
                    }
                }
                else if(radioButton2.Checked)
                {
                    
                    User = txtusername.Text;
                    Pass = txtpassword.Text;
                    //int records2 = 0;

                    //MessageBox.Show(records.ToString());
                    if (User == "donor" && Pass == "12345678")
                    {
                        MessageBox.Show("Login Successfully Done !");

                        this.Close();
                        obj = new Thread(openform2);
                        obj.SetApartmentState(ApartmentState.STA);
                        obj.Start();
                       
                    }
                    else
                    {
                        MessageBox.Show("User name or Password in incorrect. \n Please try again.");
                    }
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            obj = new Thread(openform11);
            obj.SetApartmentState(ApartmentState.STA);
            obj.Start();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

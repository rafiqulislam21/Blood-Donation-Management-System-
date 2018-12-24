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
    public partial class Form11 : Form
    {
        public static string found = "";

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        Thread obj;
        public Form11()
        {
            InitializeComponent();
        }

        private void openform1()
        {
            form1 f1 = new form1();
            Application.Run(f1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] drowVal1 = { "Nafees Adil", "01605679325", "naffy@gmail.com", "A+" };
            donorList.Rows.Add(drowVal1);
            String[] drowVal2 = { "Afif Hossain", "01975679325", "arif@gmail.com", "B+" };
            donorList.Rows.Add(drowVal2);
            String[] drowVal3 = { "Mehedi Hasan", "01745799325", "stoic@gmail.com", "B-" };
            donorList.Rows.Add(drowVal3);
            String[] drowVal4 = { "Sohel Rana", "01705679333", "exceptional@gmail.com", "B+" };
            donorList.Rows.Add(drowVal4);
            String[] drowVal5 = { "Lizan Khan", "01805679323", "lijaz1915@gmail.com", "O+" };
            donorList.Rows.Add(drowVal5);
            String[] drowVal6 = { "Dipu Roy", "01985673804", "roy@gmail.com", "A-" };
            donorList.Rows.Add(drowVal6);
            String[] drowVal7 = { "Nahin Hossain", "01595670840", "santo@gmail.com", "AB+" };
            donorList.Rows.Add(drowVal7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cmboxdeadline.Text == "Select")
            {
                MessageBox.Show("Please Select Blood Group for Search !");

            }
            else
            {
                if(cmboxdeadline.Text == "A+")
                {
                    MessageBox.Show("Search result found ! \n Name : Nafees Adil \n Mobile: 01605679325 \n Email : naffy@gmail.com \n Blood group : A+ \n");
                }
                else if (cmboxdeadline.Text == "B+")
                {
                    MessageBox.Show("Search result found ! \n Name : Afif Hossain \n Mobile: 01975679325 \n Email : arif@gmail.com \n Blood group : B+ \n");
                }
                else
                {
                    MessageBox.Show("\nSearch result not found !\n Please contact : 012030531233 (Blood Bank) \n or request for blood.");
                }

                

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            obj = new Thread(openform1);
            obj.SetApartmentState(ApartmentState.STA);
            obj.Start();
            this.Close();
        }

        private void btnapprove_Click(object sender, EventArgs e)
        {
            

            /*if (name.Text == "" || mobile.Text == "")
            {
                MessageBox.Show("Please fill the boxes to approve !");

            }
            else
            {
                
                
                MessageBox.Show("Request Done Successfully !");
                
            }*/

            if (name.Text == "")
            {
                MessageBox.Show("Please Enter Requester Name !");
                if (mobile.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Mobile Number !");
                    if (email.Text == "")
                    {
                        MessageBox.Show("\nPlease Enter Email !");
                        if(bloodGroup.Text == "Select")
                        {
                            MessageBox.Show("\nPlease Select Blood Group !");
                            if(Quantity.Text == "Select")
                            {
                                MessageBox.Show("\nPlease Select Quantity !");
                                if (!req.Checked && !blood.Checked)
                                {
                                    MessageBox.Show("\nPlease select who want to request .");
                                }
                            }
                        }
                    }
                }


            }
            else if (mobile.Text == "")
            {
                MessageBox.Show("\nPlease Enter Mobile Number !");
                if (email.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Email !");
                    if (bloodGroup.Text == "Select")
                    {
                        MessageBox.Show("\nPlease Select Blood Group !");
                        if (Quantity.Text == "Select")
                        {
                            MessageBox.Show("\nPlease Select Quantity !");
                            if (!req.Checked && !blood.Checked)
                            {
                                MessageBox.Show("\nPlease select who want to request .");
                            }
                        }
                    }
                }
            }
            else if (email.Text == "")
            {
                MessageBox.Show("\nPlease Enter Email !");
                if (bloodGroup.Text == "Select")
                {
                    MessageBox.Show("\nPlease Select Blood Group !");
                    if (Quantity.Text == "Select")
                    {
                        MessageBox.Show("\nPlease Select Quantity !");
                        if (!req.Checked && !blood.Checked)
                        {
                            MessageBox.Show("\nPlease select who want to request .");
                        }
                    }
                }
            }
            else if (bloodGroup.Text == "Select")
            {
                MessageBox.Show("\nPlease Select Blood Group !");
                if (Quantity.Text == "Select")
                {
                    MessageBox.Show("\nPlease Select Quantity !");
                    if (!req.Checked && !blood.Checked)
                    {
                        MessageBox.Show("\nPlease select who want to request .");
                    }
                }
            }
            else if (Quantity.Text == "Select")
            {
                MessageBox.Show("\nPlease Select Quantity !");
                if (!req.Checked && !blood.Checked)
                {
                    MessageBox.Show("\nPlease select who want to request .");
                }
            }

            else if (!req.Checked && !blood.Checked)
            {
                MessageBox.Show("\nPlease select who want to request .");
            }
            else
            {
                MessageBox.Show("Request done successfully !");
            }
            






        }
    }
}

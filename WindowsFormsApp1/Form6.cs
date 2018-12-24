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
    public partial class Form6 : Form
    {
        Thread obj; //object of multithreading 
           public Form6()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            

            if ( firstName.Text == "" && lastName.Text == "" && mobile.Text == "" && email.Text=="" && street.Text == "" && buildingNo.Text == "" && city.Text == "" && zip.Text == "")
            {
                MessageBox.Show("Nothing is changed.");

            }

            else
            {
                
                
                MessageBox.Show("Profile successfully Updated !");
                
            }

        }
        private void openform2()
        {
            Form2 f2 = new Form2();
            Application.Run(f2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            obj = new Thread(openform2);
            obj.SetApartmentState(ApartmentState.STA);
            obj.Start();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

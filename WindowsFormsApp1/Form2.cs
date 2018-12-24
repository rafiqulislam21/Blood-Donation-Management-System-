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
    public partial class Form2 : Form
    {
        public static string cid;
        public static string companyname, firstname, lastname, tradelicence, street, building, city, zip, details;
        public static string companyid,message;
        Thread objt; //object of multithreading 
        

        public Form2()
        {
            InitializeComponent();
        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            objt = new Thread(openform6);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            String[] rowVal1 = {"100000","Nafees Adil","01605679325","naffy@gmail.com","A+" };
            dgv2.Rows.Add(rowVal1);
            String[] rowVal2 = { "100001", "Afif Hossain", "01975679325", "arif@gmail.com", "B+" };
            dgv2.Rows.Add(rowVal2);
            String[] rowVal3 = { "100002", "Mehedi Hasan", "01745799325", "stoic@gmail.com", "B-" };
            dgv2.Rows.Add(rowVal3);
            String[] rowVal4 = { "100003", "Sohel Rana", "01705679333", "exceptional@gmail.com", "B+" };
            dgv2.Rows.Add(rowVal4);
            String[] rowVal5 = { "100004", "Lizan Khan", "01805679323", "lijaz1915@gmail.com", "O+" };
            dgv2.Rows.Add(rowVal5);
            String[] rowVal6 = { "100005", "Dipu Roy", "01985673804", "roy@gmail.com", "A-" };
            dgv2.Rows.Add(rowVal6);
            String[] rowVal7 = { "100006", "Nahin Hossain", "01595670840", "santo@gmail.com", "AB+" };
            dgv2.Rows.Add(rowVal7);


            
            String[] rowVal = { "false",  "200000", "Sadman Rafi", "01635679345", "raffi3@gmail.com", "B+" };
            dataGridView1.Rows.Add(rowVal);

        }
        public void openform9()
        {
            Form9 f9 = new Form9();
            Application.Run(f9);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            objt = new Thread(openform9);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }

        private void dgvnews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
               // int index = dataGridView1.SelectedRows[0].Index;
               // dataGridView1.Rows.RemoveAt(index);
                
                //int index2 = dgv2.SelectedRows[0].Index;
                //dgv2.Rows.RemoveAt(index2);
                MessageBox.Show("Data successfully Deleted.");

                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtto.Text.Length <= 7)
            {
                MessageBox.Show("Please Enter valid Id.");
            }
            else
            {
                MessageBox.Show("Message sent.");
                txtto.Text = "";
                txtempmessage.Text = "";
            }
        }

        private void openform6()
        {
            Form6 f6 = new Form6();
            Application.Run(f6);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            objt = new Thread(openform1);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }

        private void openform1()
        {
            form1 f1 = new form1();
            Application.Run(f1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //objt = new Thread(openform3);
            //objt.SetApartmentState(ApartmentState.STA);
            //objt.Start();
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
           

            

          







        }
    }
}

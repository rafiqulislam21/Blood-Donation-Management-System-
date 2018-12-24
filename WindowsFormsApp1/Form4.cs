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
    public partial class Form4 : Form
    {   
        public static string firstname, lastname,dob, street, building, city, zip, details,empid, empdesi, empblood, empphone,empuser,message,reciever,propname,propid;

        private void btnemployee_Click(object sender, EventArgs e)
        {

            objt = new Thread(openform8);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }
        private void openform8()
        {
            Form8 f8 = new Form8();
            Application.Run(f8);
        }

        private void display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void rdoapplication_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdocompany_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            String[] drowVal1 = { "100000", "Nafees Adil", "01605679325", "naffy@gmail.com", "A+" };
            donorList.Rows.Add(drowVal1);
            String[] drowVal2 = { "100001", "Afif Hossain", "01975679325", "arif@gmail.com", "B+" };
            donorList.Rows.Add(drowVal2);
            String[] drowVal3 = { "100002", "Mehedi Hasan", "01745799325", "stoic@gmail.com", "B-" };
            donorList.Rows.Add(drowVal3);
            String[] drowVal4 = { "100003", "Sohel Rana", "01705679333", "exceptional@gmail.com", "B+" };
            donorList.Rows.Add(drowVal4);
            String[] drowVal5 = { "100004", "Lizan Khan", "01805679323", "lijaz1915@gmail.com", "O+" };
            donorList.Rows.Add(drowVal5);
            String[] drowVal6 = { "100005", "Dipu Roy", "01985673804", "roy@gmail.com", "A-" };
            donorList.Rows.Add(drowVal6);
            String[] drowVal7 = { "100006", "Nahin Hossain", "01595670840", "santo@gmail.com", "AB+" };
            donorList.Rows.Add(drowVal7);






            String[] rowVal1 = { "200000", "Ibrahim sarker", "01605679325", "naffy@gmail.com", "A+" };
            requestLish.Rows.Add(rowVal1);
            String[] rowVal2 = { "200001", "Arafat Hossain", "01975679325", "arif@gmail.com", "B+" };
            requestLish.Rows.Add(rowVal2);
            String[] rowVal3 = { "200002", "Shawon Hasan", "01745799325", "stoic@gmail.com", "B-" };
            requestLish.Rows.Add(rowVal3);
            String[] rowVal4 = { "200003", "Kabir Rana", "01705679333", "exceptional@gmail.com", "B+" };
            requestLish.Rows.Add(rowVal4);
            String[] rowVal5 = { "200004", "Anjon Khan", "01805679323", "lijaz1915@gmail.com", "O+" };
            requestLish.Rows.Add(rowVal5);
            String[] rowVal6 = { "200005", "Dipu Roy", "01985673804", "roy@gmail.com", "A-" };
            requestLish.Rows.Add(rowVal6);
            String[] rowVal7 = { "200006", "Rifath Ahmed", "01595670840", "santo@gmail.com", "AB+" };
            requestLish.Rows.Add(rowVal7);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //int index2 = requestLish.SelectedRows[0].Index;
                //requestLish.Rows.RemoveAt(index2);
                MessageBox.Show("Requester successfully Deleted.");


            }
            
        }

        private void lbldesi_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                 //int index = donorList.SelectedRows[0].Index;
                 //donorList.Rows.RemoveAt(index);
                MessageBox.Show("Donor successfully Deleted.");


            }
            
        }
        private void openform11()
        {
            Form11 f11 = new Form11();
            Application.Run(f11);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            objt = new Thread(openform10);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }
        private void openform10()
        {
            Form10 f10 = new Form10();
            Application.Run(f10);
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            if( txtto.Text == "")
            {
                // MessageBox.Show(Form1.User);
                MessageBox.Show("Please enter receiver id ! ");

            }
            else
            {
                MessageBox.Show("Message sent !");
                txtto.Text = "";
                txtempmessage.Text = "";
            }






        }

        Thread objt; //object of multithreading 
       
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {

            
            objt = new Thread(openform7);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }

        private void openform7()
        {
            Form7 f7 = new Form7();
            Application.Run(f7);
        }
            

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
                

           
            string name = firstname + " " + lastname;
            string adress = street + ", " + building + ", " + city + ", " + zip ;
            
        }
    }
}

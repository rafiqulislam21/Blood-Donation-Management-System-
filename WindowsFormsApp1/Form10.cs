using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //for using multithreading

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        
        
        public Form10()
        {
            InitializeComponent();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            String[] drowVal1 = {  "Hello! i need A+ blood.", "21/02/2018" };
            Amessage.Rows.Add(drowVal1);
            String[] drowVal2 = { "Hi! i need A+ blood.", "09/03/2018" };
            Amessage.Rows.Add(drowVal2);
            String[] drowVal3 = { "Hi there! i need A+ blood.", "11/03/2018" };
            Amessage.Rows.Add(drowVal3);
            String[] drowVal4 = { "Hello! i need A+ blood.", "31/06/2018" };
            Amessage.Rows.Add(drowVal4);
            String[] drowVal5 = { "Hlw! i need A+ blood.", "04/08/2018" };
            Amessage.Rows.Add(drowVal5);
            String[] drowVal6 = { "Hey! i need A+ blood.", "03/08/2018" };
            Amessage.Rows.Add(drowVal6);
            String[] drowVal7 = { "Hello! i need A+ blood.", "25/08/2018" };
            Amessage.Rows.Add(drowVal7);

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //int index = Amessage.SelectedRows[0].Index;
                //Amessage.Rows.RemoveAt(index);
                MessageBox.Show("Message successfully Deleted.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop_Management_project
{
    public partial class adminForminside : Form
    {
        public adminForminside()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (radiobutton1.Checked == true)
            {
                manageemployee mngempl = new manageemployee();
                mngempl.Show();
                this.Hide();
            }
            else if (radioButton2.Checked == true)
            {
                buyitems buy = new buyitems();
                buy.Show();
                this.Hide();
            }
      
            else if (radioButton4.Checked == true)
            {
                employerinsider emp = new employerinsider();
                emp.Show();
                this.Hide();
            }
            else if (radioButton5.Checked == true)
            {
                showbalance shw = new showbalance();
                shw.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("the program is not complete yet"); }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

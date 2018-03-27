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
    public partial class employerinsider : Form
    {
        public employerinsider()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { showitems shw = new showitems();
            shw.Show();
            this.Hide();
            }
            else if (radioButton3.Checked == true)
            { sellitems sell = new sellitems();
            sell.Show();
            this.Hide();
            }
            else if (radioButton2.Checked == true)
            {
                manageempaccount emp = new manageempaccount();
                emp.Show();
                this.Hide();
            }
        }
    }
}

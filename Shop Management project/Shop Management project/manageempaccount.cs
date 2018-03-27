using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shop_Management_project
{
    public partial class manageempaccount : Form
    {
        public manageempaccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                changepass cng= new changepass();
                cng.Show();
                this.Hide();
            }
            else if (radioButton2.Checked == true)
            {
                change_email cng = new change_email();
                cng.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employerinsider emp = new employerinsider();
            emp.Show();
            this.Hide();
        }
    }
}

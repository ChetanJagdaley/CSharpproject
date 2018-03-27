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
    public partial class manageemployee : Form
    {
        public manageemployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForminside admfrmins = new adminForminside();
            admfrmins.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                newEmployeeSignupForm signup = new newEmployeeSignupForm();
                signup.Show();
                this.Hide();
            }
            if (radioButton2.Checked == true)
            {
                findemployer fnd = new findemployer();
                fnd.Show();
                this.Hide();
            }
            if (radioButton3.Checked == true)
            {
                remove_employee rem = new remove_employee();
                rem.Show();
                this.Hide();
            }
        }
    }
}

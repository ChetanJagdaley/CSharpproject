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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                AdminForm admfrm = new AdminForm();
                admfrm.Show();
            }
            else
            {
                EmployersForm empfrm = new EmployersForm();
                empfrm.Show();
            }
            this.Hide();
        }
    }
}

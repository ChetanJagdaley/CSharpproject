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
    public partial class EmployersForm : Form
    {
        public EmployersForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                string c="";
                MySqlConnection connection = new MySqlConnection();
                string constring = "server=localhost; database= shopmanagement; uid=root; pwd=root;";
                connection.ConnectionString = constring;
                string query = "select pwd from shopmanagement.employerdetails where uid='"+this.uid.Text+"';";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                    while(reader.Read()){
                    c=reader.GetString(0);}
                
                if(pwd.Text == c)
                { employerinsider emp = new employerinsider();
                emp.Show();
                this.Hide();
                }
                else{MessageBox.Show("You entered a wrong ID or PASSWORD!!!");}
                connection.Close();

        }

        private void EmployersForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contact the Admin");
        }
    }
}

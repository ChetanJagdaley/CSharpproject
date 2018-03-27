using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Shop_Management_project
{
    public partial class billing : Form
    {
        public billing()
        {
            InitializeComponent();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            employerinsider emp = new employerinsider();
            emp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char c;
            if (radioButton1.Checked == true)
            { c = 'm'; }
            else { c = 'f'; }
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost; database= shopmanagement; uid= root; pwd= root;";
            string query = "insert into shopmanagement.customer(fname,lname,gender,email,address,phone) values('"+this.fname.Text+"','"+this.lname.Text+"','"+c+"','"+this.email.Text+"','"+this.address.Text+"','"+this.phone.Text+"');";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            { }
            connection.Close();
            MessageBox.Show("Information is loaded!!!");
        }
    }
}

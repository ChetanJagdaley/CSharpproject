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
    public partial class changeadd : Form
    {
        public changeadd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageempaccount mng = new manageempaccount();
            mng.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;database=shopmanagement;uid=root;pwd=root";
            string query = "update shopmanagement.employerdetails set address='"+this.textBox2.Text+"' where uid='"+this.textBox1.Text+"'";
            MySqlCommand command = new MySqlCommand(query,connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            { }
            connection.Close();
            MessageBox.Show("Submitted!!!!");
            manageempaccount emp = new manageempaccount();
            emp.Show();
            this.Hide();

        }
    }
}

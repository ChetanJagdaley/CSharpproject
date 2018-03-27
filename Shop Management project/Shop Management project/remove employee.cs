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
    public partial class remove_employee : Form
    {
        public remove_employee()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str="";
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server= localhost; database= shopmanagement; uid= root; pwd= root";
            string query2 = "select uid from shopmanagement.employerdetails where uid='" + this.textBox1.Text + "'";
            MySqlCommand command2 = new MySqlCommand(query2, connection);
            MySqlDataReader reader2;
            connection.Open();
            reader2=command2.ExecuteReader();
            while(reader2.Read())
            {
                str = reader2.GetString(0);
            }
            connection.Close();
            
            if(textBox1.Text!=str)
            {
                MessageBox.Show("employee does not exist");
            }
            else{
            string query = "delete from shopmanagement.employerdetails where uid='" + this.textBox1.Text + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
            }
            connection.Close();
            MessageBox.Show("Removed!!!");}
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            adminForminside adm = new adminForminside();
            adm.Show();
            this.Hide();
        }
    }
}

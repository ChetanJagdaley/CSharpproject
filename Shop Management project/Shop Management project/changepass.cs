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
    public partial class changepass : Form
    {
        public changepass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageempaccount man = new manageempaccount();
            man.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str="";
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;database=shopmanagement;uid=root;pwd=root";
            string query = "select pwd from shopmanagement.employerdetails where uid ='"+this.textBox1.Text+"'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader ;
            connection.Open();
            reader=command.ExecuteReader();
            while(reader.Read())
            {
                str=reader.GetString(0);
            }
            connection.Close();
            if(str!=textBox2.Text)
            {
                MessageBox.Show("UID and Password doesn't match!!!!");
            }
            else
            {
                if(textBox3.Text!=textBox4.Text)
                {
                    MessageBox.Show("New Password doesn't match!!!");
                }
                else
                {
                string query2="update shopmanagement.employerdetails set pwd='"+this.textBox3.Text+"'where uid='"+this.textBox1.Text+"'";
                MySqlCommand command2= new MySqlCommand(query2, connection);
                MySqlDataReader reader2;
                connection.Open();
                reader2=command2.ExecuteReader();
                    while(reader2.Read())
                    {}
                connection.Close();
                }
                MessageBox.Show("Password Changed!!!");
                manageempaccount man = new manageempaccount();
                man.Show();
                this.Hide();
            }
            
        }
    }
}

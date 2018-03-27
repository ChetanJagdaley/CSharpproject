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
    public partial class findemployer : Form
    {
        public findemployer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manageemployee manage = new manageemployee();
            manage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection();
            string constring = "server=localhost; database=shopmanagement; uid=root; pwd=root;";
            connection.ConnectionString = constring;
            string query = "select fname,lname,gender,email,address,pwd from shopmanagement.employerdetails where uid='" + this.search.Text + "';";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            Boolean flag = false;
            while (reader.Read())
            {
                fname.Text = "" + reader.GetString(0);
                lname.Text = "" + reader.GetString(1);
                gender.Text = "" + reader.GetString(2);
                email.Text = "" + reader.GetString(3);
                address.Text = "" + reader.GetString(4);
                pwd.Text = "" + reader.GetString(5);
                flag = true;
            }
            connection.Close();
            if (flag == false)
            {
                MessageBox.Show("Wrong user id entered");


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
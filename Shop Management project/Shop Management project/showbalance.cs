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
    public partial class showbalance : Form
    {
        public showbalance()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost; database=shopmanagement;uid=root;pwd=root";
            string query = "select balance from shopmanagement.shopbalance";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.textBox1.Text = "" + reader.GetString(0);
            }
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForminside admfrmin = new adminForminside();
            admfrmin.Show();
            this.Hide();

        }
    }
}

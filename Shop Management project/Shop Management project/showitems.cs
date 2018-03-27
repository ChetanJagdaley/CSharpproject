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
    public partial class showitems : Form
    {
        public showitems()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employerinsider emp = new employerinsider();
            emp.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                MySqlConnection connection = new MySqlConnection();
                string constring = "server= localhost; database= shopmanagement; uid=root; pwd=root;";
                connection.ConnectionString = constring;
                string query = "select salt,dryfruits,wheat,maggie,rice,tea,oil from shopmanagement.items ;";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.salt.Text = reader.GetString(0);
                    this.dryfruit.Text = reader.GetString(1);
                    this.wheat.Text = reader.GetString(2);
                    this.maggie.Text = reader.GetString(3);
                    this.rice.Text = reader.GetString(4);
                    this.tea.Text = reader.GetString(5);
                    this.oil.Text = reader.GetString(6);
                 }
                connection.Close();
                
        }
    }
}

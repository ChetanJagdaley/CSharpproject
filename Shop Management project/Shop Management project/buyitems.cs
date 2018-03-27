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
    public partial class buyitems : Form
    {
        public buyitems()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForminside emp = new adminForminside();
            emp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            float slt = 0.0f, dryfrts = 0.0f, whet = 0.0f, oi = 0.0f, tea = 0.0f, ri = 0.0f, ma = 0.0f;
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "server= localhost; database= shopmanagement; uid= root; pwd= root;";
                string query = "update shopmanagement.items set salt=salt+'" + this.salt.Text + "',dryfruits=dryfruits+'" + this.dryfruit.Text + "',wheat=wheat+'" + this.wheat.Text + "',maggie=maggie+'" + this.maggie.Text + "',rice=rice+'" + this.rice.Text + "',tea=tea+'" + this.tea.Text + "',oil=oil+'" + this.oil.Text + "';";
                MySqlCommand command = new MySqlCommand(query, connection);
                
                MySqlDataReader reader;
               
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                { }
                
                connection.Close();
                string query2 = "select slt,dryfts,whet,ma,ri,tea,oi from shopmanagement.itemlist";
                MySqlCommand command2 = new MySqlCommand(query2, connection);
                MySqlDataReader reader2;
                connection.Open();
                reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    slt = reader2.GetFloat(0);
                    dryfrts = reader2.GetFloat(1);
                    whet = reader2.GetFloat(2);
                    ma = reader2.GetFloat(3);
                    ri = reader2.GetFloat(4);
                    tea = reader2.GetFloat(5);
                    oi = reader2.GetFloat(6);
                }
                connection.Close();
                string query3 = "update shopmanagement.shopbalance set balance= balance-('" + slt + "')*('" + this.salt.Text + "')-('" + dryfrts + "')*('" + this.dryfruit.Text + "')-('" + whet + "')*('" + this.wheat.Text + "')-('" + ma + "')*('" + this.maggie.Text + "')-('" + ri + "')*('" + this.rice.Text + "')-('" + tea + "')*('" + this.tea.Text + "')-('" + oi + "')*('" + this.oil.Text + "')";
                MySqlCommand command3 = new MySqlCommand(query3, connection);
                MySqlDataReader reader3;
                connection.Open();
                reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                }
                connection.Close();
                MessageBox.Show("Bought!!!");
                employerinsider emp = new employerinsider();
                emp.Show();
                this.Hide();
        }
    }
}

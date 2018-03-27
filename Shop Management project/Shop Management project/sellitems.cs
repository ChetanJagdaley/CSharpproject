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
    public partial class sellitems : Form
    {
        public sellitems()
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
            float slt=0f, dryfts=0.0f, whet=0f, ma=0f, ri=0f, tea=0f, oi=0f, profit=0f;
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost; database=shopmanagement;uid=root;pwd=root;";
            string query = "update shopmanagement.items set salt=salt-'"+this.salt.Text+"',dryfruits=dryfruits-'"+this.dryfruit.Text+"',wheat=wheat-'"+this.wheat.Text+"',maggie=maggie-'"+this.maggie.Text+"',rice=rice-'"+this.rice.Text+"',tea=tea-'"+this.tea.Text+"',oil=oil-'"+this.oil.Text+"';";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            { }
            connection.Close();
            connection.Open();
            string query2 = "select slt,dryfts,whet,ma,ri,tea,oi,profit from shopmanagement.itemlist";
            MySqlCommand command2 = new MySqlCommand(query2,connection);
            MySqlDataReader reader2;
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                slt =reader2.GetFloat(0);
                dryfts =reader2.GetFloat(1);
                whet= reader2.GetFloat(2);
                ma = reader2.GetFloat(3);
                ri = reader2.GetFloat(4);
                tea = reader2.GetFloat(5);
                oi = reader2.GetFloat(6);
                profit =reader2.GetFloat(7);
            }
            connection.Close();
            connection.Open();
            string query3 = "update shopmanagement.shopbalance set balance=balance+('" + slt + "')*'" + this.salt.Text + "'+('" + (slt * profit) + "')*('" + this.salt.Text + "')+('" + dryfts + "')*'" + this.dryfruit.Text + "'+('" + (dryfts * profit) + "')*('" + this.dryfruit.Text + "')+('" + whet + "')*'" + this.wheat.Text + "'+('" + (whet * profit) + "')*('" + this.wheat.Text + "')+('" + ma + "')*'" + this.maggie.Text + "'+('" + (ma * profit) + "')*('" + this.maggie.Text + "')+('" + ri + "')*'" + this.rice.Text + "'+('" + (ri * profit) + "')*('" + this.rice.Text + "')+('" + tea + "')*'" + this.tea.Text + "'+('" + (tea * profit) + "')*('" + this.tea.Text + "')+('" + oi + "')*'" + this.oil.Text + "'+('" + (oi * profit) + "')*('" + this.oil.Text + "')";
            MySqlCommand command3 = new MySqlCommand(query3, connection);
            MySqlDataReader reader3;
            reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
            }
            connection.Close();
            billing bill = new billing();
            bill.Show();
            this.Hide();
        }

        private void sellitems_Load(object sender, EventArgs e)
        {

        }
    }
}

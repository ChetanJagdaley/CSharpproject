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
    public partial class newEmployeeSignupForm : Form
    {
        public newEmployeeSignupForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manageemployee mngempl = new manageemployee();
            mngempl.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                char c;
                if(radioButton1.Checked==true)
                {c='m';}
                else{c='f';}
                MySqlConnection connection = new MySqlConnection();
                string constring = "server= localhost; database= shopmanagement; uid=root; pwd=root;";
                connection.ConnectionString = constring;
                string query = "insert into shopmanagement.employerdetails(fname,lname,uid,pwd,gender,email,address) values ('"+this.fname.Text+"','"+this.lname.Text+"','"+this.uid.Text+"','"+this.pwd.Text+"','"+c+"','"+this.email.Text+"','"+this.address.Text+"')";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                { }

                MessageBox.Show("Employer is added!!!");
                manageemployee mng = new manageemployee();
              
                connection.Close();
                mng.Show();
                this.Hide();
            
        }

        private void newEmployeeSignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}

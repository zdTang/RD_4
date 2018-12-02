using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RD_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayCustomer_Click(object sender, EventArgs e)
        {
            string sql = "select * from customer";
            using (MySqlConnection conn = new MySqlConnection("datasource = 127.0.0.1; database = ztwally; port = 3306; username = root;password=tl6902856; sslmode = none"))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                Grid.Rows.Clear();
                Grid.Columns.Clear();
                Grid.Columns.Add("customerID", "Customer ID");
                Grid.Columns.Add("first", "First Name");
                Grid.Columns.Add("last", "Last Name");
                Grid.Columns.Add("phone", "Phone Number");
                while (reader.Read())
                {
                    Grid.Rows.Add(reader["customerID"], reader["firstName"], reader["lastName"], reader["phoneNumber"]);
                }
                reader.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

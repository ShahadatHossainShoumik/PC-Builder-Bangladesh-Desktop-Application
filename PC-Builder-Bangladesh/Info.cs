using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBUILDER
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shaha\OneDrive\Documents\PCBUILDER.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT 'Customer' AS Type, * FROM customer WHERE name LIKE @name 
                         UNION ALL 
                         SELECT 'Staff' AS Type, * FROM staff WHERE name LIKE @name";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + textBox1.Text + "%");

                    DataTable dt = new DataTable();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        dt.Load(sdr);
                    }

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin adminForm=new Admin();
            adminForm.Show();
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }
    }
}

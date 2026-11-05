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
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shaha\OneDrive\Documents\PCBUILDER.mdf;Integrated Security=True;Connect Timeout=30");
        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff staff = new Staff();
            staff.Show();
            return;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable outOfStockProducts = new DataTable();

            try
            {
                con.Open();
                foreach (string table in new string[] { "Monitor", "Mouse", "Keyboard", "Ram", "Rom", "CPU", "Processor", "Motherboard" })
                {
                    string query = $"SELECT * FROM {table} WHERE Quantity = 0"; // Fetch products with Quantity = 0
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(outOfStockProducts); // Append data to the DataTable
                }

                dataGridView2.DataSource = outOfStockProducts; // Bind to dataGridView2
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching out-of-stock products: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable availableProducts = new DataTable();

            try
            {
                con.Open();
                foreach (string table in new string[] { "Monitor", "Mouse", "Keyboard", "Ram", "Rom", "CPU", "Processor", "Motherboard" })
                {
                    string query = $"SELECT * FROM {table} WHERE Quantity > 0"; // Fetch products with Quantity > 0
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(availableProducts); // Append data to the DataTable
                }

                dataGridView1.DataSource = availableProducts; // Bind to dataGridView1
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching available products: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {

        }
    }
}

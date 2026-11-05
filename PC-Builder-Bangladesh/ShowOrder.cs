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
    public partial class ShowOrder : Form
    {
        public ShowOrder()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PlacedOrder_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Order]"; // Query to fetch all data from the Order table
            DataTable dt = new DataTable();

            try
            {
                con.Open(); // Open the SQL connection
                SqlDataAdapter da = new SqlDataAdapter(query, con); // Adapter to fetch data
                da.Fill(dt); // Fill the DataTable with the results
                dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching orders: " + ex.Message); // Display any errors
            }
            finally
            {
                con.Close(); // Ensure the connection is closed
            }
        }

    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PCBUILDER
{
    public partial class Customer2 : Form
    {
        public Customer2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shaha\OneDrive\Documents\PCBUILDER.mdf;Integrated Security=True;Connect Timeout=30");

        private void Customer2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Monitor", "Keyboard", "Mouse", "CPU", "Processor", "Ram", "Rom", "Motherboard" });
            comboBox1.SelectedIndex = 0;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idBox2.Text = row.Cells["Id"].Value?.ToString() ?? "";
                nameBox1.Text = row.Cells["Name"].Value?.ToString() ?? "";
                priceBox4.Text = row.Cells["Price"].Value?.ToString() ?? "";
                brandBox3.Text = row.Cells["Brand"].Value?.ToString() ?? "";
                modelBox5.Text = row.Cells["Model"].Value?.ToString() ?? "";
                quantityBox6.Text = row.Cells["Quantity"].Value?.ToString() ?? "";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem.ToString();
            string query = $"SELECT * FROM {selectedCategory}";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {

        }

        private void nameBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void idBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void brandBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalquantityBox7_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(totalquantityBox7.Text, out int selectedQuantity) && selectedQuantity > 0 &&
                int.TryParse(quantityBox6.Text, out int availableQuantity) &&
                decimal.TryParse(priceBox4.Text, out decimal pricePerProduct))
            {
                if (selectedQuantity > availableQuantity)
                {
                    MessageBox.Show("Selected quantity exceeds available stock.");
                    totalpriceBox8.Text = "";
                }
                else
                {
                    totalpriceBox8.Text = (selectedQuantity * pricePerProduct).ToString("F2");
                }
            }
            else
            {
                totalpriceBox8.Text = "";
            }
        }

        private void totalpriceBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void billingnameBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void ORDER_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!int.TryParse(totalquantityBox7.Text, out int selectedQuantity) || selectedQuantity <= 0 ||
                !decimal.TryParse(totalpriceBox8.Text, out decimal totalPrice) || totalPrice <= 0 ||
                string.IsNullOrWhiteSpace(billingnameBox9.Text) ||
                !int.TryParse(quantityBox6.Text, out int availableQuantity) || selectedQuantity > availableQuantity)
            {
                MessageBox.Show("Invalid order details. Please check your inputs.");
                return;
            }

            string selectedCategory = comboBox1.SelectedItem.ToString();
            string insertQuery = "INSERT INTO [Order] (Quantity, Buyer_Name, Total_Price) VALUES (@Quantity, @BuyerName, @TotalPrice)";
            string updateQuery = $"UPDATE {selectedCategory} SET Quantity = Quantity - @SelectedQuantity WHERE Id = @ProductId";

            // Use a new SqlConnection instance with a 'using' statement to avoid manual open/close
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\pcbuilder.mdf;Integrated Security=True;Connect Timeout=30;"))
            {
                try
                {
                    con.Open();

                    // Execute the INSERT command
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@Quantity", selectedQuantity);
                        insertCmd.Parameters.AddWithValue("@BuyerName", billingnameBox9.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        insertCmd.ExecuteNonQuery();
                    }

                    // Execute the UPDATE command
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@SelectedQuantity", selectedQuantity);
                        updateCmd.Parameters.AddWithValue("@ProductId", idBox2.Text);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order placed successfully.");
                    comboBox1_SelectedIndexChanged(sender, e); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error placing order: " + ex.Message);
                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUSTOMER cUSTOMER = new CUSTOMER();
            cUSTOMER.Show();
            return;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

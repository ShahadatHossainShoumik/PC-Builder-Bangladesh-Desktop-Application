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
    public partial class OrderPC : Form
    {
        public OrderPC()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shaha\OneDrive\Documents\PCBUILDER.mdf;Integrated Security=True;Connect Timeout=30");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OrderPC_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Monitor", "Keyboard", "Mouse", "CPU", "Processor", "Ram", "Rom", "Motherboard" });
            comboBox1.SelectedIndex = 0;
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

        private void MONITORBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MOUSEBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

        /* private void textBox9_TextChanged(object sender, EventArgs e)
         {

         }*/

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BillingNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract the NAME column value
                string selectedName = selectedRow.Cells["NAME"].Value?.ToString();

                // Find the correct textbox based on selected category
                string selectedCategory = comboBox1.SelectedItem.ToString();

                switch (selectedCategory)
                {
                    case "Monitor":
                        MONITORBox1.Text = selectedName;
                        break;
                    case "Keyboard":
                        KEYBOARDBox.Text = selectedName;
                        break;
                    case "Mouse":
                        MOUSEBox2.Text = selectedName;
                        break;
                   case "CPU":
                        CPUBox.Text = selectedName;
                        break;
                    case "Processor":
                        PROCESSORBox.Text = selectedName;
                        break;
                    case "Ram":
                        RAMBox.Text = selectedName;
                        break;
                    case "Rom":
                        ROMBox.Text = selectedName;
                        break;
                    case "Motherboard":
                        MOTHERBOARDBox.Text = selectedName;
                        break;
                }
            }
        }

        private void KEYBOARDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPUBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PROCESSORBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MOTHERBOARDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RAMBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ROMBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void addmonitor_Click(object sender, EventArgs e)
        {
            AddProduct(MONITORBox1);
        }

        private void DeleteMonitor_Click(object sender, EventArgs e)
        {
            DeleteProduct(MONITORBox1);
        }

        private void AddMouse_Click(object sender, EventArgs e)
        {
            AddProduct(MOUSEBox2);
        }

        private void DeleteMouse_Click(object sender, EventArgs e)
        {
            DeleteProduct(MOUSEBox2);
        }
        private void AddProduct(TextBox productTextBox)
        {
            if (!string.IsNullOrWhiteSpace(productTextBox.Text))
            {
                // Check if a row is selected
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Get quantity and price from the selected row
                    int quantity;
                    decimal price;

                    if (int.TryParse(selectedRow.Cells["Quantity"].Value?.ToString(), out quantity) && quantity == 0)
                    {
                        MessageBox.Show("Product Stock Out!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Stop adding product if stock is empty
                    }

                    if (decimal.TryParse(selectedRow.Cells["Price"].Value?.ToString(), out price))
                    {
                        // Add product name to ProductBox (only if it's not already there)
                        List<string> products = ProductBox.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        if (!products.Contains(productTextBox.Text))
                        {
                            products.Add(productTextBox.Text);
                            ProductBox.Text = string.Join(", ", products);

                            // Update Total Price
                            decimal currentTotal = 0;
                            decimal.TryParse(TotalPriceBox.Text, out currentTotal);
                            TotalPriceBox.Text = (currentTotal + price).ToString();
                        }
                    }
                }
            }
        }

        private void DeleteProduct(TextBox productTextBox)
        {
            if (!string.IsNullOrWhiteSpace(productTextBox.Text))
            {
                // Check if a row is selected
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Get the price from the selected row
                    decimal price;
                    if (decimal.TryParse(selectedRow.Cells["Price"].Value?.ToString(), out price))
                    {
                        // Get product list and remove the product only once
                        List<string> products = ProductBox.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                        if (products.Contains(productTextBox.Text))
                        {
                            products.Remove(productTextBox.Text);
                            ProductBox.Text = string.Join(", ", products);

                            // Deduct price only once
                            decimal currentTotal = 0;
                            decimal.TryParse(TotalPriceBox.Text, out currentTotal);
                            TotalPriceBox.Text = (currentTotal - price >= 0 ? (currentTotal - price).ToString() : "0");

                            // Clear the respective TextBox after removal
                            productTextBox.Text = "";
                        }
                    }
                }
            }
        }

        /* private void addkeyboard_Click(object sender, EventArgs e)
         {

         }*/

        private void addkeyboard_Click(object sender, EventArgs e) { AddProduct(KEYBOARDBox); }
        private void addrom_Click(object sender, EventArgs e) { AddProduct(ROMBox); }
        private void addram_Click(object sender, EventArgs e) { AddProduct(RAMBox); }
        private void addmotherboard_Click(object sender, EventArgs e) { AddProduct(MOTHERBOARDBox); }
        private void addprocessor_Click(object sender, EventArgs e) { AddProduct(PROCESSORBox); }
        private void addCPU_Click(object sender, EventArgs e) { AddProduct(CPUBox); }


      /*  private void DeleteMonitor_Click(object sender, EventArgs e) { DeleteProduct(MONITORBox1); }
        private void DeleteMouse_Click(object sender, EventArgs e) { DeleteProduct(MOUSEBox2); }*/

        private void deletekeyboard_Click(object sender, EventArgs e) { DeleteProduct(KEYBOARDBox); }
        private void deleterom_Click(object sender, EventArgs e) { DeleteProduct(ROMBox); }
        private void deleteram_Click(object sender, EventArgs e) { DeleteProduct(RAMBox); }
        private void deletemotherboard_Click(object sender, EventArgs e) { DeleteProduct(MOTHERBOARDBox); }
        private void deleteprocessor_Click(object sender, EventArgs e) { DeleteProduct(PROCESSORBox); }
        private void deleteCPU_Click(object sender, EventArgs e) { DeleteProduct(CPUBox); }
    }
}

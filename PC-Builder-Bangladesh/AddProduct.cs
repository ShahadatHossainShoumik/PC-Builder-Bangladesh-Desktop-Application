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
    public partial class AddProduct : Form
    {
        public AddProduct()
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

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

      

        private void nameBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void brandBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void idBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMONITOR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRAM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPROCESSOR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCPU_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonKEYBOARD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMOUSE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonROM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Determine which table to insert into based on the selected radio button
            string selectedTable = null;
            if (radioButtonMONITOR.Checked) selectedTable = "Monitor";
            else if (radioButtonRAM.Checked) selectedTable = "Ram";
            else if (radioButtonPROCESSOR.Checked) selectedTable = "Processor";
            else if (radioButtonCPU.Checked) selectedTable = "CPU";
            else if (radioButtonKEYBOARD.Checked) selectedTable = "Keyboard";
            else if (radioButtonMOUSE.Checked) selectedTable = "Mouse";
            else if (radioButtonROM.Checked) selectedTable = "Rom";
            else if (radioButtonMOTHERBOARD.Checked) selectedTable = "Motherboard";

            // Check if no radio button is selected
            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("Please select a product category.");
                return;
            }

            // Validate required fields (except Storage)
            if (string.IsNullOrWhiteSpace(idBox2.Text) ||
                string.IsNullOrWhiteSpace(nameBox1.Text) ||
                string.IsNullOrWhiteSpace(brandBox3.Text) ||
                string.IsNullOrWhiteSpace(priceBox4.Text) ||
                string.IsNullOrWhiteSpace(modelBox5.Text) ||
                string.IsNullOrWhiteSpace(quantityBox6.Text) ||
                string.IsNullOrWhiteSpace(imageBox7.Text))
            {
                MessageBox.Show("All fields except must be filled.");
                return;
            }

            // Prepare the insert query
            string query = $"INSERT INTO {selectedTable} (Id, Name, Brand, Price, Model, Quantity, Storage, Image) " +
                           $"VALUES (@Id, @Name, @Brand, @Price, @Model, @Quantity, @Storage, @Image)";

            try
            {
                // Open the database connection
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Bind parameters with values from text boxes
                    cmd.Parameters.AddWithValue("@Id", idBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", nameBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Brand", brandBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", decimal.TryParse(priceBox4.Text.Trim(), out decimal price) ? price : 0);
                    cmd.Parameters.AddWithValue("@Model", modelBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quantity", int.TryParse(quantityBox6.Text.Trim(), out int quantity) ? quantity : 0);
                    cmd.Parameters.AddWithValue("@Image", imageBox7.Text.Trim());

                    // Allow Storage to be null if the textbox is empty
                    if (string.IsNullOrWhiteSpace(storageBox.Text))
                        cmd.Parameters.AddWithValue("@Storage", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Storage", storageBox.Text.Trim());

                    // Execute the insert command
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Product added successfully!");

                // Clear the text boxes after insertion
                idBox2.Clear();
                nameBox1.Clear();
                brandBox3.Clear();
                priceBox4.Clear();
                modelBox5.Clear();
                quantityBox6.Clear();
                imageBox7.Clear();
                storageBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void radioButtonMOTHERBOARD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void storageBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shaha\OneDrive\Documents\PCBUILDER.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Staff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Add_User_Click(object sender, EventArgs e)
        {
            // Check if any text box is empty or no radio button is selected
            if (string.IsNullOrWhiteSpace(textBox1.Text) || // Name
                string.IsNullOrWhiteSpace(textBox2.Text) || // Number
                string.IsNullOrWhiteSpace(textBox3.Text) || // pass
                string.IsNullOrWhiteSpace(textBox4.Text) || // Mail
                string.IsNullOrWhiteSpace(textBox5.Text) || // Address
                (!Customer.Checked && !Staff.Checked))     // Role
            {
                MessageBox.Show("Please fill out all fields and select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gather data from the text boxes
            string name = textBox1.Text;
            string number = textBox2.Text;
            string pass = textBox3.Text;
            string mail = textBox4.Text;
            string address = textBox5.Text;
            string role = Customer.Checked ? "Customer" : "Staff"; // Determine the role

            // Determine the table name based on the role
            string tableName = role == "Customer" ? "customer" : "staff";

            try
            {
                // Open the database connection
                con.Open();

                // Prepare the SQL command
                string query = $"INSERT INTO {tableName} (Name, Number, Pass, Mail, Address) VALUES (@Name, @Number, @Pass, @Mail, @Address)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Number", number);
                    cmd.Parameters.AddWithValue("@Pass", pass);
                    cmd.Parameters.AddWithValue("@Mail", mail);
                    cmd.Parameters.AddWithValue("@Address", address);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }

                // Show success message
                MessageBox.Show($"{role} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                con.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin adminForm = new Admin();
            adminForm.Show();
            return;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Adduser_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shaha\OneDrive\Documents\PCBUILDER.mdf;Integrated Security=True;Connect Timeout=30");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sing_up form2 = new Sing_up();
            this.Hide(); // Hides the current form
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve user inputs
            string Name = textBox1.Text.Trim();
            string Pass = textBox2.Text.Trim();

            // Connection string to your database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shaha\OneDrive\Documents\PCBUILDER.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check for Admin login
                    string queryAdmin = "SELECT COUNT(1) FROM Admin WHERE PASS = @PASS AND NAME = @NAME";
                    using (SqlCommand cmd = new SqlCommand(queryAdmin, con))
                    {
                        cmd.Parameters.AddWithValue("@PASS", Pass);
                        cmd.Parameters.AddWithValue("@NAME", Name);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Admin adminForm = new Admin();
                            adminForm.Show();
                            return;
                        }
                    }

                    // Check for Customer login
                    string queryCustomer = "SELECT COUNT(1) FROM Customer WHERE PASS = @PASS AND NAME = @NAME";
                    using (SqlCommand cmd = new SqlCommand(queryCustomer, con))
                    {
                        cmd.Parameters.AddWithValue("@PASS", Pass);
                        cmd.Parameters.AddWithValue("@NAME", Name);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Customer login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                           CUSTOMER customerForm = new CUSTOMER();
                           customerForm.Show();
                            return;
                        }
                    }

                    // Check for Staff login
                    string queryStaff = "SELECT COUNT(1) FROM Staff WHERE PASS = @PASS AND NAME = @NAME";
                    using (SqlCommand cmd = new SqlCommand(queryStaff, con))
                    {
                        cmd.Parameters.AddWithValue("@PASS", Pass);
                        cmd.Parameters.AddWithValue("@NAME", Name);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Staff login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Staff staffForm = new Staff();
                            staffForm.Show();
                            return;
                        }
                    }

                    // If no match found
                    MessageBox.Show("Invalid User Name or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

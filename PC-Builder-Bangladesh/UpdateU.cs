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
    public partial class UpdateU : Form
    {
        public UpdateU()
        {
            InitializeComponent();
            LoadData();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shaha\OneDrive\Documents\PCBUILDER.mdf;Integrated Security=True;Connect Timeout=30");
        private string selectedUserName;
        private string selectedUserType;

        private void LoadData()
        {
            con.Open();
            try
            {
                
                string query = "SELECT 'Customer' AS Type, * FROM customer UNION ALL SELECT 'Staff' AS Type, * FROM staff";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
               // con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedUserName = row.Cells["name"].Value.ToString();
                selectedUserType = row.Cells["Type"].Value.ToString();
                nameBox.Text = row.Cells["name"].Value.ToString();
                numberBox.Text = row.Cells["number"].Value.ToString();
                passBox.Text = row.Cells["pass"].Value.ToString();
                mailBox.Text = row.Cells["mail"].Value.ToString();
                addressBox.Text = row.Cells["address"].Value.ToString();
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedUserName) && !string.IsNullOrEmpty(selectedUserType))
            {
                string tableName = selectedUserType == "Customer" ? "customer" : "staff";
                string query = $"UPDATE {tableName} SET name = @name, number = @number, pass = @pass, mail = @mail, address = @address WHERE name = @name";
                con.Open();
                try
                {
                   
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uname", selectedUserName);
                        cmd.Parameters.AddWithValue("@name", nameBox.Text);
                        cmd.Parameters.AddWithValue("@number", numberBox.Text);
                        cmd.Parameters.AddWithValue("@pass", passBox.Text);
                        cmd.Parameters.AddWithValue("@mail", mailBox.Text);
                        cmd.Parameters.AddWithValue("@address", addressBox.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void UpdateU_Load(object sender, EventArgs e)
        {

        }
    }
}


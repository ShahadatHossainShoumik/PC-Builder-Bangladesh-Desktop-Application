using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBUILDER
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            return;
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteProduct deleteProduct = new DeleteProduct();
            deleteProduct.Show();
            return;
        }

        private void ProductDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductDetails productDetails = new ProductDetails();   
            productDetails.Show();
            return;
        }

        private void ShowOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowOrder showOrder = new ShowOrder();  
            showOrder.Show();
            return;
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login back = new Login();
            back.Show();
            return;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

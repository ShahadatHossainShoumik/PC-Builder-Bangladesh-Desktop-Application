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
    public partial class CUSTOMER : Form
    {
        public CUSTOMER()
        {
            InitializeComponent();
        }

        private void OrderProduct_Click(object sender, EventArgs e)
        {
           this.Hide();
            Customer2 customer2 = new Customer2();
            customer2.Show();
            return;
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            return;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrderPC_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderPC pC = new OrderPC();
            pC.Show();
            return;
        }

        private void CUSTOMER_Load(object sender, EventArgs e)
        {

        }
    }
}

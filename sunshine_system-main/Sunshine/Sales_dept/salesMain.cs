using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunshine.Sales_dept;

namespace Sunshine
{
    public partial class salesMain : Form
    {
        public salesMain()
        {
            InitializeComponent();
            this.salesDashboard1.Visible = true;
            this.salesOrder1.Visible = false;
            this.salesCustomer1.Visible = false;
            this.salesReport1.Visible = false;
        }

        // logout
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Logout confirm?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Hide();
                new LoginPage().ShowDialog();
                this.Close();
            }
        }

        // open dashboard, add order, customer and report
        private void dashBtn_Click(object sender, EventArgs e)
        {
            this.salesDashboard1.Visible = true;
            this.salesOrder1.Visible = false;
            this.salesCustomer1.Visible = false;
            this.salesReport1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.salesDashboard1.Visible = false;
            this.salesOrder1.Visible = true;
            this.salesCustomer1.Visible = false;
            this.salesReport1.Visible = false;
        }

        private void cusBtn_Click(object sender, EventArgs e)
        {
            this.salesDashboard1.Visible = false;
            this.salesOrder1.Visible = false;
            this.salesCustomer1.Visible = true;
            this.salesReport1.Visible = false;
        }

        private void reBtn_Click(object sender, EventArgs e)
        {
            this.salesDashboard1.Visible = false;
            this.salesOrder1.Visible = false;
            this.salesCustomer1.Visible = false;
            this.salesReport1.Visible = true;
        }
    }
}

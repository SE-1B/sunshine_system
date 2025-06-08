using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sunshine
{
    public partial class LogisticHome : Form
    {
        private string _Id; // User ID
        private string _name; // User Name
      
        public LogisticHome(string Id, string name)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _Id = Id;
            _name = name;
        }
        private void LogisticHome_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Welcome, {_name}";
        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateCustomerOrder_Click(object sender, EventArgs e)
        {
            ShowUpdateCustomerOrder();
        }

        private void btnGoodTransfer_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide LogisticHome first
            using (var logisticTransferGoodForm = new logisticTransferGood())
            {
                logisticTransferGoodForm.ShowDialog(); // Show as modal dialog
            }
            this.Hide(); // Hide LogisticHome after the dialog closes
        }

        private void btnGenerateDeliveryNote_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully logged out!");
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void ShowUpdateCustomerOrder()
        {
            using (var updateOrderForm = new logisticUpdateCustomerOrder())
            {
                this.Hide(); // Hide LogisticHome
                updateOrderForm.ShowDialog(); // Show as modal
                this.Hide(); // Hide LogisticHome after popup closes
            }
        }
    }
}

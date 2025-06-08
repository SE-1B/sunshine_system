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
            logisticUpdateCustomerOrder logisticUpdateCustomerOrder = new logisticUpdateCustomerOrder();
            logisticUpdateCustomerOrder.ShowDialog();
            this.Hide();
        }

        private void btnGoodTransfer_Click(object sender, EventArgs e)
        {
            logisticTransferGood logisticTransferGood = new logisticTransferGood();
            logisticTransferGood.ShowDialog();
            this.Hide();
        }

        private void btnGenerateDeliveryNote_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}

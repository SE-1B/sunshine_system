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
    public partial class ProductionSupplyHome : Form
    {
        private string _Id; // User ID
        private string _name; // User Name

        public ProductionSupplyHome(string Id, string name)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _Id = Id;
            _name = name;
        }

        private void ProductionSupplyHome_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Welcome, {_name}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully logged out!");
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}

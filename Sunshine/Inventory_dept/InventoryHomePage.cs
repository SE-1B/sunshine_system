using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunshine
{
    public partial class InventoryHomePage : Form
    {
        private string _Id; // User ID
        private string _name; // User Name
        public InventoryHomePage(string Id, string name)
        {
            InitializeComponent();
            _Id = Id;
            _name = name;
        }
        // change the background color of the form to a gradient
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Create a linear gradient from top-left to bottom-right
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.LightSkyBlue, // Start color
                Color.LightYellow,  // End color
                LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void InventoryHomePage_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Welcome, {_name}";

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            InventoryViewProduct viewProduct = new InventoryViewProduct();
            viewProduct.ShowDialog();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Logout confirm?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Hide();
                new LoginPage().ShowDialog();
                this.Close();
            }
        }
    }
}

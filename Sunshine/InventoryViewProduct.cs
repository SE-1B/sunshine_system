using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunshine
{
    public partial class InventoryViewProduct : Form
    {
        public OleDbConnection connStr = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sunshine.accdb;Persist Security Info=False;");
        private DataTable dt = new DataTable();
        private const string baseSQL = "SELECT Product.product_ID, Product.product_name, Product.price, Sum(Product_inventory.qty) AS totalQty, Product.MOQ, Product.color, Product.detail, Product.product_type " +
            "FROM Product INNER JOIN Product_inventory ON Product.product_ID = Product_inventory.product_ID ";
        private const string groupBySQL = "GROUP BY Product.product_ID, Product.product_name, Product.price, Product.MOQ, Product.color, Product.detail, product_type;";

        public InventoryViewProduct()
        {
            InitializeComponent();
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

        private void UpdateGrid(string sqlStr)
        {
            OleDbDataAdapter dataAdapter =
                        new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            dgvDisplay.DataSource = dt;
        }

        private void InventoryViewProduct_Load(object sender, EventArgs e)
        {
            //UpdateGrid("SELECT * FROM Product");
            UpdateGrid(baseSQL + groupBySQL);
        }
    }
}

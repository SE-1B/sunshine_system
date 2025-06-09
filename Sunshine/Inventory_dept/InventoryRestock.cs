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
    public partial class InventoryRestock : Form
    {
        public OleDbConnection connStr = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sunshine.accdb;Persist Security Info=False;");
        private DataTable dt = new DataTable();
        private const string baseSQL = "SELECT * FROM product_inventory WHERE product_ID = ";
        public InventoryRestock()
        {
            InitializeComponent();
        }

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

        private void product_inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sunshineDataSet);

        }

        private void InventoryRestock_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sunshineDataSet.Product_inventory' 資料表。您可以視需要進行移動或移除。
            this.product_inventoryTableAdapter.Fill(this.sunshineDataSet.Product_inventory);

        }
    }
}

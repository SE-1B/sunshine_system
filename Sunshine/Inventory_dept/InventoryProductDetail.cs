using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using System.Windows.Forms;


namespace Sunshine
{
    public partial class InventoryProductDetail : Form
    {
        int _index;
        private LoadImage _loadImage; // Declare an instance of LoadImage
        public OleDbConnection connStr = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sunshine.accdb;Persist Security Info=False;");
        private DataTable dt = new DataTable();
        private const string baseSQL = "SELECT * FROM product_inventory WHERE product_ID = ";

        public InventoryProductDetail()
        {
            InitializeComponent();
            _index = -1; // Default index when no specific product is selected
            _loadImage = new LoadImage(); // Initialize the LoadImage instance
        }

        public InventoryProductDetail(int index)
        {
            InitializeComponent();
            _index = index;
            _loadImage = new LoadImage(); // Initialize the LoadImage instance
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

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sunshineDataSet);

        }

        private void InventoryProductDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sunshineDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.sunshineDataSet1.Product);
            // TODO: This line of code loads data into the 'sunshineDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.sunshineDataSet1.Product);
            // TODO: 這行程式碼會將資料載入 'sunshineDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.sunshineDataSet.Product);
            if (_index < 0 || _index >= productBindingSource.Count)
            {
                productBindingSource.Position = 0;
            }
            else
            {
                // If a specific index is provided, set the position to that index
                productBindingSource.Position = _index; // Set the position to the specified index
            }
            updateData();
        }

        private void productBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void updateData()
        {
            DataRowView currentRow = productBindingSource.Current as DataRowView;
            string url = "", product_ID = "";
            if (currentRow != null)
            {
                url = currentRow["model"].ToString();
                product_ID = currentRow["product_ID"].ToString();
            }

            _loadImage.LoadImageFromWeb(pbProduct, url);
            String sqlStr = $"{baseSQL} '{product_ID}'";
            OleDbDataAdapter dataAdapter =
                        new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            dgvInventory.DataSource = dt;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            productBindingSource.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (productBindingSource.Position > 0)
            {
                productBindingSource.Position--;
                updateData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (productBindingSource.Position < productBindingSource.Count - 1)
            {
                productBindingSource.Position++;
                updateData();
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            productBindingSource.Position = productBindingSource.Count - 1;
            updateData();
        }


        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            productBindingSource.Position = cbName.SelectedIndex;
            updateData();
        }

        private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.sunshineDataSet1);

        }
    }
}

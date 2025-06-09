using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sunshine
{
    public partial class InventoryViewProduct : Form
    {
        // The setup for SendMessage to set placeholder text in TextBoxes
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
        // The end of setup for SendMessage to set placeholder text in TextBoxes

        public OleDbConnection connStr = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sunshine.accdb;Persist Security Info=False;");
        private DataTable dt = new DataTable();
        private const string baseSQL = "SELECT Product.product_ID, Product.product_name, Product.price, Sum(Product_inventory.qty) AS totalQty, Product.MOQ, Product.color, Product.detail, Product.product_type " +
            "FROM Product INNER JOIN Product_inventory ON Product.product_ID = Product_inventory.product_ID ";
        private const string groupBySQL = "GROUP BY Product.product_ID, Product.product_name, Product.price, Product.MOQ, Product.color, Product.detail, product_type;";

        // Custom exception class
        public class InvalidSearchCriteriaException : Exception
        {
            public InvalidSearchCriteriaException(string message) : base(message){}
        }

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
            cbPrice.SelectedIndex = 0; // selects the first item
            cbProductType.SelectedIndex = 0; // selects the first item
            cbQty.SelectedIndex = 0; // selects the first item

            // placeholders for username and password textboxes
            SendMessage(tbPrice.Handle, EM_SETCUEBANNER, 0, "Number only");
            SendMessage(tbPriceBtw.Handle, EM_SETCUEBANNER, 0, "Number only");
            SendMessage(tbQty.Handle, EM_SETCUEBANNER, 0, "Number only");
            SendMessage(tbQtyBtw.Handle, EM_SETCUEBANNER, 0, "Number only");
        }

        private void cbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPrice.SelectedIndex == 5)
            {
                labelAndPrice.Visible = true;
                tbPriceBtw.Visible = true;
            }
            else
            {
                labelAndPrice.Visible = false;
                tbPriceBtw.Visible = false;
            }
        }

        private void cbQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQty.SelectedIndex == 5)
            {
                labelAndQty.Visible = true;
                tbQtyBtw.Visible = true;
            }
            else
            {
                labelAndQty.Visible = false;
                tbQtyBtw.Visible = false;
            }
        }

        private void btnReset_click(object sender, EventArgs e)
        {
            cbPrice.SelectedIndex = 0; // selects the first item
            cbQty.SelectedIndex = 0; // selects the first item
            tbProductName.Clear();
            tbID.Clear();
            tbPrice.Clear();
            tbPriceBtw.Clear();
            cbProductType.SelectedIndex = 0;
            tbQty.Clear();
            tbQtyBtw.Clear();
            UpdateGrid(baseSQL + groupBySQL); // Reset to original query
        }

        private void btnSearch_click(object sender, EventArgs e)
        {
            int numConditions = 0; // Counter for the number of conditions added
            string condition = "WHERE ";  // Initialize the condition for the SQL query
            try
            {
                if (!string.IsNullOrWhiteSpace(tbID.Text))
                {
                    condition += $"Product.product_ID LIKE '%{tbID.Text}%' ";
                    numConditions++;
                }
                if (!string.IsNullOrWhiteSpace(tbProductName.Text))
                {
                    if (numConditions > 0) condition += "AND ";
                    condition += $"Product.product_name LIKE '%{tbProductName.Text}%' ";
                    numConditions++;
                }
                if (!string.IsNullOrWhiteSpace(tbPrice.Text))
                {
                    if (numConditions > 0) condition += "AND ";
                    double priceValue = ToDouble(tbPrice.Text);
                    if (priceValue < 0) { throw new InvalidSearchCriteriaException("Price cannot be negative."); }

                    if (cbPrice.SelectedIndex != 5)
                    {
                        condition += $"Product.price {cbPrice.SelectedItem} {priceValue} ";
                    }
                    else
                    {
                        double priceBtwValue = ToDouble(tbPrice.Text);
                        if (priceBtwValue < 0) { throw new InvalidSearchCriteriaException("Price cannot be negative."); }
                        if (string.IsNullOrWhiteSpace(tbPriceBtw.Text) || tbPriceBtw.Text.Length == 0)
                        {
                            throw new InvalidSearchCriteriaException("Please enter a value for the second price field.");
                        }
                        condition += $"Product.price between {priceValue} and {priceBtwValue} ";
                    }
                    numConditions++;
                }
                if (cbProductType.SelectedIndex > 0)
                {
                    if (numConditions > 0) condition += "AND ";
                    condition += $"Product.product_type = '{cbProductType.SelectedItem}' ";
                    numConditions++;
                }
                if (!string.IsNullOrWhiteSpace(tbQty.Text))
                {
                    if (numConditions > 0) condition += "AND ";
                    double qtyValue = ToDouble(tbQty.Text);
                    if (qtyValue < 0) { throw new InvalidSearchCriteriaException("Price cannot be negative."); }
                    if (cbQty.SelectedIndex != 5)
                    {
                        condition += $"totalQty {cbQty.SelectedItem} {qtyValue} ";
                    }
                    else
                    {
                        double qtyBtwValue = ToDouble(tbQtyBtw.Text);
                        if (qtyBtwValue < 0) { throw new InvalidSearchCriteriaException("Price cannot be negative."); }
                        if (string.IsNullOrWhiteSpace(tbQtyBtw.Text) || tbQtyBtw.Text.Length == 0)
                        {
                            throw new InvalidSearchCriteriaException("Please enter a value for the second price field.");
                        }
                        if (ToDouble(tbQtyBtw.Text) < 0) { throw new InvalidSearchCriteriaException("Qty cannot be negative."); }
                        condition += $"totalQty between {qtyValue} and {qtyBtwValue} ";
                    }
                    numConditions++;
                }
            }
            catch (InvalidSearchCriteriaException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            if (numConditions == 0)
            {
                UpdateGrid(baseSQL + groupBySQL);
            }
            else
            {
                // If there are conditions, append them to the base SQL query
                UpdateGrid(baseSQL + condition + groupBySQL);
            }
        }

        // string to double
        private double ToDouble(string input)
        {
            double result;
            try
            {
                if (double.TryParse(input, out result))
                    return result;
                else
                {
                    throw new Exception("Please enter the number in the respective box");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
        }

        private void btnProductDetail_Click(object sender, EventArgs e)
        {
            InventoryProductDetail inventoryProductDetail;
            // Check if any row is selected in the DataGridView
            if (dgvDisplay.SelectedRows.Count > 0)
            {
                var row = dgvDisplay.SelectedRows[0];
                int index = row.Index;
                inventoryProductDetail = new InventoryProductDetail(index);
            }
            else
            {
                inventoryProductDetail = new InventoryProductDetail();
            }
            inventoryProductDetail.ShowDialog();
        }
    }

}

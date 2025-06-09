using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunshine
{
    public partial class logisticGenerateDeliveryNote : Form
    {
        public logisticGenerateDeliveryNote()
        {
            // Set culture to English (United States) before initializing components
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            InitializeComponent();
            btnGenerate.Click += BtnGenerate_Click;
        }

        private void logisticGenerateDeliveryNote_Load(object sender, EventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            string note_ID = txtNoteID.Text.Trim();
            DateTime delivery_date = dtpDeliveryDate.Value;
            string item = txtItem.Text.Trim();
            int qty = (int)nudQty.Value;
            string location = txtLocation.Text.Trim();
            string cust_order_ID = txtCustOrderID.Text.Trim();
            string supp_order_ID = txtSuppOrderID.Text.Trim();

            if (string.IsNullOrEmpty(note_ID) || string.IsNullOrEmpty(item) || qty <= 0)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            GenerateDeliveryNote(note_ID, delivery_date, item, qty, location, cust_order_ID, supp_order_ID);
        }
        // Add this method to your logisticGenerateDeliveryNote class
        private void GenerateDeliveryNote(string note_ID, DateTime delivery_date, string item, int qty, string location, string cust_order_ID, string supp_order_ID)
        {
            // Example implementation: show a confirmation message
            // Replace with your actual delivery note generation logic
            string message = $"Delivery Note Generated:\n\n" +
                             $"Note ID: {note_ID}\n" +
                             $"Date: {delivery_date.ToShortDateString()}\n" +
                             $"Item: {item}\n" +
                             $"Quantity: {qty}\n" +
                             $"Location: {location}\n" +
                             $"Customer Order ID: {cust_order_ID}\n" +
                             $"Supplier Order ID: {supp_order_ID}";
            MessageBox.Show(message, "Delivery Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

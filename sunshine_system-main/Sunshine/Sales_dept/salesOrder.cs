using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sunshine.Sales_dept
{
    public partial class salesOrder : UserControl
    {
        public salesOrder()
        {
            InitializeComponent();
        }

        private void salesOrder_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            new addOrder().ShowDialog();
        }
    }
}

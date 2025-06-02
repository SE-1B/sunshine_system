using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunshine
{
    public partial class HomePage : Form
    {
        private bool loginSuccess;
        private String departmentType; // Variable to store the department type
        public HomePage(bool loginSuccess, String departmentType, String name)
        {
            InitializeComponent();
            this.loginSuccess = loginSuccess;
            this.departmentType = departmentType;
            welcomeLabel.Text = "Welcome, " + name; // Set the welcome label with the user's name
        }

        private void logout(object sender, EventArgs e)
        {
            MessageBox.Show("Logout success");
            loginSuccess = false;
            departmentType = "00"; // Reset department type
            Form loginForm = new LoginPage(); // Create a new instance of the LoginPage form
            loginForm.Show(); // Show the LoginPage form
            this.Close(); // Close the HomePage form
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sunshineDataSet.Staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.sunshineDataSet.Staff);

        }
    }
}

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
    public partial class DummyHomePage : Form
    {
        private bool loginSuccess;
        private String departmentType; // Variable to store the department type
        public DummyHomePage(bool loginSuccess, String departmentType, String name)
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
            this.Close(); // Close the DummyHomePage form
        }
    }
}

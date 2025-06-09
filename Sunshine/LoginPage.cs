using ManagerSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;  // For SendMessage to set placeholder text in TextBoxes
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sunshine
{
    public partial class LoginPage : Form
    {
        // The setup for SendMessage to set placeholder text in TextBoxes
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
        // The end of setup for SendMessage to set placeholder text in TextBoxes

        public bool loginSuccess = false; // Global variable to track login success
        public String departmentType = "00"; // Variable to store the department type
        public OleDbConnection connStr = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sunshine.accdb;Persist Security Info=False;");

        public LoginPage()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // placeholders for username and password textboxes
            SendMessage(usernameTB.Handle, EM_SETCUEBANNER, 0, "Username");
            SendMessage(passwordTB.Handle, EM_SETCUEBANNER, 0, "Password");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string sqlStr = ""; // SQL query string
            if (usernameTB.Text.Length == 0 ||
                    passwordTB.Text.Length == 0)
            {
                MessageBox.Show("Missing username or password. "
                            + "Please try again.");
                usernameTB.Clear();
                passwordTB.Clear();
            }
            else
            {
                try
                {
                    if (connStr.State != ConnectionState.Open)
                    {
                        connStr.Open();
                    }
                    DataTable dt = new DataTable();
                    sqlStr = $"SELECT * FROM Staff WHERE staff_ID like '__{usernameTB.Text}'";
                    
                    OleDbDataAdapter dataAdapter =
                            new OleDbDataAdapter(sqlStr, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();

                    if (passwordTB.Text.Equals(dt.Rows[0]["staff_pw"]))
                    {
                        string staff_ID = (string)dt.Rows[0]["staff_ID"];
                        string staff_name = (string)dt.Rows[0]["name"];
                        departmentType = (string)dt.Rows[0]["dept_ID"];
                        MessageBox.Show("Login success!");
                        sqlStr = $"SELECT * FROM Department WHERE dept_ID = '{departmentType}'";

                        dataAdapter =
                                new OleDbDataAdapter(sqlStr, connStr);
                        dt.Clear();
                        dataAdapter.Fill(dt);
                        dataAdapter.Dispose();
                        string dept_name = (string)dt.Rows[0]["dept_name"];
                        if (departmentType != "00")
                        {
                            MessageBox.Show($"You are logged in as a {dept_name}.");
                        }
                        else
                        {
                            MessageBox.Show("You have not assigned any job yet.");
                        }
                        // direct to respective home page based on department type

                        if (departmentType == "01")
                        // Redirect to the HomePage for Manager
                        {
                            ManagerSystemHomePage managerSystemHomePage = new ManagerSystemHomePage(staff_ID, staff_name);
                            managerSystemHomePage.Show();
                        }
                        else if (departmentType == "02")
                        {
                            InventoryHomePage inventoryHomePage = new InventoryHomePage(staff_ID, staff_name);
                            inventoryHomePage.Show();
                        }
                        else if (departmentType == "03")
                        // Redirect to the HomePage for Logistic Team  
                        {
                        }
                        else if (departmentType == "04")
                            // Redirect to the HomePage for Sales and Marketing Team
                        {
                            SalesMain salesMain = new SalesMain();
                            salesMain.Show();
                        }
                        else if (departmentType == "05")
                        // Redirect to the HomePage for Product and Supply Chain Team
                        {
                        }
                        else if (departmentType == "06")
                        // Redirect to the HomePage for Finance Team
                        {
                        }

                        if (connStr.State != ConnectionState.Closed)
                        {
                            connStr.Close();
                        }
                        this.Hide(); // Hide the LoginForm, since if it is closed, the program will exit
                    }
                    else
                    {
                        MessageBox.Show("Incorrect user name or password. "
                            + "Please try again.");
                        usernameTB.Clear();
                        passwordTB.Clear();
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nSQL: " + sqlStr);
                }
            }

        }

        private void forget_password_click(object sender, EventArgs e)
        {
            ForgetPassword forgetPasswordForm = new ForgetPassword();
            forgetPasswordForm.ShowDialog();
        }
    }
}

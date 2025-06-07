using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;  // For SendMessage to set placeholder text in TextBoxes
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Sunshine.sunshineDataSetTableAdapters;

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
            string sqlStr = "";
            loginSuccess = false;
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
                    sqlStr = "SELECT * FROM Staff WHERE staff_ID like '__" + usernameTB.Text + "'";
                    
                    OleDbDataAdapter dataAdapter =
                            new OleDbDataAdapter(sqlStr, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();
                    if (passwordTB.Text.Equals(dt.Rows[0]["staff_pw"]))
                            loginSuccess = true;

                    if (loginSuccess)
                    {
                        departmentType = (string)dt.Rows[0]["dept_ID"];
                        HomePage homePage = new HomePage(loginSuccess, departmentType, (string)dt.Rows[0]["name"]);
                        homePage.Show(); // Show the HomePage form
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

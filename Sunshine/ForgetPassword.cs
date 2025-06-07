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
    public partial class ForgetPassword : Form
    {
        public OleDbConnection connStr = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sunshine.accdb;Persist Security Info=False;");

        public ForgetPassword()
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

        public static string GenerateRandomPassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string sqlStr = "";
            if (string.IsNullOrWhiteSpace(emailTB.Text))
            {
                MessageBox.Show("Please enter your email address.");
                return;
            }
            try
            {
                if (connStr.State != ConnectionState.Open)
                {
                    connStr.Open();
                }
                DataTable dt = new DataTable();
                sqlStr = "SELECT * FROM Staff WHERE staff_ID like '__" + emailTB.Text + "'";

                OleDbDataAdapter dataAdapter =
                        new OleDbDataAdapter(sqlStr, connStr);
                dataAdapter.Fill(dt);
                dataAdapter.Dispose();

                if (foodTB.Text.Equals((String)dt.Rows[0]["favourite_food"]))
                {
                    // Simulate sending an email (to be done later)
                    MessageBox.Show("A password reset has been sent to your email address.");
                    // Generate a new password
                    string newPassword = GenerateRandomPassword(12);
                    // Update the user's password in the database
                    string updateSql = "UPDATE Staff SET staff_pw = ? WHERE staff_ID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(updateSql, connStr))
                    {
                        cmd.Parameters.AddWithValue("?", newPassword);
                        cmd.Parameters.AddWithValue("?", dt.Rows[0]["staff_ID"]);
                        cmd.ExecuteNonQuery();
                    }

                    // Show the new password to the user
                    newPasswordLabel.Text = "New password: " + newPassword;
                }
                else
                {
                    // Hint the first letter of the answer
                    string hint = dt.Rows[0]["favourite_food"].ToString().Substring(0, 1) + "****";
                    MessageBox.Show("You answer the security question incorrectly. Please try again.\n" + "Hint: " + hint);
                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
                return;
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the ForgetPassword form and return to the login page
        }
    }
}

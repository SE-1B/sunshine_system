using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTB.Text))
            {
                MessageBox.Show("Please enter your email address.");
                return;
            }
            if (emailTB.Text.Equals("admin1@sunshine.com"))
            {
                // Simulate sending an email (to be done later)
                MessageBox.Show("A password reset link has been sent to your email address.");
                // Generate a new password
                string newPassword = GenerateRandomPassword(12);
                // Update the user's password in the database (to be done later)

                // Show the new password to the user
                newPasswordLabel.Text = newPassword;
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.");
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the ForgetPassword form and return to the login page
        }
    }
}

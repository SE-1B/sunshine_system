namespace Sunshine
{
    partial class ForgetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "A new password will be send to your email";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(47, 98);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(317, 25);
            this.emailTB.TabIndex = 2;
            this.emailTB.Text = "admin1@sunshine.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "New password:";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(143, 164);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(0, 15);
            this.newPasswordLabel.TabIndex = 4;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(47, 199);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 5;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(146, 199);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(75, 23);
            this.returnBtn.TabIndex = 6;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 273);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button returnBtn;
    }
}
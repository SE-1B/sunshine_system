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
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.foodTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(47, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "A new password will be send to your email";
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.emailTB.Location = new System.Drawing.Point(53, 118);
            this.emailTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(356, 46);
            this.emailTB.TabIndex = 2;
            this.emailTB.Text = "00000000";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPasswordLabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.newPasswordLabel.Location = new System.Drawing.Point(50, 326);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(201, 32);
            this.newPasswordLabel.TabIndex = 3;
            this.newPasswordLabel.Text = "New password:";
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendBtn.Location = new System.Drawing.Point(50, 375);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(155, 48);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnBtn.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.returnBtn.Location = new System.Drawing.Point(221, 375);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(155, 48);
            this.returnBtn.TabIndex = 6;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(415, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "@sunshine.com";
            // 
            // foodTB
            // 
            this.foodTB.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.foodTB.Location = new System.Drawing.Point(53, 225);
            this.foodTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.foodTB.Name = "foodTB";
            this.foodTB.Size = new System.Drawing.Size(356, 46);
            this.foodTB.TabIndex = 8;
            this.foodTB.Text = "apple";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(47, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "What is your favourite food?";
            // 
            // ForgetPassword
            // 
            this.AcceptButton = this.sendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.returnBtn;
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.foodTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox foodTB;
        private System.Windows.Forms.Label label5;
    }
}
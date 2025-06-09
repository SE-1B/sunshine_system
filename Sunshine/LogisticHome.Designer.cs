namespace Sunshine
{
    partial class LogisticHome
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
            this.btnGenerateDeliveryNote = new System.Windows.Forms.Button();
            this.btnGoodTransfer = new System.Windows.Forms.Button();
            this.btnUpdateCustomerOrder = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_CompanyIcon = new System.Windows.Forms.PictureBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CompanyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateDeliveryNote
            // 
            this.btnGenerateDeliveryNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerateDeliveryNote.Location = new System.Drawing.Point(322, 331);
            this.btnGenerateDeliveryNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateDeliveryNote.Name = "btnGenerateDeliveryNote";
            this.btnGenerateDeliveryNote.Size = new System.Drawing.Size(349, 37);
            this.btnGenerateDeliveryNote.TabIndex = 17;
            this.btnGenerateDeliveryNote.Text = "Generate Delivery Note";
            this.btnGenerateDeliveryNote.UseVisualStyleBackColor = false;
            this.btnGenerateDeliveryNote.Click += new System.EventHandler(this.btnGenerateDeliveryNote_Click);
            // 
            // btnGoodTransfer
            // 
            this.btnGoodTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGoodTransfer.Location = new System.Drawing.Point(322, 239);
            this.btnGoodTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoodTransfer.Name = "btnGoodTransfer";
            this.btnGoodTransfer.Size = new System.Drawing.Size(349, 37);
            this.btnGoodTransfer.TabIndex = 15;
            this.btnGoodTransfer.Text = "Update Status for Good Delivery";
            this.btnGoodTransfer.UseVisualStyleBackColor = false;
            this.btnGoodTransfer.Click += new System.EventHandler(this.btnGoodTransfer_Click);
            // 
            // btnUpdateCustomerOrder
            // 
            this.btnUpdateCustomerOrder.Location = new System.Drawing.Point(322, 148);
            this.btnUpdateCustomerOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCustomerOrder.Name = "btnUpdateCustomerOrder";
            this.btnUpdateCustomerOrder.Size = new System.Drawing.Size(349, 37);
            this.btnUpdateCustomerOrder.TabIndex = 14;
            this.btnUpdateCustomerOrder.Text = "Update Status of Customer Order";
            this.btnUpdateCustomerOrder.UseVisualStyleBackColor = true;
            this.btnUpdateCustomerOrder.Click += new System.EventHandler(this.btnUpdateCustomerOrder_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(240, 100);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(74, 12);
            this.labelWelcome.TabIndex = 13;
            this.labelWelcome.Text = "Welcome back";
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnLogout.Location = new System.Drawing.Point(56, 330);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 37);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 450);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox_CompanyIcon);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 112);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox_CompanyIcon
            // 
            this.pictureBox_CompanyIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CompanyIcon.Image = global::Sunshine.Properties.Resources.companyIcon;
            this.pictureBox_CompanyIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_CompanyIcon.Name = "pictureBox_CompanyIcon";
            this.pictureBox_CompanyIcon.Size = new System.Drawing.Size(183, 112);
            this.pictureBox_CompanyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CompanyIcon.TabIndex = 0;
            this.pictureBox_CompanyIcon.TabStop = false;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDepartment.Location = new System.Drawing.Point(204, 31);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(584, 24);
            this.lblDepartment.TabIndex = 19;
            this.lblDepartment.Text = "Logistic Department of Smile and SunShine Co., Limited";
            this.lblDepartment.Click += new System.EventHandler(this.lblDepartment_Click);
            // 
            // LogisticHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.btnGenerateDeliveryNote);
            this.Controls.Add(this.btnGoodTransfer);
            this.Controls.Add(this.btnUpdateCustomerOrder);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.panel1);
            this.Name = "LogisticHome";
            this.Text = "Logistic Department Home Page";
            this.Load += new System.EventHandler(this.LogisticHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CompanyIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateDeliveryNote;
        private System.Windows.Forms.Button btnGoodTransfer;
        private System.Windows.Forms.Button btnUpdateCustomerOrder;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_CompanyIcon;
        private System.Windows.Forms.Label lblDepartment;
    }
}
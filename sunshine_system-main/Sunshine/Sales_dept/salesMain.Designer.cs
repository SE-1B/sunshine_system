namespace Sunshine
{
    partial class salesMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.reBtn = new System.Windows.Forms.Button();
            this.cusBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.dashBtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salesCustomer1 = new Sunshine.Sales_dept.salesCustomer();
            this.salesOrder1 = new Sunshine.Sales_dept.salesOrder();
            this.salesDashboard1 = new Sunshine.Sales_dept.salesDashboard();
            this.salesReport1 = new Sunshine.Sales_dept.salesReport();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.reBtn);
            this.panel2.Controls.Add(this.cusBtn);
            this.panel2.Controls.Add(this.orderBtn);
            this.panel2.Controls.Add(this.dashBtn);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 838);
            this.panel2.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.logoutBtn.Location = new System.Drawing.Point(12, 781);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(236, 45);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // reBtn
            // 
            this.reBtn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reBtn.Location = new System.Drawing.Point(12, 525);
            this.reBtn.Name = "reBtn";
            this.reBtn.Size = new System.Drawing.Size(236, 64);
            this.reBtn.TabIndex = 6;
            this.reBtn.Text = "Report";
            this.reBtn.UseVisualStyleBackColor = true;
            this.reBtn.Click += new System.EventHandler(this.reBtn_Click);
            // 
            // cusBtn
            // 
            this.cusBtn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cusBtn.Location = new System.Drawing.Point(12, 437);
            this.cusBtn.Name = "cusBtn";
            this.cusBtn.Size = new System.Drawing.Size(236, 64);
            this.cusBtn.TabIndex = 5;
            this.cusBtn.Text = "Customer";
            this.cusBtn.UseVisualStyleBackColor = true;
            this.cusBtn.Click += new System.EventHandler(this.cusBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.orderBtn.Location = new System.Drawing.Point(12, 351);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(236, 64);
            this.orderBtn.TabIndex = 4;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashBtn
            // 
            this.dashBtn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dashBtn.Location = new System.Drawing.Point(12, 264);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Size = new System.Drawing.Size(236, 64);
            this.dashBtn.TabIndex = 3;
            this.dashBtn.Text = "Dashboard";
            this.dashBtn.UseVisualStyleBackColor = true;
            this.dashBtn.Click += new System.EventHandler(this.dashBtn_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.username.Location = new System.Drawing.Point(117, 224);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(140, 37);
            this.username.TabIndex = 2;
            this.username.Text = "Leo";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sunshine.Properties.Resources.toy;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // salesCustomer1
            // 
            this.salesCustomer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesCustomer1.Location = new System.Drawing.Point(254, 3);
            this.salesCustomer1.Name = "salesCustomer1";
            this.salesCustomer1.Size = new System.Drawing.Size(1457, 845);
            this.salesCustomer1.TabIndex = 4;
            // 
            // salesOrder1
            // 
            this.salesOrder1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesOrder1.Location = new System.Drawing.Point(254, 0);
            this.salesOrder1.Name = "salesOrder1";
            this.salesOrder1.Size = new System.Drawing.Size(1457, 838);
            this.salesOrder1.TabIndex = 3;
            // 
            // salesDashboard1
            // 
            this.salesDashboard1.Dock = System.Windows.Forms.DockStyle.Right;
            this.salesDashboard1.Location = new System.Drawing.Point(265, 0);
            this.salesDashboard1.Name = "salesDashboard1";
            this.salesDashboard1.Size = new System.Drawing.Size(1446, 838);
            this.salesDashboard1.TabIndex = 2;
            // 
            // salesReport1
            // 
            this.salesReport1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesReport1.Location = new System.Drawing.Point(254, 3);
            this.salesReport1.Name = "salesReport1";
            this.salesReport1.Size = new System.Drawing.Size(1457, 835);
            this.salesReport1.TabIndex = 5;
            // 
            // salesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 838);
            this.Controls.Add(this.salesReport1);
            this.Controls.Add(this.salesCustomer1);
            this.Controls.Add(this.salesOrder1);
            this.Controls.Add(this.salesDashboard1);
            this.Controls.Add(this.panel2);
            this.Name = "salesMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales and Marketing Management System";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button dashBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button reBtn;
        private System.Windows.Forms.Button cusBtn;
        private Sales_dept.salesDashboard salesDashboard1;
        private Sales_dept.salesOrder salesOrder1;
        private Sales_dept.salesCustomer salesCustomer1;
        private Sales_dept.salesReport salesReport1;
    }
}
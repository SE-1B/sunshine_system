namespace Sunshine
{
    partial class ProductionSupplyHome
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnDisplayOrder = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnModifyOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_CompanyIcon = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSideBar_EmpHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CompanyIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.labelWelcome.Location = new System.Drawing.Point(218, 86);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(85, 15);
            this.labelWelcome.TabIndex = 28;
            this.labelWelcome.Text = "Welcome Back";
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // btnDisplayOrder
            // 
            this.btnDisplayOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDisplayOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayOrder.Location = new System.Drawing.Point(876, 267);
            this.btnDisplayOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplayOrder.Name = "btnDisplayOrder";
            this.btnDisplayOrder.Size = new System.Drawing.Size(110, 39);
            this.btnDisplayOrder.TabIndex = 25;
            this.btnDisplayOrder.Text = "Display Order";
            this.btnDisplayOrder.UseVisualStyleBackColor = false;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(221, 118);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersWidth = 51;
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.Size = new System.Drawing.Size(649, 365);
            this.dgvDisplay.TabIndex = 24;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnDeleteOrder.Location = new System.Drawing.Point(876, 445);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(110, 39);
            this.btnDeleteOrder.TabIndex = 22;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.BackColor = System.Drawing.Color.Cyan;
            this.btnModifyOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnModifyOrder.Location = new System.Drawing.Point(876, 387);
            this.btnModifyOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(110, 39);
            this.btnModifyOrder.TabIndex = 21;
            this.btnModifyOrder.Text = "Modify Order";
            this.btnModifyOrder.UseVisualStyleBackColor = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(876, 327);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(110, 39);
            this.btnAddOrder.TabIndex = 20;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(316, 23);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(474, 31);
            this.lblDepartment.TabIndex = 30;
            this.lblDepartment.Text = "Production and Supply Chain Department";
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
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnLogout.Location = new System.Drawing.Point(53, 445);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 37);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSideBar_EmpHome
            // 
            this.btnSideBar_EmpHome.BackColor = System.Drawing.Color.Transparent;
            this.btnSideBar_EmpHome.FlatAppearance.BorderSize = 0;
            this.btnSideBar_EmpHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideBar_EmpHome.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnSideBar_EmpHome.Location = new System.Drawing.Point(3, 132);
            this.btnSideBar_EmpHome.Name = "btnSideBar_EmpHome";
            this.btnSideBar_EmpHome.Size = new System.Drawing.Size(177, 79);
            this.btnSideBar_EmpHome.TabIndex = 10;
            this.btnSideBar_EmpHome.Text = "Home";
            this.btnSideBar_EmpHome.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSideBar_EmpHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 583);
            this.panel1.TabIndex = 23;
            // 
            // ProductionSupplyHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 583);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnDisplayOrder);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnModifyOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.panel1);
            this.Name = "ProductionSupplyHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production & Supply Chain Department Home Page";
            this.Load += new System.EventHandler(this.ProductionSupplyHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CompanyIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnDisplayOrder;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnModifyOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_CompanyIcon;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSideBar_EmpHome;
        private System.Windows.Forms.Panel panel1;
    }
}
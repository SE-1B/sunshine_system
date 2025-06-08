namespace Sunshine
{
    partial class InventoryHomePage
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSideBar_EmpHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_CompanyIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CompanyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(276, 69);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(90, 15);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome back";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(280, 138);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(465, 46);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View product";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRestock.Location = new System.Drawing.Point(280, 214);
            this.btnRestock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(465, 46);
            this.btnRestock.TabIndex = 3;
            this.btnRestock.Text = "Restock poduct";
            this.btnRestock.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(280, 357);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(465, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete product";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnLogout.Location = new System.Drawing.Point(74, 413);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 46);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(280, 281);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(465, 46);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit porduct";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSideBar_EmpHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 494);
            this.panel1.TabIndex = 12;
            // 
            // btnSideBar_EmpHome
            // 
            this.btnSideBar_EmpHome.BackColor = System.Drawing.Color.Transparent;
            this.btnSideBar_EmpHome.FlatAppearance.BorderSize = 0;
            this.btnSideBar_EmpHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideBar_EmpHome.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnSideBar_EmpHome.Location = new System.Drawing.Point(4, 165);
            this.btnSideBar_EmpHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnSideBar_EmpHome.Name = "btnSideBar_EmpHome";
            this.btnSideBar_EmpHome.Size = new System.Drawing.Size(236, 99);
            this.btnSideBar_EmpHome.TabIndex = 10;
            this.btnSideBar_EmpHome.Text = "Home";
            this.btnSideBar_EmpHome.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox_CompanyIcon);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 140);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox_CompanyIcon
            // 
            this.pictureBox_CompanyIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CompanyIcon.Image = global::Sunshine.Properties.Resources.companyIcon;
            this.pictureBox_CompanyIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_CompanyIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_CompanyIcon.Name = "pictureBox_CompanyIcon";
            this.pictureBox_CompanyIcon.Size = new System.Drawing.Size(244, 140);
            this.pictureBox_CompanyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CompanyIcon.TabIndex = 0;
            this.pictureBox_CompanyIcon.TabStop = false;
            // 
            // InventoryHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.labelWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventoryHomePage";
            this.Text = "InventoryHomePage";
            this.Load += new System.EventHandler(this.InventoryHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CompanyIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSideBar_EmpHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_CompanyIcon;
    }
}
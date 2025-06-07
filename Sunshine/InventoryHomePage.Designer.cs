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
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(60, 47);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(113, 20);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome back";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(64, 138);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(523, 62);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View product";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRestock.Location = new System.Drawing.Point(64, 240);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(523, 62);
            this.btnRestock.TabIndex = 3;
            this.btnRestock.Text = "Restock poduct";
            this.btnRestock.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(64, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(523, 62);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete product";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnLogout.Location = new System.Drawing.Point(541, 26);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 62);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(64, 329);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(523, 62);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit porduct";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // InventoryHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 571);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.labelWelcome);
            this.Name = "InventoryHomePage";
            this.Text = "InventoryHomePage";
            this.Load += new System.EventHandler(this.InventoryHomePage_Load);
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
    }
}
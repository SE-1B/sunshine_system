namespace Sunshine
{
    partial class logisticUpdateCustomerOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_CompanyIcon = new System.Windows.Forms.PictureBox();
            this.btnReturnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHaveProblem = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbComplete = new System.Windows.Forms.CheckBox();
            this.cbWait = new System.Windows.Forms.CheckBox();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.btnAddRemark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CompanyIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 33);
            this.label1.TabIndex = 30;
            this.label1.Text = "Logistic Department of Smile and Sunshine Co., Ltd.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 314);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.Location = new System.Drawing.Point(681, 510);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(255, 82);
            this.btnUpdateStatus.TabIndex = 20;
            this.btnUpdateStatus.Text = "Update  Status of Customer Order ";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox_CompanyIcon);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 121);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox_CompanyIcon
            // 
            this.pictureBox_CompanyIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CompanyIcon.Image = global::Sunshine.Properties.Resources.companyIcon;
            this.pictureBox_CompanyIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_CompanyIcon.Name = "pictureBox_CompanyIcon";
            this.pictureBox_CompanyIcon.Size = new System.Drawing.Size(183, 121);
            this.pictureBox_CompanyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CompanyIcon.TabIndex = 0;
            this.pictureBox_CompanyIcon.TabStop = false;
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.BackColor = System.Drawing.Color.IndianRed;
            this.btnReturnHome.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnReturnHome.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnReturnHome.Location = new System.Drawing.Point(28, 451);
            this.btnReturnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(117, 79);
            this.btnReturnHome.TabIndex = 7;
            this.btnReturnHome.Text = "Home";
            this.btnReturnHome.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnReturnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 592);
            this.panel1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHaveProblem);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cbComplete);
            this.groupBox1.Controls.Add(this.cbWait);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(681, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 88);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please select status:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbHaveProblem
            // 
            this.cbHaveProblem.AutoSize = true;
            this.cbHaveProblem.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbHaveProblem.Location = new System.Drawing.Point(109, 56);
            this.cbHaveProblem.Name = "cbHaveProblem";
            this.cbHaveProblem.Size = new System.Drawing.Size(113, 16);
            this.cbHaveProblem.TabIndex = 3;
            this.cbHaveProblem.Text = "4:Have Problem";
            this.cbHaveProblem.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(109, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "2:Process";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbComplete
            // 
            this.cbComplete.AutoSize = true;
            this.cbComplete.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbComplete.Location = new System.Drawing.Point(6, 56);
            this.cbComplete.Name = "cbComplete";
            this.cbComplete.Size = new System.Drawing.Size(88, 16);
            this.cbComplete.TabIndex = 1;
            this.cbComplete.Text = "3:Complete";
            this.cbComplete.UseVisualStyleBackColor = true;
            // 
            // cbWait
            // 
            this.cbWait.AutoSize = true;
            this.cbWait.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbWait.Location = new System.Drawing.Point(6, 22);
            this.cbWait.Name = "cbWait";
            this.cbWait.Size = new System.Drawing.Size(61, 16);
            this.cbWait.TabIndex = 0;
            this.cbWait.Text = "1:Wait";
            this.cbWait.UseVisualStyleBackColor = true;
            // 
            // tbRemark
            // 
            this.tbRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemark.Location = new System.Drawing.Point(252, 455);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(298, 137);
            this.tbRemark.TabIndex = 39;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Location = new System.Drawing.Point(249, 433);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(68, 15);
            this.lblRemark.TabIndex = 40;
            this.lblRemark.Text = "Remarks:";
            this.lblRemark.Click += new System.EventHandler(this.lblRemark_Click);
            // 
            // btnAddRemark
            // 
            this.btnAddRemark.BackColor = System.Drawing.Color.Cyan;
            this.btnAddRemark.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnAddRemark.Location = new System.Drawing.Point(555, 455);
            this.btnAddRemark.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRemark.Name = "btnAddRemark";
            this.btnAddRemark.Size = new System.Drawing.Size(122, 137);
            this.btnAddRemark.TabIndex = 41;
            this.btnAddRemark.Text = "Add Remarks";
            this.btnAddRemark.UseVisualStyleBackColor = false;
            // 
            // logisticUpdateCustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 592);
            this.Controls.Add(this.btnAddRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.panel1);
            this.Name = "logisticUpdateCustomerOrder";
            this.Text = "Update Status of Customer Order";
            this.Load += new System.EventHandler(this.logisticUpdateCustomerOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CompanyIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_CompanyIcon;
        private System.Windows.Forms.Button btnReturnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbHaveProblem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cbComplete;
        private System.Windows.Forms.CheckBox cbWait;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button btnAddRemark;
    }
}
namespace Sunshine
{
    partial class InventoryViewProduct
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
            this.btnProductDetail = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbQty = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbQtyBtw = new System.Windows.Forms.TextBox();
            this.tbPriceBtw = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAndQty = new System.Windows.Forms.Label();
            this.labelAndPrice = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductDetail
            // 
            this.btnProductDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProductDetail.Location = new System.Drawing.Point(12, 609);
            this.btnProductDetail.Name = "btnProductDetail";
            this.btnProductDetail.Size = new System.Drawing.Size(375, 65);
            this.btnProductDetail.TabIndex = 20;
            this.btnProductDetail.Text = "Product Detail";
            this.btnProductDetail.UseVisualStyleBackColor = false;
            this.btnProductDetail.Click += new System.EventHandler(this.btnProductDetail_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(12, 12);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersWidth = 51;
            this.dgvDisplay.RowTemplate.Height = 27;
            this.dgvDisplay.Size = new System.Drawing.Size(791, 308);
            this.dgvDisplay.TabIndex = 22;
            // 
            // cbPrice
            // 
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Items.AddRange(new object[] {
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "between"});
            this.cbPrice.Location = new System.Drawing.Point(201, 71);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(56, 23);
            this.cbPrice.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(287, 3);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(151, 25);
            this.tbID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Searching";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(287, 37);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(151, 25);
            this.tbProductName.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Product Name ";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(287, 71);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(151, 25);
            this.tbPrice.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Product Type";
            // 
            // cbProductType
            // 
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Items.AddRange(new object[] {
            "E",
            "T"});
            this.cbProductType.Location = new System.Drawing.Point(287, 105);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(151, 23);
            this.cbProductType.TabIndex = 34;
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(287, 139);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(151, 25);
            this.tbQty.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Quantity";
            // 
            // cbQty
            // 
            this.cbQty.FormattingEnabled = true;
            this.cbQty.Items.AddRange(new object[] {
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "between"});
            this.cbQty.Location = new System.Drawing.Point(201, 139);
            this.cbQty.Name = "cbQty";
            this.cbQty.Size = new System.Drawing.Size(56, 23);
            this.cbQty.TabIndex = 35;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.65812F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.34188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbQty, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPrice, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbQty, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbProductName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbProductType, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbQtyBtw, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPriceBtw, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAndQty, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelAndPrice, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 360);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 170);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "=";
            // 
            // tbQtyBtw
            // 
            this.tbQtyBtw.Location = new System.Drawing.Point(520, 139);
            this.tbQtyBtw.Name = "tbQtyBtw";
            this.tbQtyBtw.Size = new System.Drawing.Size(151, 25);
            this.tbQtyBtw.TabIndex = 41;
            // 
            // tbPriceBtw
            // 
            this.tbPriceBtw.Location = new System.Drawing.Point(520, 71);
            this.tbPriceBtw.Name = "tbPriceBtw";
            this.tbPriceBtw.Size = new System.Drawing.Size(151, 25);
            this.tbPriceBtw.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "=";
            // 
            // labelAndQty
            // 
            this.labelAndQty.AutoSize = true;
            this.labelAndQty.Location = new System.Drawing.Point(466, 136);
            this.labelAndQty.Name = "labelAndQty";
            this.labelAndQty.Size = new System.Drawing.Size(27, 15);
            this.labelAndQty.TabIndex = 44;
            this.labelAndQty.Text = "and";
            // 
            // labelAndPrice
            // 
            this.labelAndPrice.AutoSize = true;
            this.labelAndPrice.Location = new System.Drawing.Point(466, 68);
            this.labelAndPrice.Name = "labelAndPrice";
            this.labelAndPrice.Size = new System.Drawing.Size(27, 15);
            this.labelAndPrice.TabIndex = 43;
            this.labelAndPrice.Text = "and";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(12, 536);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(201, 47);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(255, 552);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 15);
            this.label12.TabIndex = 41;
            this.label12.Text = "Leave in blank means no crititea is checked";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.Location = new System.Drawing.Point(579, 536);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(201, 47);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_click);
            // 
            // InventoryViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 681);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.btnProductDetail);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventoryViewProduct";
            this.Text = "InventoryViewProduct";
            this.Load += new System.EventHandler(this.InventoryViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProductDetail;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.ComboBox cbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbQty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbQtyBtw;
        private System.Windows.Forms.TextBox tbPriceBtw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAndPrice;
        private System.Windows.Forms.Label labelAndQty;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReset;
    }
}
namespace Sunshine
{
    partial class InventoryRestock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryRestock));
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label inventory_IDLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label low_qty_warningLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.sunshineDataSet = new Sunshine.sunshineDataSet();
            this.product_inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_inventoryTableAdapter = new Sunshine.sunshineDataSetTableAdapters.Product_inventoryTableAdapter();
            this.tableAdapterManager = new Sunshine.sunshineDataSetTableAdapters.TableAdapterManager();
            this.product_inventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.product_inventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.product_IDTextBox = new System.Windows.Forms.TextBox();
            this.inventory_IDTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.low_qty_warningTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRestock = new System.Windows.Forms.Button();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            product_IDLabel = new System.Windows.Forms.Label();
            inventory_IDLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            low_qty_warningLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunshineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_inventoryBindingNavigator)).BeginInit();
            this.product_inventoryBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Inventory data";
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(28, 295);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 27;
            this.dgvInventory.Size = new System.Drawing.Size(709, 192);
            this.dgvInventory.TabIndex = 10;
            // 
            // sunshineDataSet
            // 
            this.sunshineDataSet.DataSetName = "sunshineDataSet";
            this.sunshineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_inventoryBindingSource
            // 
            this.product_inventoryBindingSource.DataMember = "Product_inventory";
            this.product_inventoryBindingSource.DataSource = this.sunshineDataSet;
            // 
            // product_inventoryTableAdapter
            // 
            this.product_inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComponentTableAdapter = null;
            this.tableAdapterManager.Cust_chatTableAdapter = null;
            this.tableAdapterManager.Cust_orderTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.Delivery_noteTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.FactoryTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.Material_inventoryTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.Order_materialTableAdapter = null;
            this.tableAdapterManager.Product_inventoryTableAdapter = this.product_inventoryTableAdapter;
            this.tableAdapterManager.Product_materialTableAdapter = null;
            this.tableAdapterManager.Production_lineTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.QuotationTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Supplier_orderTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.Transfer_formTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sunshine.sunshineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.事件TableAdapter = null;
            // 
            // product_inventoryBindingNavigator
            // 
            this.product_inventoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.product_inventoryBindingNavigator.BindingSource = this.product_inventoryBindingSource;
            this.product_inventoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.product_inventoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.product_inventoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.product_inventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.product_inventoryBindingNavigatorSaveItem});
            this.product_inventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.product_inventoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.product_inventoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.product_inventoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.product_inventoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.product_inventoryBindingNavigator.Name = "product_inventoryBindingNavigator";
            this.product_inventoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.product_inventoryBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.product_inventoryBindingNavigator.TabIndex = 12;
            this.product_inventoryBindingNavigator.Text = "bindingNavigator1";
            this.product_inventoryBindingNavigator.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // product_inventoryBindingNavigatorSaveItem
            // 
            this.product_inventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.product_inventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("product_inventoryBindingNavigatorSaveItem.Image")));
            this.product_inventoryBindingNavigatorSaveItem.Name = "product_inventoryBindingNavigatorSaveItem";
            this.product_inventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.product_inventoryBindingNavigatorSaveItem.Text = "儲存資料";
            this.product_inventoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.product_inventoryBindingNavigatorSaveItem_Click);
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Location = new System.Drawing.Point(19, 61);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(73, 15);
            product_IDLabel.TabIndex = 12;
            product_IDLabel.Text = "product ID:";
            // 
            // product_IDTextBox
            // 
            this.product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_inventoryBindingSource, "product_ID", true));
            this.product_IDTextBox.Location = new System.Drawing.Point(129, 58);
            this.product_IDTextBox.Name = "product_IDTextBox";
            this.product_IDTextBox.Size = new System.Drawing.Size(100, 25);
            this.product_IDTextBox.TabIndex = 13;
            // 
            // inventory_IDLabel
            // 
            inventory_IDLabel.AutoSize = true;
            inventory_IDLabel.Location = new System.Drawing.Point(19, 92);
            inventory_IDLabel.Name = "inventory_IDLabel";
            inventory_IDLabel.Size = new System.Drawing.Size(84, 15);
            inventory_IDLabel.TabIndex = 14;
            inventory_IDLabel.Text = "inventory ID:";
            // 
            // inventory_IDTextBox
            // 
            this.inventory_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_inventoryBindingSource, "inventory_ID", true));
            this.inventory_IDTextBox.Location = new System.Drawing.Point(129, 89);
            this.inventory_IDTextBox.Name = "inventory_IDTextBox";
            this.inventory_IDTextBox.Size = new System.Drawing.Size(100, 25);
            this.inventory_IDTextBox.TabIndex = 15;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(19, 123);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(29, 15);
            qtyLabel.TabIndex = 16;
            qtyLabel.Text = "qty:";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_inventoryBindingSource, "qty", true));
            this.qtyTextBox.Location = new System.Drawing.Point(129, 120);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(100, 25);
            this.qtyTextBox.TabIndex = 17;
            // 
            // low_qty_warningLabel
            // 
            low_qty_warningLabel.AutoSize = true;
            low_qty_warningLabel.Location = new System.Drawing.Point(19, 154);
            low_qty_warningLabel.Name = "low_qty_warningLabel";
            low_qty_warningLabel.Size = new System.Drawing.Size(104, 15);
            low_qty_warningLabel.TabIndex = 18;
            low_qty_warningLabel.Text = "low qty warning:";
            // 
            // low_qty_warningTextBox
            // 
            this.low_qty_warningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_inventoryBindingSource, "low_qty_warning", true));
            this.low_qty_warningTextBox.Location = new System.Drawing.Point(129, 151);
            this.low_qty_warningTextBox.Name = "low_qty_warningTextBox";
            this.low_qty_warningTextBox.Size = new System.Drawing.Size(100, 25);
            this.low_qty_warningTextBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(49, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 20;
            label2.Text = "Restock";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_inventoryBindingSource, "product_ID", true));
            this.textBox1.Location = new System.Drawing.Point(127, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 58);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 22;
            label3.Text = "inventory ID:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_inventoryBindingSource, "inventory_ID", true));
            this.textBox2.Location = new System.Drawing.Point(127, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestock);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(332, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 183);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restock";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbName);
            this.groupBox2.Controls.Add(this.product_IDTextBox);
            this.groupBox2.Controls.Add(this.low_qty_warningTextBox);
            this.groupBox2.Controls.Add(product_IDLabel);
            this.groupBox2.Controls.Add(low_qty_warningLabel);
            this.groupBox2.Controls.Add(this.qtyTextBox);
            this.groupBox2.Controls.Add(inventory_IDLabel);
            this.groupBox2.Controls.Add(qtyLabel);
            this.groupBox2.Controls.Add(this.inventory_IDTextBox);
            this.groupBox2.Location = new System.Drawing.Point(28, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 187);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail";
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRestock.Location = new System.Drawing.Point(20, 94);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(207, 41);
            this.btnRestock.TabIndex = 24;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = false;
            // 
            // cbName
            // 
            this.cbName.BackColor = System.Drawing.SystemColors.Info;
            this.cbName.DisplayMember = "product_name";
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(16, 24);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(213, 23);
            this.cbName.TabIndex = 30;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(332, 234);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 29;
            this.btnLast.Text = "&Last";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(235, 234);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(138, 234);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 27;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(37, 234);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 26;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // InventoryRestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 515);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.product_inventoryBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInventory);
            this.Name = "InventoryRestock";
            this.Text = "InventoryRestock";
            this.Load += new System.EventHandler(this.InventoryRestock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunshineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_inventoryBindingNavigator)).EndInit();
            this.product_inventoryBindingNavigator.ResumeLayout(false);
            this.product_inventoryBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventory;
        private sunshineDataSet sunshineDataSet;
        private System.Windows.Forms.BindingSource product_inventoryBindingSource;
        private sunshineDataSetTableAdapters.Product_inventoryTableAdapter product_inventoryTableAdapter;
        private sunshineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator product_inventoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton product_inventoryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox product_IDTextBox;
        private System.Windows.Forms.TextBox inventory_IDTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox low_qty_warningTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
    }
}
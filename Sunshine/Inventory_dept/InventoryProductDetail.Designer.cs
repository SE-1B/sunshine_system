namespace Sunshine
{
    partial class InventoryProductDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryProductDetail));
            System.Windows.Forms.Label product_IDLabel1;
            System.Windows.Forms.Label product_nameLabel1;
            System.Windows.Forms.Label priceLabel1;
            System.Windows.Forms.Label mOQLabel1;
            System.Windows.Forms.Label modelLabel1;
            System.Windows.Forms.Label colorLabel1;
            System.Windows.Forms.Label detailLabel1;
            System.Windows.Forms.Label product_typeLabel1;
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.sunshineDataSet1 = new Sunshine.sunshineDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter1 = new Sunshine.sunshineDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager1 = new Sunshine.sunshineDataSetTableAdapters.TableAdapterManager();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.product_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.product_nameTextBox1 = new System.Windows.Forms.TextBox();
            this.priceTextBox1 = new System.Windows.Forms.TextBox();
            this.mOQTextBox1 = new System.Windows.Forms.TextBox();
            this.modelTextBox1 = new System.Windows.Forms.TextBox();
            this.colorTextBox1 = new System.Windows.Forms.TextBox();
            this.detailTextBox1 = new System.Windows.Forms.TextBox();
            this.product_typeTextBox1 = new System.Windows.Forms.TextBox();
            product_IDLabel1 = new System.Windows.Forms.Label();
            product_nameLabel1 = new System.Windows.Forms.Label();
            priceLabel1 = new System.Windows.Forms.Label();
            mOQLabel1 = new System.Windows.Forms.Label();
            modelLabel1 = new System.Windows.Forms.Label();
            colorLabel1 = new System.Windows.Forms.Label();
            detailLabel1 = new System.Windows.Forms.Label();
            product_typeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunshineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbProduct
            // 
            this.pbProduct.BackColor = System.Drawing.Color.Transparent;
            this.pbProduct.InitialImage = null;
            this.pbProduct.Location = new System.Drawing.Point(3, 3);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(184, 244);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 2;
            this.pbProduct.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbProduct, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(190, 250);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(203, 276);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(56, 20);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(279, 276);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 20);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(352, 276);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 20);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(424, 276);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(56, 20);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = "&Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(9, 312);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 27;
            this.dgvInventory.Size = new System.Drawing.Size(712, 166);
            this.dgvInventory.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inventory data";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(516, 250);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 20);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsert.Location = new System.Drawing.Point(516, 225);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(116, 20);
            this.btnInsert.TabIndex = 27;
            this.btnInsert.Text = "&Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(516, 276);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 20);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // cbName
            // 
            this.cbName.BackColor = System.Drawing.SystemColors.Info;
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(516, 70);
            this.cbName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(176, 21);
            this.cbName.TabIndex = 29;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // sunshineDataSet1
            // 
            this.sunshineDataSet1.DataSetName = "sunshineDataSet";
            this.sunshineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.sunshineDataSet1;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ComponentTableAdapter = null;
            this.tableAdapterManager1.Cust_chatTableAdapter = null;
            this.tableAdapterManager1.Cust_orderTableAdapter = null;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.Delivery_noteTableAdapter = null;
            this.tableAdapterManager1.DepartmentTableAdapter = null;
            this.tableAdapterManager1.FactoryTableAdapter = null;
            this.tableAdapterManager1.InventoryTableAdapter = null;
            this.tableAdapterManager1.Material_inventoryTableAdapter = null;
            this.tableAdapterManager1.MaterialTableAdapter = null;
            this.tableAdapterManager1.Order_materialTableAdapter = null;
            this.tableAdapterManager1.Product_inventoryTableAdapter = null;
            this.tableAdapterManager1.Product_materialTableAdapter = null;
            this.tableAdapterManager1.Production_lineTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = this.productTableAdapter1;
            this.tableAdapterManager1.QuotationTableAdapter = null;
            this.tableAdapterManager1.StaffTableAdapter = null;
            this.tableAdapterManager1.Supplier_orderTableAdapter = null;
            this.tableAdapterManager1.SupplierTableAdapter = null;
            this.tableAdapterManager1.Transfer_formTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Sunshine.sunshineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.事件TableAdapter = null;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(953, 25);
            this.productBindingNavigator.TabIndex = 30;
            this.productBindingNavigator.Text = "bindingNavigator1";
            this.productBindingNavigator.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click_1);
            // 
            // product_IDLabel1
            // 
            product_IDLabel1.AutoSize = true;
            product_IDLabel1.Location = new System.Drawing.Point(211, 48);
            product_IDLabel1.Name = "product_IDLabel1";
            product_IDLabel1.Size = new System.Drawing.Size(60, 13);
            product_IDLabel1.TabIndex = 30;
            product_IDLabel1.Text = "product ID:";
            // 
            // product_IDTextBox1
            // 
            this.product_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_ID", true));
            this.product_IDTextBox1.Location = new System.Drawing.Point(292, 45);
            this.product_IDTextBox1.Name = "product_IDTextBox1";
            this.product_IDTextBox1.Size = new System.Drawing.Size(188, 20);
            this.product_IDTextBox1.TabIndex = 31;
            // 
            // product_nameLabel1
            // 
            product_nameLabel1.AutoSize = true;
            product_nameLabel1.Location = new System.Drawing.Point(211, 74);
            product_nameLabel1.Name = "product_nameLabel1";
            product_nameLabel1.Size = new System.Drawing.Size(75, 13);
            product_nameLabel1.TabIndex = 32;
            product_nameLabel1.Text = "product name:";
            // 
            // product_nameTextBox1
            // 
            this.product_nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_name", true));
            this.product_nameTextBox1.Location = new System.Drawing.Point(292, 71);
            this.product_nameTextBox1.Name = "product_nameTextBox1";
            this.product_nameTextBox1.Size = new System.Drawing.Size(188, 20);
            this.product_nameTextBox1.TabIndex = 33;
            // 
            // priceLabel1
            // 
            priceLabel1.AutoSize = true;
            priceLabel1.Location = new System.Drawing.Point(211, 100);
            priceLabel1.Name = "priceLabel1";
            priceLabel1.Size = new System.Drawing.Size(33, 13);
            priceLabel1.TabIndex = 34;
            priceLabel1.Text = "price:";
            // 
            // priceTextBox1
            // 
            this.priceTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "price", true));
            this.priceTextBox1.Location = new System.Drawing.Point(292, 97);
            this.priceTextBox1.Name = "priceTextBox1";
            this.priceTextBox1.Size = new System.Drawing.Size(188, 20);
            this.priceTextBox1.TabIndex = 35;
            // 
            // mOQLabel1
            // 
            mOQLabel1.AutoSize = true;
            mOQLabel1.Location = new System.Drawing.Point(211, 126);
            mOQLabel1.Name = "mOQLabel1";
            mOQLabel1.Size = new System.Drawing.Size(35, 13);
            mOQLabel1.TabIndex = 36;
            mOQLabel1.Text = "MOQ:";
            // 
            // mOQTextBox1
            // 
            this.mOQTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MOQ", true));
            this.mOQTextBox1.Location = new System.Drawing.Point(292, 123);
            this.mOQTextBox1.Name = "mOQTextBox1";
            this.mOQTextBox1.Size = new System.Drawing.Size(188, 20);
            this.mOQTextBox1.TabIndex = 37;
            // 
            // modelLabel1
            // 
            modelLabel1.AutoSize = true;
            modelLabel1.Location = new System.Drawing.Point(211, 152);
            modelLabel1.Name = "modelLabel1";
            modelLabel1.Size = new System.Drawing.Size(38, 13);
            modelLabel1.TabIndex = 38;
            modelLabel1.Text = "model:";
            // 
            // modelTextBox1
            // 
            this.modelTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "model", true));
            this.modelTextBox1.Location = new System.Drawing.Point(292, 149);
            this.modelTextBox1.Name = "modelTextBox1";
            this.modelTextBox1.Size = new System.Drawing.Size(188, 20);
            this.modelTextBox1.TabIndex = 39;
            // 
            // colorLabel1
            // 
            colorLabel1.AutoSize = true;
            colorLabel1.Location = new System.Drawing.Point(211, 178);
            colorLabel1.Name = "colorLabel1";
            colorLabel1.Size = new System.Drawing.Size(33, 13);
            colorLabel1.TabIndex = 40;
            colorLabel1.Text = "color:";
            // 
            // colorTextBox1
            // 
            this.colorTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "color", true));
            this.colorTextBox1.Location = new System.Drawing.Point(292, 175);
            this.colorTextBox1.Name = "colorTextBox1";
            this.colorTextBox1.Size = new System.Drawing.Size(188, 20);
            this.colorTextBox1.TabIndex = 41;
            // 
            // detailLabel1
            // 
            detailLabel1.AutoSize = true;
            detailLabel1.Location = new System.Drawing.Point(211, 204);
            detailLabel1.Name = "detailLabel1";
            detailLabel1.Size = new System.Drawing.Size(35, 13);
            detailLabel1.TabIndex = 42;
            detailLabel1.Text = "detail:";
            // 
            // detailTextBox1
            // 
            this.detailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "detail", true));
            this.detailTextBox1.Location = new System.Drawing.Point(292, 201);
            this.detailTextBox1.Name = "detailTextBox1";
            this.detailTextBox1.Size = new System.Drawing.Size(188, 20);
            this.detailTextBox1.TabIndex = 43;
            // 
            // product_typeLabel1
            // 
            product_typeLabel1.AutoSize = true;
            product_typeLabel1.Location = new System.Drawing.Point(211, 230);
            product_typeLabel1.Name = "product_typeLabel1";
            product_typeLabel1.Size = new System.Drawing.Size(69, 13);
            product_typeLabel1.TabIndex = 44;
            product_typeLabel1.Text = "product type:";
            // 
            // product_typeTextBox1
            // 
            this.product_typeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_type", true));
            this.product_typeTextBox1.Location = new System.Drawing.Point(292, 227);
            this.product_typeTextBox1.Name = "product_typeTextBox1";
            this.product_typeTextBox1.Size = new System.Drawing.Size(188, 20);
            this.product_typeTextBox1.TabIndex = 45;
            // 
            // InventoryProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 507);
            this.Controls.Add(product_IDLabel1);
            this.Controls.Add(this.product_IDTextBox1);
            this.Controls.Add(product_nameLabel1);
            this.Controls.Add(this.product_nameTextBox1);
            this.Controls.Add(priceLabel1);
            this.Controls.Add(this.priceTextBox1);
            this.Controls.Add(mOQLabel1);
            this.Controls.Add(this.mOQTextBox1);
            this.Controls.Add(modelLabel1);
            this.Controls.Add(this.modelTextBox1);
            this.Controls.Add(colorLabel1);
            this.Controls.Add(this.colorTextBox1);
            this.Controls.Add(detailLabel1);
            this.Controls.Add(this.detailTextBox1);
            this.Controls.Add(product_typeLabel1);
            this.Controls.Add(this.product_typeTextBox1);
            this.Controls.Add(this.productBindingNavigator);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "InventoryProductDetail";
            this.Text = "InventoryProductDetail";
            this.Load += new System.EventHandler(this.InventoryProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunshineDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label label1;
        private sunshineDataSet sunshineDataSet;
        private sunshineDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private sunshineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbName;
        private sunshineDataSet sunshineDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private sunshineDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private sunshineDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox product_IDTextBox1;
        private System.Windows.Forms.TextBox product_nameTextBox1;
        private System.Windows.Forms.TextBox priceTextBox1;
        private System.Windows.Forms.TextBox mOQTextBox1;
        private System.Windows.Forms.TextBox modelTextBox1;
        private System.Windows.Forms.TextBox colorTextBox1;
        private System.Windows.Forms.TextBox detailTextBox1;
        private System.Windows.Forms.TextBox product_typeTextBox1;
    }
}
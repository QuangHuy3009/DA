﻿namespace CafeMana.VIEW
{
    partial class fAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.SalesGroupBox = new System.Windows.Forms.GroupBox();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.SaleIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBillColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonThongke = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditProductColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteProductColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbFindProduct = new System.Windows.Forms.TextBox();
            this.buttonFindProduct = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProductCategory = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CategoryIDBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UploadPictureButton = new System.Windows.Forms.Button();
            this.CategoryPictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryDescriptionRBox = new System.Windows.Forms.RichTextBox();
            this.CategoryNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoriesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonDelCate = new System.Windows.Forms.Button();
            this.buttonEditCate = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbFindUser = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cbBoxRole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.buttonEditAcc = new System.Windows.Forms.Button();
            this.buttonAddAcc = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.SalesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.ProductsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabProductCategory.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPictureBox)).BeginInit();
            this.CategoryGroupBox.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSales);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabProductCategory);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.SalesGroupBox);
            this.tabSales.Controls.Add(this.panel1);
            this.tabSales.Controls.Add(this.tabControl2);
            this.tabSales.Location = new System.Drawing.Point(4, 22);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabSales.Size = new System.Drawing.Size(648, 409);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Sales";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Controls.Add(this.SalesGridView);
            this.SalesGroupBox.Location = new System.Drawing.Point(8, 51);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Size = new System.Drawing.Size(639, 360);
            this.SalesGroupBox.TabIndex = 3;
            this.SalesGroupBox.TabStop = false;
            this.SalesGroupBox.Text = "Sales";
            // 
            // SalesGridView
            // 
            this.SalesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleIDColumn,
            this.TimeColumn,
            this.SalesmanColumn,
            this.TotalBillColumn,
            this.ProductsColumn});
            this.SalesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesGridView.Location = new System.Drawing.Point(3, 16);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.ReadOnly = true;
            this.SalesGridView.Size = new System.Drawing.Size(633, 341);
            this.SalesGridView.TabIndex = 0;
            this.SalesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesGridView_CellContentClick);
            this.SalesGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.SalesGridView_CellPainting);
            // 
            // SaleIDColumn
            // 
            this.SaleIDColumn.HeaderText = "ID";
            this.SaleIDColumn.Name = "SaleIDColumn";
            this.SaleIDColumn.ReadOnly = true;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            // 
            // SalesmanColumn
            // 
            this.SalesmanColumn.HeaderText = "Salesman";
            this.SalesmanColumn.Name = "SalesmanColumn";
            this.SalesmanColumn.ReadOnly = true;
            // 
            // TotalBillColumn
            // 
            this.TotalBillColumn.HeaderText = "Total Bill";
            this.TotalBillColumn.Name = "TotalBillColumn";
            this.TotalBillColumn.ReadOnly = true;
            // 
            // ProductsColumn
            // 
            this.ProductsColumn.HeaderText = "Products";
            this.ProductsColumn.Name = "ProductsColumn";
            this.ProductsColumn.ReadOnly = true;
            this.ProductsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExport);
            this.panel1.Controls.Add(this.buttonThongke);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 42);
            this.panel1.TabIndex = 4;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(469, 5);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonThongke
            // 
            this.buttonThongke.Location = new System.Drawing.Point(219, 4);
            this.buttonThongke.Name = "buttonThongke";
            this.buttonThongke.Size = new System.Drawing.Size(75, 23);
            this.buttonThongke.TabIndex = 0;
            this.buttonThongke.Text = "View";
            this.buttonThongke.UseVisualStyleBackColor = true;
            this.buttonThongke.Click += new System.EventHandler(this.buttonThongke_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(270, 237);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.ProductsGroupBox);
            this.tabProduct.Controls.Add(this.panel4);
            this.tabProduct.Controls.Add(this.panel3);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabProduct.Size = new System.Drawing.Size(648, 409);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.Controls.Add(this.ProductsGridView);
            this.ProductsGroupBox.Location = new System.Drawing.Point(3, 74);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Size = new System.Drawing.Size(644, 334);
            this.ProductsGroupBox.TabIndex = 0;
            this.ProductsGroupBox.TabStop = false;
            this.ProductsGroupBox.Text = "Products";
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductCategoryColumn,
            this.ProductDescriptionColumn,
            this.ProductImageColumn,
            this.EditProductColumn,
            this.DeleteProductColumn});
            this.ProductsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGridView.Location = new System.Drawing.Point(3, 16);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.ReadOnly = true;
            this.ProductsGridView.Size = new System.Drawing.Size(638, 315);
            this.ProductsGridView.TabIndex = 0;
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
            this.ProductsGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ProductsGridView_CellPainting);
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.FillWeight = 21.90435F;
            this.ProductIDColumn.HeaderText = "ID";
            this.ProductIDColumn.Name = "ProductIDColumn";
            this.ProductIDColumn.ReadOnly = true;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.FillWeight = 68.73803F;
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.FillWeight = 81.48138F;
            this.ProductPriceColumn.HeaderText = "Price";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            this.ProductPriceColumn.ReadOnly = true;
            // 
            // ProductCategoryColumn
            // 
            this.ProductCategoryColumn.FillWeight = 72.3064F;
            this.ProductCategoryColumn.HeaderText = "Category";
            this.ProductCategoryColumn.Name = "ProductCategoryColumn";
            this.ProductCategoryColumn.ReadOnly = true;
            // 
            // ProductDescriptionColumn
            // 
            this.ProductDescriptionColumn.FillWeight = 76.51581F;
            this.ProductDescriptionColumn.HeaderText = "Description";
            this.ProductDescriptionColumn.Name = "ProductDescriptionColumn";
            this.ProductDescriptionColumn.ReadOnly = true;
            // 
            // ProductImageColumn
            // 
            this.ProductImageColumn.FillWeight = 75.21452F;
            this.ProductImageColumn.HeaderText = "Image";
            this.ProductImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ProductImageColumn.Name = "ProductImageColumn";
            this.ProductImageColumn.ReadOnly = true;
            // 
            // EditProductColumn
            // 
            this.EditProductColumn.FillWeight = 48.87409F;
            this.EditProductColumn.HeaderText = "Edit";
            this.EditProductColumn.Name = "EditProductColumn";
            this.EditProductColumn.ReadOnly = true;
            this.EditProductColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditProductColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditProductColumn.Text = "";
            // 
            // DeleteProductColumn
            // 
            this.DeleteProductColumn.FillWeight = 48.87409F;
            this.DeleteProductColumn.HeaderText = "Delete";
            this.DeleteProductColumn.Name = "DeleteProductColumn";
            this.DeleteProductColumn.ReadOnly = true;
            this.DeleteProductColumn.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbFindProduct);
            this.panel4.Controls.Add(this.buttonFindProduct);
            this.panel4.Location = new System.Drawing.Point(373, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 62);
            this.panel4.TabIndex = 1;
            // 
            // txbFindProduct
            // 
            this.txbFindProduct.Location = new System.Drawing.Point(3, 21);
            this.txbFindProduct.Name = "txbFindProduct";
            this.txbFindProduct.Size = new System.Drawing.Size(198, 20);
            this.txbFindProduct.TabIndex = 0;
            // 
            // buttonFindProduct
            // 
            this.buttonFindProduct.Location = new System.Drawing.Point(206, 3);
            this.buttonFindProduct.Name = "buttonFindProduct";
            this.buttonFindProduct.Size = new System.Drawing.Size(63, 50);
            this.buttonFindProduct.TabIndex = 4;
            this.buttonFindProduct.Text = "Find";
            this.buttonFindProduct.UseVisualStyleBackColor = true;
            this.buttonFindProduct.Click += new System.EventHandler(this.buttonFindProduct_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProductCategoryComboBox);
            this.panel3.Controls.Add(this.buttonAddProduct);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 62);
            this.panel3.TabIndex = 2;
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Items.AddRange(new object[] {
            "All Categories"});
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(68, 20);
            this.ProductCategoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(206, 21);
            this.ProductCategoryComboBox.TabIndex = 3;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(0, 3);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(63, 50);
            this.buttonAddProduct.TabIndex = 1;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Category";
            // 
            // tabProductCategory
            // 
            this.tabProductCategory.Controls.Add(this.panel2);
            this.tabProductCategory.Controls.Add(this.CategoryGroupBox);
            this.tabProductCategory.Controls.Add(this.panel8);
            this.tabProductCategory.Location = new System.Drawing.Point(4, 22);
            this.tabProductCategory.Name = "tabProductCategory";
            this.tabProductCategory.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabProductCategory.Size = new System.Drawing.Size(648, 409);
            this.tabProductCategory.TabIndex = 2;
            this.tabProductCategory.Text = "Category";
            this.tabProductCategory.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CategoryIDBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.UploadPictureButton);
            this.panel2.Controls.Add(this.CategoryPictureBox);
            this.panel2.Controls.Add(this.CategoryDescriptionRBox);
            this.panel2.Controls.Add(this.CategoryNameBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(371, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 276);
            this.panel2.TabIndex = 0;
            // 
            // CategoryIDBox
            // 
            this.CategoryIDBox.Location = new System.Drawing.Point(117, 31);
            this.CategoryIDBox.Name = "CategoryIDBox";
            this.CategoryIDBox.ReadOnly = true;
            this.CategoryIDBox.Size = new System.Drawing.Size(146, 20);
            this.CategoryIDBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category ID";
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Location = new System.Drawing.Point(3, 191);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(85, 23);
            this.UploadPictureButton.TabIndex = 0;
            this.UploadPictureButton.Text = "Upload Picture";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            this.UploadPictureButton.Click += new System.EventHandler(this.UploadPictureButton_Click);
            // 
            // CategoryPictureBox
            // 
            this.CategoryPictureBox.Location = new System.Drawing.Point(117, 162);
            this.CategoryPictureBox.Name = "CategoryPictureBox";
            this.CategoryPictureBox.Size = new System.Drawing.Size(146, 102);
            this.CategoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CategoryPictureBox.TabIndex = 1;
            this.CategoryPictureBox.TabStop = false;
            // 
            // CategoryDescriptionRBox
            // 
            this.CategoryDescriptionRBox.Location = new System.Drawing.Point(117, 83);
            this.CategoryDescriptionRBox.Name = "CategoryDescriptionRBox";
            this.CategoryDescriptionRBox.Size = new System.Drawing.Size(146, 73);
            this.CategoryDescriptionRBox.TabIndex = 2;
            this.CategoryDescriptionRBox.Text = "";
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Location = new System.Drawing.Point(117, 57);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(146, 20);
            this.CategoryNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category Picture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category Name";
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.Controls.Add(this.CategoriesFlowPanel);
            this.CategoryGroupBox.Location = new System.Drawing.Point(19, 92);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Size = new System.Drawing.Size(346, 292);
            this.CategoryGroupBox.TabIndex = 1;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "Categories";
            // 
            // CategoriesFlowPanel
            // 
            this.CategoriesFlowPanel.AutoScroll = true;
            this.CategoriesFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CategoriesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.CategoriesFlowPanel.Name = "CategoriesFlowPanel";
            this.CategoriesFlowPanel.Size = new System.Drawing.Size(340, 273);
            this.CategoriesFlowPanel.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.buttonDelCate);
            this.panel8.Controls.Add(this.buttonEditCate);
            this.panel8.Controls.Add(this.buttonAddCategory);
            this.panel8.Location = new System.Drawing.Point(164, 30);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(315, 56);
            this.panel8.TabIndex = 2;
            // 
            // buttonDelCate
            // 
            this.buttonDelCate.Location = new System.Drawing.Point(249, 3);
            this.buttonDelCate.Name = "buttonDelCate";
            this.buttonDelCate.Size = new System.Drawing.Size(63, 50);
            this.buttonDelCate.TabIndex = 0;
            this.buttonDelCate.Text = "Delete";
            this.buttonDelCate.UseVisualStyleBackColor = true;
            this.buttonDelCate.Click += new System.EventHandler(this.buttonDelCate_Click);
            // 
            // buttonEditCate
            // 
            this.buttonEditCate.Location = new System.Drawing.Point(129, 3);
            this.buttonEditCate.Name = "buttonEditCate";
            this.buttonEditCate.Size = new System.Drawing.Size(63, 50);
            this.buttonEditCate.TabIndex = 1;
            this.buttonEditCate.Text = "Update";
            this.buttonEditCate.UseVisualStyleBackColor = true;
            this.buttonEditCate.Click += new System.EventHandler(this.buttonEditCate_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(5, 3);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(63, 50);
            this.buttonAddCategory.TabIndex = 2;
            this.buttonAddCategory.Text = "Add";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.panel5);
            this.tabUsers.Controls.Add(this.UsersGridView);
            this.tabUsers.Controls.Add(this.panel12);
            this.tabUsers.Controls.Add(this.panel13);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabUsers.Size = new System.Drawing.Size(648, 409);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbFindUser);
            this.panel5.Controls.Add(this.buttonFind);
            this.panel5.Location = new System.Drawing.Point(399, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 56);
            this.panel5.TabIndex = 0;
            // 
            // txbFindUser
            // 
            this.txbFindUser.Location = new System.Drawing.Point(22, 19);
            this.txbFindUser.Name = "txbFindUser";
            this.txbFindUser.Size = new System.Drawing.Size(151, 20);
            this.txbFindUser.TabIndex = 0;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(178, 2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(63, 50);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // UsersGridView
            // 
            this.UsersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.Role,
            this.Email});
            this.UsersGridView.Location = new System.Drawing.Point(8, 101);
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.Size = new System.Drawing.Size(373, 289);
            this.UsersGridView.TabIndex = 1;
            this.UsersGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersGridView_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 40.60914F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // UserName
            // 
            this.UserName.FillWeight = 119.797F;
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // Role
            // 
            this.Role.FillWeight = 119.797F;
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // Email
            // 
            this.Email.FillWeight = 119.797F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.Window;
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.txbPassword);
            this.panel12.Controls.Add(this.cbBoxRole);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.txbUserName);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Location = new System.Drawing.Point(399, 101);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(241, 289);
            this.panel12.TabIndex = 2;
            // 
            // cbBoxRole
            // 
            this.cbBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxRole.FormattingEnabled = true;
            this.cbBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Salesman"});
            this.cbBoxRole.Location = new System.Drawing.Point(86, 100);
            this.cbBoxRole.Name = "cbBoxRole";
            this.cbBoxRole.Size = new System.Drawing.Size(138, 21);
            this.cbBoxRole.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Role";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(86, 21);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(138, 20);
            this.txbUserName.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "UserName";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.buttonEditAcc);
            this.panel13.Controls.Add(this.buttonAddAcc);
            this.panel13.Location = new System.Drawing.Point(8, 21);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(373, 56);
            this.panel13.TabIndex = 11;
            // 
            // buttonEditAcc
            // 
            this.buttonEditAcc.Location = new System.Drawing.Point(0, 6);
            this.buttonEditAcc.Name = "buttonEditAcc";
            this.buttonEditAcc.Size = new System.Drawing.Size(98, 50);
            this.buttonEditAcc.TabIndex = 1;
            this.buttonEditAcc.Text = "Update";
            this.buttonEditAcc.UseVisualStyleBackColor = true;
            this.buttonEditAcc.Click += new System.EventHandler(this.buttonEditAcc_Click);
            // 
            // buttonAddAcc
            // 
            this.buttonAddAcc.Location = new System.Drawing.Point(275, 6);
            this.buttonAddAcc.Name = "buttonAddAcc";
            this.buttonAddAcc.Size = new System.Drawing.Size(98, 50);
            this.buttonAddAcc.TabIndex = 0;
            this.buttonAddAcc.Text = "Add";
            this.buttonAddAcc.UseVisualStyleBackColor = true;
            this.buttonAddAcc.Click += new System.EventHandler(this.buttonAddAcc_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(86, 55);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(138, 20);
            this.txbPassword.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 449);
            this.Controls.Add(this.tabControl1);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAdmin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.SalesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.ProductsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabProductCategory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPictureBox)).EndInit();
            this.CategoryGroupBox.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonThongke;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbFindProduct;
        private System.Windows.Forms.Button buttonFindProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TabPage tabProductCategory;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonDelCate;
        private System.Windows.Forms.Button buttonEditCate;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cbBoxRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button buttonEditAcc;
        private System.Windows.Forms.GroupBox SalesGroupBox;
        private System.Windows.Forms.DataGridView SalesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBillColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ProductsColumn;
        private System.Windows.Forms.GroupBox ProductsGroupBox;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UploadPictureButton;
        private System.Windows.Forms.PictureBox CategoryPictureBox;
        private System.Windows.Forms.RichTextBox CategoryDescriptionRBox;
        private System.Windows.Forms.TextBox CategoryNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.FlowLayoutPanel CategoriesFlowPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbFindUser;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.Button buttonAddAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescriptionColumn;
        private System.Windows.Forms.DataGridViewImageColumn ProductImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditProductColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProductColumn;
        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.TextBox CategoryIDBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPassword;
    }
}
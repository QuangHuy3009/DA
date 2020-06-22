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
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cbBoxRole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.buttonDelAcc = new System.Windows.Forms.Button();
            this.buttonEditAcc = new System.Windows.Forms.Button();
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddAcc = new System.Windows.Forms.Button();
            this.buttonSetPassword = new System.Windows.Forms.Button();
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
            this.tabAccount.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSales);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabProductCategory);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 430);
            this.tabControl1.TabIndex = 1;
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.SalesGroupBox);
            this.tabSales.Controls.Add(this.panel1);
            this.tabSales.Controls.Add(this.tabControl2);
            this.tabSales.Location = new System.Drawing.Point(4, 22);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(646, 404);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Sales";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Controls.Add(this.SalesGridView);
            this.SalesGroupBox.Location = new System.Drawing.Point(8, 51);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Size = new System.Drawing.Size(590, 348);
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
            this.SalesGridView.Size = new System.Drawing.Size(584, 329);
            this.SalesGridView.TabIndex = 0;
            // 
            // SaleIDColumn
            // 
            this.SaleIDColumn.HeaderText = "ID";
            this.SaleIDColumn.Name = "SaleIDColumn";
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            // 
            // SalesmanColumn
            // 
            this.SalesmanColumn.HeaderText = "Salesman";
            this.SalesmanColumn.Name = "SalesmanColumn";
            // 
            // TotalBillColumn
            // 
            this.TotalBillColumn.HeaderText = "Total Bill";
            this.TotalBillColumn.Name = "TotalBillColumn";
            // 
            // ProductsColumn
            // 
            this.ProductsColumn.HeaderText = "Products";
            this.ProductsColumn.Name = "ProductsColumn";
            this.ProductsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonThongke);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 42);
            this.panel1.TabIndex = 2;
            // 
            // buttonThongke
            // 
            this.buttonThongke.Location = new System.Drawing.Point(329, 5);
            this.buttonThongke.Name = "buttonThongke";
            this.buttonThongke.Size = new System.Drawing.Size(75, 23);
            this.buttonThongke.TabIndex = 5;
            this.buttonThongke.Text = "Thống kê";
            this.buttonThongke.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(270, 237);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
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
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(646, 404);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.Controls.Add(this.ProductsGridView);
            this.ProductsGroupBox.Location = new System.Drawing.Point(3, 74);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Size = new System.Drawing.Size(590, 325);
            this.ProductsGroupBox.TabIndex = 4;
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
            this.ProductsGridView.Size = new System.Drawing.Size(584, 306);
            this.ProductsGridView.TabIndex = 0;
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.HeaderText = "ID";
            this.ProductIDColumn.Name = "ProductIDColumn";
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.HeaderText = "Price";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            // 
            // ProductCategoryColumn
            // 
            this.ProductCategoryColumn.HeaderText = "Category";
            this.ProductCategoryColumn.Name = "ProductCategoryColumn";
            // 
            // ProductDescriptionColumn
            // 
            this.ProductDescriptionColumn.HeaderText = "Description";
            this.ProductDescriptionColumn.Name = "ProductDescriptionColumn";
            // 
            // ProductImageColumn
            // 
            this.ProductImageColumn.HeaderText = "Image";
            this.ProductImageColumn.Name = "ProductImageColumn";
            this.ProductImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EditProductColumn
            // 
            this.EditProductColumn.HeaderText = "Edit";
            this.EditProductColumn.Name = "EditProductColumn";
            this.EditProductColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditProductColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteProductColumn
            // 
            this.DeleteProductColumn.HeaderText = "Delete";
            this.DeleteProductColumn.Name = "DeleteProductColumn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbFindProduct);
            this.panel4.Controls.Add(this.buttonFindProduct);
            this.panel4.Location = new System.Drawing.Point(378, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 56);
            this.panel4.TabIndex = 3;
            // 
            // txbFindProduct
            // 
            this.txbFindProduct.Location = new System.Drawing.Point(3, 19);
            this.txbFindProduct.Name = "txbFindProduct";
            this.txbFindProduct.Size = new System.Drawing.Size(137, 20);
            this.txbFindProduct.TabIndex = 5;
            // 
            // buttonFindProduct
            // 
            this.buttonFindProduct.Location = new System.Drawing.Point(146, 3);
            this.buttonFindProduct.Name = "buttonFindProduct";
            this.buttonFindProduct.Size = new System.Drawing.Size(63, 50);
            this.buttonFindProduct.TabIndex = 4;
            this.buttonFindProduct.Text = "Tìm";
            this.buttonFindProduct.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProductCategoryComboBox);
            this.panel3.Controls.Add(this.buttonAddProduct);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 56);
            this.panel3.TabIndex = 1;
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductCategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(162, 19);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(204, 21);
            this.ProductCategoryComboBox.Sorted = true;
            this.ProductCategoryComboBox.TabIndex = 4;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(5, 3);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(63, 50);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Category";
            // 
            // tabProductCategory
            // 
            this.tabProductCategory.Controls.Add(this.panel2);
            this.tabProductCategory.Controls.Add(this.CategoryGroupBox);
            this.tabProductCategory.Controls.Add(this.panel8);
            this.tabProductCategory.Location = new System.Drawing.Point(4, 22);
            this.tabProductCategory.Name = "tabProductCategory";
            this.tabProductCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductCategory.Size = new System.Drawing.Size(646, 404);
            this.tabProductCategory.TabIndex = 2;
            this.tabProductCategory.Text = "Category";
            this.tabProductCategory.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UploadPictureButton);
            this.panel2.Controls.Add(this.CategoryPictureBox);
            this.panel2.Controls.Add(this.CategoryDescriptionRBox);
            this.panel2.Controls.Add(this.CategoryNameBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(371, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 258);
            this.panel2.TabIndex = 6;
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Location = new System.Drawing.Point(3, 164);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(85, 23);
            this.UploadPictureButton.TabIndex = 14;
            this.UploadPictureButton.Text = "Upload Picture";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            // 
            // CategoryPictureBox
            // 
            this.CategoryPictureBox.Location = new System.Drawing.Point(117, 135);
            this.CategoryPictureBox.Name = "CategoryPictureBox";
            this.CategoryPictureBox.Size = new System.Drawing.Size(146, 102);
            this.CategoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CategoryPictureBox.TabIndex = 13;
            this.CategoryPictureBox.TabStop = false;
            // 
            // CategoryDescriptionRBox
            // 
            this.CategoryDescriptionRBox.Location = new System.Drawing.Point(117, 56);
            this.CategoryDescriptionRBox.Name = "CategoryDescriptionRBox";
            this.CategoryDescriptionRBox.Size = new System.Drawing.Size(146, 73);
            this.CategoryDescriptionRBox.TabIndex = 12;
            this.CategoryDescriptionRBox.Text = "";
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Location = new System.Drawing.Point(117, 30);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(146, 20);
            this.CategoryNameBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category Picture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Category Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category Name";
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.Controls.Add(this.CategoriesFlowPanel);
            this.CategoryGroupBox.Location = new System.Drawing.Point(19, 108);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Size = new System.Drawing.Size(346, 276);
            this.CategoryGroupBox.TabIndex = 4;
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
            this.CategoriesFlowPanel.Size = new System.Drawing.Size(340, 257);
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
            this.panel8.TabIndex = 5;
            // 
            // buttonDelCate
            // 
            this.buttonDelCate.Location = new System.Drawing.Point(249, 3);
            this.buttonDelCate.Name = "buttonDelCate";
            this.buttonDelCate.Size = new System.Drawing.Size(63, 50);
            this.buttonDelCate.TabIndex = 2;
            this.buttonDelCate.Text = "Delete";
            this.buttonDelCate.UseVisualStyleBackColor = true;
            // 
            // buttonEditCate
            // 
            this.buttonEditCate.Location = new System.Drawing.Point(129, 3);
            this.buttonEditCate.Name = "buttonEditCate";
            this.buttonEditCate.Size = new System.Drawing.Size(63, 50);
            this.buttonEditCate.TabIndex = 1;
            this.buttonEditCate.Text = "Update";
            this.buttonEditCate.UseVisualStyleBackColor = true;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(5, 3);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(63, 50);
            this.buttonAddCategory.TabIndex = 0;
            this.buttonAddCategory.Text = "Add";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.panel5);
            this.tabAccount.Controls.Add(this.dataGridViewAccount);
            this.tabAccount.Controls.Add(this.panel12);
            this.tabAccount.Controls.Add(this.panel13);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(646, 404);
            this.tabAccount.TabIndex = 4;
            this.tabAccount.Text = "Accounts";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.Window;
            this.panel12.Controls.Add(this.buttonSetPassword);
            this.panel12.Controls.Add(this.cbBoxRole);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.txbUserName);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Location = new System.Drawing.Point(428, 101);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(212, 289);
            this.panel12.TabIndex = 12;
            // 
            // cbBoxRole
            // 
            this.cbBoxRole.FormattingEnabled = true;
            this.cbBoxRole.Location = new System.Drawing.Point(86, 79);
            this.cbBoxRole.Name = "cbBoxRole";
            this.cbBoxRole.Size = new System.Drawing.Size(123, 21);
            this.cbBoxRole.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Role";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(86, 21);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(123, 20);
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
            this.panel13.Controls.Add(this.buttonDelAcc);
            this.panel13.Controls.Add(this.buttonEditAcc);
            this.panel13.Controls.Add(this.buttonAddAcc);
            this.panel13.Location = new System.Drawing.Point(8, 20);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(315, 56);
            this.panel13.TabIndex = 11;
            // 
            // buttonDelAcc
            // 
            this.buttonDelAcc.Location = new System.Drawing.Point(249, 3);
            this.buttonDelAcc.Name = "buttonDelAcc";
            this.buttonDelAcc.Size = new System.Drawing.Size(63, 50);
            this.buttonDelAcc.TabIndex = 2;
            this.buttonDelAcc.Text = "Delete";
            this.buttonDelAcc.UseVisualStyleBackColor = true;
            // 
            // buttonEditAcc
            // 
            this.buttonEditAcc.Location = new System.Drawing.Point(130, 3);
            this.buttonEditAcc.Name = "buttonEditAcc";
            this.buttonEditAcc.Size = new System.Drawing.Size(63, 50);
            this.buttonEditAcc.TabIndex = 1;
            this.buttonEditAcc.Text = "Update";
            this.buttonEditAcc.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.Location = new System.Drawing.Point(8, 101);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.Size = new System.Drawing.Size(400, 289);
            this.dataGridViewAccount.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.buttonFind);
            this.panel5.Location = new System.Drawing.Point(365, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 56);
            this.panel5.TabIndex = 12;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(195, 3);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(63, 50);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttonAddAcc
            // 
            this.buttonAddAcc.Location = new System.Drawing.Point(5, 3);
            this.buttonAddAcc.Name = "buttonAddAcc";
            this.buttonAddAcc.Size = new System.Drawing.Size(63, 50);
            this.buttonAddAcc.TabIndex = 0;
            this.buttonAddAcc.Text = "Add";
            this.buttonAddAcc.UseVisualStyleBackColor = true;
            this.buttonAddAcc.Click += new System.EventHandler(this.buttonAddAcc_Click);
            // 
            // buttonSetPassword
            // 
            this.buttonSetPassword.Location = new System.Drawing.Point(46, 133);
            this.buttonSetPassword.Name = "buttonSetPassword";
            this.buttonSetPassword.Size = new System.Drawing.Size(127, 26);
            this.buttonSetPassword.TabIndex = 4;
            this.buttonSetPassword.Text = "Set Password";
            this.buttonSetPassword.UseVisualStyleBackColor = true;
            this.buttonSetPassword.Click += new System.EventHandler(this.buttonSetPassword_Click);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
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
            this.tabAccount.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cbBoxRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button buttonDelAcc;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescriptionColumn;
        private System.Windows.Forms.DataGridViewImageColumn ProductImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditProductColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProductColumn;
        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridViewAccount;
        private System.Windows.Forms.Button buttonSetPassword;
        private System.Windows.Forms.Button buttonAddAcc;
    }
}
namespace CafeMana.VIEW
{
    partial class FormGeneral
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
            this.AccountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmintoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UserNameIDMenuLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.BillGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoriesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.BillGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.ProductsGroupBox.SuspendLayout();
            this.CategoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountInformationToolStripMenuItem
            // 
            this.AccountInformationToolStripMenuItem.Name = "AccountInformationToolStripMenuItem";
            this.AccountInformationToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.AccountInformationToolStripMenuItem.Text = "Account Information";
            this.AccountInformationToolStripMenuItem.Click += new System.EventHandler(this.AccountInformationToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountInformationToolStripMenuItem,
            this.LogoutToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.thôngTinToolStripMenuItem.Text = "Information";
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.LogoutToolStripMenuItem.Text = "Log out";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // AdmintoolStrip
            // 
            this.AdmintoolStrip.Name = "AdmintoolStrip";
            this.AdmintoolStrip.Size = new System.Drawing.Size(67, 24);
            this.AdmintoolStrip.Text = "Admin";
            this.AdmintoolStrip.Click += new System.EventHandler(this.AdmintoolStrip_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmintoolStrip,
            this.thôngTinToolStripMenuItem,
            this.UserNameIDMenuLabel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserNameIDMenuLabel
            // 
            this.UserNameIDMenuLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserNameIDMenuLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserNameIDMenuLabel.Enabled = false;
            this.UserNameIDMenuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameIDMenuLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserNameIDMenuLabel.Name = "UserNameIDMenuLabel";
            this.UserNameIDMenuLabel.Size = new System.Drawing.Size(27, 24);
            this.UserNameIDMenuLabel.Text = " ";
            // 
            // BillGroupBox
            // 
            this.BillGroupBox.Controls.Add(this.ProductsGridView);
            this.BillGroupBox.Location = new System.Drawing.Point(628, 33);
            this.BillGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BillGroupBox.Name = "BillGroupBox";
            this.BillGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BillGroupBox.Size = new System.Drawing.Size(567, 577);
            this.BillGroupBox.TabIndex = 9;
            this.BillGroupBox.TabStop = false;
            this.BillGroupBox.Text = "Bill";
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductsGridView.ColumnHeadersHeight = 29;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductName,
            this.ProductPrice,
            this.ProductQuantity,
            this.ProductTotal,
            this.Delete});
            this.ProductsGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProductsGridView.Location = new System.Drawing.Point(4, 19);
            this.ProductsGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.RowHeadersWidth = 51;
            this.ProductsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductsGridView.Size = new System.Drawing.Size(559, 551);
            this.ProductsGridView.TabIndex = 0;
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
            this.ProductsGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ProductsGridView_CellPainting);
            this.ProductsGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellValueChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductPrice.FillWeight = 70F;
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 50;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductQuantity.FillWeight = 70F;
            this.ProductQuantity.HeaderText = "Quantity";
            this.ProductQuantity.MinimumWidth = 6;
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Width = 60;
            // 
            // ProductTotal
            // 
            this.ProductTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductTotal.FillWeight = 70F;
            this.ProductTotal.HeaderText = "Total";
            this.ProductTotal.MinimumWidth = 6;
            this.ProductTotal.Name = "ProductTotal";
            this.ProductTotal.ReadOnly = true;
            this.ProductTotal.Width = 70;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "";
            this.Delete.Width = 50;
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.Controls.Add(this.ProductsFlowPanel);
            this.ProductsGroupBox.Location = new System.Drawing.Point(16, 295);
            this.ProductsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductsGroupBox.Size = new System.Drawing.Size(600, 369);
            this.ProductsGroupBox.TabIndex = 8;
            this.ProductsGroupBox.TabStop = false;
            this.ProductsGroupBox.Text = "Products";
            // 
            // ProductsFlowPanel
            // 
            this.ProductsFlowPanel.AutoScroll = true;
            this.ProductsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsFlowPanel.Location = new System.Drawing.Point(4, 19);
            this.ProductsFlowPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductsFlowPanel.Name = "ProductsFlowPanel";
            this.ProductsFlowPanel.Size = new System.Drawing.Size(592, 346);
            this.ProductsFlowPanel.TabIndex = 0;
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.Controls.Add(this.CategoriesFlowPanel);
            this.CategoryGroupBox.Location = new System.Drawing.Point(16, 33);
            this.CategoryGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoryGroupBox.Size = new System.Drawing.Size(604, 255);
            this.CategoryGroupBox.TabIndex = 7;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "Categories";
            // 
            // CategoriesFlowPanel
            // 
            this.CategoriesFlowPanel.AutoScroll = true;
            this.CategoriesFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CategoriesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesFlowPanel.Location = new System.Drawing.Point(4, 19);
            this.CategoriesFlowPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriesFlowPanel.Name = "CategoriesFlowPanel";
            this.CategoriesFlowPanel.Size = new System.Drawing.Size(596, 232);
            this.CategoriesFlowPanel.TabIndex = 0;
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(1049, 622);
            this.CheckOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(100, 28);
            this.CheckOutButton.TabIndex = 12;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Location = new System.Drawing.Point(761, 624);
            this.TotalBillBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(279, 22);
            this.TotalBillBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 628);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Bill";
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 667);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillGroupBox);
            this.Controls.Add(this.ProductsGroupBox);
            this.Controls.Add(this.CategoryGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGeneral";
            this.Text = "Cafe Management Software";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BillGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ProductsGroupBox.ResumeLayout(false);
            this.CategoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem AccountInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdmintoolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox BillGroupBox;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.GroupBox ProductsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel ProductsFlowPanel;
        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.FlowLayoutPanel CategoriesFlowPanel;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem UserNameIDMenuLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
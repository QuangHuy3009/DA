﻿namespace CafeMana.VIEW
{
    partial class SaleItems
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
            this.SalesGroupBox = new System.Windows.Forms.GroupBox();
            this.SaleItemsGridView = new System.Windows.Forms.DataGridView();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Controls.Add(this.SaleItemsGridView);
            this.SalesGroupBox.Location = new System.Drawing.Point(7, 11);
            this.SalesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SalesGroupBox.Size = new System.Drawing.Size(787, 428);
            this.SalesGroupBox.TabIndex = 3;
            this.SalesGroupBox.TabStop = false;
            this.SalesGroupBox.Text = "Sales Items";
            // 
            // SaleItemsGridView
            // 
            this.SaleItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SaleItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductQuantityColumn,
            this.ProductTotalColumn});
            this.SaleItemsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleItemsGridView.Location = new System.Drawing.Point(4, 19);
            this.SaleItemsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.SaleItemsGridView.Name = "SaleItemsGridView";
            this.SaleItemsGridView.ReadOnly = true;
            this.SaleItemsGridView.Size = new System.Drawing.Size(779, 405);
            this.SaleItemsGridView.TabIndex = 0;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.HeaderText = "Price";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            this.ProductPriceColumn.ReadOnly = true;
            // 
            // ProductQuantityColumn
            // 
            this.ProductQuantityColumn.HeaderText = "Quantity";
            this.ProductQuantityColumn.Name = "ProductQuantityColumn";
            this.ProductQuantityColumn.ReadOnly = true;
            // 
            // ProductTotalColumn
            // 
            this.ProductTotalColumn.HeaderText = "Total Price";
            this.ProductTotalColumn.Name = "ProductTotalColumn";
            this.ProductTotalColumn.ReadOnly = true;
            this.ProductTotalColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SaleItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesGroupBox);
            this.Name = "SaleItems";
            this.Text = "SaleItems";
            this.Load += new System.EventHandler(this.SaleItems_Load);
            this.SalesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SalesGroupBox;
        private System.Windows.Forms.DataGridView SaleItemsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalColumn;
    }
}
namespace WingBite
{
    partial class Inventory_Tracking
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
            this.lblInventoryTracking = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLowStockReport = new System.Windows.Forms.Button();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblAdjustProduct = new System.Windows.Forms.Label();
            this.lblProductNameHere = new System.Windows.Forms.Label();
            this.txtCurentStock = new System.Windows.Forms.TextBox();
            this.txtAdjustProduct = new System.Windows.Forms.TextBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.picboxInventoryTracking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxInventoryTracking)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventoryTracking
            // 
            this.lblInventoryTracking.AutoSize = true;
            this.lblInventoryTracking.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTracking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblInventoryTracking.Location = new System.Drawing.Point(441, 51);
            this.lblInventoryTracking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventoryTracking.Name = "lblInventoryTracking";
            this.lblInventoryTracking.Size = new System.Drawing.Size(428, 46);
            this.lblInventoryTracking.TabIndex = 13;
            this.lblInventoryTracking.Text = "INVENTORY TRACKING";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(18, 774);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 54);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLowStockReport
            // 
            this.btnLowStockReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLowStockReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowStockReport.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowStockReport.ForeColor = System.Drawing.Color.Black;
            this.btnLowStockReport.Location = new System.Drawing.Point(754, 703);
            this.btnLowStockReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLowStockReport.Name = "btnLowStockReport";
            this.btnLowStockReport.Size = new System.Drawing.Size(236, 48);
            this.btnLowStockReport.TabIndex = 27;
            this.btnLowStockReport.Text = "Low Stock Report";
            this.btnLowStockReport.UseVisualStyleBackColor = false;
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefreshAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshAll.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshAll.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshAll.Location = new System.Drawing.Point(266, 703);
            this.btnRefreshAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(236, 48);
            this.btnRefreshAll.TabIndex = 28;
            this.btnRefreshAll.Text = "Refresh All";
            this.btnRefreshAll.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(92, 166);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 24);
            this.lblSearch.TabIndex = 30;
            this.lblSearch.Text = "Search: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(183, 154);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(370, 32);
            this.txtSearch.TabIndex = 31;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(880, 143);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(236, 48);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblProductStock.Location = new System.Drawing.Point(92, 212);
            this.lblProductStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(195, 24);
            this.lblProductStock.TabIndex = 34;
            this.lblProductStock.Text = "PRODUCT STOCK:";
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(96, 245);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.Size = new System.Drawing.Size(1020, 269);
            this.dgvInventory.TabIndex = 35;
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblUpdateStock.Location = new System.Drawing.Point(267, 529);
            this.lblUpdateStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(173, 24);
            this.lblUpdateStock.TabIndex = 36;
            this.lblUpdateStock.Text = "UPDATE STOCK";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(267, 569);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(146, 24);
            this.lblProductName.TabIndex = 37;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStock.Location = new System.Drawing.Point(267, 611);
            this.lblCurrentStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(142, 24);
            this.lblCurrentStock.TabIndex = 38;
            this.lblCurrentStock.Text = "Current Stock:";
            // 
            // lblAdjustProduct
            // 
            this.lblAdjustProduct.AutoSize = true;
            this.lblAdjustProduct.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjustProduct.Location = new System.Drawing.Point(267, 652);
            this.lblAdjustProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdjustProduct.Name = "lblAdjustProduct";
            this.lblAdjustProduct.Size = new System.Drawing.Size(134, 24);
            this.lblAdjustProduct.TabIndex = 39;
            this.lblAdjustProduct.Text = "Adjust Stock:";
            // 
            // lblProductNameHere
            // 
            this.lblProductNameHere.AutoSize = true;
            this.lblProductNameHere.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameHere.Location = new System.Drawing.Point(482, 569);
            this.lblProductNameHere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductNameHere.Name = "lblProductNameHere";
            this.lblProductNameHere.Size = new System.Drawing.Size(146, 24);
            this.lblProductNameHere.TabIndex = 40;
            this.lblProductNameHere.Text = "Product Name:";
            // 
            // txtCurentStock
            // 
            this.txtCurentStock.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurentStock.Location = new System.Drawing.Point(486, 608);
            this.txtCurentStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurentStock.Name = "txtCurentStock";
            this.txtCurentStock.Size = new System.Drawing.Size(210, 28);
            this.txtCurentStock.TabIndex = 41;
            // 
            // txtAdjustProduct
            // 
            this.txtAdjustProduct.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustProduct.Location = new System.Drawing.Point(486, 648);
            this.txtAdjustProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdjustProduct.Name = "txtAdjustProduct";
            this.txtAdjustProduct.Size = new System.Drawing.Size(210, 28);
            this.txtAdjustProduct.TabIndex = 42;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateStock.Location = new System.Drawing.Point(790, 631);
            this.btnUpdateStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(198, 48);
            this.btnUpdateStock.TabIndex = 43;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            // 
            // picboxInventoryTracking
            // 
            this.picboxInventoryTracking.Image = global::WingBite.Properties.Resources.inventoryy_removebg_preview;
            this.picboxInventoryTracking.Location = new System.Drawing.Point(279, 18);
            this.picboxInventoryTracking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxInventoryTracking.Name = "picboxInventoryTracking";
            this.picboxInventoryTracking.Size = new System.Drawing.Size(153, 114);
            this.picboxInventoryTracking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxInventoryTracking.TabIndex = 14;
            this.picboxInventoryTracking.TabStop = false;
            // 
            // Inventory_Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1200, 846);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.txtAdjustProduct);
            this.Controls.Add(this.txtCurentStock);
            this.Controls.Add(this.lblProductNameHere);
            this.Controls.Add(this.lblAdjustProduct);
            this.Controls.Add(this.lblCurrentStock);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblUpdateStock);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.lblProductStock);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRefreshAll);
            this.Controls.Add(this.btnLowStockReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxInventoryTracking);
            this.Controls.Add(this.lblInventoryTracking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inventory_Tracking";
            this.Text = "Inventory_Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxInventoryTracking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxInventoryTracking;
        private System.Windows.Forms.Label lblInventoryTracking;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLowStockReport;
        private System.Windows.Forms.Button btnRefreshAll;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label lblAdjustProduct;
        private System.Windows.Forms.Label lblProductNameHere;
        private System.Windows.Forms.TextBox txtCurentStock;
        private System.Windows.Forms.TextBox txtAdjustProduct;
        private System.Windows.Forms.Button btnUpdateStock;
    }
}
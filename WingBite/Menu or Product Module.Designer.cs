namespace WingBite
{
    partial class Menu_or_Product_Module
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
            this.lblMenuProductManagement = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.lblFilterCategory = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.lblProductList = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxMenuProductManagement = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenuProductManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuProductManagement
            // 
            this.lblMenuProductManagement.AutoSize = true;
            this.lblMenuProductManagement.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuProductManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblMenuProductManagement.Location = new System.Drawing.Point(273, 39);
            this.lblMenuProductManagement.Name = "lblMenuProductManagement";
            this.lblMenuProductManagement.Size = new System.Drawing.Size(383, 31);
            this.lblMenuProductManagement.TabIndex = 15;
            this.lblMenuProductManagement.Text = "MENU/PRODUCT MANAGEMENT";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 503);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 35);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Green;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(244, 437);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(144, 35);
            this.btnAddProduct.TabIndex = 25;
            this.btnAddProduct.Text = "ADD PRODUCT";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(402, 437);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(144, 35);
            this.btnDeleteProduct.TabIndex = 27;
            this.btnDeleteProduct.Text = "DELETE PRODUCT";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.Location = new System.Drawing.Point(36, 115);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(101, 18);
            this.lblSearchProduct.TabIndex = 29;
            this.lblSearchProduct.Text = "Search Product:";
            // 
            // lblFilterCategory
            // 
            this.lblFilterCategory.AutoSize = true;
            this.lblFilterCategory.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterCategory.Location = new System.Drawing.Point(393, 115);
            this.lblFilterCategory.Name = "lblFilterCategory";
            this.lblFilterCategory.Size = new System.Drawing.Size(116, 18);
            this.lblFilterCategory.TabIndex = 30;
            this.lblFilterCategory.Text = "Filter by Category:";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(143, 109);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(235, 24);
            this.txtSearchProduct.TabIndex = 31;
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Location = new System.Drawing.Point(515, 108);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(235, 25);
            this.cmbFilterCategory.TabIndex = 32;
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblProductList.Location = new System.Drawing.Point(36, 144);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(111, 18);
            this.lblProductList.TabIndex = 33;
            this.lblProductList.Text = "PRODUCT LIST:";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(39, 165);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(711, 195);
            this.dgvProducts.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(274, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "UPDATE PRODUCTS:";
            // 
            // picboxMenuProductManagement
            // 
            this.picboxMenuProductManagement.Image = global::WingBite.Properties.Resources.products_removebg_preview;
            this.picboxMenuProductManagement.Location = new System.Drawing.Point(165, 14);
            this.picboxMenuProductManagement.Name = "picboxMenuProductManagement";
            this.picboxMenuProductManagement.Size = new System.Drawing.Size(102, 79);
            this.picboxMenuProductManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxMenuProductManagement.TabIndex = 16;
            this.picboxMenuProductManagement.TabStop = false;
            // 
            // Menu_or_Product_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblProductList);
            this.Controls.Add(this.cmbFilterCategory);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.lblFilterCategory);
            this.Controls.Add(this.lblSearchProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxMenuProductManagement);
            this.Controls.Add(this.lblMenuProductManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_or_Product_Module";
            this.Text = "Menu_or_Product_Module";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenuProductManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxMenuProductManagement;
        private System.Windows.Forms.Label lblMenuProductManagement;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label1;
    }
}
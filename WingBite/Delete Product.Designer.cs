namespace WingBite
{
    partial class Delete_Product
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
            this.lblDeleteProduct = new System.Windows.Forms.Label();
            this.lblMenuProductManagement = new System.Windows.Forms.Label();
            this.picboxMenuProductManagement = new System.Windows.Forms.PictureBox();
            this.btnFindID = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenuProductManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeleteProduct
            // 
            this.lblDeleteProduct.AutoSize = true;
            this.lblDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.lblDeleteProduct.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblDeleteProduct.Location = new System.Drawing.Point(221, 113);
            this.lblDeleteProduct.Name = "lblDeleteProduct";
            this.lblDeleteProduct.Size = new System.Drawing.Size(187, 24);
            this.lblDeleteProduct.TabIndex = 39;
            this.lblDeleteProduct.Text = "DELETE PRODUCT";
            // 
            // lblMenuProductManagement
            // 
            this.lblMenuProductManagement.AutoSize = true;
            this.lblMenuProductManagement.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuProductManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblMenuProductManagement.Location = new System.Drawing.Point(179, 46);
            this.lblMenuProductManagement.Name = "lblMenuProductManagement";
            this.lblMenuProductManagement.Size = new System.Drawing.Size(383, 31);
            this.lblMenuProductManagement.TabIndex = 37;
            this.lblMenuProductManagement.Text = "MENU/PRODUCT MANAGEMENT";
            // 
            // picboxMenuProductManagement
            // 
            this.picboxMenuProductManagement.Image = global::WingBite.Properties.Resources.products_removebg_preview;
            this.picboxMenuProductManagement.Location = new System.Drawing.Point(71, 21);
            this.picboxMenuProductManagement.Name = "picboxMenuProductManagement";
            this.picboxMenuProductManagement.Size = new System.Drawing.Size(102, 79);
            this.picboxMenuProductManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxMenuProductManagement.TabIndex = 38;
            this.picboxMenuProductManagement.TabStop = false;
            // 
            // btnFindID
            // 
            this.btnFindID.BackColor = System.Drawing.Color.Green;
            this.btnFindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindID.ForeColor = System.Drawing.Color.White;
            this.btnFindID.Location = new System.Drawing.Point(230, 193);
            this.btnFindID.Name = "btnFindID";
            this.btnFindID.Size = new System.Drawing.Size(96, 35);
            this.btnFindID.TabIndex = 49;
            this.btnFindID.Text = "FIND ID";
            this.btnFindID.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 342);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 35);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(131, 154);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(195, 27);
            this.txtProductID.TabIndex = 51;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.lblProductID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.Black;
            this.lblProductID.Location = new System.Drawing.Point(32, 160);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(94, 21);
            this.lblProductID.TabIndex = 50;
            this.lblProductID.Text = "Product ID:";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(342, 154);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(256, 150);
            this.dgvProducts.TabIndex = 52;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(424, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 35);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // Delete_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(634, 389);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.btnFindID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDeleteProduct);
            this.Controls.Add(this.picboxMenuProductManagement);
            this.Controls.Add(this.lblMenuProductManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete_Product";
            this.Text = "Delete_Product";
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenuProductManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteProduct;
        private System.Windows.Forms.PictureBox picboxMenuProductManagement;
        private System.Windows.Forms.Label lblMenuProductManagement;
        private System.Windows.Forms.Button btnFindID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnDelete;
    }
}
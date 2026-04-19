namespace WingBite
{
    partial class Order_Entry_Form
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
            this.lblSalesOrderForm = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.rbWings = new System.Windows.Forms.RadioButton();
            this.rbRicePlatter = new System.Windows.Forms.RadioButton();
            this.rbDrinks = new System.Windows.Forms.RadioButton();
            this.lblOrderNumResult = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.lblMenuItems = new System.Windows.Forms.Label();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.dgvCurrentOrder = new System.Windows.Forms.DataGridView();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalResult = new System.Windows.Forms.Label();
            this.picboxSalesOrderForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesOrderForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesOrderForm
            // 
            this.lblSalesOrderForm.AutoSize = true;
            this.lblSalesOrderForm.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblSalesOrderForm.Location = new System.Drawing.Point(464, 34);
            this.lblSalesOrderForm.Name = "lblSalesOrderForm";
            this.lblSalesOrderForm.Size = new System.Drawing.Size(262, 31);
            this.lblSalesOrderForm.TabIndex = 7;
            this.lblSalesOrderForm.Text = "ORDER ENTRY FORM";
            this.lblSalesOrderForm.Click += new System.EventHandler(this.lblSalesOrderForm_Click);
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(272, 111);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(67, 19);
            this.lblOrderNum.TabIndex = 11;
            this.lblOrderNum.Text = "Order #: ";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(553, 111);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(91, 19);
            this.lblOrderType.TabIndex = 12;
            this.lblOrderType.Text = "Order Type: ";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Location = new System.Drawing.Point(650, 109);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(167, 21);
            this.cmbOrderType.TabIndex = 13;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(344, 156);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(75, 19);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Category: ";
            // 
            // rbWings
            // 
            this.rbWings.AutoSize = true;
            this.rbWings.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWings.Location = new System.Drawing.Point(448, 152);
            this.rbWings.Name = "rbWings";
            this.rbWings.Size = new System.Drawing.Size(69, 23);
            this.rbWings.TabIndex = 15;
            this.rbWings.TabStop = true;
            this.rbWings.Text = "Wings";
            this.rbWings.UseVisualStyleBackColor = true;
            // 
            // rbRicePlatter
            // 
            this.rbRicePlatter.AutoSize = true;
            this.rbRicePlatter.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRicePlatter.Location = new System.Drawing.Point(546, 152);
            this.rbRicePlatter.Name = "rbRicePlatter";
            this.rbRicePlatter.Size = new System.Drawing.Size(102, 23);
            this.rbRicePlatter.TabIndex = 16;
            this.rbRicePlatter.TabStop = true;
            this.rbRicePlatter.Text = "Rice Platter";
            this.rbRicePlatter.UseVisualStyleBackColor = true;
            // 
            // rbDrinks
            // 
            this.rbDrinks.AutoSize = true;
            this.rbDrinks.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrinks.Location = new System.Drawing.Point(677, 152);
            this.rbDrinks.Name = "rbDrinks";
            this.rbDrinks.Size = new System.Drawing.Size(73, 23);
            this.rbDrinks.TabIndex = 17;
            this.rbDrinks.TabStop = true;
            this.rbDrinks.Text = "Drinks";
            this.rbDrinks.UseVisualStyleBackColor = true;
            // 
            // lblOrderNumResult
            // 
            this.lblOrderNumResult.AutoSize = true;
            this.lblOrderNumResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumResult.Location = new System.Drawing.Point(345, 111);
            this.lblOrderNumResult.Name = "lblOrderNumResult";
            this.lblOrderNumResult.Size = new System.Drawing.Size(91, 19);
            this.lblOrderNumResult.TabIndex = 18;
            this.lblOrderNumResult.Text = "Order # here";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(27, 645);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 35);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(641, 593);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(158, 31);
            this.btnCheckout.TabIndex = 22;
            this.btnCheckout.Text = "CHECKOUT";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(313, 593);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(158, 31);
            this.btnRemoveItem.TabIndex = 23;
            this.btnRemoveItem.Text = "REMOVE ITEM";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOrder.Location = new System.Drawing.Point(477, 593);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(158, 31);
            this.btnClearOrder.TabIndex = 24;
            this.btnClearOrder.Text = "CLEAR ORDER";
            this.btnClearOrder.UseVisualStyleBackColor = false;
            // 
            // lblMenuItems
            // 
            this.lblMenuItems.AutoSize = true;
            this.lblMenuItems.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItems.Location = new System.Drawing.Point(58, 191);
            this.lblMenuItems.Name = "lblMenuItems";
            this.lblMenuItems.Size = new System.Drawing.Size(95, 19);
            this.lblMenuItems.TabIndex = 25;
            this.lblMenuItems.Text = "Menu Items: ";
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentOrder.Location = new System.Drawing.Point(560, 191);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(109, 19);
            this.lblCurrentOrder.TabIndex = 26;
            this.lblCurrentOrder.Text = "Current Order: ";
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Location = new System.Drawing.Point(62, 213);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.Size = new System.Drawing.Size(465, 305);
            this.dgvMenuItems.TabIndex = 27;
            // 
            // dgvCurrentOrder
            // 
            this.dgvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentOrder.Location = new System.Drawing.Point(564, 213);
            this.dgvCurrentOrder.Name = "dgvCurrentOrder";
            this.dgvCurrentOrder.Size = new System.Drawing.Size(465, 305);
            this.dgvCurrentOrder.TabIndex = 28;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(62, 535);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(108, 27);
            this.btnAddToOrder.TabIndex = 29;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(206, 543);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(77, 19);
            this.lblQuantity.TabIndex = 30;
            this.lblQuantity.Text = "Quantity: ";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(289, 539);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 23);
            this.nudQuantity.TabIndex = 31;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(560, 543);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 19);
            this.lblSubtotal.TabIndex = 32;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // lblSubtotalResult
            // 
            this.lblSubtotalResult.AutoSize = true;
            this.lblSubtotalResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalResult.Location = new System.Drawing.Point(637, 543);
            this.lblSubtotalResult.Name = "lblSubtotalResult";
            this.lblSubtotalResult.Size = new System.Drawing.Size(115, 19);
            this.lblSubtotalResult.TabIndex = 33;
            this.lblSubtotalResult.Text = "Subtotal Result:";
            // 
            // picboxSalesOrderForm
            // 
            this.picboxSalesOrderForm.Image = global::WingBite.Properties.Resources.order_removebg_preview;
            this.picboxSalesOrderForm.Location = new System.Drawing.Point(356, 13);
            this.picboxSalesOrderForm.Name = "picboxSalesOrderForm";
            this.picboxSalesOrderForm.Size = new System.Drawing.Size(102, 74);
            this.picboxSalesOrderForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSalesOrderForm.TabIndex = 10;
            this.picboxSalesOrderForm.TabStop = false;
            // 
            // Order_Entry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.lblSubtotalResult);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.dgvCurrentOrder);
            this.Controls.Add(this.dgvMenuItems);
            this.Controls.Add(this.lblCurrentOrder);
            this.Controls.Add(this.lblMenuItems);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblOrderNumResult);
            this.Controls.Add(this.rbDrinks);
            this.Controls.Add(this.rbRicePlatter);
            this.Controls.Add(this.rbWings);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.picboxSalesOrderForm);
            this.Controls.Add(this.lblSalesOrderForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_Entry_Form";
            this.Text = "Order_Entry_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesOrderForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesOrderForm;
        private System.Windows.Forms.PictureBox picboxSalesOrderForm;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.RadioButton rbWings;
        private System.Windows.Forms.RadioButton rbRicePlatter;
        private System.Windows.Forms.RadioButton rbDrinks;
        private System.Windows.Forms.Label lblOrderNumResult;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Label lblMenuItems;
        private System.Windows.Forms.Label lblCurrentOrder;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.DataGridView dgvCurrentOrder;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalResult;
    }
}
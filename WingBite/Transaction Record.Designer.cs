namespace WingBite
{
    partial class Transaction_Record
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
            this.lblSalesTransactionForm = new System.Windows.Forms.Label();
            this.picboxSalesTransactionForm = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblTotalAmountResult = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblOrderNumResult = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblChangeTransac = new System.Windows.Forms.Label();
            this.lblPayMethodUsed = new System.Windows.Forms.Label();
            this.lblChangeResult = new System.Windows.Forms.Label();
            this.lblDateTimeResult = new System.Windows.Forms.Label();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.dgvOrderSummary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesTransactionForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesTransactionForm
            // 
            this.lblSalesTransactionForm.AutoSize = true;
            this.lblSalesTransactionForm.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTransactionForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblSalesTransactionForm.Location = new System.Drawing.Point(302, 42);
            this.lblSalesTransactionForm.Name = "lblSalesTransactionForm";
            this.lblSalesTransactionForm.Size = new System.Drawing.Size(290, 31);
            this.lblSalesTransactionForm.TabIndex = 13;
            this.lblSalesTransactionForm.Text = "TRANSACTION RECORD";
            // 
            // picboxSalesTransactionForm
            // 
            this.picboxSalesTransactionForm.Image = global::WingBite.Properties.Resources.transac_removebg_preview;
            this.picboxSalesTransactionForm.Location = new System.Drawing.Point(194, 21);
            this.picboxSalesTransactionForm.Name = "picboxSalesTransactionForm";
            this.picboxSalesTransactionForm.Size = new System.Drawing.Size(102, 74);
            this.picboxSalesTransactionForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSalesTransactionForm.TabIndex = 14;
            this.picboxSalesTransactionForm.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(397, 474);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 46);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(227, 474);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(149, 46);
            this.btnNewOrder.TabIndex = 26;
            this.btnNewOrder.Text = "NEW ORDER";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            // 
            // lblTotalAmountResult
            // 
            this.lblTotalAmountResult.AutoSize = true;
            this.lblTotalAmountResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountResult.Location = new System.Drawing.Point(248, 143);
            this.lblTotalAmountResult.Name = "lblTotalAmountResult";
            this.lblTotalAmountResult.Size = new System.Drawing.Size(160, 19);
            this.lblTotalAmountResult.TabIndex = 31;
            this.lblTotalAmountResult.Text = "Total Amount of Order";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(112, 143);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(109, 19);
            this.lblTotalAmount.TabIndex = 30;
            this.lblTotalAmount.Text = "Total Amount: ";
            // 
            // lblOrderNumResult
            // 
            this.lblOrderNumResult.AutoSize = true;
            this.lblOrderNumResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumResult.Location = new System.Drawing.Point(185, 115);
            this.lblOrderNumResult.Name = "lblOrderNumResult";
            this.lblOrderNumResult.Size = new System.Drawing.Size(91, 19);
            this.lblOrderNumResult.TabIndex = 29;
            this.lblOrderNumResult.Text = "Order # here";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(112, 115);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(67, 19);
            this.lblOrderNum.TabIndex = 28;
            this.lblOrderNum.Text = "Order #: ";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(112, 172);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(130, 19);
            this.lblPaymentMethod.TabIndex = 32;
            this.lblPaymentMethod.Text = "Payment Method: ";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(112, 229);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(114, 19);
            this.lblDateTime.TabIndex = 33;
            this.lblDateTime.Text = "Date and Time: ";
            // 
            // lblChangeTransac
            // 
            this.lblChangeTransac.AutoSize = true;
            this.lblChangeTransac.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeTransac.Location = new System.Drawing.Point(112, 200);
            this.lblChangeTransac.Name = "lblChangeTransac";
            this.lblChangeTransac.Size = new System.Drawing.Size(67, 19);
            this.lblChangeTransac.TabIndex = 34;
            this.lblChangeTransac.Text = "Change: ";
            // 
            // lblPayMethodUsed
            // 
            this.lblPayMethodUsed.AutoSize = true;
            this.lblPayMethodUsed.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethodUsed.Location = new System.Drawing.Point(248, 172);
            this.lblPayMethodUsed.Name = "lblPayMethodUsed";
            this.lblPayMethodUsed.Size = new System.Drawing.Size(159, 19);
            this.lblPayMethodUsed.TabIndex = 35;
            this.lblPayMethodUsed.Text = "Payment Method Used";
            // 
            // lblChangeResult
            // 
            this.lblChangeResult.AutoSize = true;
            this.lblChangeResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeResult.Location = new System.Drawing.Point(248, 200);
            this.lblChangeResult.Name = "lblChangeResult";
            this.lblChangeResult.Size = new System.Drawing.Size(105, 19);
            this.lblChangeResult.TabIndex = 37;
            this.lblChangeResult.Text = "Change Result";
            // 
            // lblDateTimeResult
            // 
            this.lblDateTimeResult.AutoSize = true;
            this.lblDateTimeResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeResult.Location = new System.Drawing.Point(248, 229);
            this.lblDateTimeResult.Name = "lblDateTimeResult";
            this.lblDateTimeResult.Size = new System.Drawing.Size(106, 19);
            this.lblDateTimeResult.TabIndex = 36;
            this.lblDateTimeResult.Text = "Date and Time";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.Location = new System.Drawing.Point(112, 263);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(121, 19);
            this.lblOrderSummary.TabIndex = 38;
            this.lblOrderSummary.Text = "Order Summary: ";
            // 
            // dgvOrderSummary
            // 
            this.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderSummary.Location = new System.Drawing.Point(116, 286);
            this.dgvOrderSummary.Name = "dgvOrderSummary";
            this.dgvOrderSummary.Size = new System.Drawing.Size(554, 159);
            this.dgvOrderSummary.TabIndex = 39;
            // 
            // Transaction_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dgvOrderSummary);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lblChangeResult);
            this.Controls.Add(this.lblDateTimeResult);
            this.Controls.Add(this.lblPayMethodUsed);
            this.Controls.Add(this.lblChangeTransac);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblTotalAmountResult);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblOrderNumResult);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.picboxSalesTransactionForm);
            this.Controls.Add(this.lblSalesTransactionForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction_Record";
            this.Text = "Transaction_Record";
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesTransactionForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxSalesTransactionForm;
        private System.Windows.Forms.Label lblSalesTransactionForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblTotalAmountResult;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblOrderNumResult;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblChangeTransac;
        private System.Windows.Forms.Label lblPayMethodUsed;
        private System.Windows.Forms.Label lblChangeResult;
        private System.Windows.Forms.Label lblDateTimeResult;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.DataGridView dgvOrderSummary;
    }
}
namespace WingBite
{
    partial class Payment_Form
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
            this.lblSalesPaymentForm = new System.Windows.Forms.Label();
            this.lblOrderNumResult = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmountResult = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancelPay = new System.Windows.Forms.Button();
            this.btnConfirmPay = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblAmountTendered = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtAmountTendered = new System.Windows.Forms.TextBox();
            this.lblChangeResult = new System.Windows.Forms.Label();
            this.lblFinalTotalResult = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.picboxSalesPaymentForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesPaymentForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesPaymentForm
            // 
            this.lblSalesPaymentForm.AutoSize = true;
            this.lblSalesPaymentForm.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPaymentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblSalesPaymentForm.Location = new System.Drawing.Point(321, 40);
            this.lblSalesPaymentForm.Name = "lblSalesPaymentForm";
            this.lblSalesPaymentForm.Size = new System.Drawing.Size(206, 31);
            this.lblSalesPaymentForm.TabIndex = 11;
            this.lblSalesPaymentForm.Text = "PAYMENT FORM";
            // 
            // lblOrderNumResult
            // 
            this.lblOrderNumResult.AutoSize = true;
            this.lblOrderNumResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumResult.Location = new System.Drawing.Point(194, 132);
            this.lblOrderNumResult.Name = "lblOrderNumResult";
            this.lblOrderNumResult.Size = new System.Drawing.Size(91, 19);
            this.lblOrderNumResult.TabIndex = 20;
            this.lblOrderNumResult.Text = "Order # here";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(127, 132);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(67, 19);
            this.lblOrderNum.TabIndex = 19;
            this.lblOrderNum.Text = "Order #: ";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(366, 132);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(109, 19);
            this.lblTotalAmount.TabIndex = 21;
            this.lblTotalAmount.Text = "Total Amount: ";
            // 
            // lblTotalAmountResult
            // 
            this.lblTotalAmountResult.AutoSize = true;
            this.lblTotalAmountResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountResult.Location = new System.Drawing.Point(481, 132);
            this.lblTotalAmountResult.Name = "lblTotalAmountResult";
            this.lblTotalAmountResult.Size = new System.Drawing.Size(160, 19);
            this.lblTotalAmountResult.TabIndex = 22;
            this.lblTotalAmountResult.Text = "Total Amount of Order";
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
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnCancelPay
            // 
            this.btnCancelPay.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPay.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPay.Location = new System.Drawing.Point(211, 412);
            this.btnCancelPay.Name = "btnCancelPay";
            this.btnCancelPay.Size = new System.Drawing.Size(177, 35);
            this.btnCancelPay.TabIndex = 24;
            this.btnCancelPay.Text = "CANCEL PAYMENT";
            this.btnCancelPay.UseVisualStyleBackColor = false;
            // 
            // btnConfirmPay
            // 
            this.btnConfirmPay.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirmPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPay.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPay.Location = new System.Drawing.Point(416, 412);
            this.btnConfirmPay.Name = "btnConfirmPay";
            this.btnConfirmPay.Size = new System.Drawing.Size(177, 35);
            this.btnConfirmPay.TabIndex = 25;
            this.btnConfirmPay.Text = "CONFIRM PAYMENT";
            this.btnConfirmPay.UseVisualStyleBackColor = false;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(127, 266);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(67, 19);
            this.lblChange.TabIndex = 26;
            this.lblChange.Text = "Change: ";
            // 
            // lblAmountTendered
            // 
            this.lblAmountTendered.AutoSize = true;
            this.lblAmountTendered.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountTendered.Location = new System.Drawing.Point(127, 230);
            this.lblAmountTendered.Name = "lblAmountTendered";
            this.lblAmountTendered.Size = new System.Drawing.Size(137, 19);
            this.lblAmountTendered.TabIndex = 27;
            this.lblAmountTendered.Text = "Amount Tendered: ";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(127, 193);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(130, 19);
            this.lblPaymentMethod.TabIndex = 28;
            this.lblPaymentMethod.Text = "Payment Method: ";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(267, 191);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(181, 21);
            this.cmbPaymentMethod.TabIndex = 29;
            // 
            // txtAmountTendered
            // 
            this.txtAmountTendered.Location = new System.Drawing.Point(267, 229);
            this.txtAmountTendered.Name = "txtAmountTendered";
            this.txtAmountTendered.Size = new System.Drawing.Size(181, 20);
            this.txtAmountTendered.TabIndex = 30;
            // 
            // lblChangeResult
            // 
            this.lblChangeResult.AutoSize = true;
            this.lblChangeResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeResult.Location = new System.Drawing.Point(263, 266);
            this.lblChangeResult.Name = "lblChangeResult";
            this.lblChangeResult.Size = new System.Drawing.Size(105, 19);
            this.lblChangeResult.TabIndex = 31;
            this.lblChangeResult.Text = "Change Result";
            // 
            // lblFinalTotalResult
            // 
            this.lblFinalTotalResult.AutoSize = true;
            this.lblFinalTotalResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTotalResult.Location = new System.Drawing.Point(263, 328);
            this.lblFinalTotalResult.Name = "lblFinalTotalResult";
            this.lblFinalTotalResult.Size = new System.Drawing.Size(127, 19);
            this.lblFinalTotalResult.TabIndex = 32;
            this.lblFinalTotalResult.Text = "Final Total Result";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTotal.Location = new System.Drawing.Point(127, 328);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(89, 19);
            this.lblFinalTotal.TabIndex = 33;
            this.lblFinalTotal.Text = "Final Total: ";
            // 
            // picboxSalesPaymentForm
            // 
            this.picboxSalesPaymentForm.Image = global::WingBite.Properties.Resources.payment_removebg_preview;
            this.picboxSalesPaymentForm.Location = new System.Drawing.Point(213, 19);
            this.picboxSalesPaymentForm.Name = "picboxSalesPaymentForm";
            this.picboxSalesPaymentForm.Size = new System.Drawing.Size(102, 74);
            this.picboxSalesPaymentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSalesPaymentForm.TabIndex = 12;
            this.picboxSalesPaymentForm.TabStop = false;
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblFinalTotal);
            this.Controls.Add(this.lblFinalTotalResult);
            this.Controls.Add(this.lblChangeResult);
            this.Controls.Add(this.txtAmountTendered);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblAmountTendered);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnConfirmPay);
            this.Controls.Add(this.btnCancelPay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotalAmountResult);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblOrderNumResult);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.picboxSalesPaymentForm);
            this.Controls.Add(this.lblSalesPaymentForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment_Form";
            this.Text = "Payment_Form";
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesPaymentForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxSalesPaymentForm;
        private System.Windows.Forms.Label lblSalesPaymentForm;
        private System.Windows.Forms.Label lblOrderNumResult;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountResult;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancelPay;
        private System.Windows.Forms.Button btnConfirmPay;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblAmountTendered;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.TextBox txtAmountTendered;
        private System.Windows.Forms.Label lblChangeResult;
        private System.Windows.Forms.Label lblFinalTotalResult;
        private System.Windows.Forms.Label lblFinalTotal;
    }
}
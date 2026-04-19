namespace WingBite
{
    partial class Sales_Reports
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
            this.lblReportsForm = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblReportType = new System.Windows.Forms.Label();
            this.btnDaily = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.btnTopSelling = new System.Windows.Forms.Button();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblReportTitleResult = new System.Windows.Forms.Label();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.lblReportData = new System.Windows.Forms.Label();
            this.dgvReportData = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picboxReportsForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReportsForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportsForm
            // 
            this.lblReportsForm.AutoSize = true;
            this.lblReportsForm.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblReportsForm.Location = new System.Drawing.Point(323, 33);
            this.lblReportsForm.Name = "lblReportsForm";
            this.lblReportsForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReportsForm.Size = new System.Drawing.Size(204, 31);
            this.lblReportsForm.TabIndex = 17;
            this.lblReportsForm.Text = "REPORTS FORM";
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
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(86, 101);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(85, 18);
            this.lblReportType.TabIndex = 26;
            this.lblReportType.Text = "Report Type:";
            // 
            // btnDaily
            // 
            this.btnDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaily.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.Location = new System.Drawing.Point(89, 125);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(115, 42);
            this.btnDaily.TabIndex = 27;
            this.btnDaily.Text = "Daily Summay";
            this.btnDaily.UseVisualStyleBackColor = false;
            // 
            // btnMonthly
            // 
            this.btnMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthly.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.Location = new System.Drawing.Point(331, 125);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(115, 42);
            this.btnMonthly.TabIndex = 28;
            this.btnMonthly.Text = "Monthly Summay";
            this.btnMonthly.UseVisualStyleBackColor = false;
            // 
            // btnWeekly
            // 
            this.btnWeekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.Location = new System.Drawing.Point(210, 125);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(115, 42);
            this.btnWeekly.TabIndex = 29;
            this.btnWeekly.Text = "Weekly Summay";
            this.btnWeekly.UseVisualStyleBackColor = false;
            // 
            // btnTopSelling
            // 
            this.btnTopSelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTopSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopSelling.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopSelling.Location = new System.Drawing.Point(573, 125);
            this.btnTopSelling.Name = "btnTopSelling";
            this.btnTopSelling.Size = new System.Drawing.Size(115, 42);
            this.btnTopSelling.TabIndex = 30;
            this.btnTopSelling.Text = "Top Selling";
            this.btnTopSelling.UseVisualStyleBackColor = false;
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionHistory.Location = new System.Drawing.Point(452, 125);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(115, 42);
            this.btnTransactionHistory.TabIndex = 31;
            this.btnTransactionHistory.Text = "Transaction History";
            this.btnTransactionHistory.UseVisualStyleBackColor = false;
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRange.Location = new System.Drawing.Point(86, 207);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(81, 18);
            this.lblDateRange.TabIndex = 32;
            this.lblDateRange.Text = "Date Range:";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(86, 184);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(82, 18);
            this.lblReportTitle.TabIndex = 33;
            this.lblReportTitle.Text = "Report Title:";
            // 
            // lblReportTitleResult
            // 
            this.lblReportTitleResult.AutoSize = true;
            this.lblReportTitleResult.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitleResult.Location = new System.Drawing.Point(174, 184);
            this.lblReportTitleResult.Name = "lblReportTitleResult";
            this.lblReportTitleResult.Size = new System.Drawing.Size(109, 18);
            this.lblReportTitleResult.TabIndex = 34;
            this.lblReportTitleResult.Text = "Report Title here";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Location = new System.Drawing.Point(219, 205);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFrom.TabIndex = 35;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(174, 207);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(39, 18);
            this.lblDateFrom.TabIndex = 36;
            this.lblDateFrom.Text = "From";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(425, 208);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(24, 18);
            this.lblDateTo.TabIndex = 37;
            this.lblDateTo.Text = "To";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Location = new System.Drawing.Point(455, 204);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTo.TabIndex = 38;
            // 
            // lblReportData
            // 
            this.lblReportData.AutoSize = true;
            this.lblReportData.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportData.Location = new System.Drawing.Point(85, 241);
            this.lblReportData.Name = "lblReportData";
            this.lblReportData.Size = new System.Drawing.Size(83, 18);
            this.lblReportData.TabIndex = 39;
            this.lblReportData.Text = "Report Data:";
            // 
            // dgvReportData
            // 
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Location = new System.Drawing.Point(89, 262);
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.Size = new System.Drawing.Size(599, 209);
            this.dgvReportData.TabIndex = 40;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Maroon;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(692, 503);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 35);
            this.btnRefresh.TabIndex = 42;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // picboxReportsForm
            // 
            this.picboxReportsForm.Image = global::WingBite.Properties.Resources.salesss_removebg_preview;
            this.picboxReportsForm.Location = new System.Drawing.Point(215, 12);
            this.picboxReportsForm.Name = "picboxReportsForm";
            this.picboxReportsForm.Size = new System.Drawing.Size(102, 74);
            this.picboxReportsForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxReportsForm.TabIndex = 18;
            this.picboxReportsForm.TabStop = false;
            // 
            // Sales_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvReportData);
            this.Controls.Add(this.lblReportData);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.lblReportTitleResult);
            this.Controls.Add(this.lblReportTitle);
            this.Controls.Add(this.lblDateRange);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.btnTopSelling);
            this.Controls.Add(this.btnWeekly);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnDaily);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxReportsForm);
            this.Controls.Add(this.lblReportsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Reports";
            this.Text = "Sales_Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReportsForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxReportsForm;
        private System.Windows.Forms.Label lblReportsForm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnWeekly;
        private System.Windows.Forms.Button btnTopSelling;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label lblReportTitleResult;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label lblReportData;
        private System.Windows.Forms.DataGridView dgvReportData;
        private System.Windows.Forms.Button btnRefresh;
    }
}
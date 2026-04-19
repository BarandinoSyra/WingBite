namespace WingBite
{
    partial class Sales_Report_Module
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
            this.lblSalesReports = new System.Windows.Forms.Label();
            this.picboxSalesReports = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelSalesReports = new System.Windows.Forms.Panel();
            this.btnAccessReports = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesReports)).BeginInit();
            this.panelSalesReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalesReports
            // 
            this.lblSalesReports.AutoSize = true;
            this.lblSalesReports.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblSalesReports.Location = new System.Drawing.Point(322, 48);
            this.lblSalesReports.Name = "lblSalesReports";
            this.lblSalesReports.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSalesReports.Size = new System.Drawing.Size(210, 31);
            this.lblSalesReports.TabIndex = 19;
            this.lblSalesReports.Text = "SALES REPORTS";
            // 
            // picboxSalesReports
            // 
            this.picboxSalesReports.Image = global::WingBite.Properties.Resources.salesss_removebg_preview;
            this.picboxSalesReports.Location = new System.Drawing.Point(214, 27);
            this.picboxSalesReports.Name = "picboxSalesReports";
            this.picboxSalesReports.Size = new System.Drawing.Size(102, 74);
            this.picboxSalesReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSalesReports.TabIndex = 20;
            this.picboxSalesReports.TabStop = false;
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
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // panelSalesReports
            // 
            this.panelSalesReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.panelSalesReports.Controls.Add(this.btnAccessReports);
            this.panelSalesReports.Controls.Add(this.btnDetail);
            this.panelSalesReports.Location = new System.Drawing.Point(268, 131);
            this.panelSalesReports.Name = "panelSalesReports";
            this.panelSalesReports.Size = new System.Drawing.Size(234, 120);
            this.panelSalesReports.TabIndex = 27;
            // 
            // btnAccessReports
            // 
            this.btnAccessReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnAccessReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccessReports.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessReports.Location = new System.Drawing.Point(18, 21);
            this.btnAccessReports.Name = "btnAccessReports";
            this.btnAccessReports.Size = new System.Drawing.Size(200, 36);
            this.btnAccessReports.TabIndex = 6;
            this.btnAccessReports.Text = "ACCESS REPORTS";
            this.btnAccessReports.UseVisualStyleBackColor = false;
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(18, 63);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(200, 36);
            this.btnDetail.TabIndex = 5;
            this.btnDetail.Text = "REPORT DETAIL";
            this.btnDetail.UseVisualStyleBackColor = false;
            // 
            // Sales_Report_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panelSalesReports);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxSalesReports);
            this.Controls.Add(this.lblSalesReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Report_Module";
            this.Text = "Sales_Report_Module";
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesReports)).EndInit();
            this.panelSalesReports.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxSalesReports;
        private System.Windows.Forms.Label lblSalesReports;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelSalesReports;
        private System.Windows.Forms.Button btnAccessReports;
        private System.Windows.Forms.Button btnDetail;
    }
}
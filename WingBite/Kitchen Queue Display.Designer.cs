namespace WingBite
{
    partial class Kitchen_Queue_Display
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
            this.lblKitchenQueue = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvPendingOrders = new System.Windows.Forms.DataGridView();
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.lblReadyToServe = new System.Windows.Forms.Label();
            this.lblPreparingOrders = new System.Windows.Forms.Label();
            this.dgvPreparingOrders = new System.Windows.Forms.DataGridView();
            this.dgvReadyToServe = new System.Windows.Forms.DataGridView();
            this.picboxKitchenQueue = new System.Windows.Forms.PictureBox();
            this.btnServing = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnPreparing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreparingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadyToServe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKitchenQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitchenQueue
            // 
            this.lblKitchenQueue.AutoSize = true;
            this.lblKitchenQueue.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblKitchenQueue.Location = new System.Drawing.Point(282, 43);
            this.lblKitchenQueue.Name = "lblKitchenQueue";
            this.lblKitchenQueue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKitchenQueue.Size = new System.Drawing.Size(327, 31);
            this.lblKitchenQueue.TabIndex = 17;
            this.lblKitchenQueue.Text = "KITCHEN QUEUE DISPLAY";
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
            // dgvPendingOrders
            // 
            this.dgvPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingOrders.Location = new System.Drawing.Point(36, 141);
            this.dgvPendingOrders.Name = "dgvPendingOrders";
            this.dgvPendingOrders.Size = new System.Drawing.Size(240, 278);
            this.dgvPendingOrders.TabIndex = 26;
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.AutoSize = true;
            this.lblPendingOrders.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.Location = new System.Drawing.Point(32, 119);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(121, 19);
            this.lblPendingOrders.TabIndex = 27;
            this.lblPendingOrders.Text = "Pending Orders: ";
            // 
            // lblReadyToServe
            // 
            this.lblReadyToServe.AutoSize = true;
            this.lblReadyToServe.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyToServe.Location = new System.Drawing.Point(524, 119);
            this.lblReadyToServe.Name = "lblReadyToServe";
            this.lblReadyToServe.Size = new System.Drawing.Size(115, 19);
            this.lblReadyToServe.TabIndex = 31;
            this.lblReadyToServe.Text = "Ready to Serve: ";
            // 
            // lblPreparingOrders
            // 
            this.lblPreparingOrders.AutoSize = true;
            this.lblPreparingOrders.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparingOrders.Location = new System.Drawing.Point(278, 119);
            this.lblPreparingOrders.Name = "lblPreparingOrders";
            this.lblPreparingOrders.Size = new System.Drawing.Size(128, 19);
            this.lblPreparingOrders.TabIndex = 32;
            this.lblPreparingOrders.Text = "Preparing Orders: ";
            // 
            // dgvPreparingOrders
            // 
            this.dgvPreparingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreparingOrders.Location = new System.Drawing.Point(282, 141);
            this.dgvPreparingOrders.Name = "dgvPreparingOrders";
            this.dgvPreparingOrders.Size = new System.Drawing.Size(240, 278);
            this.dgvPreparingOrders.TabIndex = 33;
            // 
            // dgvReadyToServe
            // 
            this.dgvReadyToServe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadyToServe.Location = new System.Drawing.Point(528, 141);
            this.dgvReadyToServe.Name = "dgvReadyToServe";
            this.dgvReadyToServe.Size = new System.Drawing.Size(240, 278);
            this.dgvReadyToServe.TabIndex = 34;
            // 
            // picboxKitchenQueue
            // 
            this.picboxKitchenQueue.Image = global::WingBite.Properties.Resources.kitsen_removebg_preview1;
            this.picboxKitchenQueue.Location = new System.Drawing.Point(174, 22);
            this.picboxKitchenQueue.Name = "picboxKitchenQueue";
            this.picboxKitchenQueue.Size = new System.Drawing.Size(102, 74);
            this.picboxKitchenQueue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxKitchenQueue.TabIndex = 18;
            this.picboxKitchenQueue.TabStop = false;
            // 
            // btnServing
            // 
            this.btnServing.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnServing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServing.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServing.Location = new System.Drawing.Point(340, 438);
            this.btnServing.Name = "btnServing";
            this.btnServing.Size = new System.Drawing.Size(119, 48);
            this.btnServing.TabIndex = 37;
            this.btnServing.Text = "MARK AS SERVING";
            this.btnServing.UseVisualStyleBackColor = false;
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.Green;
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.Location = new System.Drawing.Point(465, 438);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(119, 48);
            this.btnCompleted.TabIndex = 36;
            this.btnCompleted.Text = "MARK AS COMPLETED";
            this.btnCompleted.UseVisualStyleBackColor = false;
            // 
            // btnPreparing
            // 
            this.btnPreparing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPreparing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreparing.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreparing.Location = new System.Drawing.Point(217, 438);
            this.btnPreparing.Name = "btnPreparing";
            this.btnPreparing.Size = new System.Drawing.Size(117, 48);
            this.btnPreparing.TabIndex = 35;
            this.btnPreparing.Text = "MARK AS PREPARING";
            this.btnPreparing.UseVisualStyleBackColor = false;
            // 
            // Kitchen_Queue_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnServing);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnPreparing);
            this.Controls.Add(this.dgvReadyToServe);
            this.Controls.Add(this.dgvPreparingOrders);
            this.Controls.Add(this.lblPreparingOrders);
            this.Controls.Add(this.lblReadyToServe);
            this.Controls.Add(this.lblPendingOrders);
            this.Controls.Add(this.dgvPendingOrders);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxKitchenQueue);
            this.Controls.Add(this.lblKitchenQueue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kitchen_Queue_Display";
            this.Text = "Kitchen_Queue_Display";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreparingOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadyToServe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKitchenQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxKitchenQueue;
        private System.Windows.Forms.Label lblKitchenQueue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvPendingOrders;
        private System.Windows.Forms.Label lblPendingOrders;
        private System.Windows.Forms.Label lblReadyToServe;
        private System.Windows.Forms.Label lblPreparingOrders;
        private System.Windows.Forms.DataGridView dgvPreparingOrders;
        private System.Windows.Forms.DataGridView dgvReadyToServe;
        private System.Windows.Forms.Button btnServing;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnPreparing;
    }
}
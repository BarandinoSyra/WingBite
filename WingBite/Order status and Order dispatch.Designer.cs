namespace WingBite
{
    partial class Order_status_and_Order_dispatch
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
            this.picboxOrderStatusDispatch = new System.Windows.Forms.PictureBox();
            this.lblOrderStatusDispatch = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderDispatch = new System.Windows.Forms.Label();
            this.btnMarkServing = new System.Windows.Forms.Button();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.btnMarkPreparing = new System.Windows.Forms.Button();
            this.lblCurrentStats = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblTimePlaced = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblTimePlacedHere = new System.Windows.Forms.Label();
            this.lblOrderNumHere = new System.Windows.Forms.Label();
            this.txtItems = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOrderStatusDispatch)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxOrderStatusDispatch
            // 
            this.picboxOrderStatusDispatch.Image = global::WingBite.Properties.Resources.kitsen_removebg_preview;
            this.picboxOrderStatusDispatch.Location = new System.Drawing.Point(131, 14);
            this.picboxOrderStatusDispatch.Name = "picboxOrderStatusDispatch";
            this.picboxOrderStatusDispatch.Size = new System.Drawing.Size(102, 74);
            this.picboxOrderStatusDispatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxOrderStatusDispatch.TabIndex = 18;
            this.picboxOrderStatusDispatch.TabStop = false;
            // 
            // lblOrderStatusDispatch
            // 
            this.lblOrderStatusDispatch.AutoSize = true;
            this.lblOrderStatusDispatch.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatusDispatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblOrderStatusDispatch.Location = new System.Drawing.Point(239, 35);
            this.lblOrderStatusDispatch.Name = "lblOrderStatusDispatch";
            this.lblOrderStatusDispatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOrderStatusDispatch.Size = new System.Drawing.Size(424, 31);
            this.lblOrderStatusDispatch.TabIndex = 17;
            this.lblOrderStatusDispatch.Text = "ORDER STATUS/ORDER DISPATCH";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(289, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "ORDER STATUS UPDATE";
            // 
            // lblOrderDispatch
            // 
            this.lblOrderDispatch.AutoSize = true;
            this.lblOrderDispatch.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDispatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblOrderDispatch.Location = new System.Drawing.Point(323, 388);
            this.lblOrderDispatch.Name = "lblOrderDispatch";
            this.lblOrderDispatch.Size = new System.Drawing.Size(161, 21);
            this.lblOrderDispatch.TabIndex = 27;
            this.lblOrderDispatch.Text = "ORDER DISPATCH";
            // 
            // btnMarkServing
            // 
            this.btnMarkServing.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMarkServing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkServing.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkServing.Location = new System.Drawing.Point(333, 423);
            this.btnMarkServing.Name = "btnMarkServing";
            this.btnMarkServing.Size = new System.Drawing.Size(119, 48);
            this.btnMarkServing.TabIndex = 33;
            this.btnMarkServing.Text = "MARK AS SERVING";
            this.btnMarkServing.UseVisualStyleBackColor = false;
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.BackColor = System.Drawing.Color.Green;
            this.btnMarkCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkCompleted.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkCompleted.Location = new System.Drawing.Point(458, 423);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(119, 48);
            this.btnMarkCompleted.TabIndex = 32;
            this.btnMarkCompleted.Text = "MARK AS COMPLETED";
            this.btnMarkCompleted.UseVisualStyleBackColor = false;
            // 
            // btnMarkPreparing
            // 
            this.btnMarkPreparing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMarkPreparing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkPreparing.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkPreparing.Location = new System.Drawing.Point(210, 423);
            this.btnMarkPreparing.Name = "btnMarkPreparing";
            this.btnMarkPreparing.Size = new System.Drawing.Size(117, 48);
            this.btnMarkPreparing.TabIndex = 31;
            this.btnMarkPreparing.Text = "MARK AS PREPARING";
            this.btnMarkPreparing.UseVisualStyleBackColor = false;
            // 
            // lblCurrentStats
            // 
            this.lblCurrentStats.AutoSize = true;
            this.lblCurrentStats.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStats.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentStats.Location = new System.Drawing.Point(205, 331);
            this.lblCurrentStats.Name = "lblCurrentStats";
            this.lblCurrentStats.Size = new System.Drawing.Size(108, 19);
            this.lblCurrentStats.TabIndex = 34;
            this.lblCurrentStats.Text = "Current Status:";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.ForeColor = System.Drawing.Color.Black;
            this.lblItems.Location = new System.Drawing.Point(205, 209);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(48, 19);
            this.lblItems.TabIndex = 35;
            this.lblItems.Text = "Items:";
            // 
            // lblTimePlaced
            // 
            this.lblTimePlaced.AutoSize = true;
            this.lblTimePlaced.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePlaced.ForeColor = System.Drawing.Color.Black;
            this.lblTimePlaced.Location = new System.Drawing.Point(205, 180);
            this.lblTimePlaced.Name = "lblTimePlaced";
            this.lblTimePlaced.Size = new System.Drawing.Size(97, 19);
            this.lblTimePlaced.TabIndex = 36;
            this.lblTimePlaced.Text = "Time Placed: ";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.ForeColor = System.Drawing.Color.Black;
            this.lblOrderNum.Location = new System.Drawing.Point(205, 151);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(63, 19);
            this.lblOrderNum.TabIndex = 37;
            this.lblOrderNum.Text = "Order #:";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentStatus.Location = new System.Drawing.Point(318, 331);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(133, 19);
            this.lblCurrentStatus.TabIndex = 38;
            this.lblCurrentStatus.Text = "Current status here";
            // 
            // lblTimePlacedHere
            // 
            this.lblTimePlacedHere.AutoSize = true;
            this.lblTimePlacedHere.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePlacedHere.ForeColor = System.Drawing.Color.Black;
            this.lblTimePlacedHere.Location = new System.Drawing.Point(318, 180);
            this.lblTimePlacedHere.Name = "lblTimePlacedHere";
            this.lblTimePlacedHere.Size = new System.Drawing.Size(120, 19);
            this.lblTimePlacedHere.TabIndex = 39;
            this.lblTimePlacedHere.Text = "Time placed here";
            // 
            // lblOrderNumHere
            // 
            this.lblOrderNumHere.AutoSize = true;
            this.lblOrderNumHere.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumHere.ForeColor = System.Drawing.Color.Black;
            this.lblOrderNumHere.Location = new System.Drawing.Point(318, 151);
            this.lblOrderNumHere.Name = "lblOrderNumHere";
            this.lblOrderNumHere.Size = new System.Drawing.Size(113, 19);
            this.lblOrderNumHere.TabIndex = 40;
            this.lblOrderNumHere.Text = "Order num here";
            // 
            // txtItems
            // 
            this.txtItems.Location = new System.Drawing.Point(322, 209);
            this.txtItems.Multiline = true;
            this.txtItems.Name = "txtItems";
            this.txtItems.ReadOnly = true;
            this.txtItems.Size = new System.Drawing.Size(252, 117);
            this.txtItems.TabIndex = 41;
            // 
            // Order_status_and_Order_dispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.lblOrderNumHere);
            this.Controls.Add(this.lblTimePlacedHere);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.lblTimePlaced);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblCurrentStats);
            this.Controls.Add(this.btnMarkServing);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.btnMarkPreparing);
            this.Controls.Add(this.lblOrderDispatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxOrderStatusDispatch);
            this.Controls.Add(this.lblOrderStatusDispatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_status_and_Order_dispatch";
            this.Text = "Order_status_and_Order_dispatch";
            ((System.ComponentModel.ISupportInitialize)(this.picboxOrderStatusDispatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxOrderStatusDispatch;
        private System.Windows.Forms.Label lblOrderStatusDispatch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderDispatch;
        private System.Windows.Forms.Button btnMarkServing;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.Button btnMarkPreparing;
        private System.Windows.Forms.Label lblCurrentStats;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblTimePlaced;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblTimePlacedHere;
        private System.Windows.Forms.Label lblOrderNumHere;
        private System.Windows.Forms.TextBox txtItems;
    }
}
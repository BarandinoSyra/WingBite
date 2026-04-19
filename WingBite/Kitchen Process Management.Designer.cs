namespace WingBite
{
    partial class Kitchen_Process_Management
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
            this.lblKitchenProcessManagement = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.picboxKitchenProcess = new System.Windows.Forms.PictureBox();
            this.panelKitchenProcess = new System.Windows.Forms.Panel();
            this.btnKitchenQueue = new System.Windows.Forms.Button();
            this.btnOrderStatusDispatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKitchenProcess)).BeginInit();
            this.panelKitchenProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKitchenProcessManagement
            // 
            this.lblKitchenProcessManagement.AutoSize = true;
            this.lblKitchenProcessManagement.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenProcessManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblKitchenProcessManagement.Location = new System.Drawing.Point(237, 39);
            this.lblKitchenProcessManagement.Name = "lblKitchenProcessManagement";
            this.lblKitchenProcessManagement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKitchenProcessManagement.Size = new System.Drawing.Size(417, 31);
            this.lblKitchenProcessManagement.TabIndex = 15;
            this.lblKitchenProcessManagement.Text = "KITCHEN PROCESS MANAGEMENT";
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
            // picboxKitchenProcess
            // 
            this.picboxKitchenProcess.Image = global::WingBite.Properties.Resources.kitsen_removebg_preview;
            this.picboxKitchenProcess.Location = new System.Drawing.Point(129, 18);
            this.picboxKitchenProcess.Name = "picboxKitchenProcess";
            this.picboxKitchenProcess.Size = new System.Drawing.Size(102, 74);
            this.picboxKitchenProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxKitchenProcess.TabIndex = 16;
            this.picboxKitchenProcess.TabStop = false;
            // 
            // panelKitchenProcess
            // 
            this.panelKitchenProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.panelKitchenProcess.Controls.Add(this.btnKitchenQueue);
            this.panelKitchenProcess.Controls.Add(this.btnOrderStatusDispatch);
            this.panelKitchenProcess.Location = new System.Drawing.Point(283, 122);
            this.panelKitchenProcess.Name = "panelKitchenProcess";
            this.panelKitchenProcess.Size = new System.Drawing.Size(234, 133);
            this.panelKitchenProcess.TabIndex = 25;
            // 
            // btnKitchenQueue
            // 
            this.btnKitchenQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnKitchenQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitchenQueue.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchenQueue.Location = new System.Drawing.Point(18, 16);
            this.btnKitchenQueue.Name = "btnKitchenQueue";
            this.btnKitchenQueue.Size = new System.Drawing.Size(200, 48);
            this.btnKitchenQueue.TabIndex = 6;
            this.btnKitchenQueue.Text = "KITCHEN QUEUE DISPLAY";
            this.btnKitchenQueue.UseVisualStyleBackColor = false;
            // 
            // btnOrderStatusDispatch
            // 
            this.btnOrderStatusDispatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnOrderStatusDispatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderStatusDispatch.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderStatusDispatch.Location = new System.Drawing.Point(18, 69);
            this.btnOrderStatusDispatch.Name = "btnOrderStatusDispatch";
            this.btnOrderStatusDispatch.Size = new System.Drawing.Size(200, 48);
            this.btnOrderStatusDispatch.TabIndex = 5;
            this.btnOrderStatusDispatch.Text = "ORDER STATUS/ORDER DISPATCH";
            this.btnOrderStatusDispatch.UseVisualStyleBackColor = false;
            // 
            // Kitchen_Process_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panelKitchenProcess);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxKitchenProcess);
            this.Controls.Add(this.lblKitchenProcessManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kitchen_Process_Management";
            this.Text = "Kitchen_Process_Management";
            ((System.ComponentModel.ISupportInitialize)(this.picboxKitchenProcess)).EndInit();
            this.panelKitchenProcess.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxKitchenProcess;
        private System.Windows.Forms.Label lblKitchenProcessManagement;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelKitchenProcess;
        private System.Windows.Forms.Button btnKitchenQueue;
        private System.Windows.Forms.Button btnOrderStatusDispatch;
    }
}
namespace WingBite
{
    partial class Login
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
            this.panelWallpaper = new System.Windows.Forms.Panel();
            this.lblWingBitePOS = new System.Windows.Forms.Label();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.picboxWallpaper = new System.Windows.Forms.PictureBox();
            this.panelWallpaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWallpaper
            // 
            this.panelWallpaper.Controls.Add(this.picboxWallpaper);
            this.panelWallpaper.Location = new System.Drawing.Point(360, 0);
            this.panelWallpaper.Name = "panelWallpaper";
            this.panelWallpaper.Size = new System.Drawing.Size(441, 551);
            this.panelWallpaper.TabIndex = 0;
            // 
            // lblWingBitePOS
            // 
            this.lblWingBitePOS.AutoSize = true;
            this.lblWingBitePOS.Font = new System.Drawing.Font("Stencil", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWingBitePOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblWingBitePOS.Location = new System.Drawing.Point(60, 70);
            this.lblWingBitePOS.Name = "lblWingBitePOS";
            this.lblWingBitePOS.Size = new System.Drawing.Size(228, 37);
            this.lblWingBitePOS.TabIndex = 2;
            this.lblWingBitePOS.Text = "WingBite POS";
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblUserLogin.Location = new System.Drawing.Point(102, 246);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(135, 24);
            this.lblUserLogin.TabIndex = 3;
            this.lblUserLogin.Text = "- User Login -";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(48, 291);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 18);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username*";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(48, 355);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 18);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password*";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcc.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(50, 433);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(120, 36);
            this.btnCreateAcc.TabIndex = 8;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(176, 433);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 36);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(51, 312);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(237, 24);
            this.txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(51, 376);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 24);
            this.txtPassword.TabIndex = 11;
            // 
            // picboxUser
            // 
            this.picboxUser.Image = global::WingBite.Properties.Resources.user__1_;
            this.picboxUser.Location = new System.Drawing.Point(106, 117);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(127, 110);
            this.picboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxUser.TabIndex = 1;
            this.picboxUser.TabStop = false;
            // 
            // picboxWallpaper
            // 
            this.picboxWallpaper.Image = global::WingBite.Properties.Resources._123456_removebg_preview;
            this.picboxWallpaper.Location = new System.Drawing.Point(1, 94);
            this.picboxWallpaper.Name = "picboxWallpaper";
            this.picboxWallpaper.Size = new System.Drawing.Size(440, 371);
            this.picboxWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxWallpaper.TabIndex = 0;
            this.picboxWallpaper.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.lblWingBitePOS);
            this.Controls.Add(this.picboxUser);
            this.Controls.Add(this.panelWallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.panelWallpaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxWallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWallpaper;
        private System.Windows.Forms.PictureBox picboxWallpaper;
        private System.Windows.Forms.PictureBox picboxUser;
        private System.Windows.Forms.Label lblWingBitePOS;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
    }
}


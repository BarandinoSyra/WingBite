namespace WingBite
{
    partial class User_Management
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
            this.lblUserManagement = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.picboxUserManagement = new System.Windows.Forms.PictureBox();
            this.btnAddNewUSer = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblConfirmStatus = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPasword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblUserList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUserManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserManagement
            // 
            this.lblUserManagement.AutoSize = true;
            this.lblUserManagement.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblUserManagement.Location = new System.Drawing.Point(319, 44);
            this.lblUserManagement.Name = "lblUserManagement";
            this.lblUserManagement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserManagement.Size = new System.Drawing.Size(254, 31);
            this.lblUserManagement.TabIndex = 19;
            this.lblUserManagement.Text = "USER MANAGEMENT";
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
            // picboxUserManagement
            // 
            this.picboxUserManagement.Image = global::WingBite.Properties.Resources.user__1_2;
            this.picboxUserManagement.Location = new System.Drawing.Point(211, 23);
            this.picboxUserManagement.Name = "picboxUserManagement";
            this.picboxUserManagement.Size = new System.Drawing.Size(102, 74);
            this.picboxUserManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxUserManagement.TabIndex = 20;
            this.picboxUserManagement.TabStop = false;
            // 
            // btnAddNewUSer
            // 
            this.btnAddNewUSer.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddNewUSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUSer.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUSer.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewUSer.Location = new System.Drawing.Point(144, 457);
            this.btnAddNewUSer.Name = "btnAddNewUSer";
            this.btnAddNewUSer.Size = new System.Drawing.Size(120, 30);
            this.btnAddNewUSer.TabIndex = 27;
            this.btnAddNewUSer.Text = "ADD NEW USER";
            this.btnAddNewUSer.UseVisualStyleBackColor = false;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.BackColor = System.Drawing.Color.Green;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshList.Location = new System.Drawing.Point(73, 113);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(120, 27);
            this.btnRefreshList.TabIndex = 28;
            this.btnRefreshList.Text = "REFRESH LIST";
            this.btnRefreshList.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(522, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Location = new System.Drawing.Point(396, 457);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteUser.TabIndex = 30;
            this.btnDeleteUser.Text = "DELETE USER";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Tomato;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Location = new System.Drawing.Point(270, 457);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(120, 30);
            this.btnUpdateUser.TabIndex = 31;
            this.btnUpdateUser.Text = "UPDATE USER";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(73, 167);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(625, 160);
            this.dgvUsers.TabIndex = 32;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(70, 367);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 18);
            this.lblUsername.TabIndex = 33;
            this.lblUsername.Text = "Username:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(383, 415);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 18);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "Status:";
            // 
            // lblConfirmStatus
            // 
            this.lblConfirmStatus.AutoSize = true;
            this.lblConfirmStatus.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmStatus.Location = new System.Drawing.Point(383, 391);
            this.lblConfirmStatus.Name = "lblConfirmStatus";
            this.lblConfirmStatus.Size = new System.Drawing.Size(122, 18);
            this.lblConfirmStatus.TabIndex = 35;
            this.lblConfirmStatus.Text = "Confirm Password:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(383, 367);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(74, 18);
            this.lblFullName.TabIndex = 36;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblUserDetails.Location = new System.Drawing.Point(70, 338);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(334, 18);
            this.lblUserDetails.TabIndex = 37;
            this.lblUserDetails.Text = "USER DETAILS ── Fill this section to Add or Edit User";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(70, 415);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(38, 18);
            this.lblRole.TabIndex = 38;
            this.lblRole.Text = "Role:";
            // 
            // lblPasword
            // 
            this.lblPasword.AutoSize = true;
            this.lblPasword.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasword.Location = new System.Drawing.Point(70, 391);
            this.lblPasword.Name = "lblPasword";
            this.lblPasword.Size = new System.Drawing.Size(69, 18);
            this.lblPasword.TabIndex = 39;
            this.lblPasword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(149, 367);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(212, 20);
            this.txtUsername.TabIndex = 40;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(511, 363);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(212, 20);
            this.txtFullName.TabIndex = 41;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(511, 389);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(212, 20);
            this.txtConfirmPassword.TabIndex = 42;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 391);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(212, 20);
            this.txtPassword.TabIndex = 43;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(511, 415);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(212, 21);
            this.cmbStatus.TabIndex = 44;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(149, 417);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(212, 21);
            this.cmbRole.TabIndex = 45;
            // 
            // lblUserList
            // 
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblUserList.Location = new System.Drawing.Point(70, 146);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(64, 18);
            this.lblUserList.TabIndex = 46;
            this.lblUserList.Text = "User List:";
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblUserList);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPasword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUserDetails);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblConfirmStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.btnAddNewUSer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxUserManagement);
            this.Controls.Add(this.lblUserManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Management";
            this.Text = "User_Management";
            ((System.ComponentModel.ISupportInitialize)(this.picboxUserManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxUserManagement;
        private System.Windows.Forms.Label lblUserManagement;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNewUSer;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblConfirmStatus;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPasword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblUserList;
    }
}
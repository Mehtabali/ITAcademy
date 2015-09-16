namespace ITAcademy.WinForms
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
            this.RbtnAdmin = new System.Windows.Forms.RadioButton();
            this.RbtnOtherUsers = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpUser.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // RbtnAdmin
            // 
            this.RbtnAdmin.AutoSize = true;
            this.RbtnAdmin.Location = new System.Drawing.Point(6, 19);
            this.RbtnAdmin.Name = "RbtnAdmin";
            this.RbtnAdmin.Size = new System.Drawing.Size(54, 17);
            this.RbtnAdmin.TabIndex = 0;
            this.RbtnAdmin.TabStop = true;
            this.RbtnAdmin.Text = "Admin";
            this.RbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // RbtnOtherUsers
            // 
            this.RbtnOtherUsers.AutoSize = true;
            this.RbtnOtherUsers.Location = new System.Drawing.Point(140, 19);
            this.RbtnOtherUsers.Name = "RbtnOtherUsers";
            this.RbtnOtherUsers.Size = new System.Drawing.Size(81, 17);
            this.RbtnOtherUsers.TabIndex = 1;
            this.RbtnOtherUsers.TabStop = true;
            this.RbtnOtherUsers.Text = "Other Users";
            this.RbtnOtherUsers.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(197, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.RbtnOtherUsers);
            this.grpUser.Controls.Add(this.RbtnAdmin);
            this.grpUser.Location = new System.Drawing.Point(12, 12);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(260, 50);
            this.grpUser.TabIndex = 3;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Switch User";
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.lblUserName);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtUserName);
            this.grpLogin.Location = new System.Drawing.Point(18, 68);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(254, 153);
            this.grpLogin.TabIndex = 4;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(48, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Pasword";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(83, 15);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(155, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // Login_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login_WinForm";
            this.Text = "Login_WinForm";
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RbtnAdmin;
        private System.Windows.Forms.RadioButton RbtnOtherUsers;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
    }
}
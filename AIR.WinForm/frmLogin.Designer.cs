namespace AIR.WinForm
{
    partial class frmLogin
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
            this.rdbtnUser = new System.Windows.Forms.RadioButton();
            this.rdbtnAdmin = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtbxUserName = new System.Windows.Forms.TextBox();
            this.txtbxUserPassword = new System.Windows.Forms.TextBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnUser
            // 
            this.rdbtnUser.AutoSize = true;
            this.rdbtnUser.Location = new System.Drawing.Point(118, 12);
            this.rdbtnUser.Name = "rdbtnUser";
            this.rdbtnUser.Size = new System.Drawing.Size(47, 17);
            this.rdbtnUser.TabIndex = 0;
            this.rdbtnUser.TabStop = true;
            this.rdbtnUser.Text = "User";
            this.rdbtnUser.UseVisualStyleBackColor = true;
            // 
            // rdbtnAdmin
            // 
            this.rdbtnAdmin.AutoSize = true;
            this.rdbtnAdmin.Location = new System.Drawing.Point(209, 12);
            this.rdbtnAdmin.Name = "rdbtnAdmin";
            this.rdbtnAdmin.Size = new System.Drawing.Size(85, 17);
            this.rdbtnAdmin.TabIndex = 1;
            this.rdbtnAdmin.TabStop = true;
            this.rdbtnAdmin.Text = "Administrator";
            this.rdbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(136, 97);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 33);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtbxUserName
            // 
            this.txtbxUserName.Location = new System.Drawing.Point(136, 45);
            this.txtbxUserName.Name = "txtbxUserName";
            this.txtbxUserName.Size = new System.Drawing.Size(140, 20);
            this.txtbxUserName.TabIndex = 3;
            this.txtbxUserName.Text = "Enter User Name";
            // 
            // txtbxUserPassword
            // 
            this.txtbxUserPassword.Location = new System.Drawing.Point(136, 71);
            this.txtbxUserPassword.Name = "txtbxUserPassword";
            this.txtbxUserPassword.Size = new System.Drawing.Size(140, 20);
            this.txtbxUserPassword.TabIndex = 4;
            this.txtbxUserPassword.Text = "Enter Password";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(135, 136);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(143, 27);
            this.btnNewUser.TabIndex = 5;
            this.btnNewUser.Text = "New Admin/User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 168);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.txtbxUserPassword);
            this.Controls.Add(this.txtbxUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rdbtnAdmin);
            this.Controls.Add(this.rdbtnUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnUser;
        private System.Windows.Forms.RadioButton rdbtnAdmin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtbxUserName;
        private System.Windows.Forms.TextBox txtbxUserPassword;
        private System.Windows.Forms.Button btnNewUser;
    }
}
namespace AIR.WinForm
{
    partial class frmNewUser
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserName = new System.Windows.Forms.TextBox();
            this.btnUserPassword = new System.Windows.Forms.TextBox();
            this.txtbxUserPassConf = new System.Windows.Forms.TextBox();
            this.rdbtnUser = new System.Windows.Forms.RadioButton();
            this.rdbtnAdmin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 179);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 45);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaco", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "New User/System Admin";
            // 
            // btnUserName
            // 
            this.btnUserName.Location = new System.Drawing.Point(152, 102);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(141, 20);
            this.btnUserName.TabIndex = 3;
            // 
            // btnUserPassword
            // 
            this.btnUserPassword.Location = new System.Drawing.Point(152, 128);
            this.btnUserPassword.Name = "btnUserPassword";
            this.btnUserPassword.Size = new System.Drawing.Size(141, 20);
            this.btnUserPassword.TabIndex = 4;
            // 
            // txtbxUserPassConf
            // 
            this.txtbxUserPassConf.Location = new System.Drawing.Point(152, 154);
            this.txtbxUserPassConf.Name = "txtbxUserPassConf";
            this.txtbxUserPassConf.Size = new System.Drawing.Size(141, 20);
            this.txtbxUserPassConf.TabIndex = 5;
            // 
            // rdbtnUser
            // 
            this.rdbtnUser.AutoSize = true;
            this.rdbtnUser.Location = new System.Drawing.Point(113, 78);
            this.rdbtnUser.Name = "rdbtnUser";
            this.rdbtnUser.Size = new System.Drawing.Size(47, 17);
            this.rdbtnUser.TabIndex = 6;
            this.rdbtnUser.TabStop = true;
            this.rdbtnUser.Text = "User";
            this.rdbtnUser.UseVisualStyleBackColor = true;
            // 
            // rdbtnAdmin
            // 
            this.rdbtnAdmin.AutoSize = true;
            this.rdbtnAdmin.Location = new System.Drawing.Point(204, 79);
            this.rdbtnAdmin.Name = "rdbtnAdmin";
            this.rdbtnAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdbtnAdmin.TabIndex = 7;
            this.rdbtnAdmin.TabStop = true;
            this.rdbtnAdmin.Text = "Admin";
            this.rdbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm Password";
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 237);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbtnAdmin);
            this.Controls.Add(this.rdbtnUser);
            this.Controls.Add(this.txtbxUserPassConf);
            this.Controls.Add(this.btnUserPassword);
            this.Controls.Add(this.btnUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewUser";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnUserName;
        private System.Windows.Forms.TextBox btnUserPassword;
        private System.Windows.Forms.TextBox txtbxUserPassConf;
        private System.Windows.Forms.RadioButton rdbtnUser;
        private System.Windows.Forms.RadioButton rdbtnAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
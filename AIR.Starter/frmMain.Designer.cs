namespace AIR.Starter
{
    partial class frmMain
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
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbxWCFService = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbxClientAdmin = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbxClientUser = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(6, 52);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(111, 41);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start Service";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(6, 22);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(111, 64);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Launch Admin Client Instance";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(6, 27);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(111, 64);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "Launch Consumer Client Instance";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Font = new System.Drawing.Font("Monaco", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceStatus.Location = new System.Drawing.Point(4, 6);
            this.lblServiceStatus.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(134, 16);
            this.lblServiceStatus.TabIndex = 3;
            this.lblServiceStatus.Text = "Service Status";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtbxWCFService);
            this.panel1.Controls.Add(this.btnStartStop);
            this.panel1.Controls.Add(this.lblServiceStatus);
            this.panel1.Location = new System.Drawing.Point(11, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 117);
            this.panel1.TabIndex = 4;
            // 
            // txtbxWCFService
            // 
            this.txtbxWCFService.Location = new System.Drawing.Point(180, 3);
            this.txtbxWCFService.Multiline = true;
            this.txtbxWCFService.Name = "txtbxWCFService";
            this.txtbxWCFService.ReadOnly = true;
            this.txtbxWCFService.Size = new System.Drawing.Size(292, 109);
            this.txtbxWCFService.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtbxClientAdmin);
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Location = new System.Drawing.Point(12, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 111);
            this.panel2.TabIndex = 5;
            // 
            // txtbxClientAdmin
            // 
            this.txtbxClientAdmin.Location = new System.Drawing.Point(179, 5);
            this.txtbxClientAdmin.Multiline = true;
            this.txtbxClientAdmin.Name = "txtbxClientAdmin";
            this.txtbxClientAdmin.ReadOnly = true;
            this.txtbxClientAdmin.Size = new System.Drawing.Size(292, 101);
            this.txtbxClientAdmin.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtbxClientUser);
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Location = new System.Drawing.Point(12, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 120);
            this.panel3.TabIndex = 6;
            // 
            // txtbxClientUser
            // 
            this.txtbxClientUser.Location = new System.Drawing.Point(179, 3);
            this.txtbxClientUser.Multiline = true;
            this.txtbxClientUser.Name = "txtbxClientUser";
            this.txtbxClientUser.ReadOnly = true;
            this.txtbxClientUser.Size = new System.Drawing.Size(292, 112);
            this.txtbxClientUser.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(151, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 19);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Starter application";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 46);
            this.label5.MaximumSize = new System.Drawing.Size(450, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(446, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "This is the starter application. Please run this with administrator previlege for" +
    " the WCF service to be started below. This application is used to invoke further" +
    " modules or instance as defined below.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Intel Reservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxWCFService;
        private System.Windows.Forms.TextBox txtbxClientAdmin;
        private System.Windows.Forms.TextBox txtbxClientUser;
    }
}


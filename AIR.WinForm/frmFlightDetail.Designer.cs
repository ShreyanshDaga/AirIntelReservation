namespace AIR.WinForm
{
    partial class frmFlightDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.lblFlightTo = new System.Windows.Forms.Label();
            this.lblFlightFrom = new System.Windows.Forms.Label();
            this.lblFlightDep = new System.Windows.Forms.Label();
            this.lblFlightArr = new System.Windows.Forms.Label();
            this.lblAircraftType = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Details";
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Location = new System.Drawing.Point(83, 55);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(35, 13);
            this.lblFlightNumber.TabIndex = 1;
            this.lblFlightNumber.Text = "label2";
            // 
            // lblFlightTo
            // 
            this.lblFlightTo.AutoSize = true;
            this.lblFlightTo.Location = new System.Drawing.Point(83, 85);
            this.lblFlightTo.Name = "lblFlightTo";
            this.lblFlightTo.Size = new System.Drawing.Size(35, 13);
            this.lblFlightTo.TabIndex = 2;
            this.lblFlightTo.Text = "label3";
            // 
            // lblFlightFrom
            // 
            this.lblFlightFrom.AutoSize = true;
            this.lblFlightFrom.Location = new System.Drawing.Point(212, 85);
            this.lblFlightFrom.Name = "lblFlightFrom";
            this.lblFlightFrom.Size = new System.Drawing.Size(35, 13);
            this.lblFlightFrom.TabIndex = 3;
            this.lblFlightFrom.Text = "label4";
            // 
            // lblFlightDep
            // 
            this.lblFlightDep.AutoSize = true;
            this.lblFlightDep.Location = new System.Drawing.Point(83, 115);
            this.lblFlightDep.Name = "lblFlightDep";
            this.lblFlightDep.Size = new System.Drawing.Size(35, 13);
            this.lblFlightDep.TabIndex = 4;
            this.lblFlightDep.Text = "label5";
            // 
            // lblFlightArr
            // 
            this.lblFlightArr.AutoSize = true;
            this.lblFlightArr.Location = new System.Drawing.Point(212, 115);
            this.lblFlightArr.Name = "lblFlightArr";
            this.lblFlightArr.Size = new System.Drawing.Size(35, 13);
            this.lblFlightArr.TabIndex = 5;
            this.lblFlightArr.Text = "label6";
            // 
            // lblAircraftType
            // 
            this.lblAircraftType.AutoSize = true;
            this.lblAircraftType.Location = new System.Drawing.Point(83, 145);
            this.lblAircraftType.Name = "lblAircraftType";
            this.lblAircraftType.Size = new System.Drawing.Size(35, 13);
            this.lblAircraftType.TabIndex = 6;
            this.lblAircraftType.Text = "label7";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(286, 167);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmFlightDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(373, 202);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAircraftType);
            this.Controls.Add(this.lblFlightArr);
            this.Controls.Add(this.lblFlightDep);
            this.Controls.Add(this.lblFlightFrom);
            this.Controls.Add(this.lblFlightTo);
            this.Controls.Add(this.lblFlightNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFlightDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label lblFlightTo;
        private System.Windows.Forms.Label lblFlightFrom;
        private System.Windows.Forms.Label lblFlightDep;
        private System.Windows.Forms.Label lblFlightArr;
        private System.Windows.Forms.Label lblAircraftType;
        private System.Windows.Forms.Button btnBack;
    }
}
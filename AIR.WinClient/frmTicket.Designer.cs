namespace AIR.WinClient
{
    partial class frmTicket
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lblDepartire = new System.Windows.Forms.Label();
            this.lblBoarding = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFlight = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFare = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblFare);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblSeat);
            this.panel1.Controls.Add(this.lblDepartire);
            this.panel1.Controls.Add(this.lblBoarding);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.lblFlight);
            this.panel1.Controls.Add(this.lblTicket);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 156);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name: ";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(161, 59);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(48, 13);
            this.lblSeat.TabIndex = 10;
            this.lblSeat.Text = "Seat #:  ";
            // 
            // lblDepartire
            // 
            this.lblDepartire.AutoSize = true;
            this.lblDepartire.Location = new System.Drawing.Point(33, 134);
            this.lblDepartire.Name = "lblDepartire";
            this.lblDepartire.Size = new System.Drawing.Size(86, 13);
            this.lblDepartire.TabIndex = 7;
            this.lblDepartire.Text = "Departure Time: ";
            // 
            // lblBoarding
            // 
            this.lblBoarding.AutoSize = true;
            this.lblBoarding.Location = new System.Drawing.Point(33, 109);
            this.lblBoarding.Name = "lblBoarding";
            this.lblBoarding.Size = new System.Drawing.Size(81, 13);
            this.lblBoarding.TabIndex = 6;
            this.lblBoarding.Text = "Boarding Time: ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(307, 84);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To: ";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(161, 84);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 13);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From: ";
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Location = new System.Drawing.Point(33, 84);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(51, 13);
            this.lblFlight.TabIndex = 3;
            this.lblFlight.Text = "Flight #:  ";
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(33, 59);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(53, 13);
            this.lblTicket.TabIndex = 2;
            this.lblTicket.Text = "Ticket #: ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(377, 127);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 26);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaco", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Ticket";
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.lblFare.Location = new System.Drawing.Point(307, 59);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(34, 13);
            this.lblFare.TabIndex = 12;
            this.lblFare.Text = "Fare: ";
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(493, 180);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Ticket";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblDepartire;
        private System.Windows.Forms.Label lblBoarding;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFare;
    }
}
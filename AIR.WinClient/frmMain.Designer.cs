namespace AIR.WinClient
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
            this.grbbxBooking = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefreshFlights = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.grpbxFlightDetails = new System.Windows.Forms.GroupBox();
            this.txtbxSeatMap = new System.Windows.Forms.TextBox();
            this.btnRefreshSeatMap = new System.Windows.Forms.Button();
            this.lblAircraftType = new System.Windows.Forms.Label();
            this.pnlFlightInformation = new System.Windows.Forms.Panel();
            this.pnlUserInformation = new System.Windows.Forms.Panel();
            this.grbbxBooking.SuspendLayout();
            this.grpbxFlightDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbbxBooking
            // 
            this.grbbxBooking.Controls.Add(this.btnBookFlight);
            this.grbbxBooking.Controls.Add(this.listView1);
            this.grbbxBooking.Controls.Add(this.btnRefreshFlights);
            this.grbbxBooking.Controls.Add(this.label1);
            this.grbbxBooking.Location = new System.Drawing.Point(12, 31);
            this.grbbxBooking.Name = "grbbxBooking";
            this.grbbxBooking.Size = new System.Drawing.Size(408, 524);
            this.grbbxBooking.TabIndex = 0;
            this.grbbxBooking.TabStop = false;
            this.grbbxBooking.Text = "Book Tickets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Flights";
            // 
            // btnRefreshFlights
            // 
            this.btnRefreshFlights.Location = new System.Drawing.Point(6, 448);
            this.btnRefreshFlights.Name = "btnRefreshFlights";
            this.btnRefreshFlights.Size = new System.Drawing.Size(93, 59);
            this.btnRefreshFlights.TabIndex = 3;
            this.btnRefreshFlights.Text = "Refresh List";
            this.btnRefreshFlights.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 47);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(396, 395);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Flight #";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "From";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "To";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 64;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Depature";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Arrival";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 96;
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.Location = new System.Drawing.Point(309, 448);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(93, 59);
            this.btnBookFlight.TabIndex = 5;
            this.btnBookFlight.Text = "Book Flight";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            // 
            // grpbxFlightDetails
            // 
            this.grpbxFlightDetails.Controls.Add(this.pnlUserInformation);
            this.grpbxFlightDetails.Controls.Add(this.pnlFlightInformation);
            this.grpbxFlightDetails.Controls.Add(this.lblAircraftType);
            this.grpbxFlightDetails.Controls.Add(this.btnRefreshSeatMap);
            this.grpbxFlightDetails.Controls.Add(this.txtbxSeatMap);
            this.grpbxFlightDetails.Location = new System.Drawing.Point(426, 31);
            this.grpbxFlightDetails.Name = "grpbxFlightDetails";
            this.grpbxFlightDetails.Size = new System.Drawing.Size(570, 524);
            this.grpbxFlightDetails.TabIndex = 1;
            this.grpbxFlightDetails.TabStop = false;
            this.grpbxFlightDetails.Text = "Flight Details";
            // 
            // txtbxSeatMap
            // 
            this.txtbxSeatMap.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSeatMap.Location = new System.Drawing.Point(230, 47);
            this.txtbxSeatMap.Multiline = true;
            this.txtbxSeatMap.Name = "txtbxSeatMap";
            this.txtbxSeatMap.ReadOnly = true;
            this.txtbxSeatMap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxSeatMap.Size = new System.Drawing.Size(334, 395);
            this.txtbxSeatMap.TabIndex = 0;
            this.txtbxSeatMap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRefreshSeatMap
            // 
            this.btnRefreshSeatMap.Location = new System.Drawing.Point(337, 448);
            this.btnRefreshSeatMap.Name = "btnRefreshSeatMap";
            this.btnRefreshSeatMap.Size = new System.Drawing.Size(121, 23);
            this.btnRefreshSeatMap.TabIndex = 1;
            this.btnRefreshSeatMap.Text = "Refresh Seat Map";
            this.btnRefreshSeatMap.UseVisualStyleBackColor = true;
            // 
            // lblAircraftType
            // 
            this.lblAircraftType.AutoSize = true;
            this.lblAircraftType.Location = new System.Drawing.Point(334, 29);
            this.lblAircraftType.Name = "lblAircraftType";
            this.lblAircraftType.Size = new System.Drawing.Size(73, 13);
            this.lblAircraftType.TabIndex = 2;
            this.lblAircraftType.Text = "Aircraft Type: ";
            // 
            // pnlFlightInformation
            // 
            this.pnlFlightInformation.Location = new System.Drawing.Point(6, 47);
            this.pnlFlightInformation.Name = "pnlFlightInformation";
            this.pnlFlightInformation.Size = new System.Drawing.Size(218, 116);
            this.pnlFlightInformation.TabIndex = 3;
            // 
            // pnlUserInformation
            // 
            this.pnlUserInformation.Location = new System.Drawing.Point(6, 169);
            this.pnlUserInformation.Name = "pnlUserInformation";
            this.pnlUserInformation.Size = new System.Drawing.Size(218, 273);
            this.pnlUserInformation.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 567);
            this.Controls.Add(this.grpbxFlightDetails);
            this.Controls.Add(this.grbbxBooking);
            this.Name = "frmMain";
            this.Text = "AIR Client";
            this.grbbxBooking.ResumeLayout(false);
            this.grbbxBooking.PerformLayout();
            this.grpbxFlightDetails.ResumeLayout(false);
            this.grpbxFlightDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbbxBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshFlights;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.GroupBox grpbxFlightDetails;
        private System.Windows.Forms.TextBox txtbxSeatMap;
        private System.Windows.Forms.Button btnRefreshSeatMap;
        private System.Windows.Forms.Label lblAircraftType;
        private System.Windows.Forms.Panel pnlFlightInformation;
        private System.Windows.Forms.Panel pnlUserInformation;
    }
}


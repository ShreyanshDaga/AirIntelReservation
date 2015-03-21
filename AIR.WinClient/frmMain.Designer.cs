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
            this.lblSelFlightNumbe = new System.Windows.Forms.Label();
            this.lblSelFlightFrom = new System.Windows.Forms.Label();
            this.lblSelFlightTo = new System.Windows.Forms.Label();
            this.lblSelFlightDep = new System.Windows.Forms.Label();
            this.lblSelFlightArr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnCheckAvail = new System.Windows.Forms.Button();
            this.grbbxBooking.SuspendLayout();
            this.grpbxFlightDetails.SuspendLayout();
            this.pnlFlightInformation.SuspendLayout();
            this.pnlUserInformation.SuspendLayout();
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
            this.btnBookFlight.Text = "Next";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // grpbxFlightDetails
            // 
            this.grpbxFlightDetails.Controls.Add(this.pnlUserInformation);
            this.grpbxFlightDetails.Controls.Add(this.pnlFlightInformation);
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
            this.txtbxSeatMap.Location = new System.Drawing.Point(279, 25);
            this.txtbxSeatMap.Multiline = true;
            this.txtbxSeatMap.Name = "txtbxSeatMap";
            this.txtbxSeatMap.ReadOnly = true;
            this.txtbxSeatMap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxSeatMap.Size = new System.Drawing.Size(274, 326);
            this.txtbxSeatMap.TabIndex = 0;
            this.txtbxSeatMap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRefreshSeatMap
            // 
            this.btnRefreshSeatMap.Location = new System.Drawing.Point(356, 357);
            this.btnRefreshSeatMap.Name = "btnRefreshSeatMap";
            this.btnRefreshSeatMap.Size = new System.Drawing.Size(121, 23);
            this.btnRefreshSeatMap.TabIndex = 1;
            this.btnRefreshSeatMap.Text = "Refresh Seat Map";
            this.btnRefreshSeatMap.UseVisualStyleBackColor = true;
            // 
            // lblAircraftType
            // 
            this.lblAircraftType.AutoSize = true;
            this.lblAircraftType.Location = new System.Drawing.Point(353, 9);
            this.lblAircraftType.Name = "lblAircraftType";
            this.lblAircraftType.Size = new System.Drawing.Size(73, 13);
            this.lblAircraftType.TabIndex = 2;
            this.lblAircraftType.Text = "Aircraft Type: ";
            // 
            // pnlFlightInformation
            // 
            this.pnlFlightInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFlightInformation.Controls.Add(this.lblSelFlightArr);
            this.pnlFlightInformation.Controls.Add(this.lblSelFlightDep);
            this.pnlFlightInformation.Controls.Add(this.lblSelFlightTo);
            this.pnlFlightInformation.Controls.Add(this.lblSelFlightFrom);
            this.pnlFlightInformation.Controls.Add(this.lblSelFlightNumbe);
            this.pnlFlightInformation.Location = new System.Drawing.Point(6, 47);
            this.pnlFlightInformation.Name = "pnlFlightInformation";
            this.pnlFlightInformation.Size = new System.Drawing.Size(558, 80);
            this.pnlFlightInformation.TabIndex = 3;
            // 
            // pnlUserInformation
            // 
            this.pnlUserInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserInformation.Controls.Add(this.btnCheckAvail);
            this.pnlUserInformation.Controls.Add(this.textBox8);
            this.pnlUserInformation.Controls.Add(this.btnConfirm);
            this.pnlUserInformation.Controls.Add(this.textBox7);
            this.pnlUserInformation.Controls.Add(this.btnRefreshSeatMap);
            this.pnlUserInformation.Controls.Add(this.lblAircraftType);
            this.pnlUserInformation.Controls.Add(this.textBox6);
            this.pnlUserInformation.Controls.Add(this.radioButton3);
            this.pnlUserInformation.Controls.Add(this.txtbxSeatMap);
            this.pnlUserInformation.Controls.Add(this.radioButton2);
            this.pnlUserInformation.Controls.Add(this.radioButton1);
            this.pnlUserInformation.Controls.Add(this.textBox5);
            this.pnlUserInformation.Controls.Add(this.textBox4);
            this.pnlUserInformation.Controls.Add(this.textBox3);
            this.pnlUserInformation.Controls.Add(this.textBox2);
            this.pnlUserInformation.Controls.Add(this.textBox1);
            this.pnlUserInformation.Location = new System.Drawing.Point(6, 133);
            this.pnlUserInformation.Name = "pnlUserInformation";
            this.pnlUserInformation.Size = new System.Drawing.Size(558, 385);
            this.pnlUserInformation.TabIndex = 4;
            // 
            // lblSelFlightNumbe
            // 
            this.lblSelFlightNumbe.AutoSize = true;
            this.lblSelFlightNumbe.Location = new System.Drawing.Point(15, 13);
            this.lblSelFlightNumbe.Name = "lblSelFlightNumbe";
            this.lblSelFlightNumbe.Size = new System.Drawing.Size(35, 13);
            this.lblSelFlightNumbe.TabIndex = 0;
            this.lblSelFlightNumbe.Text = "label2";
            // 
            // lblSelFlightFrom
            // 
            this.lblSelFlightFrom.AutoSize = true;
            this.lblSelFlightFrom.Location = new System.Drawing.Point(15, 34);
            this.lblSelFlightFrom.Name = "lblSelFlightFrom";
            this.lblSelFlightFrom.Size = new System.Drawing.Size(35, 13);
            this.lblSelFlightFrom.TabIndex = 1;
            this.lblSelFlightFrom.Text = "label3";
            // 
            // lblSelFlightTo
            // 
            this.lblSelFlightTo.AutoSize = true;
            this.lblSelFlightTo.Location = new System.Drawing.Point(238, 34);
            this.lblSelFlightTo.Name = "lblSelFlightTo";
            this.lblSelFlightTo.Size = new System.Drawing.Size(35, 13);
            this.lblSelFlightTo.TabIndex = 2;
            this.lblSelFlightTo.Text = "label4";
            // 
            // lblSelFlightDep
            // 
            this.lblSelFlightDep.AutoSize = true;
            this.lblSelFlightDep.Location = new System.Drawing.Point(15, 55);
            this.lblSelFlightDep.Name = "lblSelFlightDep";
            this.lblSelFlightDep.Size = new System.Drawing.Size(35, 13);
            this.lblSelFlightDep.TabIndex = 3;
            this.lblSelFlightDep.Text = "label5";
            // 
            // lblSelFlightArr
            // 
            this.lblSelFlightArr.AutoSize = true;
            this.lblSelFlightArr.Location = new System.Drawing.Point(238, 55);
            this.lblSelFlightArr.Name = "lblSelFlightArr";
            this.lblSelFlightArr.Size = new System.Drawing.Size(35, 13);
            this.lblSelFlightArr.TabIndex = 4;
            this.lblSelFlightArr.Text = "label6";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(133, 20);
            this.textBox5.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 245);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 268);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 291);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(215, 245);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(49, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(160, 245);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(49, 20);
            this.textBox7.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(160, 340);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 33);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Book ";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(18, 347);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(136, 20);
            this.textBox8.TabIndex = 11;
            // 
            // btnCheckAvail
            // 
            this.btnCheckAvail.Location = new System.Drawing.Point(160, 285);
            this.btnCheckAvail.Name = "btnCheckAvail";
            this.btnCheckAvail.Size = new System.Drawing.Size(104, 32);
            this.btnCheckAvail.TabIndex = 12;
            this.btnCheckAvail.Text = "Check Availabilty";
            this.btnCheckAvail.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 567);
            this.Controls.Add(this.grpbxFlightDetails);
            this.Controls.Add(this.grbbxBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "AIR Client";
            this.grbbxBooking.ResumeLayout(false);
            this.grbbxBooking.PerformLayout();
            this.grpbxFlightDetails.ResumeLayout(false);
            this.pnlFlightInformation.ResumeLayout(false);
            this.pnlFlightInformation.PerformLayout();
            this.pnlUserInformation.ResumeLayout(false);
            this.pnlUserInformation.PerformLayout();
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
        private System.Windows.Forms.Label lblSelFlightArr;
        private System.Windows.Forms.Label lblSelFlightDep;
        private System.Windows.Forms.Label lblSelFlightTo;
        private System.Windows.Forms.Label lblSelFlightFrom;
        private System.Windows.Forms.Label lblSelFlightNumbe;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnCheckAvail;
    }
}


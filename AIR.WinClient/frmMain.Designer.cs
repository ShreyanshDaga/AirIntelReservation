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
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.lstvwFlights = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshFlights = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxFlightDetails = new System.Windows.Forms.GroupBox();
            this.pnlUserInformation = new System.Windows.Forms.Panel();
            this.cmbbxCols = new System.Windows.Forms.ComboBox();
            this.cmbbxRows = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckAvail = new System.Windows.Forms.Button();
            this.txtbxTotalFare = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRefreshSeatMap = new System.Windows.Forms.Button();
            this.lblAircraftType = new System.Windows.Forms.Label();
            this.rdbtnEcon = new System.Windows.Forms.RadioButton();
            this.txtbxSeatMap = new System.Windows.Forms.TextBox();
            this.rdbtnFirst = new System.Windows.Forms.RadioButton();
            this.rdbtnBusiness = new System.Windows.Forms.RadioButton();
            this.txtbxUserPassport = new System.Windows.Forms.TextBox();
            this.txtbxUserAge = new System.Windows.Forms.TextBox();
            this.txtbxUserEmail = new System.Windows.Forms.TextBox();
            this.txtbxUserName = new System.Windows.Forms.TextBox();
            this.pnlFlightInformation = new System.Windows.Forms.Panel();
            this.lblSelFlightArr = new System.Windows.Forms.Label();
            this.lblSelFlightDep = new System.Windows.Forms.Label();
            this.lblSelFlightTo = new System.Windows.Forms.Label();
            this.lblSelFlightFrom = new System.Windows.Forms.Label();
            this.lblSelFlightNumbe = new System.Windows.Forms.Label();
            this.grbbxBooking.SuspendLayout();
            this.grpbxFlightDetails.SuspendLayout();
            this.pnlUserInformation.SuspendLayout();
            this.pnlFlightInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbbxBooking
            // 
            this.grbbxBooking.Controls.Add(this.btnBookFlight);
            this.grbbxBooking.Controls.Add(this.lstvwFlights);
            this.grbbxBooking.Controls.Add(this.btnRefreshFlights);
            this.grbbxBooking.Controls.Add(this.label1);
            this.grbbxBooking.Location = new System.Drawing.Point(12, 31);
            this.grbbxBooking.Name = "grbbxBooking";
            this.grbbxBooking.Size = new System.Drawing.Size(408, 524);
            this.grbbxBooking.TabIndex = 0;
            this.grbbxBooking.TabStop = false;
            this.grbbxBooking.Text = "Book Tickets";
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
            // lstvwFlights
            // 
            this.lstvwFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstvwFlights.FullRowSelect = true;
            this.lstvwFlights.GridLines = true;
            this.lstvwFlights.Location = new System.Drawing.Point(6, 47);
            this.lstvwFlights.MultiSelect = false;
            this.lstvwFlights.Name = "lstvwFlights";
            this.lstvwFlights.Size = new System.Drawing.Size(396, 395);
            this.lstvwFlights.TabIndex = 4;
            this.lstvwFlights.UseCompatibleStateImageBehavior = false;
            this.lstvwFlights.View = System.Windows.Forms.View.Details;
            this.lstvwFlights.SelectedIndexChanged += new System.EventHandler(this.lstvwFlights_SelectedIndexChanged);
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
            // btnRefreshFlights
            // 
            this.btnRefreshFlights.Location = new System.Drawing.Point(6, 448);
            this.btnRefreshFlights.Name = "btnRefreshFlights";
            this.btnRefreshFlights.Size = new System.Drawing.Size(93, 59);
            this.btnRefreshFlights.TabIndex = 3;
            this.btnRefreshFlights.Text = "Refresh List";
            this.btnRefreshFlights.UseVisualStyleBackColor = true;
            this.btnRefreshFlights.Click += new System.EventHandler(this.btnRefreshFlights_Click);
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
            // pnlUserInformation
            // 
            this.pnlUserInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserInformation.Controls.Add(this.cmbbxCols);
            this.pnlUserInformation.Controls.Add(this.cmbbxRows);
            this.pnlUserInformation.Controls.Add(this.label13);
            this.pnlUserInformation.Controls.Add(this.label12);
            this.pnlUserInformation.Controls.Add(this.label11);
            this.pnlUserInformation.Controls.Add(this.label10);
            this.pnlUserInformation.Controls.Add(this.label9);
            this.pnlUserInformation.Controls.Add(this.label8);
            this.pnlUserInformation.Controls.Add(this.label7);
            this.pnlUserInformation.Controls.Add(this.label6);
            this.pnlUserInformation.Controls.Add(this.label5);
            this.pnlUserInformation.Controls.Add(this.label4);
            this.pnlUserInformation.Controls.Add(this.label3);
            this.pnlUserInformation.Controls.Add(this.label2);
            this.pnlUserInformation.Controls.Add(this.btnCheckAvail);
            this.pnlUserInformation.Controls.Add(this.txtbxTotalFare);
            this.pnlUserInformation.Controls.Add(this.btnConfirm);
            this.pnlUserInformation.Controls.Add(this.btnRefreshSeatMap);
            this.pnlUserInformation.Controls.Add(this.lblAircraftType);
            this.pnlUserInformation.Controls.Add(this.rdbtnEcon);
            this.pnlUserInformation.Controls.Add(this.txtbxSeatMap);
            this.pnlUserInformation.Controls.Add(this.rdbtnFirst);
            this.pnlUserInformation.Controls.Add(this.rdbtnBusiness);
            this.pnlUserInformation.Controls.Add(this.txtbxUserPassport);
            this.pnlUserInformation.Controls.Add(this.txtbxUserAge);
            this.pnlUserInformation.Controls.Add(this.txtbxUserEmail);
            this.pnlUserInformation.Controls.Add(this.txtbxUserName);
            this.pnlUserInformation.Location = new System.Drawing.Point(6, 133);
            this.pnlUserInformation.Name = "pnlUserInformation";
            this.pnlUserInformation.Size = new System.Drawing.Size(558, 385);
            this.pnlUserInformation.TabIndex = 4;
            // 
            // cmbbxCols
            // 
            this.cmbbxCols.FormattingEnabled = true;
            this.cmbbxCols.Location = new System.Drawing.Point(220, 258);
            this.cmbbxCols.Name = "cmbbxCols";
            this.cmbbxCols.Size = new System.Drawing.Size(49, 21);
            this.cmbbxCols.TabIndex = 26;
            // 
            // cmbbxRows
            // 
            this.cmbbxRows.FormattingEnabled = true;
            this.cmbbxRows.Location = new System.Drawing.Point(165, 258);
            this.cmbbxRows.Name = "cmbbxRows";
            this.cmbbxRows.Size = new System.Drawing.Size(42, 21);
            this.cmbbxRows.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monaco", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Total Fare";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monaco", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Class Selection";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monaco", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(215, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Column";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monaco", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(163, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Row #";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monaco", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "User Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monaco", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Seat Selection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "years";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Passport #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // btnCheckAvail
            // 
            this.btnCheckAvail.Location = new System.Drawing.Point(160, 285);
            this.btnCheckAvail.Name = "btnCheckAvail";
            this.btnCheckAvail.Size = new System.Drawing.Size(104, 32);
            this.btnCheckAvail.TabIndex = 12;
            this.btnCheckAvail.Text = "Check Availabilty";
            this.btnCheckAvail.UseVisualStyleBackColor = true;
            this.btnCheckAvail.Click += new System.EventHandler(this.btnCheckAvail_Click);
            // 
            // txtbxTotalFare
            // 
            this.txtbxTotalFare.Location = new System.Drawing.Point(18, 347);
            this.txtbxTotalFare.Name = "txtbxTotalFare";
            this.txtbxTotalFare.Size = new System.Drawing.Size(112, 20);
            this.txtbxTotalFare.TabIndex = 11;
            this.txtbxTotalFare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(160, 340);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 33);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Book ";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnRefreshSeatMap
            // 
            this.btnRefreshSeatMap.Location = new System.Drawing.Point(356, 357);
            this.btnRefreshSeatMap.Name = "btnRefreshSeatMap";
            this.btnRefreshSeatMap.Size = new System.Drawing.Size(121, 23);
            this.btnRefreshSeatMap.TabIndex = 1;
            this.btnRefreshSeatMap.Text = "Refresh Seat Map";
            this.btnRefreshSeatMap.UseVisualStyleBackColor = true;
            this.btnRefreshSeatMap.Click += new System.EventHandler(this.btnRefreshSeatMap_Click);
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
            // rdbtnEcon
            // 
            this.rdbtnEcon.AutoSize = true;
            this.rdbtnEcon.Checked = true;
            this.rdbtnEcon.Location = new System.Drawing.Point(18, 291);
            this.rdbtnEcon.Name = "rdbtnEcon";
            this.rdbtnEcon.Size = new System.Drawing.Size(69, 17);
            this.rdbtnEcon.TabIndex = 7;
            this.rdbtnEcon.TabStop = true;
            this.rdbtnEcon.Text = "Economy";
            this.rdbtnEcon.UseVisualStyleBackColor = true;
            this.rdbtnEcon.CheckedChanged += new System.EventHandler(this.rdbtnEcon_CheckedChanged);
            // 
            // txtbxSeatMap
            // 
            this.txtbxSeatMap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbxSeatMap.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSeatMap.ForeColor = System.Drawing.Color.Yellow;
            this.txtbxSeatMap.Location = new System.Drawing.Point(279, 25);
            this.txtbxSeatMap.Multiline = true;
            this.txtbxSeatMap.Name = "txtbxSeatMap";
            this.txtbxSeatMap.ReadOnly = true;
            this.txtbxSeatMap.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbxSeatMap.Size = new System.Drawing.Size(274, 326);
            this.txtbxSeatMap.TabIndex = 0;
            this.txtbxSeatMap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbtnFirst
            // 
            this.rdbtnFirst.AutoSize = true;
            this.rdbtnFirst.Location = new System.Drawing.Point(18, 268);
            this.rdbtnFirst.Name = "rdbtnFirst";
            this.rdbtnFirst.Size = new System.Drawing.Size(44, 17);
            this.rdbtnFirst.TabIndex = 6;
            this.rdbtnFirst.TabStop = true;
            this.rdbtnFirst.Text = "First";
            this.rdbtnFirst.UseVisualStyleBackColor = true;
            this.rdbtnFirst.CheckedChanged += new System.EventHandler(this.rdbtnFirst_CheckedChanged);
            // 
            // rdbtnBusiness
            // 
            this.rdbtnBusiness.AutoSize = true;
            this.rdbtnBusiness.Location = new System.Drawing.Point(18, 245);
            this.rdbtnBusiness.Name = "rdbtnBusiness";
            this.rdbtnBusiness.Size = new System.Drawing.Size(67, 17);
            this.rdbtnBusiness.TabIndex = 5;
            this.rdbtnBusiness.TabStop = true;
            this.rdbtnBusiness.Text = "Business";
            this.rdbtnBusiness.UseVisualStyleBackColor = true;
            this.rdbtnBusiness.CheckedChanged += new System.EventHandler(this.rdbtnBusiness_CheckedChanged);
            // 
            // txtbxUserPassport
            // 
            this.txtbxUserPassport.Location = new System.Drawing.Point(111, 119);
            this.txtbxUserPassport.Name = "txtbxUserPassport";
            this.txtbxUserPassport.Size = new System.Drawing.Size(133, 20);
            this.txtbxUserPassport.TabIndex = 3;
            // 
            // txtbxUserAge
            // 
            this.txtbxUserAge.Location = new System.Drawing.Point(111, 93);
            this.txtbxUserAge.Name = "txtbxUserAge";
            this.txtbxUserAge.Size = new System.Drawing.Size(65, 20);
            this.txtbxUserAge.TabIndex = 2;
            // 
            // txtbxUserEmail
            // 
            this.txtbxUserEmail.Location = new System.Drawing.Point(111, 67);
            this.txtbxUserEmail.Name = "txtbxUserEmail";
            this.txtbxUserEmail.Size = new System.Drawing.Size(162, 20);
            this.txtbxUserEmail.TabIndex = 1;
            // 
            // txtbxUserName
            // 
            this.txtbxUserName.Location = new System.Drawing.Point(111, 41);
            this.txtbxUserName.Name = "txtbxUserName";
            this.txtbxUserName.Size = new System.Drawing.Size(162, 20);
            this.txtbxUserName.TabIndex = 0;
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
            // lblSelFlightArr
            // 
            this.lblSelFlightArr.AutoSize = true;
            this.lblSelFlightArr.Location = new System.Drawing.Point(238, 55);
            this.lblSelFlightArr.Name = "lblSelFlightArr";
            this.lblSelFlightArr.Size = new System.Drawing.Size(35, 13);
            this.lblSelFlightArr.TabIndex = 4;
            this.lblSelFlightArr.Text = "label6";
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
            // lblSelFlightTo
            // 
            this.lblSelFlightTo.AutoSize = true;
            this.lblSelFlightTo.Location = new System.Drawing.Point(238, 34);
            this.lblSelFlightTo.Name = "lblSelFlightTo";
            this.lblSelFlightTo.Size = new System.Drawing.Size(35, 13);
            this.lblSelFlightTo.TabIndex = 2;
            this.lblSelFlightTo.Text = "label4";
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
            // lblSelFlightNumbe
            // 
            this.lblSelFlightNumbe.AutoSize = true;
            this.lblSelFlightNumbe.Location = new System.Drawing.Point(15, 13);
            this.lblSelFlightNumbe.Name = "lblSelFlightNumbe";
            this.lblSelFlightNumbe.Size = new System.Drawing.Size(35, 13);
            this.lblSelFlightNumbe.TabIndex = 0;
            this.lblSelFlightNumbe.Text = "label2";
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
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbbxBooking.ResumeLayout(false);
            this.grbbxBooking.PerformLayout();
            this.grpbxFlightDetails.ResumeLayout(false);
            this.pnlUserInformation.ResumeLayout(false);
            this.pnlUserInformation.PerformLayout();
            this.pnlFlightInformation.ResumeLayout(false);
            this.pnlFlightInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbbxBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshFlights;
        private System.Windows.Forms.ListView lstvwFlights;
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
        private System.Windows.Forms.RadioButton rdbtnEcon;
        private System.Windows.Forms.RadioButton rdbtnFirst;
        private System.Windows.Forms.RadioButton rdbtnBusiness;
        private System.Windows.Forms.TextBox txtbxUserPassport;
        private System.Windows.Forms.TextBox txtbxUserAge;
        private System.Windows.Forms.TextBox txtbxUserEmail;
        private System.Windows.Forms.TextBox txtbxUserName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtbxTotalFare;
        private System.Windows.Forms.Button btnCheckAvail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbbxCols;
        private System.Windows.Forms.ComboBox cmbbxRows;
    }
}


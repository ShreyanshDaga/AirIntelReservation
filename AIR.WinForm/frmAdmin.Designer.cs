namespace AIR.WinForm
{
    partial class frmAdmin
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
            this.grpbxPersonalDetails = new System.Windows.Forms.GroupBox();
            this.tbctMainPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.picbxLogo = new System.Windows.Forms.PictureBox();
            this.grpbxAddNewAircraft = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddAircraft = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpbxAddNewFlight = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lstvwAircrafts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbctMainPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogo)).BeginInit();
            this.grpbxAddNewAircraft.SuspendLayout();
            this.grpbxAddNewFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxPersonalDetails
            // 
            this.grpbxPersonalDetails.Location = new System.Drawing.Point(12, 296);
            this.grpbxPersonalDetails.Name = "grpbxPersonalDetails";
            this.grpbxPersonalDetails.Size = new System.Drawing.Size(225, 186);
            this.grpbxPersonalDetails.TabIndex = 0;
            this.grpbxPersonalDetails.TabStop = false;
            this.grpbxPersonalDetails.Text = "Personal Details";
            // 
            // tbctMainPanel
            // 
            this.tbctMainPanel.Controls.Add(this.tabPage1);
            this.tbctMainPanel.Controls.Add(this.tabPage2);
            this.tbctMainPanel.Controls.Add(this.tabPage3);
            this.tbctMainPanel.Controls.Add(this.tabPage4);
            this.tbctMainPanel.Location = new System.Drawing.Point(243, 51);
            this.tbctMainPanel.Name = "tbctMainPanel";
            this.tbctMainPanel.SelectedIndex = 0;
            this.tbctMainPanel.Size = new System.Drawing.Size(724, 435);
            this.tbctMainPanel.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstvwAircrafts);
            this.tabPage1.Controls.Add(this.grpbxAddNewAircraft);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aircrafts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpbxAddNewFlight);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flights";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(716, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bookings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(716, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reports";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // picbxLogo
            // 
            this.picbxLogo.Location = new System.Drawing.Point(12, 51);
            this.picbxLogo.Name = "picbxLogo";
            this.picbxLogo.Size = new System.Drawing.Size(225, 221);
            this.picbxLogo.TabIndex = 3;
            this.picbxLogo.TabStop = false;
            // 
            // grpbxAddNewAircraft
            // 
            this.grpbxAddNewAircraft.Controls.Add(this.btnClear);
            this.grpbxAddNewAircraft.Controls.Add(this.btnAddAircraft);
            this.grpbxAddNewAircraft.Controls.Add(this.label9);
            this.grpbxAddNewAircraft.Controls.Add(this.label8);
            this.grpbxAddNewAircraft.Controls.Add(this.label7);
            this.grpbxAddNewAircraft.Controls.Add(this.label6);
            this.grpbxAddNewAircraft.Controls.Add(this.label5);
            this.grpbxAddNewAircraft.Controls.Add(this.label4);
            this.grpbxAddNewAircraft.Controls.Add(this.label3);
            this.grpbxAddNewAircraft.Controls.Add(this.label2);
            this.grpbxAddNewAircraft.Controls.Add(this.textBox5);
            this.grpbxAddNewAircraft.Controls.Add(this.textBox4);
            this.grpbxAddNewAircraft.Controls.Add(this.textBox3);
            this.grpbxAddNewAircraft.Controls.Add(this.textBox2);
            this.grpbxAddNewAircraft.Controls.Add(this.textBox1);
            this.grpbxAddNewAircraft.Controls.Add(this.label1);
            this.grpbxAddNewAircraft.Location = new System.Drawing.Point(6, 13);
            this.grpbxAddNewAircraft.Name = "grpbxAddNewAircraft";
            this.grpbxAddNewAircraft.Size = new System.Drawing.Size(249, 328);
            this.grpbxAddNewAircraft.TabIndex = 0;
            this.grpbxAddNewAircraft.TabStop = false;
            this.grpbxAddNewAircraft.Text = "Add new Aircraft";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaco", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Aircraft";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(188, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 189);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 20);
            this.textBox5.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seat Columns";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "First";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Business";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Economy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total Seats: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monaco", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Seating";
            // 
            // btnAddAircraft
            // 
            this.btnAddAircraft.Location = new System.Drawing.Point(7, 275);
            this.btnAddAircraft.Name = "btnAddAircraft";
            this.btnAddAircraft.Size = new System.Drawing.Size(121, 36);
            this.btnAddAircraft.TabIndex = 14;
            this.btnAddAircraft.Text = "Add";
            this.btnAddAircraft.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(167, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // grpbxAddNewFlight
            // 
            this.grpbxAddNewFlight.Controls.Add(this.textBox6);
            this.grpbxAddNewFlight.Controls.Add(this.label10);
            this.grpbxAddNewFlight.Location = new System.Drawing.Point(6, 6);
            this.grpbxAddNewFlight.Name = "grpbxAddNewFlight";
            this.grpbxAddNewFlight.Size = new System.Drawing.Size(245, 397);
            this.grpbxAddNewFlight.TabIndex = 0;
            this.grpbxAddNewFlight.TabStop = false;
            this.grpbxAddNewFlight.Text = "Add New Flight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monaco", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Add New Flight";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(89, 54);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 1;
            // 
            // lstvwAircrafts
            // 
            this.lstvwAircrafts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstvwAircrafts.GridLines = true;
            this.lstvwAircrafts.HideSelection = false;
            this.lstvwAircrafts.HoverSelection = true;
            this.lstvwAircrafts.Location = new System.Drawing.Point(261, 13);
            this.lstvwAircrafts.Name = "lstvwAircrafts";
            this.lstvwAircrafts.Size = new System.Drawing.Size(449, 328);
            this.lstvwAircrafts.TabIndex = 1;
            this.lstvwAircrafts.UseCompatibleStateImageBehavior = false;
            this.lstvwAircrafts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Width (Seats)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 58;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Business";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Economy";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 66;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 67;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 498);
            this.Controls.Add(this.picbxLogo);
            this.Controls.Add(this.tbctMainPanel);
            this.Controls.Add(this.grpbxPersonalDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.TopMost = true;
            this.tbctMainPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogo)).EndInit();
            this.grpbxAddNewAircraft.ResumeLayout(false);
            this.grpbxAddNewAircraft.PerformLayout();
            this.grpbxAddNewFlight.ResumeLayout(false);
            this.grpbxAddNewFlight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxPersonalDetails;
        private System.Windows.Forms.TabControl tbctMainPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox picbxLogo;
        private System.Windows.Forms.GroupBox grpbxAddNewAircraft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAircraft;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpbxAddNewFlight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListView lstvwAircrafts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
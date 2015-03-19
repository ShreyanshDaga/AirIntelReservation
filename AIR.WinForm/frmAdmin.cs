using AIR.DAL;
using AIR.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIR.WinForm
{
    public partial class frmAdmin : Form
    {
        Admin loggedinAdmin;

        public frmAdmin(Admin loggedInAdmin)
        {
            InitializeComponent();
            this.loggedinAdmin = loggedInAdmin;

            txtbxAdminName.Text = loggedInAdmin.Name;
            txtbxAdminUName.Text = loggedInAdmin.Name;            
        }

        private void btnAddAircraft_Click(object sender, EventArgs e)
        {
            if (!Validate_AddNewAircraft())
                return;

            int iWidth, iBusinessSeats, iEconSeats, iFirstSeats, iTotal;

            iWidth = Convert.ToInt32(txtbxNewAircraftWidth.Text);
            iBusinessSeats = Convert.ToInt32(txtbxNewAircraftBusinessSeats.Text);
            iEconSeats = Convert.ToInt32(txtbxNewAircraftEconSeats.Text);
            iFirstSeats = Convert.ToInt32(txtbxNewAircraftFirstSeats.Text);
            iTotal = iBusinessSeats + iEconSeats + iFirstSeats;

            var newAircraft = new Aircraft { Name = txtbxNewAircraftName.Text, FusalageWidth = iWidth, BusinessSeats = iBusinessSeats, EconomySeats = iEconSeats, FirstClassSeats=iFirstSeats, TotalSeats = iTotal};

            API.AddNewAircraft(newAircraft, loggedinAdmin.Id);

            MessageBox.Show("Aircraft added successfully");

            btnClear_Click(sender, e);
        }        

        private void btnClear_Click(object sender, EventArgs e)
        {            
            txtbxNewAircraftWidth.Clear();
            txtbxNewAircraftName.Clear();
            txtbxNewAircraftFirstSeats.Clear();
            txtbxNewAircraftEconSeats.Clear();
            txtbxNewAircraftBusinessSeats.Clear();
        }

        private bool Validate_AddNewAircraft()
        {
            // Validate all the fields
            return true;
        }

        private void btnEditAdminDetails_Click(object sender, EventArgs e)
        {
            txtbxAdminName.Enabled = true;
            txtbxAdminNewPwd.Enabled = true;
            txtbxAdminUName.Enabled = true;
            txtbxAdminOldPwd.Enabled = true;

            btnSaveDetails.Enabled = true;
            btnEditAdminDetails.Enabled = false;
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            if (!Validate_EditPersonalDetails())
            {
                MessageBox.Show("Validation Error");
                return;
            }

            // Save Changes here

            txtbxAdminName.Enabled = false;
            txtbxAdminUName.Enabled = false;
            txtbxAdminNewPwd.Enabled = false;
            txtbxAdminOldPwd.Enabled = false;

            btnSaveDetails.Enabled = false;
            btnEditAdminDetails.Enabled = true;
        }

        private bool Validate_EditPersonalDetails()
        {
            // Check for validation errors here
            return true;
        }
    }
}

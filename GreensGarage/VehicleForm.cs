using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GreensGarage
{
    public partial class VehicleForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public VehicleForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddVehicle.Left = 200;
            pnlAddVehicle.Top = 20;
            pnlAddVehicle.Visible = false;
            this.Width = 700;
        }

        public void BindControls()
        {
            lblVehicleID.DataBindings.Add("Text", DM.DSGreen, "Vehicle.VehicleID");
            txtPlateNumber.DataBindings.Add("Text", DM.DSGreen, "Vehicle.PlateNumber");
            txtMake.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Make");
            txtModel.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Model");
            txtOwnerID.DataBindings.Add("Text", DM.DSGreen, "Vehicle.OwnerID");
            txtPlateNumber.Enabled = false;
            txtMake.Enabled = false;
            txtModel.Enabled = false;
            txtOwnerID.Enabled = false;
            //txtAddPlateNumber.DataBindings.Add("Text", DM.DSGreen, "Vehicle.PlateNumber");
            //txtAddMake.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Make");
            //txtAddModel.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Model");
            //cboAddOwner.DataBindings.Add("Text", DM.DSGreen, "Vehicle.OwnerID");
            
            lstVehicle.DataSource = DM.DSGreen;
            lstVehicle.DisplayMember = "Vehicle.PlateNumber";
            lstVehicle.ValueMember = "Vehicle.PlateNumber";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "VEHICLE"];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            lstVehicle.Visible = true;
            btnDeleteVehicle.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateVehicle.Enabled = false;
            btnAddVehicle.Enabled = false;
            btnSaveVehicle.Enabled = true;
            btnModifyVehicle.Enabled = false;
            cboAddOwner.Enabled = true;
            pnlAddVehicle.Show();
            LoadVehicleOwner();
        }

        private void LoadVehicleOwner()
        {
            cboAddOwner.DataSource = DM.DSGreen;
            cboAddOwner.DisplayMember = "Owner.OwnerID";
            cboAddOwner.ValueMember = "Owner.OwnerID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddVehicle.Hide();
            lstVehicle.Enabled = true;
            lstVehicle.Visible = true;
            btnDeleteVehicle.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnModifyVehicle.Enabled = true;
            btnAddVehicle.Enabled = true;
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            lblVehicleID.Text = null;
            //Create a new row that the variables will be added into
            DataRow newVehicleRow = DM.dtVehicle.NewRow();

            //If any of the text areas are empty then do not write data and return
            if ((txtAddPlateNumber.Text == "") || (txtAddMake.Text == "") ||
               (txtAddModel.Text == "") || (cboAddOwner.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields.", "Error");
            }
            else
            {
                newVehicleRow["PlateNumber"] = txtAddPlateNumber.Text;
                newVehicleRow["Make"] = txtAddMake.Text;
                newVehicleRow["Model"] = txtAddModel.Text;
                newVehicleRow["OwnerID"] = cboAddOwner.Text;
                
                //Add the new row to the Table
                DM.dtVehicle.Rows.Add(newVehicleRow);
                DM.UpdateVehicle();
                //Give the user a success message
                MessageBox.Show("Vehicle added successfully.", "Success");
            }
            return;
        }

        private void btnModifyVehicle_Click(object sender, EventArgs e)
        {
            lstVehicle.Visible = true;
            lstVehicle.SelectedItem = true;
            btnDeleteVehicle.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateVehicle.Enabled = true;
            btnCancel.Enabled = true;
            btnSaveVehicle.Enabled = false;
            btnModifyVehicle.Enabled = false;
            btnAddVehicle.Enabled = false;
            txtAddPlateNumber.Text = txtPlateNumber.Text;
            txtAddMake.Text = txtMake.Text;
            txtAddModel.Text = txtModel.Text;
            cboAddOwner.Enabled = false;
            cboAddOwner.Text = txtOwnerID.Text;
            pnlAddVehicle.Show();
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            DataRow updateVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];
            if ((txtAddPlateNumber.Text == "") || (txtAddMake.Text == "") ||
               (txtAddModel.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields.", "Error");
                return;
            }
            else
            {
                //Update the text areas
                updateVehicleRow["PlateNumber"] = txtAddPlateNumber.Text;
                updateVehicleRow["Make"] = txtAddMake.Text;
                updateVehicleRow["Model"] = txtAddModel.Text;
                //updateVehicleRow["OwnerID"] = cboAddOwner.Text;
                
                //Update the database
                currencyManager.EndCurrentEdit();
                DM.UpdateVehicle();

                //Give the user a success message
                MessageBox.Show("Vehicle updated successfully.", "Success");
            }
            return;
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            DataRow deleteVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];
            DataRow[] ServiceRow = DM.dtService.Select("VehicleID = " + lblVehicleID.Text);
            if (ServiceRow.Length != 0)
            {
                MessageBox.Show("You may only delete Vehicles that do not have services.", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVehicleRow.Delete();
                    DM.UpdateVehicle();

                    //Give the user a success message
                    MessageBox.Show("Vehicle deleted successfully.", "Success");
                }
            }
            return;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtOwnerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {

        }
    }
}

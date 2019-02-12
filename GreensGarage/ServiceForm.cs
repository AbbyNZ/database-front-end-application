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
    public partial class ServiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmService;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;
       
        public ServiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddService.Left = 620;
            pnlAddService.Top = 20;
            pnlAddService.Visible = false;
        }

        public void BindControls()
        {
            
            //cboAddVehicleID.DataBindings.Add("Text", DM.DSGreen, "Service.VehicleID");
            //cboAddServiceType.DataBindings.Add("Text", DM.DSGreen, "Service.ServiceTypeID");
            //txtAddHours.DataBindings.Add("Text", DM.DSGreen, "Service.Hours");
            //dtpServiceDate.DataBindings.Add("Text", DM.DSGreen, "Service.ServiceDate");
           //txtAddStatus.DataBindings.Add("Text", DM.DSGreen, "Service.Status");
            //cboVehicleID.Enabled = false;
            //cboServiceType.Enabled = false;
            //txtHours.Enabled = false;
            //dtpServiceDate.Enabled = false;
            //txtAddStatus.Enabled = false;
            dgvService.DataSource = DM.DSGreen;
            dgvService.DataMember = "Service";
            cmService = (CurrencyManager)this.BindingContext[DM.DSGreen, "Service"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cmService.Position > 0)
            {
                --cmService.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmService.Position < cmService.Count - 1)
            {
                ++cmService.Position;
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            dgvService.Enabled = false;
            dgvService.Visible = false;
            btnDeleteService.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateService.Enabled = false;
            btnUpdate.Enabled = false;
            btnAddService.Enabled = false;
            btnMarkedService.Enabled = false;
            btnSaveService.Enabled = true;
            cboAddServiceType.Enabled = true;
            cboAddVehicleID.Enabled = true;
            //txtAddHours.Enabled = true;
            txtAddStatus.Enabled = true;
            //dtpServiceDate.Enabled = true;
            pnlAddService.Show();
            LoadService();
        }

        private void LoadService()
        {
            cboAddVehicleID.DataSource = DM.DSGreen;
            cboAddVehicleID.DisplayMember = "Service.VehicleID";
            cboAddVehicleID.ValueMember = "Service.VehicleID";
            cboAddServiceType.DataSource = DM.DSGreen;
            cboAddServiceType.DisplayMember = "Service.ServiceTypeID";
            cboAddServiceType.ValueMember = "Service.ServiceTypeID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddService.Hide();
            dgvService.Enabled = true;
            dgvService.Visible = true;
            btnDeleteService.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateService.Enabled = true;
            btnAddService.Enabled = true;
            btnMarkedService.Enabled = true;
        }

        private void btnSaveService_Click(object sender, EventArgs e)
        {
            //Create a new row that the variables will be added into
            DataRow newServiceRow = DM.dtService.NewRow();

            //If any of the text areas are empty then do not write data and return
            if ((cboAddVehicleID.Text == "") || (cboAddServiceType.Text == "") ||
               (txtAddHours.Text == "") || (dtpServiceDate.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields.", "Error");
            }
            else
            {
                newServiceRow["VehicleID"] = cboAddVehicleID.Text;
                newServiceRow["ServiceTypeID"] = cboAddServiceType.Text;
                newServiceRow["Hours"] = txtAddHours.Text;
                newServiceRow["ServiceDate"] = dtpServiceDate.Text;
                newServiceRow["Status"] = "Pending";

                //Add the new row to the Table
                DM.dtService.Rows.Add(newServiceRow);
                DM.UpdateService();
                //Give the user a success message
                MessageBox.Show("Service added successfully.", "Success");
            }
            return;
        }

        private void dtpServiceDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            DataRow updateServiceRow = DM.dtService.Rows[cmService.Position];
            string orignalStatus = updateServiceRow["Status"].ToString();
            if (orignalStatus == "Pending")
            {
                dgvService.Enabled = true;
                dgvService.Visible = true;
                btnDeleteService.Enabled = false;
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
                btnUpdateService.Enabled = false;
                btnAddService.Enabled = false;
                btnMarkedService.Enabled = false;
                btnUpdate.Enabled = true;
                btnCancel.Enabled = true;
                btnSaveService.Enabled = false;
                cboAddVehicleID.Enabled = false;
                cboAddServiceType.Enabled = false;
                txtAddStatus.Enabled = false;
                //txtAddHours.Enabled = true;
                pnlAddService.Show();

            }
            else
            {
                MessageBox.Show("You cannot update a paid service.", "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Create a new row that the variables will be added into
            DataRow newServiceRow = DM.dtService.NewRow();

            //If any of the text areas are empty then do not write data and return
            if ((cboAddVehicleID.Text == "") || (cboAddServiceType.Text == "") ||
               (txtAddHours.Text == "") || (dtpServiceDate.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields.", "Error");
            }
            else
            {
                //newServiceRow["VehicleID"] = cboVehicleID.Text;
                //newServiceRow["ServiceTypeID"] = cboServiceType.Text;
                newServiceRow["Hours"] = txtAddHours.Text;
                newServiceRow["ServiceDate"] = dtpServiceDate.Text;
                //newServiceRow["Status"] = txtStatus.Text == "Pending";

                //Add the new row to the Table
                cmService.EndCurrentEdit();
                DM.UpdateService();
                //Give the user a success message
                MessageBox.Show("Service updated successfully.", "Success");
            }
            return;
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            DataRow deleteServiceRow = DM.dtService.Rows[cmService.Position];
            if (txtAddStatus.Text == "Paid")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) ==
                                    DialogResult.OK)
                {
                    deleteServiceRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete paid services.", "Error");
                return;
            }
            //Update
            DM.UpdateService();

            //Give the user a success message
            MessageBox.Show("Service deleted successfully.", "Success");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'greenDataSet1.SERVICE' table. You can move, or remove it, as needed.
            //this.sERVICETableAdapter1.Fill(this.greenDataSet1.SERVICE);

        }

        private void btnMarkedService_Click(object sender, EventArgs e)
        {
            DataRow updateServiceRow = DM.dtService.Rows[cmService.Position];
            string orignalStatus = updateServiceRow["Status"].ToString();
            if (orignalStatus == "Pending")
            {
                updateServiceRow["Status"] = "Paid";
                //Update
                cmService.EndCurrentEdit();
                DM.UpdateService();

                //Give the user a success message
                MessageBox.Show("Service marked as paid.", "Success");
            }
            else
            {
                MessageBox.Show("The Service is already paid.", "Error");
            }
        }

        private void pnlAddService_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddStatus_TextChanged(object sender, EventArgs e)
        {

        }

               
    }
}

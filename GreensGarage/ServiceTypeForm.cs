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
    public partial class ServiceTypeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public ServiceTypeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddServiceType.Left = 220;
            pnlAddServiceType.Top = 20;
        }

        public void BindControls()
        {
            lblServiceTypeID.DataBindings.Add("Text", DM.DSGreen, "ServiceType.ServiceTypeID");
            txtDescription.DataBindings.Add("Text", DM.DSGreen, "ServiceType.Description");
            txtHourlyRate.DataBindings.Add("Text", DM.DSGreen, "ServiceType.HourlyRate");
            txtDescription.Enabled = false;
            txtHourlyRate.Enabled = false;
            lstServiceType.DataSource = DM.DSGreen;
            lstServiceType.DisplayMember = "ServiceType.Description";
            lstServiceType.ValueMember = "ServiceType.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICETYPE"];
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

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            lstServiceType.Visible = true; 
            btnDeleteServiceType.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateServiceType.Enabled = false;
            btnAddServiceType.Enabled = false;
            btnUpdate.Enabled = false;
            btnSaveServiceType.Enabled = true;
            pnlAddServiceType.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddServiceType.Hide();
            lstServiceType.Enabled = true;
            lstServiceType.Visible = true;
            btnDeleteServiceType.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateServiceType.Enabled = true;
            btnAddServiceType.Enabled = true;
        }

        private void btnSaveServiceType_Click(object sender, EventArgs e)
        {
            lblServiceTypeID.Text = null;
            DataRow newServiceTypeRow = DM.dtServiceType.NewRow();

            if ((txtAddDescription.Text == "") || (txtAddHourlyRate.Text == ""))
            {
                MessageBox.Show("You must type in a Service type description and hourly rate.", "Error");

            }
            else
            {
                try
                {
                    newServiceTypeRow["Description"] = txtAddDescription.Text;
                    newServiceTypeRow["HourlyRate"] = Convert.ToDouble(txtAddHourlyRate.Text);
                    DM.dtServiceType.Rows.Add(newServiceTypeRow);
                    MessageBox.Show("Service Type added successfully.", "Success");
                    DM.UpdateServiceType();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a value for hourly rate.", "Error");
                }
            }
            return;
        }

        private void btnUpdateServiceType_Click(object sender, EventArgs e)
        {
            lstServiceType.Visible = true;
            
            btnDeleteServiceType.Enabled = false;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateServiceType.Enabled = false;
            btnAddServiceType.Enabled = false;
            btnUpdate.Enabled = true;
            btnSaveServiceType.Enabled = false;
            pnlAddServiceType.Show();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
            if ((txtAddDescription.Text == "") || (txtAddHourlyRate.Text == ""))
               
            {
                MessageBox.Show("You must enter a value for each of the text fields.", "Error");
                return;
            }
            else
            {
                //Update the text areas
                updateServiceTypeRow["Description"] = txtAddDescription.Text;
                updateServiceTypeRow["HourlyRate"] = Convert.ToDouble(txtAddHourlyRate.Text);
                
                //Update the database
                currencyManager.EndCurrentEdit();
                DM.UpdateServiceType();
                //Give the user a success message
                MessageBox.Show("Service Type updated successfully.", "Success");
            }
            return;
        }

        private void btnDeleteServiceType_Click(object sender, EventArgs e)
        {
            DataRow deleteServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
            DataRow[] ServiceTypeEquipmentRow = DM.dtServiceTypeEquipment.Select("ServiceTypeID = " + lblServiceTypeID.Text);
            if (ServiceTypeEquipmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteServiceTypeRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Service Type that are not allocated to services.", "Error");
                return;
            }
            
            //Update
            DM.UpdateServiceType();     
            MessageBox.Show("Service Type deleted successfully.", "Success");
        }

        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
              
              
    }
}

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
    public partial class OwnerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public OwnerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddOwner.Left = 170;
            pnlAddOwner.Top = 30;
            pnlUpdateOwner.Left = 170;
            pnlUpdateOwner.Top = 30;
        }

        public void BindControls()
        {
            lblOwnerID.DataBindings.Add("Text", DM.DSGreen, "Owner.OwnerID");
            txtLastName.DataBindings.Add("Text", DM.DSGreen, "Owner.LastName");
            txtFirstName.DataBindings.Add("Text", DM.DSGreen, "Owner.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.DSGreen, "Owner.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.DSGreen, "Owner.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.DSGreen, "Owner.PhoneNumber");
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtUpdateLastName.DataBindings.Add("Text", DM.DSGreen, "Owner.LastName");
            txtUpdateFirstName.DataBindings.Add("Text", DM.DSGreen, "Owner.FirstName");
            txtUpdateStreetAddress.DataBindings.Add("Text", DM.DSGreen, "Owner.StreetAddress");
            txtUpdateSuburb.DataBindings.Add("Text", DM.DSGreen, "Owner.Suburb");
            txtUpdatePhoneNumber.DataBindings.Add("Text", DM.DSGreen, "Owner.PhoneNumber");
            txtUpdateLastName.Enabled = true;
            txtUpdateFirstName.Enabled = true;
            txtUpdateStreetAddress.Enabled = true;
            txtUpdateSuburb.Enabled = true;
            txtUpdatePhoneNumber.Enabled = true;
            lstOwner.DataSource = DM.DSGreen;
            lstOwner.DisplayMember = "Owner.LastName";
            lstOwner.ValueMember = "Owner.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "OWNER"];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                
        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            lstOwner.Visible = true; // Note that if you use this line of code
            //lstOwner.Enabled = false; // … you do not need this line
            //lstOwner.SelectedItem = null; // … or this line
            btnDeleteOwner.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateOwner.Enabled = false;
            btnAddOwner.Enabled = false;
            pnlAddOwner.Show();
        }

        private void btnSaveOwner_Click(object sender, EventArgs e)
        {
            lblOwnerID.Text = null;
            //Create a new row that the variables will be added into
            DataRow newOwnerRow = DM.dtOwner.NewRow();

            //If any of the text areas are empty then do not write data and return
            if ((txtAddLastName.Text == "") || (txtAddFirstName.Text == "") ||
               (txtAddStreetAddress.Text == "") || (txtAddSuburb.Text == "") || (txtAddPhoneNumber.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields.", "Error");
            }
            else
            {
                newOwnerRow["LastName"] = txtAddLastName.Text;
                newOwnerRow["FirstName"] = txtAddFirstName.Text;
                newOwnerRow["StreetAddress"] = txtAddStreetAddress.Text;
                newOwnerRow["Suburb"] = txtAddSuburb.Text;
                newOwnerRow["PhoneNumber"] = txtAddPhoneNumber.Text;

                //Add the new row to the Table
                DM.dtOwner.Rows.Add(newOwnerRow);
                DM.UpdateOwner();
                //Give the user a success message
                MessageBox.Show("Owner added successfully.", "Success");
            }
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddOwner.Hide();
            lstOwner.Enabled = true;
            lstOwner.Visible = true;
            btnDeleteOwner.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateOwner.Enabled = true;
            btnAddOwner.Enabled = true;
        }

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            lstOwner.Visible = true; 
            btnDeleteOwner.Enabled = false;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateOwner.Enabled = false;
            btnAddOwner.Enabled = false;
            pnlUpdateOwner.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            if ((txtUpdateLastName.Text == "") || (txtUpdateFirstName.Text == "") ||
               (txtUpdateStreetAddress.Text == "") || (txtUpdateSuburb.Text == "") || (txtUpdatePhoneNumber.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields.", "Error");
                return;
            }
            else
            {
                //Update the text areas
                updateOwnerRow["LastName"] = txtUpdateLastName.Text;
                updateOwnerRow["FirstName"] = txtUpdateFirstName.Text;
                updateOwnerRow["StreetAddress"] = txtUpdateStreetAddress.Text;
                updateOwnerRow["Suburb"] = txtUpdateSuburb.Text;
                updateOwnerRow["PhoneNumber"] = txtUpdatePhoneNumber.Text;
                //Update the database
                currencyManager.EndCurrentEdit();
                DM.UpdateOwner();
                //Give the user a success message
                MessageBox.Show("Owner updated successfully.", "Success");
            }
            return;
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateOwner.Hide();
            lstOwner.Enabled = true;
            lstOwner.Visible = true;
            btnDeleteOwner.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateOwner.Enabled = true;
            btnAddOwner.Enabled = true;
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            DataRow deleteOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            DataRow[] VehicleRow = DM.dtVehicle.Select("OwnerID = " + lblOwnerID.Text);
            if (VehicleRow.Length != 0)
            {
                MessageBox.Show("You may only delete Owners who do not have a registered vehicle.", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteOwnerRow.Delete();
                    DM.UpdateOwner();

                    //Give the user a success message
                    MessageBox.Show("Owner deleted successfully.", "Success");
                }

                
            }
            return;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

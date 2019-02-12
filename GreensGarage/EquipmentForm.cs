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
    public partial class EquipmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public EquipmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddEquipment.Left = 280;
            pnlAddEquipment.Top = 40;
            pnlUpdateEquipment.Left = 280;
            pnlUpdateEquipment.Top = 40;
        }

        public void BindControls()
        {
            lblEquipmentID.DataBindings.Add("Text", DM.DSGreen, "Equipment.EquipmentID");
            txtDescription.DataBindings.Add("Text", DM.DSGreen, "Equipment.Description");
            txtDescription.Enabled = false;
            txtUpdateDescription.DataBindings.Add("Text", DM.DSGreen, "Equipment.Description");
            txtUpdateDescription.Enabled = true;
            lstEquipment.DataSource = DM.DSGreen;
            lstEquipment.DisplayMember = "Equipment.Description";
            lstEquipment.ValueMember = "Equipment.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "EQUIPMENT"];
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            lstEquipment.Visible = true; // Note that if you use this line of code
            //lstEquipment.Enabled = false; // … you do not need this line
            //lstEquipment.SelectedItem = null; // … or this line
            btnDeleteEquipment.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateEquipment.Enabled = false;
            btnAddEquipment.Enabled = false;
            pnlAddEquipment.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddEquipment.Hide();
            lstEquipment.Enabled = true;
            lstEquipment.Visible = true;
            btnDeleteEquipment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEquipment.Enabled = true;
            btnAddEquipment.Enabled = true;
        }

        private void btnSaveEquipment_Click(object sender, EventArgs e)
        {
            lblEquipmentID.Text = null;
            DataRow newEquipmentRow = DM.dtEquipment.NewRow();

            if (txtAddDescription.Text == "")
            {
                MessageBox.Show("You must type in an Equipment description.", "Error");

            }
            else
            {
                newEquipmentRow["Description"] = txtAddDescription.Text;
                DM.dtEquipment.Rows.Add(newEquipmentRow);
                MessageBox.Show("Equipment added successfully.", "Success");
                DM.UpdateEquipment();
            }

            return;
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {
            lstEquipment.Visible = true; // Note that if you use this line of code
            //lstEquipment.Enabled = false; // … you do not need this line
            //lstEquipment.SelectedItem = null; // … or this line
            btnDeleteEquipment.Enabled = false;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEquipment.Enabled = false;
            btnAddEquipment.Enabled = false;
            pnlUpdateEquipment.Show();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateEquipment.Hide();
            lstEquipment.Enabled = true;
            lstEquipment.Visible = true;
            btnDeleteEquipment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEquipment.Enabled = true;
            btnAddEquipment.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];

            if (txtUpdateDescription.Text == "")
            {
                MessageBox.Show("You must type in an Equipment description.", "Error");

            }
            else
            {
                updateEquipmentRow["Description"] = txtUpdateDescription.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateEquipment();
                MessageBox.Show("Equipment updated successfully.", "Success");
            }
            return;
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            DataRow deleteEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
            DataRow[] ServiceTypeEquipmentRow = DM.dtServiceTypeEquipment.Select("EquipmentID = " + lblEquipmentID.Text);
            if (ServiceTypeEquipmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEquipmentRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Equipment that are not allocated to services.", "Error");
                return;
            }
            //Update
            DM.UpdateEquipment();    
            MessageBox.Show("Equipment deleted successfully.", "Success");
        }

        private void lstEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        

        

    }
}

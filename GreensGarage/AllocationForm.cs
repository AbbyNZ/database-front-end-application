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
    public partial class AllocationForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmServiceType;
        private CurrencyManager cmServiceTypeEquipment;
        private CurrencyManager cmEquipment;
        private CurrencyManager cmSSS;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        public AllocationForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceType"];
            cmServiceTypeEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceTypeEquipment"];
            cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "Equipment"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            cmSSS = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceType.ServiceType_ServiceTypeEquipment"];
            BindControls();

        }

        public void BindControls()
        {
            dgvServiceType.DataSource = DM.DSGreen;
            dgvServiceType.DataMember = "ServiceType";
            dgvEquipment.DataSource = DM.DSGreen;
            dgvEquipment.DataMember = "Equipment";
            dgvServiceTypeEquipment.DataSource = DM.DSGreen;
            dgvServiceTypeEquipment.DataMember = "ServiceType.ServiceType_ServiceTypeEquipment";
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DM.dtService.Rows[cmServiceType.Position]["Status"].ToString() == "Pending")
                {
                    DataRow newServiceTypeEquipment = DM.dtServiceTypeEquipment.NewRow();

                    newServiceTypeEquipment["EquipmentID"] = dgvEquipment["EquipmentID", cmEquipment.Position].Value;
                    newServiceTypeEquipment["ServiceTypeID"] = dgvServiceType["ServiceTypeID", cmServiceType.Position].Value;

                    DM.DSGreen.Tables["ServiceTypeEquipment"].Rows.Add(newServiceTypeEquipment);    //add a new row to dataset
                    DM.UpdateServiceTypeEquipment();    //update database
                    //Give the user a success message
                    MessageBox.Show("Item of equipment allocated successfully.");
                }
                else
                {
                    MessageBox.Show("Cannot allocate equipment to paid service.", "Error");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("This item of equipment has already been allocated to this service type.", "Error");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DM.dtService.Rows[cmServiceType.Position]["Status"].ToString() == "Pending")
            {
                string ServiceTypeID = DM.dtService.Rows[cmServiceType.Position]["ServiceTypeID"].ToString();
                string EquipmentID = dgvServiceTypeEquipment.Rows[cmSSS.Position].Cells[1].Value.ToString();
                int row = 0;

                for (int i = 0; i < DM.dtServiceTypeEquipment.Rows.Count; i++)
                {
                    string sID = DM.dtServiceTypeEquipment.Rows[i]["ServiceTypeID"].ToString();
                    string aID = DM.dtServiceTypeEquipment.Rows[i]["EquipmentID"].ToString();

                    if (ServiceTypeID == sID && EquipmentID == aID)
                    {
                        row = i;
                    }
                }

                DataRow dr = DM.DSGreen.Tables["ServiceTypeEquipment"].Rows[row];
                dr.Delete();
                DM.UpdateServiceTypeEquipment();    //update database
                //Give the user a success message
                MessageBox.Show("Item of equipment removed successfully.");
            }
            else
            {
                MessageBox.Show("You may only remove equipment from pending service.", "Error");
            }

        }
    }
}

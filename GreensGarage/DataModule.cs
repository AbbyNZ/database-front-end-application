using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GreensGarage
{
    public partial class DataModule : Form
    {
        public DataTable dtOwner;
        public DataTable dtServiceType;
        public DataTable dtVehicle;
        public DataTable dtEquipment;
        public DataTable dtService;
        public DataTable dtServiceTypeEquipment;
        public DataView ownerView;
        public DataView serviceTypeView;
        public DataView vehicleView;
        public DataView equipmentView;
        public DataView serviceView;
        public DataView ServiceTypeEquipmentView;

        public DataModule()
        {
            InitializeComponent();
            DSGreen.EnforceConstraints = false;
            daOwner.Fill(DSGreen);
            daServiceTypeEquipment.Fill(DSGreen);
            daVehicle.Fill(DSGreen);
            daEquipment.Fill(DSGreen);
            daService.Fill(DSGreen);
            daServiceType.Fill(DSGreen);
            dtOwner = DSGreen.Tables["Owner"];
            dtServiceType = DSGreen.Tables["ServiceType"];
            dtVehicle = DSGreen.Tables["Vehicle"];
            dtEquipment = DSGreen.Tables["Equipment"];
            dtService = DSGreen.Tables["Service"];
            dtServiceTypeEquipment = DSGreen.Tables["ServiceTypeEquipment"];

            vehicleView = new DataView(dtVehicle);
            vehicleView.Sort = "VehicleID";
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            serviceTypeView = new DataView(dtServiceType);
            serviceTypeView.Sort = "ServiceTypeID";
            equipmentView = new DataView(dtEquipment);
            equipmentView.Sort = "EquipmentID";
            DSGreen.EnforceConstraints = true;
        }

        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        public void UpdateEquipment()
        {
            daEquipment.Update(dtEquipment);
        }

        private void daEquipment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", Green);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EquipmentID"] = newID;
            }

        }

        public void UpdateOwner()
        {
            daOwner.Update(dtOwner);
        }

        private void daOwner_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY",Green);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["OwnerID"] = newID;
            }
        }

        public void UpdateServiceType()
        {
            daServiceType.Update(dtServiceType);
        }

        private void daServiceType_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", Green);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ServiceTypeID"] = newID;
            }
        }

        public void UpdateVehicle()
        {
            daVehicle.Update(dtVehicle);
        }

        private void daVehicle_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", Green);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VehicleID"] = newID;
            }
        }

        public void UpdateService()
        {
            daService.Update(dtService);
        }

        private void daService_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", Green);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VehicleID"] = newID;
            }
        }

        public void UpdateServiceTypeEquipment()
        {
            daServiceTypeEquipment.Update(dtServiceTypeEquipment);
        }

        private void daServiceTypeEquipment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", Green);

            if (e.StatementType == StatementType.Insert)
            {
                //newID = (int)idCMD.ExecuteScalar();
                //e.Row["ServiceTypeID"] = newID;
            }
        }

     }
}

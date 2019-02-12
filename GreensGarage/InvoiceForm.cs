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
    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesForPrint;

        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            CurrencyManager cmOwner;
            CurrencyManager cmVehicle;
            CurrencyManager cmServiceType;
            CurrencyManager cmEquipment;
            string serviceText = "";
            double serviceTotal = 0;     

            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGreen, "OWNER"];
            cmVehicle = (CurrencyManager)this.BindingContext[DM.DSGreen, "VEHICLE"];
            cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICETYPE"];
            cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "EQUIPMENT"];

            txtInvoices.Text = "";

            foreach (DataRow drService in DM.dtService.Rows)
            {
                string serviceStatus = drService["Status"].ToString();
                if (serviceStatus.Equals("Pending") == true)
                {
                    // get the vehicle record matching the vehicle ID from the service record
                    int aVehicleID = Convert.ToInt32(drService["VehicleID"].ToString());
                    cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
                    DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];

                    // get the owner record matching the owner ID from the vehicle record
                    int anOwnerID = Convert.ToInt32(drVehicle["OwnerID"].ToString());
                    cmOwner.Position = DM.ownerView.Find(aVehicleID);
                    DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

                    // get the service type record matching the Service Type ID from the service record
                    int aServiceTypeID = Convert.ToInt32(drService["ServiceTypeID"].ToString());
                    cmServiceType.Position = DM.serviceTypeView.Find(aServiceTypeID);
                    DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];


                    serviceText += "Owner ID: " + drOwner["OwnerID"] + "\r\n";
                    serviceText += "Owner Name: " + drOwner["LastName"] + ", " + drOwner["FirstName"] + "\r\n";
                    serviceText += "Address: " + drOwner["StreetAddress"] + "\r\n";
                    serviceText += "Suburb: " + drOwner["Suburb"] + "\r\n\r\n";
                    //serviceText += "Vehicle ID: " + drVehicle["VehicleID"] + "\r\n";
                    serviceText += "Plate Number: " + drVehicle["PlateNumber"] + "\r\n";
                    serviceText += "Make: " + drVehicle["Make"] + "\r\n";
                    serviceText += "Model: " + drVehicle["Model"] + "\r\n\r\n";
                    serviceText += "Service Type: " + drServiceType["Description"] + "\r\n";
                    serviceText += "Hourly Rate: " + drServiceType["HourlyRate"] + "\r\n";
                    serviceText += "Hours: " + drService["Hours"] + "\r\n";
                    serviceText += "Service Date: " + ((DateTime)drService["ServiceDate"]).ToShortDateString()+ "\r\n\r\n";

                    DataRow[] drEquipments = drServiceType.GetChildRows(DM.dtServiceType.ChildRelations["ServiceType_ServiceTypeEquipment"]);

                    if (drEquipments.Length > 0)
                    {
                        txtInvoices.Text += serviceText;
                        
                        foreach (DataRow drServiceTypeEquipment in drEquipments)
                        {
                            string equipmentText = "";

                            // get the Equipment record matching the equipment ID from the service record
                            int aEquipmentID = Convert.ToInt32(drServiceTypeEquipment["EquipmentID"].ToString());
                            cmEquipment.Position = DM.equipmentView.Find(aEquipmentID);
                            DataRow drEquipment = DM.dtEquipment.Rows[cmEquipment.Position];

                            double grossDue;

                            grossDue = Convert.ToInt32(drService["Hours"]) *
                                            Convert.ToDouble(drServiceType["HourlyRate"]);
                            serviceTotal += grossDue;
                            equipmentText = "Equipment: " + drEquipment["Description"] + "\r\n";
                            txtInvoices.Text += equipmentText;
                        }

                        txtInvoices.Text += "\r\n";
                        txtInvoices.Text += "\t\t\t\t\t\t\t\t\t\t\t\t\tGross Due: " + Convert.ToString(serviceTotal);
                        txtInvoices.Text += "\r\n\r\n\r\n\r\n";
                    }
                    serviceText = "";
                    serviceTotal = 0;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            amountOfInvoicesPrinted = 0;
            string strFilter = "Status = 'Pending'";
            string strSort = "VehicleID";

            invoicesForPrint = DM.DSGreen.Tables["SERVICE"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;
            previewService.Show();

        }

        private void printService_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            //Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            //Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);

            DataRow drService = invoicesForPrint[amountOfInvoicesPrinted];

            CurrencyManager cmOwner;
            CurrencyManager cmVehicle;
            CurrencyManager cmServiceType;
            CurrencyManager cmEquipment;

            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGreen, "OWNER"];
            cmVehicle = (CurrencyManager)this.BindingContext[DM.DSGreen, "VEHICLE"];
            cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICETYPE"];
            cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "EQUIPMENT"];

            Brush brush = new SolidBrush(Color.Black);

            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            //int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //heading
            g.DrawString("Invoice: ", headingFont, Brushes.Gray, leftMargin, topMargin);

            double serviceTotal = 0;
            string serviceText = "";

            // get the vehicle record matching the vehicle ID from the service record
            int aVehicleID = Convert.ToInt32(drService["VehicleID"].ToString());
            cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
            DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];
            linesSoFarHeading++;
            linesSoFarHeading++;

            // get the owner record matching the owner ID from the vehicle record
            int anOwnerID = Convert.ToInt32(drVehicle["OwnerID"].ToString());
            cmOwner.Position = DM.ownerView.Find(aVehicleID);
            DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

            g.DrawString("Owner ID: " + anOwnerID, textFont, brush, leftMargin, (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Owner Name: " + drOwner["LastName"] + ", " + drOwner["FirstName"], textFont, brush, leftMargin, (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
          
            // get the service type record matching the Service Type ID from the service record
            int aServiceTypeID = Convert.ToInt32(drService["ServiceTypeID"].ToString());
            cmServiceType.Position = DM.serviceTypeView.Find(aServiceTypeID);
            DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];

            serviceText = "Address: " + drOwner["StreetAddress"] + "Suburb: " + drOwner["Suburb"] + 
             "Plate Number: " + drVehicle["PlateNumber"] + "Make: " + drVehicle["Make"] + "Model: " + drVehicle["Model"] + "Service Type: " + drServiceType["Description"] + "Hourly Rate: " + drServiceType["HourlyRate"] + "Hours: " + drService["Hours"] +
             "Service Date: " + ((DateTime)drService["ServiceDate"]).ToShortDateString();

            g.DrawString(serviceText, textFont, brush, leftMargin, linesSoFarHeading * textFont.Height);

            DataRow[] drEquipments = drServiceType.GetChildRows(DM.dtServiceType.ChildRelations["ServiceType_ServiceTypeEquipment"]);

            if (drEquipments.Length > 0)
            {
                  foreach (DataRow drServiceTypeEquipment in drEquipments)
                  {
                      string equipmentText = "";
                      double grossDue = 0;

                      // get the Equipment record matching the equipment ID from the service record
                      int aEquipmentID = Convert.ToInt32(drServiceTypeEquipment["EquipmentID"].ToString());
                      cmEquipment.Position = DM.equipmentView.Find(aEquipmentID);
                      DataRow drEquipment = DM.dtEquipment.Rows[cmEquipment.Position];

                      grossDue = Convert.ToInt32(drService["Hours"]) *
                                                Convert.ToDouble(drServiceType["HourlyRate"]);
                      serviceTotal += grossDue;
                      equipmentText = "Equipment: " + drEquipment["Description"];

                      g.DrawString(equipmentText, textFont, brush, leftMargin, (linesSoFarHeading * textFont.Height));
                      linesSoFarHeading++;
                      linesSoFarHeading++;
                      g.DrawString("Gross Due: NZ $" + string.Format("{0:#,##0.00}", serviceTotal), textFont, brush, leftMargin, (linesSoFarHeading * textFont.Height));
                      linesSoFarHeading++;
                    }
                       
            }
                
            serviceTotal = 0;
            amountOfInvoicesPrinted++;

            if (!(amountOfInvoicesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void previewService_Load(object sender, EventArgs e)
        {

        }

    }
}

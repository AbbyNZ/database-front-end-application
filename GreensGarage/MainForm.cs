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
    public partial class MainForm : Form
    {
        private DataModule DM;                   		// the reference to the form that holds the data components
        private OwnerForm frmOwner;            	    	// the reference to the Owner form
        private ServiceTypeForm frmServiceType;	 	    // the reference to the Service Type form
        private VehicleForm frmVehicle;      		    // the reference to the Vehicle form
        private EquipmentForm frmEquipment;         	// the reference to the Equipment form
        private ServiceForm frmService;       		    // the reference to the Service form
        private AllocationForm frmAllocation;  	        // the reference to the Equipment Allocation form
        private InvoiceForm frmInvoice;     	        // the reference to the invoice form

        //private int amountOfInvoicesPrinted;
        //private int pagesAmountExpected;
        //private DataRow[] invoicesForPrint;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();    //create the data module and load the dataset
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            if (frmEquipment == null)
            {
                frmEquipment = new EquipmentForm(DM, this);
            }
            frmEquipment.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            if (frmOwner == null)
            {
                frmOwner = new OwnerForm(DM, this);
            }
            frmOwner.ShowDialog();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (frmService == null)
            {
                frmService = new ServiceForm(DM, this);
            }
            frmService.ShowDialog();
        }

        private void btnServiceType_Click(object sender, EventArgs e)
        {
            if (frmServiceType == null)
            {
                frmServiceType = new ServiceTypeForm(DM, this);
            }
            frmServiceType.ShowDialog();
        }

        private void btnVehicleMaintenance_Click(object sender, EventArgs e)
        {
            if (frmVehicle == null)
            {
                frmVehicle = new VehicleForm(DM, this);
            }
            frmVehicle.ShowDialog();
        }

        private void btnEquipmentAllocation_Click(object sender, EventArgs e)
        {
            if (frmAllocation == null)
            {
                frmAllocation = new AllocationForm(DM, this);
            }
            frmAllocation.ShowDialog();

        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);
            }
            frmInvoice.ShowDialog();
        }

       
        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    amountOfInvoicesPrinted = 0;
        //    string strFilter = "Status = 'Pending'";
        //    string strSort = "VehicleID";

        //    invoicesForPrint = DM.DSGreen.Tables["SERVICE"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
        //    pagesAmountExpected = invoicesForPrint.Length;
        //    printPreviewDialog1.Show();
        //}
        

        //private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    int linesSoFarHeading = 0;
        //    Font textFont = new Font("Arial", 10, FontStyle.Regular);
        //    Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
        //    Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
        //    Font headingFont = new Font("Arial", 10, FontStyle.Bold);

        //    DataRow drService = invoicesForPrint[amountOfInvoicesPrinted];
            
        //    CurrencyManager cmOwner;
        //    CurrencyManager cmVehicle;
        //    CurrencyManager cmServiceType;
        //    CurrencyManager cmEquipment;
        //    string serviceText = "";
        //    double serviceTotal = 0;

        //    // Use local Data Views
        //    DataView dvService = new DataView(DM.dtService);
        //    dvService.Sort = "VehicleID";
        //    DataView dvOwner = new DataView(DM.dtOwner);
        //    dvOwner.Sort = "OwnerID";
        //    DataView dvServiceType = new DataView(DM.dtServiceType);
        //    dvServiceType.Sort = "ServiceTypeID";
        //    DataView dvEquipment = new DataView(DM.dtEquipment);
        //    dvEquipment.Sort = "EquipmentID";
        //    DataView dvVehicle = new DataView(DM.dtVehicle);
        //    dvVehicle.Sort = "VehicleID";

        //    cmOwner = (CurrencyManager)this.BindingContext[DM.DSGreen, "OWNER"];
        //    cmVehicle = (CurrencyManager)this.BindingContext[DM.DSGreen, "VEHICLE"];
        //    cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICETYPE"];
        //    cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "EQUIPMENT"];

        //    Brush brush = new SolidBrush(Color.Black);

        //    //margins
        //    int leftMargin = e.MarginBounds.Left;
        //    int topMargin = e.MarginBounds.Top;
        //    int headingLeftMargin = 50;
        //    int topMarginDetails = topMargin + 70;
        //    int rightMargin = e.MarginBounds.Right;

        //    //heading
        //    g.DrawString("Vehicle: " + drService["VehicleID"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin);

        //    double grossDue;
        //    //int anOwnerID = Convert.ToInt32(drVehicle["OwnerID"].ToString());
        //    //cmOwner.Position = DM.ownerView.Find(aVehicleID);
        //    //DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];
        //    //linesSoFarHeading++;
        //    //linesSoFarHeading++;

        //    //g.DrawString("Owner: " + drOwner["LastName"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
        //    linesSoFarHeading++;
        //    linesSoFarHeading++;
        //    linesSoFarHeading++;

        //    //body of the Invoice
        //    string serviceStatus = drService["Status"].ToString();
        //    if (serviceStatus.Equals("Pending") == true)
        //    {
        //        // get the vehicle record matching the vehicle ID from the service record
        //        int aVehicleID = Convert.ToInt32(drService["VehicleID"].ToString());
        //        cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
        //        DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];

        //        // get the owner record matching the owner ID from the vehicle record
        //        int anOwnerID = Convert.ToInt32(drVehicle["OwnerID"].ToString());
        //        cmOwner.Position = DM.ownerView.Find(aVehicleID);
        //        DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

        //        // get the service type record matching the Service Type ID from the service record
        //        int aServiceTypeID = Convert.ToInt32(drService["ServiceTypeID"].ToString());
        //        cmServiceType.Position = DM.serviceTypeView.Find(aServiceTypeID);
        //        DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];

        //        serviceText += "Owner ID: " + drOwner["OwnerID"] + "\r\n";
        //        serviceText += "Owner Name: " + drOwner["LastName"] + ", " + drOwner["FirstName"] + "\r\n";
        //        serviceText += "Address: " + drOwner["StreetAddress"] + "\r\n";
        //        serviceText += "Suburb: " + drOwner["Suburb"] + "\r\n\r\n";
        //        serviceText += "Plate Number: " + drVehicle["PlateNumber"] + "\r\n";
        //        serviceText += "Make: " + drVehicle["Make"] + "\r\n";
        //        serviceText += "Model: " + drVehicle["Model"] + "\r\n\r\n";
        //        serviceText += "Service Type: " + drServiceType["Description"] + "\r\n";
        //        serviceText += "Hourly Rate: " + drServiceType["HourlyRate"] + "\r\n";
        //        serviceText += "Hours: " + drService["Hours"] + "\r\n";
        //        serviceText += "Service Date: " + ((DateTime)drService["ServiceDate"]).ToShortDateString() + "\r\n\r\n";

        //        g.DrawString(serviceText, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
        //        linesSoFarHeading++;

        //        DataRow[] drEquipments = drServiceType.GetChildRows(DM.dtServiceType.ChildRelations["ServiceType_ServiceTypeEquipment"]);

        //        if (drEquipments.Length > 0)
        //        {

        //            //txtInvoices.Text += serviceText;

        //            foreach (DataRow drServiceTypeEquipment in drEquipments)
        //            {
        //                string equipmentText = "";
                        

        //                // get the Equipment record matching the equipment ID from the service record
        //                int aEquipmentID = Convert.ToInt32(drServiceTypeEquipment["EquipmentID"].ToString());
        //                cmEquipment.Position = DM.equipmentView.Find(aEquipmentID);
        //                DataRow drEquipment = DM.dtEquipment.Rows[cmEquipment.Position];


        //                grossDue = Convert.ToInt32(drService["Hours"]) *
        //                                        Convert.ToDouble(drServiceType["HourlyRate"]);
        //                serviceTotal += grossDue;
        //                equipmentText = "Equipment: " + drEquipment["Description"] + "\r\n";
        //                //txtInvoices.Text += equipmentText;

        //                linesSoFarHeading++;
        //                g.DrawString(equipmentText, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
        //                linesSoFarHeading++;

        //                linesSoFarHeading++;
        //                g.DrawString("Gross Due: NZ $" + string.Format("{0:#,##0.00}", grossDue), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
        //                linesSoFarHeading++;
        //            }
        //        }
        //        grossDue = 0;
        //        serviceText = "";
        //        serviceTotal = 0;
        //        amountOfInvoicesPrinted++;
        //    }

        //    if (!(amountOfInvoicesPrinted == pagesAmountExpected))
        //    {
        //        e.HasMorePages = true;
        //    }
        //}


    }
}

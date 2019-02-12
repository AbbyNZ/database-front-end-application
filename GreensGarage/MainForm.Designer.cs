namespace GreensGarage
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnEquipmentAllocation = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnVehicleMaintenance = new System.Windows.Forms.Button();
            this.btnEquipmentMaintenance = new System.Windows.Forms.Button();
            this.btnServiceType = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnEquipmentAllocation);
            this.grpMaintenance.Controls.Add(this.btnService);
            this.grpMaintenance.Controls.Add(this.btnVehicleMaintenance);
            this.grpMaintenance.Controls.Add(this.btnEquipmentMaintenance);
            this.grpMaintenance.Controls.Add(this.btnServiceType);
            this.grpMaintenance.Controls.Add(this.btnOwner);
            this.grpMaintenance.Location = new System.Drawing.Point(39, 49);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(242, 392);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnEquipmentAllocation
            // 
            this.btnEquipmentAllocation.Location = new System.Drawing.Point(16, 337);
            this.btnEquipmentAllocation.Name = "btnEquipmentAllocation";
            this.btnEquipmentAllocation.Size = new System.Drawing.Size(187, 23);
            this.btnEquipmentAllocation.TabIndex = 5;
            this.btnEquipmentAllocation.Text = "Equipment Allocation";
            this.btnEquipmentAllocation.UseVisualStyleBackColor = true;
            this.btnEquipmentAllocation.Click += new System.EventHandler(this.btnEquipmentAllocation_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(16, 276);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(187, 23);
            this.btnService.TabIndex = 4;
            this.btnService.Text = "Service Maintenance";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnVehicleMaintenance
            // 
            this.btnVehicleMaintenance.Location = new System.Drawing.Point(16, 215);
            this.btnVehicleMaintenance.Name = "btnVehicleMaintenance";
            this.btnVehicleMaintenance.Size = new System.Drawing.Size(187, 23);
            this.btnVehicleMaintenance.TabIndex = 3;
            this.btnVehicleMaintenance.Text = "Vehicle Maintenance";
            this.btnVehicleMaintenance.UseVisualStyleBackColor = true;
            this.btnVehicleMaintenance.Click += new System.EventHandler(this.btnVehicleMaintenance_Click);
            // 
            // btnEquipmentMaintenance
            // 
            this.btnEquipmentMaintenance.Location = new System.Drawing.Point(16, 151);
            this.btnEquipmentMaintenance.Name = "btnEquipmentMaintenance";
            this.btnEquipmentMaintenance.Size = new System.Drawing.Size(187, 23);
            this.btnEquipmentMaintenance.TabIndex = 2;
            this.btnEquipmentMaintenance.Text = "Equipment Maintenance";
            this.btnEquipmentMaintenance.UseVisualStyleBackColor = true;
            this.btnEquipmentMaintenance.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnServiceType
            // 
            this.btnServiceType.Location = new System.Drawing.Point(16, 90);
            this.btnServiceType.Name = "btnServiceType";
            this.btnServiceType.Size = new System.Drawing.Size(187, 23);
            this.btnServiceType.TabIndex = 1;
            this.btnServiceType.Text = "Service Type Maintenance";
            this.btnServiceType.UseVisualStyleBackColor = true;
            this.btnServiceType.Click += new System.EventHandler(this.btnServiceType_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(16, 30);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(187, 23);
            this.btnOwner.TabIndex = 0;
            this.btnOwner.Text = "Owner Maintenance";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnInvoices);
            this.grpReport.Location = new System.Drawing.Point(328, 49);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(200, 392);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(39, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(39, 30);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(124, 23);
            this.btnInvoices.TabIndex = 0;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 533);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnEquipmentAllocation;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnVehicleMaintenance;
        private System.Windows.Forms.Button btnEquipmentMaintenance;
        private System.Windows.Forms.Button btnServiceType;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}


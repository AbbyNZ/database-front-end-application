namespace GreensGarage
{
    partial class ServiceForm
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
            this.components = new System.ComponentModel.Container();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.pnlAddService = new System.Windows.Forms.Panel();
            this.txtAddStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAddHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.cboAddServiceType = new System.Windows.Forms.ComboBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.cboAddVehicleID = new System.Windows.Forms.ComboBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveService = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.sERVICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMarkedService = new System.Windows.Forms.Button();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.pnlAddService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(490, 450);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(237, 411);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 23);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(339, 411);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(117, 23);
            this.btnUpdateService.TabIndex = 3;
            this.btnUpdateService.Text = "Modify Service";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(490, 411);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteService.TabIndex = 4;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // pnlAddService
            // 
            this.pnlAddService.Controls.Add(this.txtAddStatus);
            this.pnlAddService.Controls.Add(this.lblStatus);
            this.pnlAddService.Controls.Add(this.dtpServiceDate);
            this.pnlAddService.Controls.Add(this.lblDate);
            this.pnlAddService.Controls.Add(this.txtAddHours);
            this.pnlAddService.Controls.Add(this.lblHours);
            this.pnlAddService.Controls.Add(this.cboAddServiceType);
            this.pnlAddService.Controls.Add(this.lblServiceType);
            this.pnlAddService.Controls.Add(this.cboAddVehicleID);
            this.pnlAddService.Controls.Add(this.lblVehicleID);
            this.pnlAddService.Controls.Add(this.btnUpdate);
            this.pnlAddService.Controls.Add(this.btnSaveService);
            this.pnlAddService.Controls.Add(this.btnCancel);
            this.pnlAddService.Location = new System.Drawing.Point(610, 26);
            this.pnlAddService.Name = "pnlAddService";
            this.pnlAddService.Size = new System.Drawing.Size(305, 361);
            this.pnlAddService.TabIndex = 5;
            this.pnlAddService.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddService_Paint);
            // 
            // txtAddStatus
            // 
            this.txtAddStatus.Location = new System.Drawing.Point(80, 155);
            this.txtAddStatus.Name = "txtAddStatus";
            this.txtAddStatus.Size = new System.Drawing.Size(100, 20);
            this.txtAddStatus.TabIndex = 12;
            this.txtAddStatus.TextChanged += new System.EventHandler(this.txtAddStatus_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(36, 162);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Location = new System.Drawing.Point(80, 122);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpServiceDate.TabIndex = 10;
            this.dtpServiceDate.ValueChanged += new System.EventHandler(this.dtpServiceDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(41, 122);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date:";
            // 
            // txtAddHours
            // 
            this.txtAddHours.Location = new System.Drawing.Point(80, 80);
            this.txtAddHours.Name = "txtAddHours";
            this.txtAddHours.Size = new System.Drawing.Size(100, 20);
            this.txtAddHours.TabIndex = 8;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(38, 87);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(38, 13);
            this.lblHours.TabIndex = 7;
            this.lblHours.Text = "Hours:";
            // 
            // cboAddServiceType
            // 
            this.cboAddServiceType.FormattingEnabled = true;
            this.cboAddServiceType.Location = new System.Drawing.Point(80, 46);
            this.cboAddServiceType.Name = "cboAddServiceType";
            this.cboAddServiceType.Size = new System.Drawing.Size(121, 21);
            this.cboAddServiceType.TabIndex = 6;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(1, 55);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(73, 13);
            this.lblServiceType.TabIndex = 5;
            this.lblServiceType.Text = "Service Type:";
            // 
            // cboAddVehicleID
            // 
            this.cboAddVehicleID.FormattingEnabled = true;
            this.cboAddVehicleID.Location = new System.Drawing.Point(80, 13);
            this.cboAddVehicleID.Name = "cboAddVehicleID";
            this.cboAddVehicleID.Size = new System.Drawing.Size(121, 21);
            this.cboAddVehicleID.TabIndex = 4;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(15, 21);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(59, 13);
            this.lblVehicleID.TabIndex = 3;
            this.lblVehicleID.Text = "Vehicle ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(96, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Service";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSaveService
            // 
            this.btnSaveService.Location = new System.Drawing.Point(208, 310);
            this.btnSaveService.Name = "btnSaveService";
            this.btnSaveService.Size = new System.Drawing.Size(91, 23);
            this.btnSaveService.TabIndex = 1;
            this.btnSaveService.Text = "Save Service";
            this.btnSaveService.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(29, 411);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(134, 411);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMarkedService
            // 
            this.btnMarkedService.Location = new System.Drawing.Point(334, 450);
            this.btnMarkedService.Name = "btnMarkedService";
            this.btnMarkedService.Size = new System.Drawing.Size(126, 23);
            this.btnMarkedService.TabIndex = 9;
            this.btnMarkedService.Text = "Mark Service as Paid";
            this.btnMarkedService.UseVisualStyleBackColor = true;
            this.btnMarkedService.Click += new System.EventHandler(this.btnMarkedService_Click);
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(29, 26);
            this.dgvService.Name = "dgvService";
            this.dgvService.Size = new System.Drawing.Size(560, 361);
            this.dgvService.TabIndex = 10;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 485);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.btnMarkedService);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pnlAddService);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.btnReturn);
            this.Name = "ServiceForm";
            this.Text = "Service Maintenance";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.pnlAddService.ResumeLayout(false);
            this.pnlAddService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sERVICEBindingSource;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Panel pnlAddService;
        private System.Windows.Forms.Button btnSaveService;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboAddServiceType;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.ComboBox cboAddVehicleID;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtAddHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnMarkedService;
        private System.Windows.Forms.TextBox txtAddStatus;
        private System.Windows.Forms.DataGridView dgvService;
    }
}
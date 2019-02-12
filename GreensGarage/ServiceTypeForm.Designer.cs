namespace GreensGarage
{
    partial class ServiceTypeForm
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
            this.lstServiceType = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddServiceType = new System.Windows.Forms.Button();
            this.btnUpdateServiceType = new System.Windows.Forms.Button();
            this.btnDeleteServiceType = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblServiceTypeNo = new System.Windows.Forms.Label();
            this.lblServiceTypeID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.pnlAddServiceType = new System.Windows.Forms.Panel();
            this.btnSaveServiceType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAddHourlyRate = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.lblAddHourlyRate = new System.Windows.Forms.Label();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlAddServiceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstServiceType
            // 
            this.lstServiceType.FormattingEnabled = true;
            this.lstServiceType.Location = new System.Drawing.Point(24, 25);
            this.lstServiceType.Name = "lstServiceType";
            this.lstServiceType.Size = new System.Drawing.Size(173, 355);
            this.lstServiceType.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(24, 392);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(120, 392);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.Location = new System.Drawing.Point(215, 392);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(103, 23);
            this.btnAddServiceType.TabIndex = 3;
            this.btnAddServiceType.Text = "Add Service Type";
            this.btnAddServiceType.UseVisualStyleBackColor = true;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // btnUpdateServiceType
            // 
            this.btnUpdateServiceType.Location = new System.Drawing.Point(339, 392);
            this.btnUpdateServiceType.Name = "btnUpdateServiceType";
            this.btnUpdateServiceType.Size = new System.Drawing.Size(117, 23);
            this.btnUpdateServiceType.TabIndex = 4;
            this.btnUpdateServiceType.Text = "Modify Service Type";
            this.btnUpdateServiceType.UseVisualStyleBackColor = true;
            this.btnUpdateServiceType.Click += new System.EventHandler(this.btnUpdateServiceType_Click);
            // 
            // btnDeleteServiceType
            // 
            this.btnDeleteServiceType.Location = new System.Drawing.Point(467, 392);
            this.btnDeleteServiceType.Name = "btnDeleteServiceType";
            this.btnDeleteServiceType.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteServiceType.TabIndex = 5;
            this.btnDeleteServiceType.Text = "Delete Service Type";
            this.btnDeleteServiceType.UseVisualStyleBackColor = true;
            this.btnDeleteServiceType.Click += new System.EventHandler(this.btnDeleteServiceType_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(467, 432);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(114, 23);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblServiceTypeNo
            // 
            this.lblServiceTypeNo.AutoSize = true;
            this.lblServiceTypeNo.Location = new System.Drawing.Point(233, 25);
            this.lblServiceTypeNo.Name = "lblServiceTypeNo";
            this.lblServiceTypeNo.Size = new System.Drawing.Size(87, 13);
            this.lblServiceTypeNo.TabIndex = 7;
            this.lblServiceTypeNo.Text = "Service Type ID:";
            // 
            // lblServiceTypeID
            // 
            this.lblServiceTypeID.AutoSize = true;
            this.lblServiceTypeID.Location = new System.Drawing.Point(327, 24);
            this.lblServiceTypeID.Name = "lblServiceTypeID";
            this.lblServiceTypeID.Size = new System.Drawing.Size(70, 13);
            this.lblServiceTypeID.TabIndex = 8;
            this.lblServiceTypeID.Text = "Service Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(257, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(254, 88);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(66, 13);
            this.lblHourlyRate.TabIndex = 10;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(330, 56);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(330, 88);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyRate.TabIndex = 12;
            // 
            // pnlAddServiceType
            // 
            this.pnlAddServiceType.Controls.Add(this.btnUpdate);
            this.pnlAddServiceType.Controls.Add(this.btnSaveServiceType);
            this.pnlAddServiceType.Controls.Add(this.btnCancel);
            this.pnlAddServiceType.Controls.Add(this.txtAddHourlyRate);
            this.pnlAddServiceType.Controls.Add(this.txtAddDescription);
            this.pnlAddServiceType.Controls.Add(this.lblAddHourlyRate);
            this.pnlAddServiceType.Controls.Add(this.lblAddDescription);
            this.pnlAddServiceType.Location = new System.Drawing.Point(236, 124);
            this.pnlAddServiceType.Name = "pnlAddServiceType";
            this.pnlAddServiceType.Size = new System.Drawing.Size(361, 122);
            this.pnlAddServiceType.TabIndex = 13;
            this.pnlAddServiceType.Visible = false;
            // 
            // btnSaveServiceType
            // 
            this.btnSaveServiceType.Location = new System.Drawing.Point(237, 85);
            this.btnSaveServiceType.Name = "btnSaveServiceType";
            this.btnSaveServiceType.Size = new System.Drawing.Size(108, 23);
            this.btnSaveServiceType.TabIndex = 5;
            this.btnSaveServiceType.Text = "Save Service Type";
            this.btnSaveServiceType.UseVisualStyleBackColor = true;
            this.btnSaveServiceType.Click += new System.EventHandler(this.btnSaveServiceType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAddHourlyRate
            // 
            this.txtAddHourlyRate.Location = new System.Drawing.Point(94, 48);
            this.txtAddHourlyRate.Name = "txtAddHourlyRate";
            this.txtAddHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtAddHourlyRate.TabIndex = 3;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(94, 20);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(251, 20);
            this.txtAddDescription.TabIndex = 2;
            // 
            // lblAddHourlyRate
            // 
            this.lblAddHourlyRate.AutoSize = true;
            this.lblAddHourlyRate.Location = new System.Drawing.Point(16, 56);
            this.lblAddHourlyRate.Name = "lblAddHourlyRate";
            this.lblAddHourlyRate.Size = new System.Drawing.Size(66, 13);
            this.lblAddHourlyRate.TabIndex = 1;
            this.lblAddHourlyRate.Text = "Hourly Rate:";
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(21, 20);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(63, 13);
            this.lblAddDescription.TabIndex = 0;
            this.lblAddDescription.Text = "Description:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(97, 85);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Service Type";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ServiceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 470);
            this.Controls.Add(this.pnlAddServiceType);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblServiceTypeID);
            this.Controls.Add(this.lblServiceTypeNo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteServiceType);
            this.Controls.Add(this.btnUpdateServiceType);
            this.Controls.Add(this.btnAddServiceType);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstServiceType);
            this.Name = "ServiceTypeForm";
            this.Text = "Service Type Maintenance";
            this.pnlAddServiceType.ResumeLayout(false);
            this.pnlAddServiceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstServiceType;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddServiceType;
        private System.Windows.Forms.Button btnUpdateServiceType;
        private System.Windows.Forms.Button btnDeleteServiceType;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblServiceTypeNo;
        private System.Windows.Forms.Label lblServiceTypeID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Panel pnlAddServiceType;
        private System.Windows.Forms.TextBox txtAddHourlyRate;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddHourlyRate;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Button btnSaveServiceType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
    }
}
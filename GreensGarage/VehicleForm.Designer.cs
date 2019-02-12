namespace GreensGarage
{
    partial class VehicleForm
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
            this.lstVehicle = new System.Windows.Forms.ListBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnModifyVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddVehicle = new System.Windows.Forms.Panel();
            this.cboAddOwner = new System.Windows.Forms.ComboBox();
            this.lblAddOwner = new System.Windows.Forms.Label();
            this.txtAddModel = new System.Windows.Forms.TextBox();
            this.lblAddModel = new System.Windows.Forms.Label();
            this.txtAddMake = new System.Windows.Forms.TextBox();
            this.lblAddMake = new System.Windows.Forms.Label();
            this.txtAddPlateNumber = new System.Windows.Forms.TextBox();
            this.lblAddPlateNumber = new System.Windows.Forms.Label();
            this.btnSaveVehicle = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlAddVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVehicle
            // 
            this.lstVehicle.FormattingEnabled = true;
            this.lstVehicle.Location = new System.Drawing.Point(12, 18);
            this.lstVehicle.Name = "lstVehicle";
            this.lstVehicle.Size = new System.Drawing.Size(182, 368);
            this.lstVehicle.TabIndex = 0;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(203, 417);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(85, 23);
            this.btnAddVehicle.TabIndex = 1;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnModifyVehicle
            // 
            this.btnModifyVehicle.Location = new System.Drawing.Point(306, 417);
            this.btnModifyVehicle.Name = "btnModifyVehicle";
            this.btnModifyVehicle.Size = new System.Drawing.Size(101, 23);
            this.btnModifyVehicle.TabIndex = 2;
            this.btnModifyVehicle.Text = "Modify Vehicle";
            this.btnModifyVehicle.UseVisualStyleBackColor = true;
            this.btnModifyVehicle.Click += new System.EventHandler(this.btnModifyVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(424, 417);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteVehicle.TabIndex = 3;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Location = new System.Drawing.Point(224, 25);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(59, 13);
            this.lblVehicleNo.TabIndex = 4;
            this.lblVehicleNo.Text = "Vehicle ID:";
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(209, 58);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(74, 13);
            this.lblPlateNumber.TabIndex = 6;
            this.lblPlateNumber.Text = "Plate Number:";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(289, 51);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPlateNumber.TabIndex = 7;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(248, 94);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 8;
            this.lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(289, 86);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 9;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(249, 132);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(289, 125);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 11;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(242, 162);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(41, 13);
            this.lblOwner.TabIndex = 12;
            this.lblOwner.Text = "Owner:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(429, 451);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(96, 23);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddVehicle
            // 
            this.pnlAddVehicle.Controls.Add(this.cboAddOwner);
            this.pnlAddVehicle.Controls.Add(this.lblAddOwner);
            this.pnlAddVehicle.Controls.Add(this.txtAddModel);
            this.pnlAddVehicle.Controls.Add(this.lblAddModel);
            this.pnlAddVehicle.Controls.Add(this.txtAddMake);
            this.pnlAddVehicle.Controls.Add(this.lblAddMake);
            this.pnlAddVehicle.Controls.Add(this.txtAddPlateNumber);
            this.pnlAddVehicle.Controls.Add(this.lblAddPlateNumber);
            this.pnlAddVehicle.Controls.Add(this.btnSaveVehicle);
            this.pnlAddVehicle.Controls.Add(this.btnUpdateVehicle);
            this.pnlAddVehicle.Controls.Add(this.btnCancel);
            this.pnlAddVehicle.Location = new System.Drawing.Point(203, 185);
            this.pnlAddVehicle.Name = "pnlAddVehicle";
            this.pnlAddVehicle.Size = new System.Drawing.Size(334, 219);
            this.pnlAddVehicle.TabIndex = 15;
            // 
            // cboAddOwner
            // 
            this.cboAddOwner.FormattingEnabled = true;
            this.cboAddOwner.Location = new System.Drawing.Point(94, 111);
            this.cboAddOwner.Name = "cboAddOwner";
            this.cboAddOwner.Size = new System.Drawing.Size(155, 21);
            this.cboAddOwner.TabIndex = 10;
            // 
            // lblAddOwner
            // 
            this.lblAddOwner.AutoSize = true;
            this.lblAddOwner.Location = new System.Drawing.Point(48, 114);
            this.lblAddOwner.Name = "lblAddOwner";
            this.lblAddOwner.Size = new System.Drawing.Size(41, 13);
            this.lblAddOwner.TabIndex = 9;
            this.lblAddOwner.Text = "Owner:";
            // 
            // txtAddModel
            // 
            this.txtAddModel.Location = new System.Drawing.Point(94, 83);
            this.txtAddModel.Name = "txtAddModel";
            this.txtAddModel.Size = new System.Drawing.Size(100, 20);
            this.txtAddModel.TabIndex = 8;
            // 
            // lblAddModel
            // 
            this.lblAddModel.AutoSize = true;
            this.lblAddModel.Location = new System.Drawing.Point(53, 83);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(39, 13);
            this.lblAddModel.TabIndex = 7;
            this.lblAddModel.Text = "Model:";
            // 
            // txtAddMake
            // 
            this.txtAddMake.Location = new System.Drawing.Point(94, 43);
            this.txtAddMake.Name = "txtAddMake";
            this.txtAddMake.Size = new System.Drawing.Size(100, 20);
            this.txtAddMake.TabIndex = 6;
            // 
            // lblAddMake
            // 
            this.lblAddMake.AutoSize = true;
            this.lblAddMake.Location = new System.Drawing.Point(52, 54);
            this.lblAddMake.Name = "lblAddMake";
            this.lblAddMake.Size = new System.Drawing.Size(37, 13);
            this.lblAddMake.TabIndex = 5;
            this.lblAddMake.Text = "Make:";
            // 
            // txtAddPlateNumber
            // 
            this.txtAddPlateNumber.Location = new System.Drawing.Point(94, 17);
            this.txtAddPlateNumber.Name = "txtAddPlateNumber";
            this.txtAddPlateNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAddPlateNumber.TabIndex = 4;
            // 
            // lblAddPlateNumber
            // 
            this.lblAddPlateNumber.AutoSize = true;
            this.lblAddPlateNumber.Location = new System.Drawing.Point(15, 24);
            this.lblAddPlateNumber.Name = "lblAddPlateNumber";
            this.lblAddPlateNumber.Size = new System.Drawing.Size(74, 13);
            this.lblAddPlateNumber.TabIndex = 3;
            this.lblAddPlateNumber.Text = "Plate Number:";
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Location = new System.Drawing.Point(217, 164);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(80, 23);
            this.btnSaveVehicle.TabIndex = 2;
            this.btnSaveVehicle.Text = "Save Vehicle";
            this.btnSaveVehicle.UseVisualStyleBackColor = true;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Location = new System.Drawing.Point(105, 164);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(90, 23);
            this.btnUpdateVehicle.TabIndex = 1;
            this.btnUpdateVehicle.Text = "Update Vehicle";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(289, 159);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(173, 20);
            this.txtOwnerID.TabIndex = 16;
            this.txtOwnerID.TextChanged += new System.EventHandler(this.txtOwnerID_TextChanged);
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(286, 25);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(53, 13);
            this.lblVehicleID.TabIndex = 17;
            this.lblVehicleID.Text = "VehicleID";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 417);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 18;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(108, 417);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 484);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.pnlAddVehicle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.lblVehicleNo);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnModifyVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.lstVehicle);
            this.Name = "VehicleForm";
            this.Text = "Vehicle Maintenance";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            this.pnlAddVehicle.ResumeLayout(false);
            this.pnlAddVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVehicle;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnModifyVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddVehicle;
        private System.Windows.Forms.Button btnSaveVehicle;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboAddOwner;
        private System.Windows.Forms.Label lblAddOwner;
        private System.Windows.Forms.TextBox txtAddModel;
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.TextBox txtAddMake;
        private System.Windows.Forms.Label lblAddMake;
        private System.Windows.Forms.TextBox txtAddPlateNumber;
        private System.Windows.Forms.Label lblAddPlateNumber;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}
namespace GreensGarage
{
    partial class EquipmentForm
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
            this.lstEquipment = new System.Windows.Forms.ListBox();
            this.lblEquipmentNo = new System.Windows.Forms.Label();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnUpdateEquipment = new System.Windows.Forms.Button();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddEquipment = new System.Windows.Forms.Panel();
            this.btnSaveEquipment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.pnlUpdateEquipment = new System.Windows.Forms.Panel();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.pnlAddEquipment.SuspendLayout();
            this.pnlUpdateEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEquipment
            // 
            this.lstEquipment.FormattingEnabled = true;
            this.lstEquipment.Location = new System.Drawing.Point(30, 39);
            this.lstEquipment.Name = "lstEquipment";
            this.lstEquipment.Size = new System.Drawing.Size(220, 329);
            this.lstEquipment.TabIndex = 0;
            this.lstEquipment.SelectedIndexChanged += new System.EventHandler(this.lstEquipment_SelectedIndexChanged);
            // 
            // lblEquipmentNo
            // 
            this.lblEquipmentNo.AutoSize = true;
            this.lblEquipmentNo.Location = new System.Drawing.Point(281, 39);
            this.lblEquipmentNo.Name = "lblEquipmentNo";
            this.lblEquipmentNo.Size = new System.Drawing.Size(74, 13);
            this.lblEquipmentNo.TabIndex = 1;
            this.lblEquipmentNo.Text = "Equipment ID:";
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Location = new System.Drawing.Point(362, 39);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(57, 13);
            this.lblEquipmentID.TabIndex = 2;
            this.lblEquipmentID.Text = "Equipment";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(292, 71);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(365, 71);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(181, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(30, 396);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(133, 396);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(233, 396);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(93, 23);
            this.btnAddEquipment.TabIndex = 7;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnUpdateEquipment
            // 
            this.btnUpdateEquipment.Location = new System.Drawing.Point(348, 396);
            this.btnUpdateEquipment.Name = "btnUpdateEquipment";
            this.btnUpdateEquipment.Size = new System.Drawing.Size(104, 23);
            this.btnUpdateEquipment.TabIndex = 8;
            this.btnUpdateEquipment.Text = "Modify Equipment";
            this.btnUpdateEquipment.UseVisualStyleBackColor = true;
            this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdateEquipment_Click);
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Location = new System.Drawing.Point(473, 396);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteEquipment.TabIndex = 9;
            this.btnDeleteEquipment.Text = "Delete Equipment";
            this.btnDeleteEquipment.UseVisualStyleBackColor = true;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(473, 443);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddEquipment
            // 
            this.pnlAddEquipment.Controls.Add(this.btnSaveEquipment);
            this.pnlAddEquipment.Controls.Add(this.btnCancel);
            this.pnlAddEquipment.Controls.Add(this.txtAddDescription);
            this.pnlAddEquipment.Controls.Add(this.lblAddDescription);
            this.pnlAddEquipment.Location = new System.Drawing.Point(284, 242);
            this.pnlAddEquipment.Name = "pnlAddEquipment";
            this.pnlAddEquipment.Size = new System.Drawing.Size(291, 126);
            this.pnlAddEquipment.TabIndex = 11;
            this.pnlAddEquipment.Visible = false;
            // 
            // btnSaveEquipment
            // 
            this.btnSaveEquipment.Location = new System.Drawing.Point(152, 82);
            this.btnSaveEquipment.Name = "btnSaveEquipment";
            this.btnSaveEquipment.Size = new System.Drawing.Size(98, 23);
            this.btnSaveEquipment.TabIndex = 3;
            this.btnSaveEquipment.Text = "Save Equipment";
            this.btnSaveEquipment.UseVisualStyleBackColor = true;
            this.btnSaveEquipment.Click += new System.EventHandler(this.btnSaveEquipment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(35, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(81, 16);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(181, 20);
            this.txtAddDescription.TabIndex = 1;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(11, 23);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(63, 13);
            this.lblAddDescription.TabIndex = 0;
            this.lblAddDescription.Text = "Description:";
            // 
            // pnlUpdateEquipment
            // 
            this.pnlUpdateEquipment.Controls.Add(this.txtUpdateDescription);
            this.pnlUpdateEquipment.Controls.Add(this.lblUpdateDescription);
            this.pnlUpdateEquipment.Controls.Add(this.btnUpdate);
            this.pnlUpdateEquipment.Controls.Add(this.btnCancel2);
            this.pnlUpdateEquipment.Location = new System.Drawing.Point(284, 114);
            this.pnlUpdateEquipment.Name = "pnlUpdateEquipment";
            this.pnlUpdateEquipment.Size = new System.Drawing.Size(291, 112);
            this.pnlUpdateEquipment.TabIndex = 12;
            this.pnlUpdateEquipment.Visible = false;
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(81, 18);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(181, 20);
            this.txtUpdateDescription.TabIndex = 3;
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(12, 18);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(63, 13);
            this.lblUpdateDescription.TabIndex = 2;
            this.lblUpdateDescription.Text = "Description:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(145, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Equipment";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(35, 72);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 0;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 484);
            this.Controls.Add(this.pnlUpdateEquipment);
            this.Controls.Add(this.pnlAddEquipment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnUpdateEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEquipmentID);
            this.Controls.Add(this.lblEquipmentNo);
            this.Controls.Add(this.lstEquipment);
            this.Name = "EquipmentForm";
            this.Text = "Equipment Maintenance";
            this.pnlAddEquipment.ResumeLayout(false);
            this.pnlAddEquipment.PerformLayout();
            this.pnlUpdateEquipment.ResumeLayout(false);
            this.pnlUpdateEquipment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEquipment;
        private System.Windows.Forms.Label lblEquipmentNo;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnUpdateEquipment;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddEquipment;
        private System.Windows.Forms.Button btnSaveEquipment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Panel pnlUpdateEquipment;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel2;
    }
}
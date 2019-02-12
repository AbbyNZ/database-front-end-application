namespace GreensGarage
{
    partial class OwnerForm
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
            this.lstOwner = new System.Windows.Forms.ListBox();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.btnUpdateOwner = new System.Windows.Forms.Button();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblOwnerNo = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblStreetAdd = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.pnlAddOwner = new System.Windows.Forms.Panel();
            this.txtAddPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddSuburb = new System.Windows.Forms.TextBox();
            this.txtAddStreetAddress = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.btnSaveOwner = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddSuburb = new System.Windows.Forms.Label();
            this.lblAddStreetAddress = new System.Windows.Forms.Label();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.lblAddLastName = new System.Windows.Forms.Label();
            this.pnlUpdateOwner = new System.Windows.Forms.Panel();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.lblUpdateFirstName = new System.Windows.Forms.Label();
            this.lblUpdateStreetAdress = new System.Windows.Forms.Label();
            this.lblUpdateSuburb = new System.Windows.Forms.Label();
            this.lblUpdatePhoneNumber = new System.Windows.Forms.Label();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdateStreetAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateSuburb = new System.Windows.Forms.TextBox();
            this.txtUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlAddOwner.SuspendLayout();
            this.pnlUpdateOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOwner
            // 
            this.lstOwner.FormattingEnabled = true;
            this.lstOwner.Location = new System.Drawing.Point(13, 29);
            this.lstOwner.Name = "lstOwner";
            this.lstOwner.Size = new System.Drawing.Size(145, 342);
            this.lstOwner.TabIndex = 0;
            this.lstOwner.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(243, 462);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(100, 23);
            this.btnAddOwner.TabIndex = 1;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Location = new System.Drawing.Point(358, 462);
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.Size = new System.Drawing.Size(93, 23);
            this.btnUpdateOwner.TabIndex = 2;
            this.btnUpdateOwner.Text = "Update Owner";
            this.btnUpdateOwner.UseVisualStyleBackColor = true;
            this.btnUpdateOwner.Click += new System.EventHandler(this.btnUpdateOwner_Click);
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(461, 462);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(84, 23);
            this.btnDeleteOwner.TabIndex = 3;
            this.btnDeleteOwner.Text = "Delete Owner";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(461, 507);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(84, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblOwnerNo
            // 
            this.lblOwnerNo.AutoSize = true;
            this.lblOwnerNo.Location = new System.Drawing.Point(198, 29);
            this.lblOwnerNo.Name = "lblOwnerNo";
            this.lblOwnerNo.Size = new System.Drawing.Size(55, 13);
            this.lblOwnerNo.TabIndex = 5;
            this.lblOwnerNo.Text = "Owner ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(192, 59);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(270, 59);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(193, 95);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(270, 92);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // lblStreetAdd
            // 
            this.lblStreetAdd.AutoSize = true;
            this.lblStreetAdd.Location = new System.Drawing.Point(178, 129);
            this.lblStreetAdd.Name = "lblStreetAdd";
            this.lblStreetAdd.Size = new System.Drawing.Size(79, 13);
            this.lblStreetAdd.TabIndex = 11;
            this.lblStreetAdd.Text = "Street Address:";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(270, 126);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(275, 20);
            this.txtStreetAddress.TabIndex = 12;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(213, 161);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(44, 13);
            this.lblSuburb.TabIndex = 13;
            this.lblSuburb.Text = "Suburb:";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(270, 161);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(128, 20);
            this.txtSuburb.TabIndex = 14;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(172, 197);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 15;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(270, 197);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(128, 20);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(13, 462);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(94, 23);
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(130, 462);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(267, 29);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(23, 13);
            this.lblOwnerID.TabIndex = 19;
            this.lblOwnerID.Text = "null";
            // 
            // pnlAddOwner
            // 
            this.pnlAddOwner.Controls.Add(this.txtAddPhoneNumber);
            this.pnlAddOwner.Controls.Add(this.txtAddSuburb);
            this.pnlAddOwner.Controls.Add(this.txtAddStreetAddress);
            this.pnlAddOwner.Controls.Add(this.txtAddFirstName);
            this.pnlAddOwner.Controls.Add(this.txtAddLastName);
            this.pnlAddOwner.Controls.Add(this.btnSaveOwner);
            this.pnlAddOwner.Controls.Add(this.btnCancel);
            this.pnlAddOwner.Controls.Add(this.lblAddPhoneNumber);
            this.pnlAddOwner.Controls.Add(this.lblAddSuburb);
            this.pnlAddOwner.Controls.Add(this.lblAddStreetAddress);
            this.pnlAddOwner.Controls.Add(this.lblAddFirstName);
            this.pnlAddOwner.Controls.Add(this.lblAddLastName);
            this.pnlAddOwner.Location = new System.Drawing.Point(164, 264);
            this.pnlAddOwner.Name = "pnlAddOwner";
            this.pnlAddOwner.Size = new System.Drawing.Size(400, 192);
            this.pnlAddOwner.TabIndex = 20;
            this.pnlAddOwner.Visible = false;
            // 
            // txtAddPhoneNumber
            // 
            this.txtAddPhoneNumber.Location = new System.Drawing.Point(106, 121);
            this.txtAddPhoneNumber.Name = "txtAddPhoneNumber";
            this.txtAddPhoneNumber.Size = new System.Drawing.Size(128, 20);
            this.txtAddPhoneNumber.TabIndex = 11;
            // 
            // txtAddSuburb
            // 
            this.txtAddSuburb.Location = new System.Drawing.Point(106, 94);
            this.txtAddSuburb.Name = "txtAddSuburb";
            this.txtAddSuburb.Size = new System.Drawing.Size(128, 20);
            this.txtAddSuburb.TabIndex = 10;
            // 
            // txtAddStreetAddress
            // 
            this.txtAddStreetAddress.Location = new System.Drawing.Point(106, 69);
            this.txtAddStreetAddress.Name = "txtAddStreetAddress";
            this.txtAddStreetAddress.Size = new System.Drawing.Size(272, 20);
            this.txtAddStreetAddress.TabIndex = 9;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(106, 41);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtAddFirstName.TabIndex = 8;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(106, 14);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(100, 20);
            this.txtAddLastName.TabIndex = 7;
            // 
            // btnSaveOwner
            // 
            this.btnSaveOwner.Location = new System.Drawing.Point(255, 153);
            this.btnSaveOwner.Name = "btnSaveOwner";
            this.btnSaveOwner.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOwner.TabIndex = 6;
            this.btnSaveOwner.Text = "Save Owner";
            this.btnSaveOwner.UseVisualStyleBackColor = true;
            this.btnSaveOwner.Click += new System.EventHandler(this.btnSaveOwner_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(131, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddPhoneNumber
            // 
            this.lblAddPhoneNumber.AutoSize = true;
            this.lblAddPhoneNumber.Location = new System.Drawing.Point(8, 121);
            this.lblAddPhoneNumber.Name = "lblAddPhoneNumber";
            this.lblAddPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblAddPhoneNumber.TabIndex = 4;
            this.lblAddPhoneNumber.Text = "Phone Number:";
            // 
            // lblAddSuburb
            // 
            this.lblAddSuburb.AutoSize = true;
            this.lblAddSuburb.Location = new System.Drawing.Point(45, 94);
            this.lblAddSuburb.Name = "lblAddSuburb";
            this.lblAddSuburb.Size = new System.Drawing.Size(44, 13);
            this.lblAddSuburb.TabIndex = 3;
            this.lblAddSuburb.Text = "Suburb:";
            // 
            // lblAddStreetAddress
            // 
            this.lblAddStreetAddress.AutoSize = true;
            this.lblAddStreetAddress.Location = new System.Drawing.Point(10, 69);
            this.lblAddStreetAddress.Name = "lblAddStreetAddress";
            this.lblAddStreetAddress.Size = new System.Drawing.Size(79, 13);
            this.lblAddStreetAddress.TabIndex = 2;
            this.lblAddStreetAddress.Text = "Street Address:";
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Location = new System.Drawing.Point(29, 41);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblAddFirstName.TabIndex = 1;
            this.lblAddFirstName.Text = "First Name:";
            // 
            // lblAddLastName
            // 
            this.lblAddLastName.AutoSize = true;
            this.lblAddLastName.Location = new System.Drawing.Point(28, 14);
            this.lblAddLastName.Name = "lblAddLastName";
            this.lblAddLastName.Size = new System.Drawing.Size(61, 13);
            this.lblAddLastName.TabIndex = 0;
            this.lblAddLastName.Text = "Last Name:";
            // 
            // pnlUpdateOwner
            // 
            this.pnlUpdateOwner.Controls.Add(this.btnUpdate);
            this.pnlUpdateOwner.Controls.Add(this.btnCancel2);
            this.pnlUpdateOwner.Controls.Add(this.txtUpdatePhoneNumber);
            this.pnlUpdateOwner.Controls.Add(this.txtUpdateSuburb);
            this.pnlUpdateOwner.Controls.Add(this.txtUpdateStreetAddress);
            this.pnlUpdateOwner.Controls.Add(this.txtUpdateFirstName);
            this.pnlUpdateOwner.Controls.Add(this.txtUpdateLastName);
            this.pnlUpdateOwner.Controls.Add(this.lblUpdatePhoneNumber);
            this.pnlUpdateOwner.Controls.Add(this.lblUpdateSuburb);
            this.pnlUpdateOwner.Controls.Add(this.lblUpdateStreetAdress);
            this.pnlUpdateOwner.Controls.Add(this.lblUpdateFirstName);
            this.pnlUpdateOwner.Controls.Add(this.lblUpdateLastName);
            this.pnlUpdateOwner.Location = new System.Drawing.Point(164, 29);
            this.pnlUpdateOwner.Name = "pnlUpdateOwner";
            this.pnlUpdateOwner.Size = new System.Drawing.Size(400, 200);
            this.pnlUpdateOwner.TabIndex = 12;
            this.pnlUpdateOwner.Visible = false;
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Location = new System.Drawing.Point(28, 17);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(61, 13);
            this.lblUpdateLastName.TabIndex = 0;
            this.lblUpdateLastName.Text = "Last Name:";
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.AutoSize = true;
            this.lblUpdateFirstName.Location = new System.Drawing.Point(29, 46);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblUpdateFirstName.TabIndex = 1;
            this.lblUpdateFirstName.Text = "First Name:";
            // 
            // lblUpdateStreetAdress
            // 
            this.lblUpdateStreetAdress.AutoSize = true;
            this.lblUpdateStreetAdress.Location = new System.Drawing.Point(10, 76);
            this.lblUpdateStreetAdress.Name = "lblUpdateStreetAdress";
            this.lblUpdateStreetAdress.Size = new System.Drawing.Size(79, 13);
            this.lblUpdateStreetAdress.TabIndex = 2;
            this.lblUpdateStreetAdress.Text = "Street Address:";
            // 
            // lblUpdateSuburb
            // 
            this.lblUpdateSuburb.AutoSize = true;
            this.lblUpdateSuburb.Location = new System.Drawing.Point(45, 105);
            this.lblUpdateSuburb.Name = "lblUpdateSuburb";
            this.lblUpdateSuburb.Size = new System.Drawing.Size(44, 13);
            this.lblUpdateSuburb.TabIndex = 3;
            this.lblUpdateSuburb.Text = "Suburb:";
            // 
            // lblUpdatePhoneNumber
            // 
            this.lblUpdatePhoneNumber.AutoSize = true;
            this.lblUpdatePhoneNumber.Location = new System.Drawing.Point(8, 135);
            this.lblUpdatePhoneNumber.Name = "lblUpdatePhoneNumber";
            this.lblUpdatePhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblUpdatePhoneNumber.TabIndex = 4;
            this.lblUpdatePhoneNumber.Text = "Phone Number:";
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(106, 17);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateLastName.TabIndex = 5;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(106, 46);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateFirstName.TabIndex = 6;
            // 
            // txtUpdateStreetAddress
            // 
            this.txtUpdateStreetAddress.Location = new System.Drawing.Point(106, 76);
            this.txtUpdateStreetAddress.Name = "txtUpdateStreetAddress";
            this.txtUpdateStreetAddress.Size = new System.Drawing.Size(275, 20);
            this.txtUpdateStreetAddress.TabIndex = 7;
            // 
            // txtUpdateSuburb
            // 
            this.txtUpdateSuburb.Location = new System.Drawing.Point(106, 105);
            this.txtUpdateSuburb.Name = "txtUpdateSuburb";
            this.txtUpdateSuburb.Size = new System.Drawing.Size(128, 20);
            this.txtUpdateSuburb.TabIndex = 8;
            // 
            // txtUpdatePhoneNumber
            // 
            this.txtUpdatePhoneNumber.Location = new System.Drawing.Point(106, 131);
            this.txtUpdatePhoneNumber.Name = "txtUpdatePhoneNumber";
            this.txtUpdatePhoneNumber.Size = new System.Drawing.Size(128, 20);
            this.txtUpdatePhoneNumber.TabIndex = 9;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(131, 168);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 10;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(255, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Owner";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 542);
            this.Controls.Add(this.pnlUpdateOwner);
            this.Controls.Add(this.pnlAddOwner);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.lblStreetAdd);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblOwnerNo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteOwner);
            this.Controls.Add(this.btnUpdateOwner);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.lstOwner);
            this.Name = "OwnerForm";
            this.Text = "Owner Maintenance";
            this.pnlAddOwner.ResumeLayout(false);
            this.pnlAddOwner.PerformLayout();
            this.pnlUpdateOwner.ResumeLayout(false);
            this.pnlUpdateOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOwner;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Button btnUpdateOwner;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblOwnerNo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblStreetAdd;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Panel pnlAddOwner;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.Label lblAddLastName;
        private System.Windows.Forms.Label lblAddPhoneNumber;
        private System.Windows.Forms.Label lblAddSuburb;
        private System.Windows.Forms.Label lblAddStreetAddress;
        private System.Windows.Forms.Button btnSaveOwner;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAddPhoneNumber;
        private System.Windows.Forms.TextBox txtAddSuburb;
        private System.Windows.Forms.TextBox txtAddStreetAddress;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Panel pnlUpdateOwner;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.TextBox txtUpdatePhoneNumber;
        private System.Windows.Forms.TextBox txtUpdateSuburb;
        private System.Windows.Forms.TextBox txtUpdateStreetAddress;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label lblUpdatePhoneNumber;
        private System.Windows.Forms.Label lblUpdateSuburb;
        private System.Windows.Forms.Label lblUpdateStreetAdress;
        private System.Windows.Forms.Label lblUpdateFirstName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel2;
    }
}
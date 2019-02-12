namespace GreensGarage
{
    partial class AllocationForm
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
            this.dgvServiceType = new System.Windows.Forms.DataGridView();
            this.dgvServiceTypeEquipment = new System.Windows.Forms.DataGridView();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypeEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServiceType
            // 
            this.dgvServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceType.Location = new System.Drawing.Point(35, 34);
            this.dgvServiceType.Name = "dgvServiceType";
            this.dgvServiceType.Size = new System.Drawing.Size(342, 196);
            this.dgvServiceType.TabIndex = 0;
            // 
            // dgvServiceTypeEquipment
            // 
            this.dgvServiceTypeEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceTypeEquipment.Location = new System.Drawing.Point(412, 264);
            this.dgvServiceTypeEquipment.Name = "dgvServiceTypeEquipment";
            this.dgvServiceTypeEquipment.Size = new System.Drawing.Size(257, 181);
            this.dgvServiceTypeEquipment.TabIndex = 1;
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Location = new System.Drawing.Point(412, 34);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.Size = new System.Drawing.Size(258, 196);
            this.dgvEquipment.TabIndex = 2;
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(99, 288);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(143, 23);
            this.btnAllocate.TabIndex = 3;
            this.btnAllocate.Text = "Allocate Equipment";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(99, 346);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Equipment";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(99, 422);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(143, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // AllocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 480);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.dgvEquipment);
            this.Controls.Add(this.dgvServiceTypeEquipment);
            this.Controls.Add(this.dgvServiceType);
            this.Name = "AllocationForm";
            this.Text = "Equipment Allocation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypeEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServiceType;
        private System.Windows.Forms.DataGridView dgvServiceTypeEquipment;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReturn;
    }
}
namespace GreensGarage
{
    partial class ServiceMaintenaceForm2
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
            this.dgvServiceMaintanance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceMaintanance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServiceMaintanance
            // 
            this.dgvServiceMaintanance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceMaintanance.Location = new System.Drawing.Point(23, 30);
            this.dgvServiceMaintanance.Name = "dgvServiceMaintanance";
            this.dgvServiceMaintanance.Size = new System.Drawing.Size(350, 278);
            this.dgvServiceMaintanance.TabIndex = 0;
            // 
            // ServiceMaintenaceForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 493);
            this.Controls.Add(this.dgvServiceMaintanance);
            this.Name = "ServiceMaintenaceForm2";
            this.Text = "Service Maintenance";
            this.Load += new System.EventHandler(this.ServiceMaintenaceForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceMaintanance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServiceMaintanance;
    }
}
namespace GreensGarage
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.txtInvoices = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printService = new System.Drawing.Printing.PrintDocument();
            this.previewService = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // txtInvoices
            // 
            this.txtInvoices.Location = new System.Drawing.Point(12, 24);
            this.txtInvoices.Multiline = true;
            this.txtInvoices.Name = "txtInvoices";
            this.txtInvoices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInvoices.Size = new System.Drawing.Size(633, 341);
            this.txtInvoices.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(410, 386);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(94, 23);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display Report";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(523, 386);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(523, 431);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // previewService
            // 
            this.previewService.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previewService.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previewService.ClientSize = new System.Drawing.Size(400, 300);
            this.previewService.Document = this.printService;
            this.previewService.Enabled = true;
            this.previewService.Icon = ((System.Drawing.Icon)(resources.GetObject("previewService.Icon")));
            this.previewService.Name = "previewService";
            this.previewService.Visible = false;
            this.previewService.Load += new System.EventHandler(this.previewService_Load);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 466);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtInvoices);
            this.Name = "InvoiceForm";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoices;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printService;
        private System.Windows.Forms.PrintPreviewDialog previewService;
    }
}
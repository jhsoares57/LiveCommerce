namespace LiveCommerce.View.Impressao
{
    partial class FrmImprimirVenda
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
            this.rptImprimeVenda = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptImprimeVenda
            // 
            this.rptImprimeVenda.Location = new System.Drawing.Point(12, 12);
            this.rptImprimeVenda.Name = "rptImprimeVenda";
            this.rptImprimeVenda.ServerReport.BearerToken = null;
            this.rptImprimeVenda.Size = new System.Drawing.Size(776, 426);
            this.rptImprimeVenda.TabIndex = 1;
            this.rptImprimeVenda.Load += new System.EventHandler(this.rptImprimeVenda_Load);
            // 
            // FrmImprimirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptImprimeVenda);
            this.Name = "FrmImprimirVenda";
            this.Text = "FrmImprimirVenda";
            this.Load += new System.EventHandler(this.FrmImprimirVenda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptImprimeVenda;
    }
}
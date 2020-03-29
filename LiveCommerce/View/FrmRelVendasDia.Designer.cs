namespace LiveCommerce.View
{
    partial class FrmRelVendasDia
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
            this.rptVendasDia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptVendasDia
            // 
            this.rptVendasDia.Location = new System.Drawing.Point(12, 12);
            this.rptVendasDia.Name = "rptVendasDia";
            this.rptVendasDia.ServerReport.BearerToken = null;
            this.rptVendasDia.Size = new System.Drawing.Size(776, 426);
            this.rptVendasDia.TabIndex = 0;
            this.rptVendasDia.Load += new System.EventHandler(this.rptVendasDia_Load);
            // 
            // FrmRelVendasDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptVendasDia);
            this.Name = "FrmRelVendasDia";
            this.Load += new System.EventHandler(this.FrmRelVendasDia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVendasDia;
    }
}
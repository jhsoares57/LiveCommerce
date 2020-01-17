namespace LiveCommerce.View
{
    partial class FrmRelVendasFormaPagamento
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
            this.rptVendasFormaPagamento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptVendasFormaPagamento
            // 
            this.rptVendasFormaPagamento.Location = new System.Drawing.Point(13, 13);
            this.rptVendasFormaPagamento.Name = "rptVendasFormaPagamento";
            this.rptVendasFormaPagamento.ServerReport.BearerToken = null;
            this.rptVendasFormaPagamento.Size = new System.Drawing.Size(677, 340);
            this.rptVendasFormaPagamento.TabIndex = 0;
            this.rptVendasFormaPagamento.Load += new System.EventHandler(this.rptVendasFormaPagamento_Load);
            // 
            // FrmRelVendasFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 365);
            this.Controls.Add(this.rptVendasFormaPagamento);
            this.Name = "FrmRelVendasFormaPagamento";
            this.Text = "FrmRelVendasFormaPagamento";
            this.Load += new System.EventHandler(this.FrmRelVendasFormaPagamento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVendasFormaPagamento;
    }
}
namespace LiveCommerce.View
{
    partial class FrmRelatorioProdutos
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
            this.rptProdutos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptProdutos
            // 
            this.rptProdutos.Location = new System.Drawing.Point(3, 12);
            this.rptProdutos.Name = "rptProdutos";
            this.rptProdutos.ServerReport.BearerToken = null;
            this.rptProdutos.Size = new System.Drawing.Size(754, 426);
            this.rptProdutos.TabIndex = 0;
            this.rptProdutos.Load += new System.EventHandler(this.rptProdutos_Load);
            // 
            // FrmRelatorioProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.rptProdutos);
            this.Name = "FrmRelatorioProdutos";
            this.Text = "FrmRelatorioProdutos";
            this.Load += new System.EventHandler(this.FrmRelatorioProdutos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptProdutos;
    }
}
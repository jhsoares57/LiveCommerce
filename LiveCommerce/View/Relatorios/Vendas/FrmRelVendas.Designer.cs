namespace LiveCommerce.View.Relatorios.Vendas
{
    partial class FrmRelVendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelVendas));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRelatorios = new LiveCommerce.Relatorios.dsRelatorios();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureSair = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDtInicial = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDtFinal = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vENDATableAdapter = new LiveCommerce.Relatorios.dsRelatoriosTableAdapters.VENDATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vENDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSair)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vENDABindingSource
            // 
            this.vENDABindingSource.DataMember = "VENDA";
            this.vENDABindingSource.DataSource = this.dsRelatorios;
            // 
            // dsRelatorios
            // 
            this.dsRelatorios.DataSetName = "dsRelatorios";
            this.dsRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureSair);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-22, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 26);
            this.panel1.TabIndex = 4;
            // 
            // pictureSair
            // 
            this.pictureSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSair.Image = ((System.Drawing.Image)(resources.GetObject("pictureSair.Image")));
            this.pictureSair.Location = new System.Drawing.Point(809, -3);
            this.pictureSair.Name = "pictureSair";
            this.pictureSair.Size = new System.Drawing.Size(30, 28);
            this.pictureSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSair.TabIndex = 4;
            this.pictureSair.TabStop = false;
            this.pictureSair.Click += new System.EventHandler(this.pictureSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Relatório de Contas Pagas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDtInicial);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDtFinal);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtInicial.Location = new System.Drawing.Point(26, 30);
            this.txtDtInicial.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Size = new System.Drawing.Size(97, 20);
            this.txtDtInicial.TabIndex = 14;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(269, 27);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(94, 23);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Inicial:";
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtFinal.Location = new System.Drawing.Point(142, 30);
            this.txtDtFinal.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Size = new System.Drawing.Size(97, 20);
            this.txtDtFinal.TabIndex = 6;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "rptVendaMes";
            reportDataSource1.Value = this.vENDABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LiveCommerce.Relatorios.rptVendaMes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(796, 344);
            this.reportViewer1.TabIndex = 8;
            // 
            // vENDATableAdapter
            // 
            this.vENDATableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelVendas";
            this.Load += new System.EventHandler(this.FrmRelVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vENDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSair)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDtFinal;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vENDABindingSource;
        private LiveCommerce.Relatorios.dsRelatorios dsRelatorios;
        private LiveCommerce.Relatorios.dsRelatoriosTableAdapters.VENDATableAdapter vENDATableAdapter;
        private System.Windows.Forms.DateTimePicker txtDtInicial;
    }
}
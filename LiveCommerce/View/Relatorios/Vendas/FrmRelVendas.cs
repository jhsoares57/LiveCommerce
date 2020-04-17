using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCommerce.View.Relatorios.Vendas
{
    public partial class FrmRelVendas : Form
    {
        public FrmRelVendas()
        {
            InitializeComponent();
        }

        private void FrmRelVendas_Load(object sender, EventArgs e)
        {
            reportViewer1.Enabled = false;
            //this.reportViewer1.RefreshReport();
        }

        
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.vENDATableAdapter.FillBy1(this.dsRelatorios.VENDA, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(txtDtInicial.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(txtDtFinal.Text, typeof(System.DateTime))))));
                this.reportViewer1.RefreshReport();
                reportViewer1.Enabled = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pictureSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

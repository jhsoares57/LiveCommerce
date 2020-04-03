using DGVPrinterHelper;
using LiveCommerce.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCommerce.View.Relatorios.ContasPagar
{
    public partial class FrmContasRecebidas : Form
    {
        ContasPagarReceberBLL contaService = new ContasPagarReceberBLL();
        public static DateTime DataInicial;
        public static DateTime DataFinal;
        public FrmContasRecebidas()
        {
            InitializeComponent();
        }

        public void CarregarConta()
        {
            DateTime DataInicial = Convert.ToDateTime(txtDtInicial.Text);
            DateTime DataFinal = Convert.ToDateTime(txtDtFinal.Text);
            dgvRelatorioContaRecebida.DataSource = contaService.RelatorioContasRecebidas(DataInicial, DataFinal);
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarConta();
        }

        private void brnImprimir_Click(object sender, EventArgs e)
        {
            this.printDocument.DefaultPageSettings.Landscape = true;
            DGVPrinter print = new DGVPrinter();
            print.Title = "Relatório de Contas Pagas"; //Titulo da Página
            print.PageSettings.Landscape = true;

            // print.SubTitle = "Relatorio de Contas a Pagar/Receber"; //SubTitulo da Página
            //print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            //print.PageNumbers = true;
            //print.PageNumberInHeader = false;
            //print.PorportionalColumns = false;
            //print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "LiveCommerce";
            print.FooterSpacing = 15;

            //print.PrintPreviewDataGridView(dgvContas);
            print.PrintDataGridView(dgvRelatorioContaRecebida);
        }


        private void pictureSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

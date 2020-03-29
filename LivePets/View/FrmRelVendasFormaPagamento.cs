using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCommerce.View
{
    public partial class FrmRelVendasFormaPagamento : Form
    {
        public FrmRelVendasFormaPagamento()
        {
            InitializeComponent();
        }

        private void FrmRelVendasFormaPagamento_Load(object sender, EventArgs e)
        {

            this.rptVendasFormaPagamento.RefreshReport();
        }

        private void rptVendasFormaPagamento_Load(object sender, EventArgs e)
        {
            //Instanciando o Table Adapter do Dataset
            Relatorios.dsRelatoriosTableAdapters.LV_VENDA_FORMA_PAGAMENTO_DIATableAdapter dta =
            new
            Relatorios.dsRelatoriosTableAdapters.LV_VENDA_FORMA_PAGAMENTO_DIATableAdapter();
            //Chamando a consulta contida no table adapter
            DataTable dt = dta.GetData();
            //Indica que o processamento do relatório é local
            rptVendasFormaPagamento.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = rptVendasFormaPagamento.LocalReport;
            //Indica o caminho físico do relatório
            localReport.ReportEmbeddedResource = "LiveCommerce.Relatorios.VendaFormaPagamentoDia.rdlc";
            //Instância fonte de dados do relatório
            ReportDataSource rpds = new ReportDataSource();
            //Abaixo deve ser colocado o nome dado ao Dataset que contém os campos no relatório
            //Pode ser que seu DataSource criado no relatório esteja com nome diferente (confira)
            rpds.Name = "LV_Venda_Forma_Pagamento_Dia";
            //Atribuição do resultado da pesquisa à fonte de dados do relatório
            rpds.Value = dt;
            //Limpa a fonte de dados do relatório, evitando que dados anteriores prejudiquem o relatório
            rptVendasFormaPagamento.LocalReport.DataSources.Clear();
            //Adiciona o dataSource instanciado aqui a cima para a fonte de dados do relatório
            rptVendasFormaPagamento.LocalReport.DataSources.Add(rpds);
            rptVendasFormaPagamento.Visible = true; //Deixa o relatório visível
            rptVendasFormaPagamento.LocalReport.Refresh();
        }
    }
}

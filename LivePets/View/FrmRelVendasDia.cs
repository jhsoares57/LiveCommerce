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
    public partial class FrmRelVendasDia : Form
    {
        public FrmRelVendasDia()
        {
            InitializeComponent();
        }

        private void FrmRelVendasDia_Load(object sender, EventArgs e)
        {

            this.rptVendasDia.RefreshReport();
        }

        private void rptVendasDia_Load(object sender, EventArgs e)
        {
            //Instanciando o Table Adapter do Dataset
            Relatorios.dsRelatoriosTableAdapters.USP_VENDA_DO_DIATableAdapter dta =
            new
            Relatorios.dsRelatoriosTableAdapters.USP_VENDA_DO_DIATableAdapter();
            //Chamando a consulta contida no table adapter
            DataTable dt = dta.GetData();
            //Indica que o processamento do relatório é local
            rptVendasDia.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = rptVendasDia.LocalReport;
            //Indica o caminho físico do relatório
            localReport.ReportEmbeddedResource = "LiveCommerce.Relatorios.VendasDia.rdlc";
            //Instância fonte de dados do relatório
            ReportDataSource rpds = new ReportDataSource();
            //Abaixo deve ser colocado o nome dado ao Dataset que contém os campos no relatório
            //Pode ser que seu DataSource criado no relatório esteja com nome diferente (confira)
            rpds.Name = "dsVendasDia";
            //Atribuição do resultado da pesquisa à fonte de dados do relatório
            rpds.Value = dt;
            //Limpa a fonte de dados do relatório, evitando que dados anteriores prejudiquem o relatório
            rptVendasDia.LocalReport.DataSources.Clear();
            //Adiciona o dataSource instanciado aqui a cima para a fonte de dados do relatório
            rptVendasDia.LocalReport.DataSources.Add(rpds);
            rptVendasDia.Visible = true; //Deixa o relatório visível
            rptVendasDia.LocalReport.Refresh();
        }
    }
}

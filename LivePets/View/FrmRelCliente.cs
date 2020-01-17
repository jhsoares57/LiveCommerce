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
    public partial class FrmRelCliente : Form
    {
        public FrmRelCliente()
        {
            InitializeComponent();
        }

        private void FrmRelCliente_Load(object sender, EventArgs e)
        {

            this.rptClientes.RefreshReport();
        }

        private void rptClientes_Load(object sender, EventArgs e)
        {
            //Instanciando o Table Adapter do Dataset
            Relatorios.dsRelatoriosTableAdapters.USP_RELATORIO_CLIENTESTableAdapter dta =
            new
            Relatorios.dsRelatoriosTableAdapters.USP_RELATORIO_CLIENTESTableAdapter();
            //Chamando a consulta contida no table adapter
            DataTable dt = dta.GetData();
            //Indica que o processamento do relatório é local
            rptClientes.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = rptClientes.LocalReport;
            //Indica o caminho físico do relatório
            localReport.ReportEmbeddedResource = "LiveCommerce.Relatorios.Clientes.rdlc";
            //Instância fonte de dados do relatório
            ReportDataSource rpds = new ReportDataSource();
            //Abaixo deve ser colocado o nome dado ao Dataset que contém os campos no relatório
            //Pode ser que seu DataSource criado no relatório esteja com nome diferente (confira)
            rpds.Name = "dsClientes";
            //Atribuição do resultado da pesquisa à fonte de dados do relatório
            rpds.Value = dt;
            //Limpa a fonte de dados do relatório, evitando que dados anteriores prejudiquem o relatório
            rptClientes.LocalReport.DataSources.Clear();
            //Adiciona o dataSource instanciado aqui a cima para a fonte de dados do relatório
            rptClientes.LocalReport.DataSources.Add(rpds);
            rptClientes.Visible = true; //Deixa o relatório visível
            rptClientes.LocalReport.Refresh();
        }
    }
}

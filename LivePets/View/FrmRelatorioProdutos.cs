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
    public partial class FrmRelatorioProdutos : Form
    {
        public FrmRelatorioProdutos()
        {
            InitializeComponent();
        }

        private void FrmRelatorioProdutos_Load(object sender, EventArgs e)
        {

            this.rptProdutos.RefreshReport();
        }

        private void rptProdutos_Load(object sender, EventArgs e)
        {
            //Instanciando o Table Adapter do Dataset
            Relatorios.dsRelatoriosTableAdapters.USP_PRODUTO_ESTOQUETableAdapter dta =
            new
            Relatorios.dsRelatoriosTableAdapters.USP_PRODUTO_ESTOQUETableAdapter();
            //Chamando a consulta contida no table adapter
            DataTable dt = dta.GetData();
            //Indica que o processamento do relatório é local
            rptProdutos.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = rptProdutos.LocalReport;
            //Indica o caminho físico do relatório
            localReport.ReportEmbeddedResource = "LiveCommerce.Relatorios.Produtos.rdlc";
            //Instância fonte de dados do relatório
            ReportDataSource rpds = new ReportDataSource();
            //Abaixo deve ser colocado o nome dado ao Dataset que contém os campos no relatório
            //Pode ser que seu DataSource criado no relatório esteja com nome diferente (confira)
            rpds.Name = "dsProdutos";
            //Atribuição do resultado da pesquisa à fonte de dados do relatório
            rpds.Value = dt;
            //Limpa a fonte de dados do relatório, evitando que dados anteriores prejudiquem o relatório
            rptProdutos.LocalReport.DataSources.Clear();
            //Adiciona o dataSource instanciado aqui a cima para a fonte de dados do relatório
            rptProdutos.LocalReport.DataSources.Add(rpds);
            rptProdutos.Visible = true; //Deixa o relatório visível
            rptProdutos.LocalReport.Refresh();
        }
    }
}

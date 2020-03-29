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

namespace LiveCommerce.View.Impressao
{
    public partial class FrmImprimirVenda : Form
    {
        public FrmImprimirVenda()
        {
            InitializeComponent();
        }

        private void rptImprimeVenda_Load(object sender, EventArgs e)
        {
            //Instanciando o Table Adapter do Dataset
            Relatorios.dsRelatoriosTableAdapters.LV_IMPRIMI_VENDA_COMPLETA_V1TableAdapter dta =
            new
            Relatorios.dsRelatoriosTableAdapters.LV_IMPRIMI_VENDA_COMPLETA_V1TableAdapter();
            //Chamando a consulta contida no table adapter
            DataTable dt = dta.GetData();
            //Indica que o processamento do relatório é local
            rptImprimeVenda.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = rptImprimeVenda.LocalReport;
            //Indica o caminho físico do relatório
            localReport.ReportEmbeddedResource = "LiveCommerce.Relatorios.ImprimiVenda.rdlc";
            //Instância fonte de dados do relatório
            ReportDataSource rpds = new ReportDataSource();
            //Abaixo deve ser colocado o nome dado ao Dataset que contém os campos no relatório
            //Pode ser que seu DataSource criado no relatório esteja com nome diferente (confira)
            rpds.Name = "ImprimiVenda";
            //Atribuição do resultado da pesquisa à fonte de dados do relatório
            rpds.Value = dt;
            //Limpa a fonte de dados do relatório, evitando que dados anteriores prejudiquem o relatório
            rptImprimeVenda.LocalReport.DataSources.Clear();
            //Adiciona o dataSource instanciado aqui a cima para a fonte de dados do relatório
            rptImprimeVenda.LocalReport.DataSources.Add(rpds);
            rptImprimeVenda.Visible = true; //Deixa o relatório visível
            rptImprimeVenda.LocalReport.Refresh();



            //List<ReportParameter> parametros = new List<ReportParameter>();


            ////string usuario = "teste";
            ////parametros.Add(new ReportParameter("NrVenda",usuario)) ;
            ////parametros.Add(new ReportParameter("pData", DateTime.Now.ToString()));
            ////parametros.Add(new ReportParameter("pNomeUsuario", usuario.Login));
            
            //ReportParameter[] parametro =
            //{
            //new ReportParameter("NrVenda","The Club - O Maior Clube de Programadores do Brasil"),
            ////new ReportParameter("ParamSubtitulo","Relatório de Venda - Mestre/Detalhe")
            //};
            //rptImprimeVenda.LocalReport.SetParameters(parametros);
            //rptImprimeVenda.LocalReport.Refresh();
        }

        private void FrmImprimirVenda_Load(object sender, EventArgs e)
        {
            this.rptImprimeVenda.RefreshReport();
        }
    }
}

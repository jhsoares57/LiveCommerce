using LiveCommerce.Business;
using LiveCommerce.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCommerce.View.Contas
{
    public partial class FrmContas : Form
    {
        ListaGenericaBLL ListServive = new ListaGenericaBLL();
        FornecedorBLL fornecedorService = new FornecedorBLL();
        ContasPagarReceberBLL contaService = new ContasPagarReceberBLL();
        public FrmContas()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ContasPagarReceber P = new ContasPagarReceber();
            P.CtpCont = Convert.ToInt32(cbxTipoLabnc.SelectedValue);
            P.CdtLanc = Convert.ToDateTime(txtDtLanc.Text);
            P.CcodOri = Convert.ToInt32(cbxOrigem.SelectedValue);
            P.CvlrCnt = Convert.ToDouble(txtValor.Text);
            P.CdtVcto = Convert.ToDateTime(txtDtPagamento.Text);
            P.Cobs = txtObservacao.Text;
           

            contaService.Insert(P);

            MessageBox.Show("Conta Lançada com Sucesso!!!","Mensagem do Sistema");
            LimparDados();
        }

        public void LimparDados()
        {
            carregarTipo();
            txtValor.Clear();
            txtObservacao.Clear();
        }

        private void carregarTipo()
        {
            List<ListaGenerica> ListTipoConta = new List<ListaGenerica>();
            ListTipoConta.Add(new ListaGenerica() { CodItem = 0, DescricaoItem = "SELECIONE" });
            ListTipoConta.AddRange(ListServive.TipoConta());
            cbxTipoLabnc.DataSource = ListTipoConta;
            cbxTipoLabnc.ValueMember = "CodItem";
            cbxTipoLabnc.DisplayMember = "DescricaoItem";
        }

        private void carregarTipoFiltro()
        {
            List<ListaGenerica> ListTipoConta = new List<ListaGenerica>();
            ListTipoConta.Add(new ListaGenerica() { CodItem = 0, DescricaoItem = "SELECIONE" });
            ListTipoConta.AddRange(ListServive.TipoConta());
            cbxFiltroTipo.DataSource = ListTipoConta;
            cbxFiltroTipo.ValueMember = "CodItem";
            cbxFiltroTipo.DisplayMember = "DescricaoItem";
        }

        private void CarregarFornecedor()
        {
            List<Fornecedor> listaFornecedor = new List<Fornecedor>();
            listaFornecedor.Add(new Fornecedor() { IdFornecedor = 0, NomeFantasia = "SELECIONE" });
            listaFornecedor.AddRange(fornecedorService.FindNome());
            cbxOrigem.DataSource = listaFornecedor;
            cbxOrigem.ValueMember = "IdFornecedor";
            cbxOrigem.DisplayMember = "NomeFantasia";
        }

        private void FrmContas_Load(object sender, EventArgs e)
        {
            carregarTipo();
            carregarTipoFiltro();
        }

        private void cbxTipoLabnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = (cbxTipoLabnc.SelectedValue == null) ? string.Empty : cbxTipoLabnc.SelectedValue.ToString();

            if (int.TryParse(tipo, out int numero))
            {
                int idUF = Convert.ToInt32(cbxTipoLabnc.SelectedValue.ToString());
                if (cbxTipoLabnc.SelectedValue.ToString() == "1")
                {
                    CarregarFornecedor();
                }
                else
                {

                }
            }
        //}
    }
}

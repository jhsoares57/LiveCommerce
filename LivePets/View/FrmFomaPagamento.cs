using LiveCommerce.Business;
using LiveCommerce.Model;
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
    public partial class FrmFomaPagamento : Form
    {
        SituacaoBLL situacaoService = new SituacaoBLL();
        FormaPagamentoBLL Pagamentoservice = new FormaPagamentoBLL();
        public FrmFomaPagamento()
        {
            InitializeComponent();
        }

        private void btnSairFormaPagamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarFormaPagamento_Click(object sender, EventArgs e)
        {
            FormaPagamento P = new FormaPagamento();
            P.DsFormaPagamento = txtDescricaoFormaPagamento.Text;
            P.Financeiro = Convert.ToInt32(cbxFinanceiro.SelectedValue);

            Pagamentoservice.Insert(P);
                MessageBox.Show("Forma Recebimento Inserida com sucesso", "Mensagem");
            }

        private void FrmFomaPagamento_Load(object sender, EventArgs e)
        {
            CarregarSituacao();
        }

        private void CarregarSituacao()
        {
            List<Situacao> FinanCeiro = new List<Situacao>();
            //FinanCeiro.Add(new Situacao() { IdSituacao = 0, DsSituacao = "SELECIONE" });
            FinanCeiro.AddRange(situacaoService.FindALL());
            cbxFinanceiro.DataSource = FinanCeiro;
            cbxFinanceiro.ValueMember = "idSituacao";
            cbxFinanceiro.DisplayMember = "DsSituacao";

        }
    }
}

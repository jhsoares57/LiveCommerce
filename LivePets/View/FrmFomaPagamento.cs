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

            if (Pagamentoservice.Insert(P))
            {
                string mensagem = "Usuario inserido com sucesso";
                MessageBox.Show(mensagem);
            }
        }
    }
}

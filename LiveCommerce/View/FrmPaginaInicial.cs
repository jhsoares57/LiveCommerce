using LiveCommerce.View.Configurar;
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
    public partial class FrmPaginaInicial : Form
    {
        public FrmPaginaInicial()
        {
            InitializeComponent();         
        }       

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<FrmCadastroProduto>().Count() > 0)
            {
                DialogResult result;
                result = MessageBox.Show("A tela já está aberta!", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.OpenForms["FrmCadastroProduto"].BringToFront();

                }
            }
            else
            {
                FrmCadastroProduto frmCadastroProduto = new FrmCadastroProduto();
                frmCadastroProduto.Show();
            }
        }

         private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmListaProdutos>().Count() > 0)
            {
                Application.OpenForms["FrmListaProduto"].BringToFront();
            }
            else
            {
                FrmListaProdutos frmListaProdutos = new FrmListaProdutos();
                frmListaProdutos.Show();
            }
        }

         private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
         {
            // FrmCadastroFornecedor.ActiveForm(typeof(FrmCadastroFornecedor));

            if (Application.OpenForms.OfType<FrmCadastroFornecedor>().Count() > 0)
            {
                Application.OpenForms["FrmCadastroFornecedor"].BringToFront();
            }
            else
            {
                FrmCadastroFornecedor frmCadastroFornecedor = new FrmCadastroFornecedor();
                frmCadastroFornecedor.Show();
            }
        }

         private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
         {
            if (Application.OpenForms.OfType<FrmListaVendas>().Count() > 0)
            {
                Application.OpenForms["FrmListaVendas"].BringToFront();
            }
            else
            {
                FrmListaVendas frmListaVendas = new FrmListaVendas();
                frmListaVendas.Show();
            }
         }

         private void sairToolStripMenuItem_Click(object sender, EventArgs e)
         {
            Sair();
         }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastroCliente>().Count() > 0)
            {
                Application.OpenForms["FrmCadastroCliente"].BringToFront();
            }
            else
            {
                FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
                frmCadastroCliente.Show();
            }
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crio o método para o botão Sair
            DialogResult result;

            result = MessageBox.Show("Tem certeza que deseja realizar logoff?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.Show();
            }
        }

      

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUsuario>().Count() > 0)
            {
                MessageBox.Show("A tela já está aberta!");
            }

            else
            {
                FrmUsuario usuario = new FrmUsuario();
                usuario.Show();
            }
        }

        private void fuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastroFuncionario>().Count() > 0)
            {
                Application.OpenForms["FrmCadastroFuncionario"].BringToFront();
            }
            else
            {
                FrmCadastroFuncionario funcionario = new FrmCadastroFuncionario();
                funcionario.Show();
            }
        }

        private void formaPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmFomaPagamento>().Count() > 0)
            {
                Application.OpenForms["FrmFormaPagamento"].BringToFront();
            }
            else
            {
                FrmFomaPagamento Pagamento = new FrmFomaPagamento();
                Pagamento.Show();
            }
        }

       

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaProdutos p = new FrmListaProdutos();
            p.Pesquisa = FrmListaProdutos.TipoPesquisa.Cliente;
        }
        public void Sair()
        {
            //Crio o método para o botão Sair
            DialogResult result;

            result = MessageBox.Show("Tem certeza que deseja sair?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void planoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmPlanoDePagamento>().Count() > 0)
            {
                Application.OpenForms["FrmPlanoDePagamento"].BringToFront();
            }
            else
            {
                FrmPlanoDePagamento Plano = new FrmPlanoDePagamento();
                Plano.Show();
            }
        }

        private void FrmPaginaInicial_Load(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("H:mm");
        }

        private void clientesEndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelCliente frCCli = new FrmRelCliente();
            frCCli.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioProdutos frmprod = new FrmRelatorioProdutos();
            frmprod.Show();
        }

        private void porFormaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelVendasFormaPagamento frmVendn = new FrmRelVendasFormaPagamento();
            frmVendn.Show();
        }

        private void vendasDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelVendasDia frmVd = new FrmRelVendasDia();
            frmVd.Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.Show();
        }

        private void parâmetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParam frmp = new FrmParam();
            frmp.Show();
        }

        private void contasAPagarEReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Contas.FrmContas frcontas = new View.Contas.FrmContas();
            frcontas.Show();
        }

        private void contasPagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<View.Relatorios.ContasPagar.FrmRelContaPagar>().Count() > 0)
            {
                Application.OpenForms["FrmRelContaPagar"].BringToFront();
            }
            else
            {
                View.Relatorios.ContasPagar.FrmRelContaPagar ContaPagas = new View.Relatorios.ContasPagar.FrmRelContaPagar();
                ContaPagas.Show();
            }
        }

        private void contasRecebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<View.Relatorios.ContasPagar.FrmContasRecebidas>().Count() > 0)
            {
                Application.OpenForms["FrmContasRecebidas"].BringToFront();
            }
            else
            {
                View.Relatorios.ContasPagar.FrmContasRecebidas ContaRecebidas = new View.Relatorios.ContasPagar.FrmContasRecebidas();
                ContaRecebidas.Show();
            }
        }

        private void vendasPorPeridoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<View.Relatorios.Vendas.FrmRelVendas>().Count() > 0)
            {
                Application.OpenForms["FrmRelVendas"].BringToFront();
            }
            else
            {
                View.Relatorios.Vendas.FrmRelVendas ContaRecebidas = new View.Relatorios.Vendas.FrmRelVendas();
                ContaRecebidas.Show();
            }
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FluxoCaixa.Caixa>().Count() > 0)
            {
                Application.OpenForms["Caixa"].BringToFront();
            }
            else
            {
                FluxoCaixa.Caixa cax = new FluxoCaixa.Caixa();
                cax.Show();
            }
        }
    }
}

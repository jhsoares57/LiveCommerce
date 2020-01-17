using LiveCommerce.Business;
using LiveCommerce.Model;
using LiveCommerce.View;
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
    public partial class FrmVendas : Form
    {
        FormaPagamentoBLL formaService = new FormaPagamentoBLL();

        FuncionarioBLL funcService = new FuncionarioBLL();
        List<VendaItens> listaVenda = new List<VendaItens>();
        VendaBLL vendaService = new VendaBLL();
        
        public static decimal total;

        public FrmVendas()
        {
            InitializeComponent();
        }

        private void btnCancelarVendas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregarProdutoSelecionadoPesquisa(int id)
        {
            Produto p = new ProdutoBLL().FindById(id);
            txtCodigoProduto.Text = p.Id.ToString();
            txtDescricaoProduto.Text = p.NomeProduto;
            txtPrecoProduto.Text = p.ValorUnitarioProduto.ToString();
        }

        public void CarregarClienteSelecionadoPesquisa(int id)
        {
            Cliente c = new ClienteBLL().FindById(id);
            txtCodigoCliente.Text = c.ID.ToString();
            txtDescricaoCliente.Text = c.NomeCliente;
            txtCpfCliente.Text = c.CpfCliente;
        }


        private void FrmVendas_Load(object sender, EventArgs e)
        {
            CarregarFormaPagamento();
            CarregarVendedor();

            //Carregar data que foi feito a venda.
            txtDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtHoraVenda.Text = DateTime.Now.ToShortTimeString();

        }

        private void CarregarFormaPagamento()
        {
            List<FormaPagamento> listaForma = new List<FormaPagamento>();
            listaForma.Add(new FormaPagamento() { IdFormaPagamento = 0, DsFormaPagamento = "SELECIONE" });
            listaForma.AddRange(formaService.FindALL());
            cbxFormaPagamentoVendas.DataSource = listaForma;
            cbxFormaPagamentoVendas.ValueMember = "IdFormaPagamento";
            cbxFormaPagamentoVendas.DisplayMember = "DsFormaPagamento";
        }

        //Campo Data de Cadstro do Formulario

        private void CarregarVendedor()
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();
            listaFuncionario.Add(new Funcionario() { IdFuncionario = 0, NmFuncionario = "SELECIONE"});
            listaFuncionario.AddRange(funcService.FindAll());
            cbxVendedor.DataSource = listaFuncionario;
            cbxVendedor.ValueMember = "IdFuncionario";
            cbxVendedor.DisplayMember = "NmFuncionario";
            
        }
        private decimal calculo()
        {
            if(string.IsNullOrEmpty(txtQuantidade.Text))
            {

                decimal cal = Convert.ToDecimal(txtPrecoProduto.Text);
                return cal;
            }
            float calcular = Convert.ToInt32(txtQuantidade.Text) * Convert.ToSingle(txtPrecoProduto.Text);

            return Convert.ToDecimal(calcular);
        }
        private void CalculoFinalizado()
        {
            txtValorTotal.Text = Convert.ToString(calculo());
        }

        private void txtValorTotal_KeyDown(object sender, KeyEventArgs e)
        {
            txtValorTotal.Text = Convert.ToString(calculo());
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmSelecionar frmSel = new FrmSelecionar();
            frmSel.F = this;//TODO - Luiz --> Esta etapada é crucial para que seja informado de qual form a pesquisa foi chamado...
            //É passada a instancia do Form para que de lá do Form de pesquisa possamos chamar o método para carregar os textbox.
            frmSel.TipoPesquisa = FrmSelecionar.Pesquisa.Produto;
            frmSel.Show(this);
        }

        
        public string TotalVenda()
        {
            if (txtDesconto.Text != "")
            {
                double valor = Convert.ToDouble(txtTotalVenda.Text);
                double percentual = Convert.ToInt32(txtDesconto.Text)/ 100.0; 
                double valor_final = valor - (percentual * valor);              

                string resul = string.Format("{0:C}", Convert.ToString(valor_final));
                return txtTotalaPagar.Text = resul;
            }

            else
            {

                return txtTotalaPagar.Text = txtTotalVenda.Text;
            }


        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                {

                    TotalVenda();

                }
            }
            
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            FrmSelecionar frmSel = new FrmSelecionar();
            frmSel.F = this;//TODO - Luiz --> Esta etapada é crucial para que seja informado de qual form a pesquisa foi chamado...
            //É passada a instancia do Form para que de lá do Form de pesquisa possamos chamar o método para carregar os textbox.
            frmSel.TipoPesquisa = FrmSelecionar.Pesquisa.Cliente;
            frmSel.Show(this);
        }

        private void btnCancelarVendas_Click_1(object sender, EventArgs e)
        {
            //Crio o método para o botão Sair
            DialogResult result;

            result = MessageBox.Show("Deseja realmente cancelar essa venda?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                FrmListaVendas fvendas = new FrmListaVendas();
                fvendas.Visible = true;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                VendaItens venda = new VendaItens();

                venda.IdProduto = Convert.ToInt32(txtCodigoProduto.Text);
                venda.NomeProduto = txtDescricaoProduto.Text;
                venda.ValorUnitario = Convert.ToDouble(txtPrecoProduto.Text);
                venda.QtProduto = Convert.ToInt32(txtQuantidade.Text);
                venda.ValorTotal = Convert.ToDouble(txtValorTotal.Text);

                listaVenda.Add(venda);

                dgvVenda.DataSource = listaVenda.Select(v => new
                { Column1 = v.IdProduto, Column2 = v.NomeProduto, Column3 = v.ValorUnitario, Column4 = v.QtProduto, Column5 = v.ValorTotal }).ToList();


                dgvVenda.Columns[0].HeaderText = "Ordem";
                dgvVenda.Columns[1].HeaderText = "Nome";
                dgvVenda.Columns[2].HeaderText = "Preço";
                dgvVenda.Columns[3].HeaderText = "Quantidade";
                dgvVenda.Columns[4].HeaderText = "Total";

                txtCodigoProduto.Clear();
                txtDescricaoProduto.Clear();
                txtQuantidade.Clear();
                txtPrecoProduto.Clear();
                txtValorTotal.Clear();
                btnPesquisar.Focus();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            total = 0;
            foreach (DataGridViewRow linha in dgvVenda.Rows)
            {
                total += Convert.ToDecimal(linha.Cells[4].Value);
            }

            txtTotalVenda.Text = total.ToString();

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Venda v = new Venda();
                v.DataVenda = Convert.ToDateTime(txtDataVenda.Text);
                v.HoraVenda = Convert.ToDateTime(txtHoraVenda.Text);
                v.IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
                v.Id_funcionario = Convert.ToInt32(cbxVendedor.SelectedValue);
                v.IdPagamento = Convert.ToInt32(cbxFormaPagamentoVendas.SelectedValue);
                v.ValorFinalProdutos = Convert.ToSingle(txtTotalVenda.Text);

                v.ListaVendasItens = new List<VendaItens>();

                foreach(VendaItens i in listaVenda)
                {
                    v.ListaVendasItens.Add(i);
                }

                vendaService.Insert(v);
                MessageBox.Show("VENDA REALIZADA ID:" + v.IdVenda);
                //Crio o método para o botão Sair
                DialogResult result;

                result = MessageBox.Show("Deseja realmente Imprimir essa venda?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    ImprimirVenda();
                }
                LimparCampos();


            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }
        public void LimparCampos()
        {
            txtCodigoCliente.Clear();
            txtDescricaoCliente.Clear();
            txtCpfCliente.Clear();
            txtCodigoProduto.Clear();
            txtDescricaoProduto.Clear();
            txtPrecoProduto.Clear();
            txtTotalaPagar.Clear();
            txtQuantidade.Clear();
            txtValorTotal.Clear();
            txtTotalVenda.Clear();
            dgvVenda.Columns.Clear();
            listaVenda.Clear();
            txtDesconto.Clear();
            btnPesquisarCliente.Focus();
        }

        private void dgvVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvVenda.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (listaVenda.Exists(venda => venda.IdProduto == id))
            {
                listaVenda.RemoveAll(venda => venda.IdProduto == id);

                dgvVenda.DataSource = listaVenda;
            }
        }

        private void ImprimirVenda()
        {
            Impressao.FrmImprimirVenda FrImprimi = new Impressao.FrmImprimirVenda();
            FrImprimi.Show();
        }
    }
}

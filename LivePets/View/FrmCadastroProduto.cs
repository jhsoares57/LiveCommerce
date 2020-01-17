using LiveCommerce.Business;
using LiveCommerce.Business.Exceptions;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCommerce.View
{
    public partial class FrmCadastroProduto : Form
    {
        UnidadeMedidaBLL UnidadeService = new UnidadeMedidaBLL();
        CategoriaProdutoBLL CategoriaService = new CategoriaProdutoBLL();
        ProdutoBLL ProdutoService = new ProdutoBLL();
        TipoProdutoBLL tipoService = new TipoProdutoBLL();
        FornecedorBLL fornecedorService = new FornecedorBLL();


        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtIdproduto.Clear();
            txtCDBarras.Clear();
            txtNomeProduto.Clear();
            cbxTipoProduto.SelectedValue = 0;
            cbxFornecedor.SelectedValue = 0;
            txtPrecoProduto.Clear();
            txtLucroProduto.Clear();
            txtValorVenda.Clear();
            cbxUnidadeMedidaCadastroProduto.SelectedValue = 0;
            cbxCategoriaProduto.SelectedValue = 0;
            cbxFormaCompraMedida.SelectedValue = 0;
            txtQuantidadeProduto.Clear();
            txtCDBarras.Focus();
        }

        private void CarregarUnidadeMedida()
        {
            List<UnidadeMedida> listaUnidade = new List<UnidadeMedida>();
            listaUnidade.Add(new UnidadeMedida() { IDMedida = 0, DescricaoMedida = "SELECIONE" });
            listaUnidade.AddRange(UnidadeService.FindALL());
            cbxUnidadeMedidaCadastroProduto.DataSource = listaUnidade;
            cbxUnidadeMedidaCadastroProduto.ValueMember = "IDMedida";
            cbxUnidadeMedidaCadastroProduto.DisplayMember = "DescricaoMedida";
        }

        private void CarregarCategoriaProduto()
        {
            List<CategoriaProduto> listaCategoria = new List<CategoriaProduto>();
            listaCategoria.Add(new CategoriaProduto() { IdCategoriaProduto = 0, DsCategoriaProduto = "SELECIONE" });
            listaCategoria.AddRange(CategoriaService.FindALL());
            cbxCategoriaProduto.DataSource = listaCategoria;
            cbxCategoriaProduto.ValueMember = "IdCategoriaProduto";
            cbxCategoriaProduto.DisplayMember = "DsCategoriaProduto";
        }

        private void CarregarFormaCompra()
        {
            List<UnidadeMedida> listaUnidade = new List<UnidadeMedida>();
            listaUnidade.Add(new UnidadeMedida() { IDMedida = 0, DescricaoMedida = "SELECIONE" });
            listaUnidade.AddRange(UnidadeService.FindALL());
            cbxFormaCompraMedida.DataSource = listaUnidade;
            cbxFormaCompraMedida.ValueMember = "IDMedida";
            cbxFormaCompraMedida.DisplayMember = "DescricaoMedida";
        }

        public void CarregarTipoProduto()
        {
            List<TipoProduto> listaTipo = new List<TipoProduto>();
            listaTipo.Add(new TipoProduto() { IDTipoProduto = 0, DescricaoTipoProduto = "SELECIONE" });
            listaTipo.AddRange(tipoService.FindTipoProduto());
            cbxTipoProduto.DataSource = listaTipo;
            cbxTipoProduto.ValueMember = "IDTipoProduto";
            cbxTipoProduto.DisplayMember = "DescricaoTipoProduto";
        }

        private void CarregarFornecedor()
        {
            List<Fornecedor> listaFornecedor = new List<Fornecedor>();
            listaFornecedor.Add(new Fornecedor() { IdFornecedor = 0, NomeFantasia = "SELECIONE" });
            listaFornecedor.AddRange(fornecedorService.FindNome());
            cbxFornecedor.DataSource = listaFornecedor;
            cbxFornecedor.ValueMember = "IdFornecedor";
            cbxFornecedor.DisplayMember = "NomeFantasia";
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            //Campo Data de Cadstro do Formulario
            txtDTCadastroProduto.Text = DateTime.Now.ToString("dd/MM/yyyy");

            CarregarFornecedor();
            CarregarTipoProduto();
            CarregarUnidadeMedida();
            CarregarCategoriaProduto();
            CarregarFormaCompra();

        }
        public string VendaProduto()
        {
            if (txtLucroProduto.Text != "")
                
            {
                var CultureInfo = Thread.CurrentThread.CurrentCulture;
                double valor = Convert.ToDouble(txtPrecoProduto.Text);
                double percentual = Convert.ToInt32(txtLucroProduto.Text) / 100.0;
                double valor_final = valor + (percentual * valor);

                string resul = string.Format("{0:C}", Convert.ToString(valor_final));
                //string resul = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor_final);
                return txtValorVenda.Text = resul;
            }
            else
            {

                return txtValorVenda.Text = txtPrecoProduto.Text;
            }


        }
        

        private void btncadastrarproduto_Click_1(object sender, EventArgs e)
        {

            try
            {
                string NomeProdutoEx = txtNomeProduto.Text;
                if (string.IsNullOrEmpty(NomeProdutoEx))
                {
                    throw new CampoInvalidoException("Nome é necessário para prosseguir!");

                }
                string TipoEx = cbxTipoProduto.Text.Replace("SELECIONE", "").Trim();
                if (string.IsNullOrEmpty(TipoEx))
                {
                    throw new CampoInvalidoException("Tipo do produto é necessário para prosseguir!");

                }
                string FornecedorEx = cbxFornecedor.Text.Replace("SELECIONE", "").Trim();
                if (string.IsNullOrEmpty(FornecedorEx))
                {
                    throw new CampoInvalidoException("Fornecedor é necessário para prosseguir!");

                }

                string PrecoEx = txtPrecoProduto.Text;
                if (string.IsNullOrEmpty(PrecoEx))
                {
                    throw new PrecoInvalidoException("Preço custo é necessário para prosseguir!");

                }
                string ValorVendaEx = txtValorVenda.Text;
                if (string.IsNullOrEmpty(ValorVendaEx))
                {
                    throw new PrecoInvalidoException("Valor de venda é necessário para prosseguir!");

                }
                string UnidadeEx = cbxUnidadeMedidaCadastroProduto.Text.Replace("SELECIONE", "").Trim();
                if (string.IsNullOrEmpty(UnidadeEx))
                {
                    throw new CampoInvalidoException("Unidade Medida é necessário para prosseguir!");

                }
                string CategoriaEx = cbxCategoriaProduto.Text.Replace("SELECIONE", "").Trim();
                if (string.IsNullOrEmpty(CategoriaEx))
                {
                    throw new CampoInvalidoException("Categoria é necessário para prosseguir!");

                }
                string CompraEx = cbxFormaCompraMedida.Text.Replace("SELECIONE", "").Trim();
                if (string.IsNullOrEmpty(CompraEx))
                {
                    throw new CampoInvalidoException("Forma Compra é necessário para prosseguir!");

                }



                if (string.IsNullOrEmpty(txtIdproduto.Text))
                {
                    Produto P = new Produto();
                    P.CDBarras = txtCDBarras.Text;
                    P.NomeProduto = txtNomeProduto.Text;
                    P.DTCadastro = Convert.ToDateTime(txtDTCadastroProduto.Text);
                    P.NomeProduto = txtNomeProduto.Text;
                    P.ValorCompra = Convert.ToDecimal(txtValorVenda.Text);
                    P.ValorUnitarioProduto = Convert.ToDecimal(txtPrecoProduto.Text);
                    P.LucroProduto = Convert.ToSingle(txtLucroProduto.Text);
                    P.UnidadeMedida = Convert.ToInt32(cbxUnidadeMedidaCadastroProduto.SelectedValue);
                    P.FormaCompra = Convert.ToInt32(cbxFormaCompraMedida.SelectedValue);
                    P.CategoriaProduto = Convert.ToInt32(cbxCategoriaProduto.SelectedValue);
                    P.QuantidadeProduto = Convert.ToInt32(txtQuantidadeProduto.Text);
                    P.IdTipoProduto = Convert.ToInt32(cbxTipoProduto.SelectedValue);
                    P.IdFornecedor = Convert.ToInt32(cbxFornecedor.SelectedValue);

                    ProdutoService.Insert(P);

                    MessageBox.Show("Produto inserido com sucesso");
                    Limpar();

                }

                else
                {
                    Produto P = new Produto();
                    P.Id = Convert.ToInt32(txtIdproduto.Text);
                    P.CDBarras = txtCDBarras.Text;
                    P.NomeProduto = txtNomeProduto.Text;
                    P.DTCadastro = Convert.ToDateTime(txtDTCadastroProduto.Text);
                    P.NomeProduto = txtNomeProduto.Text;
                    P.ValorCompra = Convert.ToDecimal(txtValorVenda.Text);
                    P.ValorUnitarioProduto = Convert.ToDecimal(txtPrecoProduto.Text);
                    P.LucroProduto = Convert.ToSingle(txtLucroProduto.Text);
                    P.UnidadeMedida = Convert.ToInt32(cbxUnidadeMedidaCadastroProduto.SelectedValue);
                    P.FormaCompra = Convert.ToInt32(cbxFormaCompraMedida.SelectedValue);
                    P.CategoriaProduto = Convert.ToInt32(cbxCategoriaProduto.SelectedValue);
                    P.QuantidadeProduto = Convert.ToInt32(txtQuantidadeProduto.Text);
                    P.IdTipoProduto = Convert.ToInt32(cbxTipoProduto.SelectedValue);
                    P.IdFornecedor = Convert.ToInt32(cbxFornecedor.SelectedValue);

                    ProdutoService.Update(P);

                    MessageBox.Show("Produto Atualizado com sucesso");
                    Limpar();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSaircadastroProduto_Click_1(object sender, EventArgs e)
        {
            //Crio o método para o botão Sair
            DialogResult result;

            result = MessageBox.Show("Deseja realmente sair do cadastro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtPesquisaProduto_TextChanged(object sender, EventArgs e)
        {
            dgvPesquisaProduto.DataSource = ProdutoService.FindAll(txtPesquisaProduto.Text);
        }

        private void dgvPesquisaProduto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dataCadastro = Convert.ToDateTime(dgvPesquisaProduto.Rows[e.RowIndex].Cells[2].Value.ToString());
            int tipoID = Convert.ToInt32(dgvPesquisaProduto.Rows[e.RowIndex].Cells[4].Value.ToString());
            int unidadeID = Convert.ToInt32(dgvPesquisaProduto.Rows[e.RowIndex].Cells[9].Value.ToString());
            int categoriaID = Convert.ToInt32(dgvPesquisaProduto.Rows[e.RowIndex].Cells[10].Value.ToString());
            int formacompraID = Convert.ToInt32(dgvPesquisaProduto.Rows[e.RowIndex].Cells[11].Value.ToString());
            int fornecedorID = Convert.ToInt32(dgvPesquisaProduto.Rows[e.RowIndex].Cells[5].Value.ToString());
            decimal precoProduto = Convert.ToDecimal(dgvPesquisaProduto.Rows[e.RowIndex].Cells[6].Value.ToString());
            decimal valorVenda = Convert.ToDecimal(dgvPesquisaProduto.Rows[e.RowIndex].Cells[8].Value.ToString());

            txtIdproduto.Text = dgvPesquisaProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCDBarras.Text = dgvPesquisaProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDTCadastroProduto.Text = dataCadastro.Date.ToString("dd/MM/yyyy");
            txtNomeProduto.Text = dgvPesquisaProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxTipoProduto.SelectedValue = tipoID;
            cbxFornecedor.SelectedValue = fornecedorID;
            txtPrecoProduto.Text = precoProduto.ToString();
            txtLucroProduto.Text = dgvPesquisaProduto.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtValorVenda.Text = valorVenda.ToString();
            cbxUnidadeMedidaCadastroProduto.SelectedValue = unidadeID;
            cbxCategoriaProduto.SelectedValue = categoriaID;
            cbxFormaCompraMedida.SelectedValue = formacompraID;
            txtQuantidadeProduto.Text = dgvPesquisaProduto.Rows[e.RowIndex].Cells[12].Value.ToString();

        }

        private void txtLucroProduto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                {

                    VendaProduto();

                }
            }
        }
    }
}

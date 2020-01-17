using LiveCommerce.Business;
using LiveCommerce.Business.Exceptions;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LiveCommerce.View
{
    public partial class FrmCadastroFornecedor : Form
    {
        UFBLL UFservice = new UFBLL();
        FornecedorBLL fService = new FornecedorBLL();
        CidadesBLL cidadesService = new CidadesBLL();
        SituacaoBLL situacaoService = new SituacaoBLL();
        TipoPessoaBLL tipoService = new TipoPessoaBLL();

        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }

        public void LimparCampo()
        {
            txtIdFornecedor.Clear();
            txtRazaoFornecedor.Clear();
            txtNomeFantasia.Clear();
            txtCpfCnpj.Clear();
            txtIE.Clear();
            txtCepFornecedor.Clear();
            txtEnderecoFornecedor.Clear();
            txtBairroFornecedor.Clear();
            txtNumeroFornecedor.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtRazaoFornecedor.Focus();
            cbxUFCadastroFornecedor.SelectedValue = 0;
            cbxCidade.SelectedValue = 0;
            cbxTipoFornecedor.SelectedValue = 0;
            cbxSituacaoFornecedor.SelectedValue = 0;
        }

        public void CarregarPessoa()
        {
            List<TipoPessoa> listaPessoa = new List<TipoPessoa>();
            listaPessoa.Add(new TipoPessoa() { IDPessoa = 0, DSPessoa = "SELECIONE" });
            listaPessoa.AddRange(tipoService.FindALL());
            cbxTipoFornecedor.DataSource = listaPessoa;
            cbxTipoFornecedor.ValueMember = "IDPessoa";
            cbxTipoFornecedor.DisplayMember = "DSPessoa";
        }
        public void CarregarUF()
        {
            List<UF> listaUF = new List<UF>();
            listaUF.Add(new UF() { IdUF = 0, DsUF = "SELECIONE" });
            listaUF.AddRange(UFservice.FindALL());
            cbxUFCadastroFornecedor.DataSource = listaUF;
            cbxUFCadastroFornecedor.ValueMember = "IdUF";
            cbxUFCadastroFornecedor.DisplayMember = "DsUF";
        }

        private void CarregarSituacao()
        {
            List<Situacao> listaSituacao = new List<Situacao>();
            listaSituacao.Add(new Situacao() { IdSituacao = 0, DsSituacao = "SELECIONE" });
            listaSituacao.AddRange(situacaoService.FindALL());
            cbxSituacaoFornecedor.DataSource = listaSituacao;
            cbxSituacaoFornecedor.ValueMember = "idSituacao";
            cbxSituacaoFornecedor.DisplayMember = "DsSituacao";

        }

        //private void CarregarTipo()
        //{
        //    List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        //    listaFornecedor.Add(new Fornecedor() { IdFornecedor = 0, DSFornecedor= "SELECIONE" });
        //    cbxTipoFornecedor.DataSource = listaFornecedor;
        //    cbxTipoFornecedor.ValueMember = "IdFornecedor";
        //}

        private void FrmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            //Campo Data de Cadstro do Formulario
            txtDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");

            CarregarPessoa();
            CarregarUF();
            CarregarSituacao();
        }



        private void btnCadastrarFornecedor_Click_1(object sender, EventArgs e)
        {
            try
            {

                int TP = Convert.ToInt32(cbxTipoFornecedor.SelectedValue.ToString());
                if (TP == 1)
                {
                    if (txtCpfCnpj.Text != string.Empty)
                    {
                        if (!CepCpfCnpjException.ValidaCPF(txtCpfCnpj.Text))
                        {
                            throw new CampoInvalidoException("CPF Inválido.");
                        }
                    }
                }
                else
                {
                    if (txtCpfCnpj.Text != string.Empty)
                    {
                        if (!CepCpfCnpjException.ValidaCNPJ(txtCpfCnpj.Text))
                        {
                            throw new CampoInvalidoException("CNPJ Inválido.");
                        }
                    }
                }
                string EMAIL = txtEmail.Text;
                if (string.IsNullOrEmpty(EMAIL))
                {
                    //validarCPF_CNPJ();
                    CepCpfCnpjException.ValidaEmail(EMAIL);

                }

                if (txtEmail.Text != string.Empty)
                {
                    if (!CepCpfCnpjException.ValidaEmail(txtEmail.Text))
                    {
                        throw new CampoInvalidoException("E-mail Inválido.");
                    }
                }

                if (txtCepFornecedor.Text != string.Empty)
                {
                    if (!CepCpfCnpjException.ValidaCep(txtCepFornecedor.Text))
                    {
                        throw new CampoInvalidoException("CEP Inválido.");
                    }
                }

                if (string.IsNullOrEmpty(txtIdFornecedor.Text))
                {
                    
                    Fornecedor F = new Fornecedor();
                    F.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                    F.Razao = txtRazaoFornecedor.Text;
                    F.NomeFantasia = txtNomeFantasia.Text;
                    F.Ie = txtIE.Text;
                    F.CpfcnpjFornecedor = txtCpfCnpj.Text;
                    F.EnderecoFornecedor = txtEnderecoFornecedor.Text;
                    F.EnderevoNumeroFornecedor = txtNumeroFornecedor.Text;
                    F.EnderecoBairroFornecedor = txtBairroFornecedor.Text;
                    F.EnderecoCepFornecedor = txtCepFornecedor.Text;
                    F.EnderecoCidadeFornecedor = Convert.ToInt32(cbxCidade.SelectedValue);
                    F.UfFornecedor = Convert.ToInt32(cbxUFCadastroFornecedor.SelectedValue);
                    F.TelefoneFornecedor = txtTelefone.Text;
                    F.CelularFornecdor = txtCelular.Text;
                    F.EmailFornecedor = txtEmail.Text;
                    F.IDSituacao = Convert.ToInt32(cbxSituacaoFornecedor.SelectedValue);
                    F.TipoPessoa = Convert.ToInt32(cbxTipoFornecedor.SelectedValue);

                    fService.Insert(F);
                    MessageBox.Show("Fornecedor inserido com sucesso");
                    LimparCampo();
                }
                else
                {
                    Fornecedor F = new Fornecedor();
                    F.IdFornecedor = Convert.ToInt32(txtIdFornecedor.Text);
                    F.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                    F.Razao = txtRazaoFornecedor.Text;
                    F.NomeFantasia = txtNomeFantasia.Text;
                    F.Ie = txtIE.Text;
                    F.CpfcnpjFornecedor = txtCpfCnpj.Text;
                    F.EnderecoFornecedor = txtEnderecoFornecedor.Text;
                    F.EnderevoNumeroFornecedor = txtNumeroFornecedor.Text;
                    F.EnderecoBairroFornecedor = txtBairroFornecedor.Text;
                    F.EnderecoCepFornecedor = txtCepFornecedor.Text;
                    F.EnderecoCidadeFornecedor = Convert.ToInt32(cbxCidade.SelectedValue);
                    F.UfFornecedor = Convert.ToInt32(cbxUFCadastroFornecedor.SelectedValue);
                    F.TelefoneFornecedor = txtTelefone.Text;
                    F.CelularFornecdor = txtCelular.Text;
                    F.EmailFornecedor = txtEmail.Text;
                    F.IDSituacao = Convert.ToInt32(cbxSituacaoFornecedor.SelectedValue);
                    F.TipoPessoa = Convert.ToInt32(cbxTipoFornecedor.SelectedValue);

                    fService.Update(F);
                    MessageBox.Show("Fornecedor atulizau com sucesso");
                    LimparCampo();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSairCadstroFornecedor_Click(object sender, EventArgs e)
        {
            //Crio o método para o botão Sair
            DialogResult result;

            result = MessageBox.Show("Deseja realmente sair do cadastro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbxUFCadastroFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (int.TryParse(cbxUFCadastroFornecedor.SelectedValue.ToString(), out int numero))
            {
                int idUF = Convert.ToInt32(cbxUFCadastroFornecedor.SelectedValue.ToString());
                if (cbxUFCadastroFornecedor.SelectedValue.ToString() != "0")
                {
                    List<Cidades> listaCidade = new List<Cidades>();
                    listaCidade.Add(new Cidades() { IdCidade = 0, DsCidade = "SELECIONE" });
                    listaCidade.AddRange(cidadesService.FindByID(Convert.ToInt32(cbxUFCadastroFornecedor.SelectedValue.ToString())));

                    cbxCidade.DataSource = listaCidade;
                    cbxCidade.ValueMember = "IdCidade";
                    cbxCidade.DisplayMember = "DsCidade";
                }
            }
        }

        private void txtPesquisaFornecedor_TextChanged(object sender, EventArgs e)
        {
            dgvCadastroFornecedor.DataSource = fService.FindLike(txtPesquisaFornecedor.Text);
        }

        private void btnLimparGrid_Click(object sender, EventArgs e)
        {
            //Crio o método para o botão Sair
            DialogResult result;

            result = MessageBox.Show("Deseja realmente limpar grid?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                txtIdFornecedor.Clear();
                txtRazaoFornecedor.Clear();
                txtNomeFantasia.Clear();
                txtCpfCnpj.Clear();
                txtIE.Clear();
                txtCepFornecedor.Clear();
                txtEnderecoFornecedor.Clear();
                txtBairroFornecedor.Clear();
                txtNumeroFornecedor.Clear();
                txtTelefone.Clear();
                txtCelular.Clear();
                txtEmail.Clear();
                txtRazaoFornecedor.Focus();
                return;
            }
        }

        private void btnExcluirCadastroFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdFornecedor.Text);
                bool excluiu = fService.Delete(id);

                if (excluiu)
                {

                    MessageBox.Show("Fornecedor Excluido com sucesso");
                    LimparCampo();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCadastroFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dataCadastro = Convert.ToDateTime(dgvCadastroFornecedor.Rows[e.RowIndex].Cells[1].Value.ToString());
            int situacao = Convert.ToInt32(dgvCadastroFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString());
            int ufID = Convert.ToInt32(dgvCadastroFornecedor.Rows[e.RowIndex].Cells[7].Value.ToString());
            int cidadeID = Convert.ToInt32(dgvCadastroFornecedor.Rows[e.RowIndex].Cells[8].Value.ToString());
            int TipoCliente = Convert.ToInt32(dgvCadastroFornecedor.Rows[e.RowIndex].Cells[16].Value.ToString());


            txtIdFornecedor.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDataCadastro.Text = dataCadastro.Date.ToString("dd/MM/yyyy");
            cbxSituacaoFornecedor.SelectedValue = situacao;
            txtRazaoFornecedor.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNomeFantasia.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCpfCnpj.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtIE.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbxUFCadastroFornecedor.SelectedValue = ufID;
            cbxCidade.SelectedValue = cidadeID;
            txtCepFornecedor.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtEnderecoFornecedor.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtBairroFornecedor.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtNumeroFornecedor.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtTelefone.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtCelular.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtEmail.Text = dgvCadastroFornecedor.Rows[e.RowIndex].Cells[15].Value.ToString();
            cbxTipoFornecedor.SelectedValue = TipoCliente;

        }

        private void cbxTipoFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoFornecedor.SelectedValue.ToString() == "2")
            {
                txtCpfCnpj.Text = "";
                txtCpfCnpj.Mask = "00,000,000/0000-00";
                lblRazao.Text = "Razão Social";
                lblFantasia.Visible = true;
                txtNomeFantasia.Visible = true;
                lblIERG.Text = "Inscrição estadual";
            }
            else
            {
                txtCpfCnpj.Text = "";
                txtCpfCnpj.Mask = "000,000,000-00";
                lblRazao.Text = "Nome";
                lblFantasia.Visible = false;
                txtNomeFantasia.Visible = false;
                lblIERG.Text = "RG";
            }
        }
    }
}

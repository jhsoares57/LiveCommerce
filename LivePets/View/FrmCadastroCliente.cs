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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCommerce.View
{
    public partial class FrmCadastroCliente : Form
    {
        UFBLL UFservice = new UFBLL();
       
        ClienteBLL clienteService = new ClienteBLL();
       
        CidadesBLL cidadesService = new CidadesBLL();
        SituacaoBLL situacaoService = new SituacaoBLL();

        
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }


        public void Limpar()
        {
            txtIDCliente.Clear();
            txtDTCadastroCadastroCliente.Clear();
            txtNomeCliente.Clear();
            txtBairroCliente.Clear();
            txtCelularCliente.Clear();
            txtCpfCliente.Clear();
            txtEnderecoCliente.Clear();
            txtcep.Clear();
            txtNumeroCliente.Clear();
            cbxUFCadastroCliente.SelectedValue = 0;
            dgvPesquisaCliente.Columns.Clear();
           
            
        }

        public void CarregarUF()
        {
            List<UF> listaUF = new List<UF>();
            listaUF.Add(new UF() { IdUF = 0, DsUF = "SELECIONE" });
            listaUF.AddRange(UFservice.FindALL());
            cbxUFCadastroCliente.DataSource = listaUF;
            cbxUFCadastroCliente.ValueMember = "IdUF";
            cbxUFCadastroCliente.DisplayMember = "DsUF";
        }
                
        public void CarregarSituacao()
        {
            List<Situacao> listaSituacao = new List<Situacao>();
            listaSituacao.Add(new Situacao() { IdSituacao = 0, DsSituacao= "SELECIONE" });
            listaSituacao.AddRange(situacaoService.FindALL());
            cbxSituacaoCadastroCliente.DataSource = listaSituacao;
            cbxSituacaoCadastroCliente.ValueMember = "idSituacao";
            cbxSituacaoCadastroCliente.DisplayMember = "dsSituacao";

        }
        private void btnCadastroCliente_Click_1(object sender, EventArgs e)
        {

            try
            {
                string AtivoEx =cbxSituacaoCadastroCliente.Text.Replace("SELECIONE","").Trim();
                if (string.IsNullOrEmpty(AtivoEx))
                {
                    throw new CpfInvalidoException("Situação do cliente é necessário para prosseguir!");

                }
                string NomeClienteEx = txtNomeCliente.Text;
                if (string.IsNullOrEmpty(NomeClienteEx))
                {
                    throw new CpfInvalidoException("Nome do cliente é necessário para prosseguir!");

                }
                string Enderecoex = txtEnderecoCliente.Text;
                if (string.IsNullOrEmpty(Enderecoex))
                {
                    throw new CpfInvalidoException("Endereço do cliente é necessário para prosseguir!");

                }
                string BairroEx = txtBairroCliente.Text;
                if (string.IsNullOrEmpty(BairroEx))
                {
                    throw new CpfInvalidoException("Bairro do cliente é necessário para prosseguir!");

                }
                string NumeroEx = txtNumeroCliente.Text;
                if (string.IsNullOrEmpty(NumeroEx))
                {
                    throw new CpfInvalidoException("Numero do cliente é necessário para prosseguir!");

                }
                string CepEx = txtcep.Text.Replace("_","").Replace("-","").Replace("00000-000", "").Trim();
                if (string.IsNullOrEmpty(CepEx))
                {
                    throw new CpfInvalidoException("Cep do cliente é necessário para prosseguir!");

                }
                string UfEx = cbxUFCadastroCliente.Text.Replace("SELECIONE", "").Trim();
                if (string.IsNullOrEmpty(UfEx))
                {
                    throw new CpfInvalidoException("UF do cliente é necessário para prosseguir!");

                }
                string CidadeEx = cbxCidadeCliente.Text.Replace("SELECIONE", "").Trim();
                if (string.IsNullOrEmpty(CidadeEx))
                {
                    throw new CpfInvalidoException("Situação do cliente é necessário para prosseguir!");

                }
                //string CpfEx = txtCpfCliente.Text;
                //if (CepCpfCnpjException.ValidaCPF(txtCpfCliente.Text.))
                //{
                //    //throw new CpfInvalidoException("Cpf do cliente é necessário para prosseguir!");
                //    MessageBox.Show("Erro");

                //}


                if(string.IsNullOrEmpty(txtIDCliente.Text))
                { 
                Cliente c = new Cliente();
                c.NomeCliente = txtNomeCliente.Text;
                c.CelularCliente = txtCelularCliente.Text;
                c.CepEndereco = txtcep.Text;
                c.BairroEndereco = txtBairroCliente.Text;
                c.CpfCliente = txtCpfCliente.Text;
                c.RgCliente = txtRGCliente.Text;
                c.NumeroEndereco = Convert.ToInt32(txtNumeroCliente.Text);
                c.DataCadastro = Convert.ToDateTime(txtDTCadastroCadastroCliente.Text);
                c.DataNascimento = Convert.ToDateTime(txtDTNascimentoCliente.Text);
                c.UfEndereco = Convert.ToInt32(cbxUFCadastroCliente.SelectedValue);
                c.CidadeEndereco = Convert.ToInt32(cbxCidadeCliente.SelectedValue);
                c.Situacao = Convert.ToInt32(cbxSituacaoCadastroCliente.SelectedValue);
                c.Endereco = txtEnderecoCliente.Text;
         
                clienteService.Insert(c);
                MessageBox.Show("CLIENTE ID: " + c.ID+ " CADASTRADO!");
                }
                else
                {
                    Cliente c = new Cliente();
                    c.NomeCliente = txtNomeCliente.Text;
                    c.CelularCliente = txtCelularCliente.Text;
                    c.CepEndereco = txtcep.Text;
                    c.BairroEndereco = txtBairroCliente.Text;
                    c.CpfCliente = txtCpfCliente.Text;
                    c.RgCliente = txtRGCliente.Text;
                    c.NumeroEndereco = Convert.ToInt32(txtNumeroCliente.Text);
                    c.DataCadastro = Convert.ToDateTime(txtDTCadastroCadastroCliente.Text);
                    c.DataNascimento = Convert.ToDateTime(txtDTNascimentoCliente.Text);
                    c.UfEndereco = Convert.ToInt32(cbxUFCadastroCliente.SelectedValue);
                    c.CidadeEndereco = Convert.ToInt32(cbxCidadeCliente.SelectedValue);
                    c.Situacao = Convert.ToInt32(cbxSituacaoCadastroCliente.SelectedValue);
                    c.Endereco = txtEnderecoCliente.Text;

                    clienteService.Update(c);
                    MessageBox.Show("CLIENTE ATUALIZADO!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSairCadastroCliente_Click(object sender, EventArgs e)
        {
            //Crio o método para o botão Sair
            DialogResult result;

            result = MessageBox.Show("Deseja realmente sair do cadastro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void cbxUFCadastroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse(cbxUFCadastroCliente.SelectedValue.ToString(), out int numero))
            {     
                int idUF = Convert.ToInt32(cbxUFCadastroCliente.SelectedValue.ToString());
                if (cbxUFCadastroCliente.SelectedValue.ToString() != "0")
                {
                    List<Cidades> listaCidade = new List<Cidades>();
                    listaCidade.Add(new Cidades() { IdCidade = 0, DsCidade = "SELECIONE" });
                    listaCidade.AddRange(cidadesService.FindByID(Convert.ToInt32(cbxUFCadastroCliente.SelectedValue.ToString())));

                    cbxCidadeCliente.DataSource = listaCidade;
                    cbxCidadeCliente.ValueMember = "IdCidade";
                    cbxCidadeCliente.DisplayMember = "DsCidade";
                }
            }
        }

        private void txtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            dgvPesquisaCliente.DataSource = clienteService.FindLike(txtPesquisaCliente.Text);
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        { 
            
            try
            {
                int id = int.Parse(txtIDCliente.Text);
                bool excluiu = clienteService.Delete(id);

                if (excluiu)
                {

                    MessageBox.Show("Cliente Excluido com sucesso");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataCadastro()
        {
            txtDTCadastroCadastroCliente.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            CarregarUF();
            CarregarSituacao();
            DataCadastro();
        }


        private void dgvPesquisaCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dataCadastro = Convert.ToDateTime(dgvPesquisaCliente.Rows[e.RowIndex].Cells[10].Value.ToString());
            DateTime dataNascimento = Convert.ToDateTime(dgvPesquisaCliente.Rows[e.RowIndex].Cells[3].Value.ToString());
            int numeroEndereco = Convert.ToInt32(dgvPesquisaCliente.Rows[e.RowIndex].Cells[5].Value.ToString());
            int ufID = Convert.ToInt32(dgvPesquisaCliente.Rows[e.RowIndex].Cells[8].Value.ToString());
            int situacaoID = Convert.ToInt32(dgvPesquisaCliente.Rows[e.RowIndex].Cells[9].Value.ToString());
            int cidadeID = Convert.ToInt32(dgvPesquisaCliente.Rows[e.RowIndex].Cells[11].Value.ToString());

            txtIDCliente.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeCliente.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCpfCliente.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDTNascimentoCliente.Text = dataNascimento.ToString();
            txtEnderecoCliente.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNumeroCliente.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtBairroCliente.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtcep.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbxUFCadastroCliente.SelectedValue = ufID;
            cbxSituacaoCadastroCliente.SelectedValue = situacaoID;
            txtDTCadastroCadastroCliente.Text = dataCadastro.ToString();
            cbxCidadeCliente.SelectedValue = cidadeID;
            txtRGCliente.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtCelularCliente.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[13].Value.ToString();

        }
    }


}

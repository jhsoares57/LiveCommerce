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
    public partial class FrmCadastroFuncionario : Form
    {
        UFBLL UFservice = new UFBLL();
        FuncionarioBLL funcionarioService = new FuncionarioBLL();
        SituacaoBLL situacaoService = new SituacaoBLL();
        SexoBLL sexoService = new SexoBLL();
        CidadesBLL cidadesService = new CidadesBLL();
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnSairCadastroFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            CarregarSituacao();
            CarregarSexo();
            CarregarUF();
        }

        private void limparCampo()
        {
            txtID.Clear();
            txtNomeFuncionario.Clear();
            txtCPFFuncionario.Clear();
            txtRGFuncionario.Clear();
            txtEnderecoFuncionario.Clear();
            txtCELFuncionario.Clear();
            txtEmailFuncionario.Clear();
            txtBairroFuncionario.Clear();
            cbxCidadeFuncionario.SelectedValue = 0;
           // txtDTFuncionario.();
            txtNumeroFuncionario.Clear();
            cbxSituacaoFuncionario.SelectedValue = 0;
            cbxUFcadastrofuncionario.SelectedValue = 0;
            cbxSexoCadastroFuncionario.SelectedValue = 0;
            txtSalarioBaseFuncionario.Clear();
            txtCEPFuncionario.Clear();
            txtNomeFuncionario.Focus();
        }

        private void CarregarSituacao()
        {
            List<Situacao> listaSituacao = new List<Situacao>();
            listaSituacao.Add(new Situacao() { IdSituacao = 0, DsSituacao = "SELECIONE" });
            listaSituacao.AddRange(situacaoService.FindALL());
            cbxSituacaoFuncionario.DataSource = listaSituacao;
            cbxSituacaoFuncionario.ValueMember = "idSituacao";
            cbxSituacaoFuncionario.DisplayMember = "DsSituacao";

        }

        private void CarregarSexo()
        {
            List<Sexo> listaSexo = new List<Sexo>();
            listaSexo.Add(new Sexo() { IdSexo = 0, DsSexo = "SELECIONE" });
            listaSexo.AddRange(sexoService.FindALL());
            cbxSexoCadastroFuncionario.DataSource = listaSexo;
            cbxSexoCadastroFuncionario.ValueMember = "idSexo";
            cbxSexoCadastroFuncionario.DisplayMember = "DsSexo";

        }

        public void CarregarUF()
        {
            List<UF> listaUF = new List<UF>();
            listaUF.Add(new UF() { IdUF = 0, DsUF = "SELECIONE" });
            listaUF.AddRange(UFservice.FindALL());
            cbxUFcadastrofuncionario.DataSource = listaUF;
            cbxUFcadastrofuncionario.ValueMember = "IdUF";
            cbxUFcadastrofuncionario.DisplayMember = "DsUF";
        }

        private void btnSalvarCadastroFuncionario_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cpfSomenteNumeros = txtCPFFuncionario.Text.Replace(",", " ").Replace("-", " ").Trim();
                if (string.IsNullOrEmpty(cpfSomenteNumeros))
                {
                    throw new CpfInvalidoException("CPF necessário para prosseguir!");

                }
                string NomeEx = txtNomeFuncionario.Text.Replace(" ", " ").Trim();
                if (string.IsNullOrEmpty(NomeEx))
                {
                    throw new CampoInvalidoException("Nome necessário para prosseguir!");

                }
                string EnderecoEx = txtEnderecoFuncionario.Text.Replace(" ", " ").Trim();
                if (string.IsNullOrEmpty(EnderecoEx))
                {
                    throw new CampoInvalidoException("Endereço necessário para prosseguir!");

                }
                string NumeroEx = txtNumeroFuncionario.Text.Replace(" ", " ").Trim();
                if (string.IsNullOrEmpty(NumeroEx))
                {
                    throw new CampoInvalidoException("Numero necessário para prosseguir!");

                }
                string bairroEx = txtBairroFuncionario.Text.Replace(" ", " ").Trim();
                if (string.IsNullOrEmpty(bairroEx))
                {
                    throw new CampoInvalidoException("Bairro necessário para prosseguir!");

                }
                string ufEx = cbxUFcadastrofuncionario.Text.Replace("SELECIONE", " ").Trim();
                if (string.IsNullOrEmpty(ufEx))
                {
                    throw new CampoInvalidoException("UF necessário para prosseguir!");

                }
                string CidadeEx = cbxCidadeFuncionario.Text.Replace("SELECIONE", " ").Trim();
                if (string.IsNullOrEmpty(CidadeEx))
                {
                    throw new CampoInvalidoException("Cidade necessário para prosseguir!");

                }
                string CepEx = txtCEPFuncionario.Text.Replace("_", " ").Replace("-"," ").Trim();
                if (string.IsNullOrEmpty(CepEx))
                {
                    throw new CampoInvalidoException("CEP necessário para prosseguir!");

                }
                string SituacaoEx = cbxSituacaoFuncionario.Text.Replace("SELECIONE", " ").Trim();
                if (string.IsNullOrEmpty(SituacaoEx))
                {
                    throw new CampoInvalidoException("Situação necessário para prosseguir!");

                }
                string SexoEx = cbxSexoCadastroFuncionario.Text.Replace("SELECIONE", " ").Trim();
                if (string.IsNullOrEmpty(SexoEx))
                {
                    throw new CampoInvalidoException("Sexo do Funcionário necessário para prosseguir!");

                }


                if (string.IsNullOrEmpty(txtID.Text))
                {
                    Funcionario F = new Funcionario();
                    F.NmFuncionario = txtNomeFuncionario.Text;
                    F.CfpFuncionario = txtCPFFuncionario.Text;
                    F.RGFuncionario = txtRGFuncionario.Text;
                    F.EndFuncionario = txtEnderecoFuncionario.Text;
                    F.TelFuncionario = txtCELFuncionario.Text;
                    F.EmailFuncionario = txtEmailFuncionario.Text;
                    F.BairroEndereco = txtBairroFuncionario.Text;
                    F.CEPFuncionario = txtCEPFuncionario.Text;
                    F.CidadeEndereco = Convert.ToInt32(cbxCidadeFuncionario.SelectedValue);                    
                    F.DataNascimento = Convert.ToDateTime(txtDTFuncionario.Text);
                    F.NumeroEndereco = Convert.ToInt32(txtNumeroFuncionario.Text);
                    F.IdSituacao = Convert.ToInt32(cbxSituacaoFuncionario.SelectedValue);
                    F.IdUF = Convert.ToInt32(cbxUFcadastrofuncionario.SelectedValue);
                    F.IdSexo = Convert.ToInt32(cbxSexoCadastroFuncionario.SelectedValue);
                    F.SalarioBase = Convert.ToSingle(txtSalarioBaseFuncionario.Text);


                    funcionarioService.Insert(F);
                    MessageBox.Show("Funcionario inserido com sucesso");
                    limparCampo();
                }
                else
                {
                    Funcionario F = new Funcionario();
                    F.IdFuncionario = Convert.ToInt32(txtID.Text);
                    F.NmFuncionario = txtNomeFuncionario.Text;
                    F.CfpFuncionario = txtCPFFuncionario.Text;
                    F.RGFuncionario = txtRGFuncionario.Text;
                    F.EndFuncionario = txtEnderecoFuncionario.Text;
                    F.TelFuncionario = txtCELFuncionario.Text;
                    F.EmailFuncionario = txtEmailFuncionario.Text;
                    F.BairroEndereco = txtBairroFuncionario.Text;
                    F.CEPFuncionario = txtCEPFuncionario.Text;
                    F.CidadeEndereco = Convert.ToInt32(cbxCidadeFuncionario.SelectedValue);                    
                    F.DataNascimento = Convert.ToDateTime(txtDTFuncionario.Text);
                    F.NumeroEndereco = Convert.ToInt32(txtNumeroFuncionario.Text);
                    F.IdSituacao = Convert.ToInt32(cbxSituacaoFuncionario.SelectedValue);
                    F.IdUF = Convert.ToInt32(cbxUFcadastrofuncionario.SelectedValue);
                    F.IdSexo = Convert.ToInt32(cbxSexoCadastroFuncionario.SelectedValue);
                    F.SalarioBase = Convert.ToSingle(txtSalarioBaseFuncionario.Text);


                    funcionarioService.Update(F);
                    MessageBox.Show("Funcionario atualizado com sucesso");
                    limparCampo();
                }

            }
            catch (CpfInvalidoException excpf)
            {
                MessageBox.Show(excpf.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSairCadastroFuncionario_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxUFcadastrofuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string UF = (cbxUFcadastrofuncionario.SelectedValue == null) ? string.Empty : cbxUFcadastrofuncionario.SelectedValue.ToString();

            if (int.TryParse(UF, out int numero))
            {
                int idUF = Convert.ToInt32(cbxUFcadastrofuncionario.SelectedValue.ToString());
                if (cbxUFcadastrofuncionario.SelectedValue.ToString() != "0")
                {
                    List<Cidades> listaCidade = new List<Cidades>();
                    listaCidade.Add(new Cidades() { IdCidade = 0, DsCidade = "SELECIONE" });
                    listaCidade.AddRange(cidadesService.FindByID(Convert.ToInt32(cbxUFcadastrofuncionario.SelectedValue.ToString())));

                    cbxCidadeFuncionario.DataSource = listaCidade;
                    cbxCidadeFuncionario.ValueMember = "IdCidade";
                    cbxCidadeFuncionario.DisplayMember = "DsCidade";
                }
            }
        }

        private void txtPesquisaFuncionario_TextChanged(object sender, EventArgs e)
        {
            dgvPesquisaFuncionario.DataSource = funcionarioService.FindLike(txtPesquisaFuncionario.Text);
        }

        private void dgvPesquisaFuncionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dataCadastro = Convert.ToDateTime(dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[7].Value.ToString());
            int numeroEndereco = Convert.ToInt32(dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[9].Value.ToString());
            int ufID = Convert.ToInt32(dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[11].Value.ToString());
            int situacaoID = Convert.ToInt32(dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[12].Value.ToString());
            int sexoID = Convert.ToInt32(dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[13].Value.ToString());
            int cidadeID = Convert.ToInt32(dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[14].Value.ToString());

            txtID.Text = dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeFuncionario.Text = dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCPFFuncionario.Text = dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRGFuncionario.Text = dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEnderecoFuncionario.Text = dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCELFuncionario.Text = dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmailFuncionario.Text = dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDTFuncionario.Text = dataCadastro.Date.ToString();
            txtBairroFuncionario.Text = dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtNumeroFuncionario.Text = numeroEndereco.ToString();
            txtSalarioBaseFuncionario.Text = dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[10].Value.ToString();            

            cbxUFcadastrofuncionario.SelectedValue = ufID;
            cbxSituacaoFuncionario.SelectedValue = situacaoID;
            cbxSexoCadastroFuncionario.SelectedValue = sexoID;
            cbxCidadeFuncionario.SelectedValue = cidadeID;

            txtCEPFuncionario.Text = dgvPesquisaFuncionario.Rows[e.RowIndex].Cells[15].Value.ToString();


        }

        private void btnExcluirCadastroFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                bool excluiu = funcionarioService.Delete(id);

                if (excluiu)
                {

                    MessageBox.Show("Funcionário Excluido com sucesso");
                   


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

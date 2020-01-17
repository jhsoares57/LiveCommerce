using LiveCommerce.Business;
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
    public partial class FrmSelecionar : Form
    {
        public enum Pesquisa
        {
            Cliente,
            Produto,
            Agendamento
        }

        public Pesquisa TipoPesquisa { get; set; }

        ProdutoBLL pBLL = new ProdutoBLL();
        ClienteBLL cBLL = new ClienteBLL();

        private Form f;
        public Form F { get => f; set => f = value; }


        public FrmSelecionar()
        {
            InitializeComponent();
        }

        public FrmSelecionar(FrmVendas venda)
        {            
            InitializeComponent();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (this.TipoPesquisa == Pesquisa.Cliente)
            {
                dgvPesquisa.DataSource = cBLL.FindLikeOLD(txtPesquisa.Text);
            }
            else if (this.TipoPesquisa == Pesquisa.Produto)
            {
                dgvPesquisa.DataSource = pBLL.FindLike(txtPesquisa.Text);
            }
            //else if(this.TipoPesquisa == Pesquisa.Agendamento)
            //{
            //    dgvPesquisa.DataSource = aBLL.FindByCliente(txtPesquisa.Text); 
            //}
        }

        private void dgvPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.TipoPesquisa == Pesquisa.Cliente)
            {
                if (Application.OpenForms.OfType<FrmVendas>().Count() > 0)
                {

                    int id = Convert.ToInt32(dgvPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString());
                    ((FrmVendas)f).CarregarClienteSelecionadoPesquisa(id);
                    this.Close();
                }


            }
            else if (this.TipoPesquisa == Pesquisa.Produto)
            {
                if (Application.OpenForms.OfType<FrmVendas>().Count() > 0)
                {
                    int id = Convert.ToInt32(dgvPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString());
                    ((FrmVendas)f).CarregarProdutoSelecionadoPesquisa(id);
                    this.Close();
                }

            }
            //else if(this.TipoPesquisa == Pesquisa.Agendamento)
            //{

            //    if (Application.OpenForms.OfType<FrmCadastroAgendamento>().Count() > 0)
            //    {
            //        int id = Convert.ToInt32(dgvPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString());
            //        ((FrmCadastroAgendamento)f).CarregarClienteSelecionadoPesquisa(id);
            //        this.Close();
            //    }


            //}
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using LiveCommerce.Business;
using LiveCommerce.DAL;
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
    public partial class FrmListaVendas : Form
    {
        VendaBLL vendaService = new VendaBLL();
        public static int id;

        public FrmListaVendas()
        {
            InitializeComponent();
        }

        private void FrmListaVendas_Load(object sender, EventArgs e)
        {
            CarregarVendas();            
        }

        private void btnAdicionarVenda_Click_1(object sender, EventArgs e)
        {
          
            FrmVendas frmVenda = new FrmVendas();
            frmVenda.Show();
            this.Visible = false;
        }

        private void btnSairlistaVendas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregarVendas()
        {
            dgvVendasDias.DataSource = vendaService.FindByDia(txtPeriodo.Text);
        }

        private void txtPeriodo_TextChanged(object sender, EventArgs e)
        {
            CarregarVendas();
        }        

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Venda v = new Venda();
                v.IdVenda = id;

                

                if (v.IdVenda > 0)
                {
                    vendaService.CancelarVenda(v);
                    MessageBox.Show("VENDA CANCELADA");
                    CarregarVendas();
                }
                else
                {
                    MessageBox.Show("SELECIONE UMA VENDA");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("SELECIONE UMA VENDA");
            }
            
        }

        private void dgvVendasDias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvVendasDias.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("SELECIONE UMA VENDA");
            }
            
        }

        private void btnImprimirVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Venda v = new Venda();
                v.IdVenda = id;



                if (v.IdVenda > 0)
                {
                    vendaService.ImprimeVnedaParam(v);
                    ImprimirVenda();
                }
                else
                {
                    MessageBox.Show("SELECIONE UMA VENDA");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("SELECIONE UMA VENDA");
            }
        }
        private void ImprimirVenda()
        {
            Impressao.FrmImprimirVenda FrImprimi = new Impressao.FrmImprimirVenda();
            FrImprimi.Show();
        }
    }
}

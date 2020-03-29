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
    public partial class FrmPlanoDePagamento : Form
    {
        FormaPagamentoBLL formaService = new FormaPagamentoBLL();
        PlanoPagamentoBLL pagaService = new PlanoPagamentoBLL();
        public FrmPlanoDePagamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarFormaPagamento()
        {
            cbxFormaPagamento.DataSource = formaService.FindALL();
            cbxFormaPagamento.ValueMember = "idFormaPagamento";
            cbxFormaPagamento.DisplayMember = "dsFormaPagamento";
        }

        private void FrmPlanoDePagamento_Load(object sender, EventArgs e)
        {
            CarregarFormaPagamento();
        }

        private void btnSalvarPlano_Click(object sender, EventArgs e)
        {
            try
            {
                PlanoPagamento P = new PlanoPagamento();
               
                P.DsPlanoPagamento = txtDescricaoPlanoPagamento.Text;
                P.QtParcelas = Convert.ToInt32(txtQuantidadeParcelas.Text);
                P.VlMinimo = Convert.ToSingle(txtValorMinimo.Text);
                P.IdFormaPagamento = Convert.ToInt32(cbxFormaPagamento.SelectedValue);


                //P.NcmProduto = Convert.ToInt32(txtNCMProduto.Text);
                //P.CstProduto = Convert.ToInt32(txtCTSProduto.Text);
                //P.IcmsProduto = Convert.ToInt32(txtICMSProduto.Text);




                pagaService.Insert(P);


                MessageBox.Show("Inserido com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

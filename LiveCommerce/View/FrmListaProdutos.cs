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
    public partial class FrmListaProdutos : Form
    {
        public enum TipoPesquisa
        {
            Cliente = 1,
            Pet
        }

        private TipoPesquisa pesquisa;
        public TipoPesquisa Pesquisa { get => pesquisa; set => pesquisa = value; }

        public FrmListaProdutos()
        {
            InitializeComponent();

            if (pesquisa == TipoPesquisa.Cliente)
            {
                label4.Text = "Pesquisa de produtos";
            }
        }

        private void btnSairListaProdutos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (pesquisa == TipoPesquisa.Cliente)
            {

            }
            else if (pesquisa == TipoPesquisa.Pet)
            {

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (pesquisa == TipoPesquisa.Cliente)
            {

            }
            else if (pesquisa == TipoPesquisa.Pet)
            {

            }
        }
    }
}

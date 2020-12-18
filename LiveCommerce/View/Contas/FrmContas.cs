﻿using DGVPrinterHelper;
using LiveCommerce.Business;
using LiveCommerce.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LiveCommerce.View.Contas
{
    public partial class FrmContas : Form
    {
        ListaGenericaBLL ListServive = new ListaGenericaBLL();
        FornecedorBLL fornecedorService = new FornecedorBLL();
        ContasPagarReceberBLL contaService = new ContasPagarReceberBLL();
        ClienteBLL ClienteService = new ClienteBLL();
        public static int id;
        public static string obs;
        public static decimal total;
        public FrmContas()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                string AtivoEx = cbxTipoLabnc.Text.Replace("SELECIONE", "").Trim();
                if (string.IsNullOrEmpty(AtivoEx))
                {
                    throw new CpfInvalidoException("Informe um tipo de conta!");

                }

                string oriex = cbxOrigem.Text.Replace("SELECIONE", "").Trim();
                if (string.IsNullOrEmpty(oriex))
                {
                    throw new CpfInvalidoException("Informe uma origem!");

                }

                string valorex = txtValor.Text;
                if (string.IsNullOrEmpty(valorex))
                {
                    throw new CpfInvalidoException("Informe um valor!");

                }

                ContasPagarReceber P = new ContasPagarReceber();
                P.CtpCont = Convert.ToInt32(cbxTipoLabnc.SelectedValue);
                P.CdtLanc = Convert.ToDateTime(txtDtLanc.Text);
                P.CcodOri = Convert.ToInt32(cbxOrigem.SelectedValue);
                P.CvlrCnt = Convert.ToDouble(txtValor.Text);
                P.CdtVcto = Convert.ToDateTime(txtDtPagamento.Text);
                P.Cobs = txtObservacao.Text;
                P.CsNrDoc = txtnrdoc.Text;

                contaService.Insert(P);

                MessageBox.Show("Conta Lançada com Sucesso!!!", "Mensagem do Sistema");
                LimparDados();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
           

          
        }

        public void LimparDados()
        {
            carregarTipo();
            txtValor.Clear();
            txtObservacao.Clear();
        }

        private void carregarTipo()
        {
            List<ListaGenerica> ListTipoConta = new List<ListaGenerica>();
            ListTipoConta.Add(new ListaGenerica() { CodItem = 0, DescricaoItem = "SELECIONE" });
            ListTipoConta.AddRange(ListServive.TipoConta());
            cbxTipoLabnc.DataSource = ListTipoConta;
            cbxTipoLabnc.ValueMember = "CodItem";
            cbxTipoLabnc.DisplayMember = "DescricaoItem";
        }

        private void carregarTipoFiltro()
        {
            List<ListaGenerica> ListTipoConta = new List<ListaGenerica>();
            ListTipoConta.Add(new ListaGenerica() { CodItem = 0, DescricaoItem = "SELECIONE" });
            ListTipoConta.AddRange(ListServive.TipoConta());
            cbxFiltroTipo.DataSource = ListTipoConta;
            cbxFiltroTipo.ValueMember = "CodItem";
            cbxFiltroTipo.DisplayMember = "DescricaoItem";
        }

        private void CarregarFornecedor()
        {
            List<Fornecedor> listaFornecedor = new List<Fornecedor>();
            listaFornecedor.Add(new Fornecedor() { IdFornecedor = 0, NomeFantasia = "SELECIONE" });
            listaFornecedor.AddRange(fornecedorService.FindNome());
            cbxOrigem.DataSource = listaFornecedor;
            cbxOrigem.ValueMember = "IdFornecedor";
            cbxOrigem.DisplayMember = "NomeFantasia";
        }

        private void CarregarCliente()
        {
            List<Cliente> listaFornecedor = new List<Cliente>();
            listaFornecedor.Add(new Cliente() { ID = 0, NomeCliente = "SELECIONE" });
            listaFornecedor.AddRange(ClienteService.FindNome());
            cbxOrigem.DataSource = listaFornecedor;
            cbxOrigem.ValueMember = "ID";
            cbxOrigem.DisplayMember = "NomeCliente";
        }

        private void FrmContas_Load(object sender, EventArgs e)
        {
            carregarTipo();
            carregarTipoFiltro();
        }

        private void cbxTipoLabnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = (cbxTipoLabnc.SelectedValue == null) ? string.Empty : cbxTipoLabnc.SelectedValue.ToString();

            if (int.TryParse(tipo, out int numero))
            {
                int idUF = Convert.ToInt32(cbxTipoLabnc.SelectedValue.ToString());
                if (cbxTipoLabnc.SelectedValue.ToString() == "1")
                {
                    CarregarFornecedor();
                }
                else
                {
                    CarregarCliente();
                }
            }
        }

        public void CarregarConta()
        {
            int tipo = Convert.ToInt32(cbxFiltroTipo.SelectedValue);
            dgvContas.DataSource = contaService.FindFiltroTipo(tipo);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarConta();


            total = 0;
            foreach (DataGridViewRow linha in dgvContas.Rows)
            {
                total += Convert.ToDecimal(linha.Cells[4].Value);
            }

            txtTotalContas.Text = total.ToString();
        }

        private void btnRealizarPagamento_Click(object sender, EventArgs e)
        {
                try
                {
                    ContasPagarReceber v = new ContasPagarReceber();
                    v.CodCont = id;



                    if (v.CodCont > 0)
                    {
                    //contaService.PagamentoConta(v);
                    PagamentoConta(v.CodCont);
                        MessageBox.Show("Conta Paga com sucesso!");
                        CarregarConta();
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma conta!");
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Selecione uma conta!");
                }

            
        }

        private void PagamentoConta(int idc)
        {
            ContasPagarReceber p = new ContasPagarReceber();
            p.DdtPag = Convert.ToDateTime(txtDataPagamentoFim.Text);
            p.Status = "P";
            p.CodCont = Convert.ToInt32(idc);
            

            contaService.PagamentoConta(p);

        }

        private void CancelamentoConta(int idc)
        {
            ContasPagarReceber p = new ContasPagarReceber();
            p.DdtPag = Convert.ToDateTime(txtDataCancelamento.Text);
            p.Status = "C";
            p.CodCont = Convert.ToInt32(idc);


            contaService.PagamentoConta(p);

        }

        private void dgvContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                string dt;
                dt = Convert.ToString(dgvContas.Rows[e.RowIndex].Cells[6].Value.ToString());
                if (dt != "")
                {
                    //id = Convert.ToInt32(dgvContas.Rows[e.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Conta já paga! Selecione uma outra conta.");
                    gpCancelamento.Enabled = false;
                    gpPagemento.Enabled = false;
                }
                else
                {
                    id = Convert.ToInt32(dgvContas.Rows[e.RowIndex].Cells[0].Value.ToString());
                    gpCancelamento.Enabled = true;
                    gpPagemento.Enabled = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione uma conta!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                ContasPagarReceber v = new ContasPagarReceber();
                v.CodCont = id;
                v.Cobs = obs;



                if (v.CodCont > 0)
                {
                    if(v.Cobs != "Conta Lançada a partir da venda") { 
                    //contaService.PagamentoConta(v);
                    CancelamentoConta(v.CodCont);
                    MessageBox.Show("Conta cancelada com sucesso!");
                    CarregarConta();
                    }
                    else
                    {
                        MessageBox.Show("Conta lançada a partir de uma venda, \n por favor cancele a venda!");
                        CarregarConta();
                    }
                }
                if (v.CodCont <= 0)
                {
                    MessageBox.Show("Selecione uma conta!");
                    CarregarConta();
                }
                else
                {
                    MessageBox.Show("Selecione uma conta!");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Selecione uma conta!");
            }
        }
        Bitmap bitmap;
        private void txtImprimir_Click(object sender, EventArgs e)
        {
            this.printDocument.DefaultPageSettings.Landscape = true;
            DGVPrinter print = new DGVPrinter();
            print.Title = "Relatório de Contas a Pagar/Receber"; //Titulo da Página
            print.PageSettings.Landscape = true;

            // print.SubTitle = "Relatorio de Contas a Pagar/Receber"; //SubTitulo da Página
            //print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            //print.PageNumbers = true;
            //print.PageNumberInHeader = false;
            //print.PorportionalColumns = false;
            //print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "LiveCommerce";
            print.FooterSpacing = 15;

            //print.PrintPreviewDataGridView(dgvContas);
            print.PrintDataGridView(dgvContas);
          

        }
       
    }
}

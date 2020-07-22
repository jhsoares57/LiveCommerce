using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class Venda
    {
        private int idVenda;

        private int id_funcionario;

        private int idCliente;

        private int iDProduto;

        private float valorFinalProdutos;

        private int idPagamento;

        private float calcularImposto;

        private DateTime dataVenda;

        private DateTime horaVenda;

        private List<VendaItens> listaVendasItens;

        private float valorParcela;

        private int qtdParcelas;

        
        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int Id_funcionario { get => id_funcionario; set => id_funcionario = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        
        public float ValorFinalProdutos { get => valorFinalProdutos; set => valorFinalProdutos = value; }
        public int IdPagamento { get => idPagamento; set => idPagamento = value; }
        public float CalcularImposto { get => calcularImposto; set => calcularImposto = value; }
        public int IDProduto { get => iDProduto; set => iDProduto = value; }
        public List<VendaItens> ListaVendasItens { get => listaVendasItens; set => listaVendasItens = value; }
        public DateTime DataVenda { get => dataVenda; set => dataVenda = value; }
        public DateTime HoraVenda { get => horaVenda; set => horaVenda = value; }
        public float ValorParcela { get => valorParcela; set => valorParcela = value; }
        public int QtdParcelas { get => qtdParcelas; set => qtdParcelas = value; }
    }
}

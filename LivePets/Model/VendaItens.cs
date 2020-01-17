using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class VendaItens
    {
        private int iDVendaItens;

        private int idProduto;

        private int idVenda;

        private int qtProduto;

        private string nomeProduto;

        private double valorUnitario;

        private double valorTotal;

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int QtProduto { get => qtProduto; set => qtProduto = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        public int IDVendaItens { get => iDVendaItens; set => iDVendaItens = value; }
    }
}

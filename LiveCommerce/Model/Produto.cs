using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class Produto
    {
        private int id;       

        private string nomeProduto;

        private decimal valorUnitarioProduto;

        private string cDBarras;

        private decimal valorCompra; 
        

        private int quantidadeProduto;

        private int idFornecedor;

        private int idTipoProduto;

        private int unidadeMedida;

        private int categoriaProduto;

        private int formaCompra;

        private int ncmProduto;

        private int cstProduto;

        private int icmsProduto;

        private DateTime dTCadastro;

        private float lucroProduto;

        private string referencia;

        

        public int Id { get => id; set => id = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }        
        public int QuantidadeProduto { get => quantidadeProduto; set => quantidadeProduto = value; }
        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public int IdTipoProduto { get => idTipoProduto; set => idTipoProduto = value; }
        
       
        public int NcmProduto { get => ncmProduto; set => ncmProduto = value; }
        public int CstProduto { get => CstProduto1; set => CstProduto1 = value; }
        public int CstProduto1 { get => cstProduto; set => cstProduto = value; }
        public int IcmsProduto { get => icmsProduto; set => icmsProduto = value; }
       
       
        public DateTime DTCadastro { get => dTCadastro; set => dTCadastro = value; }        
        public string CDBarras { get => cDBarras; set => cDBarras = value; }        
        public int CategoriaProduto { get => categoriaProduto; set => categoriaProduto = value; }
        public int UnidadeMedida { get => unidadeMedida; set => unidadeMedida = value; }
        public int FormaCompra { get => formaCompra; set => formaCompra = value; }        
        public float LucroProduto { get => lucroProduto; set => lucroProduto = value; }
        public decimal ValorUnitarioProduto { get => valorUnitarioProduto; set => valorUnitarioProduto = value; }
        public decimal ValorCompra { get => valorCompra; set => valorCompra = value; }
        public string Referencia { get => referencia; set => referencia = value; }
    }
}

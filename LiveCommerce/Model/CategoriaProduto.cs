using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class CategoriaProduto
    {
        private int idCategoriaProduto;

        private string dsCategoriaProduto;

        public int IdCategoriaProduto { get => idCategoriaProduto; set => idCategoriaProduto = value; }
        public string DsCategoriaProduto { get => dsCategoriaProduto; set => dsCategoriaProduto = value; }
    }
}

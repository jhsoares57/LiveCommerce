using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class TipoProduto
    {
        private int iDTipoProduto;

        private string descricaoTipoProduto;

        public int IDTipoProduto { get => iDTipoProduto; set => iDTipoProduto = value; }
        public string DescricaoTipoProduto { get => descricaoTipoProduto; set => descricaoTipoProduto = value; }
    }
}

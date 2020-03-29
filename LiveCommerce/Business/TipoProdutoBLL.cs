using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class TipoProdutoBLL
    {
        public List<TipoProduto> FindTipoProduto()
        {
            TipoProdutoDAL TDAL = new TipoProdutoDAL();
            return TDAL.FindALL();
        }
    }
}

using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class CategoriaProdutoBLL
    {
        public List<CategoriaProduto> FindALL()
        {
            CategoriaProdutoDAL CDAL = new CategoriaProdutoDAL();
            return CDAL.FindByDSCategoriaProduto();
        }
    }
}

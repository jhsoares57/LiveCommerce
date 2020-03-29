using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
  public  class ProdutoBLL
    {
        public bool Insert(Produto c)
        {
            bool salvou = false;
            new ProdutoDAL().Insert(c);
            return salvou;
        }

        public DataTable FindLike(string termo)
        {
            return new ProdutoDAL().FindLike(termo);
        }

        public DataTable FindAll(string termo)
        {
            return new ProdutoDAL().FindAll(termo);
        }

        public bool Update(Produto p)
        {
            bool atualizou = false;
            ProdutoDAL pDAL = new ProdutoDAL();

            if(pDAL.Update(p) > 0)
            {
                atualizou = true;
            }

            return atualizou;
        }

        public Produto FindById(int id)
        {
            return new ProdutoDAL().FindById(id);
        }
    }
}

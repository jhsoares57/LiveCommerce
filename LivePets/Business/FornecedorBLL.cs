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
        public  class FornecedorBLL
    {
        public bool Insert(Fornecedor c)
        {
            bool salvou = false;
            new FornecedorDAL().Insert(c);
            return salvou;

        }

        public DataTable FindLike(string termo1)
        {
            return new FornecedorDAL().FindLike(termo1);
        }

        public bool Update(Fornecedor F)
        {
            bool atualizou = false;
            FornecedorDAL fDAL = new FornecedorDAL();

            if (fDAL.Update(F) > 0)
            {
                atualizou = true;
            }

            return atualizou;
        }
        public List<Fornecedor> FindNome()
        {
            FornecedorDAL forDAL = new FornecedorDAL();
            return forDAL.FindNome();
        }
        public bool Delete(int id)
        {
            bool deletou = false;
            FornecedorDAL dDAL = new FornecedorDAL();
            if (dDAL.Delete(id) > 0)
            {
                deletou = true;
            }
            return deletou;
        }
    }
}

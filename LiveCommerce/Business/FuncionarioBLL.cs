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
    public class FuncionarioBLL
    {
        public bool Insert(Funcionario F)
        {
            bool salvou = false;
            new FuncionarioDAL().Insert(F);
            return salvou;

        }
        public List<Funcionario> FindAll()
        {
            FuncionarioDAL UserDAL = new FuncionarioDAL();
            return UserDAL.FindAll();
        }

        public DataTable FindLike(string termo)
        {
            return new FuncionarioDAL().FindLike(termo);
        }

        public bool Update(Funcionario F)
        {
            bool atualizou = false;
            FuncionarioDAL fDAL = new FuncionarioDAL();

            if (fDAL.Update(F) > 0)
            {
                atualizou = true;
            }

            return atualizou;
        }
        public bool Delete(int id)
        {
            bool deletou = false;
            FuncionarioDAL dDAL = new FuncionarioDAL();
            if (dDAL.Delete(id) > 0)
            {
                deletou = true;
            }
            return deletou;
        }
    }
}

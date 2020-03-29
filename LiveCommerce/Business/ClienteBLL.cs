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
    public class ClienteBLL
    {
        public void Insert(Cliente C)
        {
            new ClienteDAL().Insert(C);            
        }

        public DataTable FindLike(string termo)
        {
            return new ClienteDAL().FindLike(termo);
        }

        public DataTable FindLikeOLD(string termo)
        {
            return new ClienteDAL().FindLikeOld(termo);
        }

        public bool Update(Cliente c)
        {
            bool atualizou = false;
            ClienteDAL cDAL = new ClienteDAL();

            if (cDAL.Update(c) > 0)
            {
                atualizou = true;
            }

            return atualizou;
        }
        public bool Delete(int id)
        {
            bool deletou = false;
            ClienteDAL dDAL = new ClienteDAL();
            if (dDAL.Delete(id) > 0)
            {
                deletou = true;
            }
            return deletou;
        }

        public Cliente FindById(int id)
        {
            return new ClienteDAL().FindById(id);
        }

        public List<Cliente> FindNome()
        {
            ClienteDAL forDAL = new ClienteDAL();
            return forDAL.FindNome();
        }

    }
}

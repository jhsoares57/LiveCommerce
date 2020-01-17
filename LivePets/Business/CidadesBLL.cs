using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class CidadesBLL
    {
        public List<Cidades> FindByID(int id)
        {
            CidadesDAL CDAL = new CidadesDAL();
            return CDAL.FindByID(id);
        }
    }
}

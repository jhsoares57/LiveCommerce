using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class ListaGenericaBLL
    {
        public List<ListaGenerica> TipoConta()
        {
            ListaGenericaDAL tDAL = new ListaGenericaDAL();
            return tDAL.TipoConta();
        }
    }
}

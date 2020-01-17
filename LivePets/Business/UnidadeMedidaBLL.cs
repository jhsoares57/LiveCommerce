using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class UnidadeMedidaBLL
    {
        public List<UnidadeMedida> FindALL()
        {
            UnidadeMedidaDAL uDAL = new UnidadeMedidaDAL();
            return uDAL.FindALL();
        }
    }
}

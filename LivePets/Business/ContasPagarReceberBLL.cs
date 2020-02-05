using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class ContasPagarReceberBLL
    {
        public bool Insert(ContasPagarReceber c)
        {
            bool salvou = false;
            new ContasPagarReceberDAL().Insert(c);

            //Se o ID for maior que zero, indica que o dado foi salvo
            if (c.CodCont > 0)
            {
                salvou = true;
            }
            return salvou;
        }
    }
}

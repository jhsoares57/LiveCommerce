using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class PlanoPagamentoBLL
    {
        public bool Insert(PlanoPagamento p)
        {
            bool salvou = false;
            new PlanoPagamentoDAL().Insert(p);
            return salvou;

        }

        public List<FormaPagamento> FindALL()
        {
            FormaPagamentoDAL CDAL = new FormaPagamentoDAL();
            return CDAL.FindALL();
        }
    }
}

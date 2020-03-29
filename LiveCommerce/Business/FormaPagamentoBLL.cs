using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class FormaPagamentoBLL
    {
        public bool Insert(FormaPagamento P)
        {
            bool salvou = false;
            new FormaPagamentoDAL().Insert(P);
            return salvou;

        }
        public List<FormaPagamento> FindALL()
        {
            FormaPagamentoDAL FDAL = new FormaPagamentoDAL();
            return FDAL.FindALL();
        }
    }
}

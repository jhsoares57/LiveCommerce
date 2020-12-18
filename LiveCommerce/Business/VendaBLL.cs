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
    public class VendaBLL
    {
        public void Insert(Venda V)
        { 
            new VendaDAL().Insert(V);
        }

        public DataTable FindByDia(string data)
        {
            return new VendaDAL().FindByDia(data);
        }

        public bool CancelarVenda(Venda v)
        {
            bool atualizou = false;
            VendaDAL vendaDAL = new VendaDAL();
            int ID_Venda = v.IdVenda;


            if (vendaDAL.CancelarVenda(v) > 0)
            {
                    atualizou = true;
            }

            return atualizou;
        }

        public bool ImprimeVnedaParam(Venda v)
        {
            bool atualizou = false;
            VendaDAL vendaDAL = new VendaDAL();

            if (vendaDAL.ParamImprimeVenda(v) > 0)
            {
                atualizou = true;
            }

            return atualizou;
        }

    }
}

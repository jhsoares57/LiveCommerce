using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable FindFiltroTipo(int tipo)
        {
            return new ContasPagarReceberDAL().FindFiltroTipo(tipo);
        }

        public bool PagamentoConta(ContasPagarReceber c)
        {
            bool atualizou = false;
            ContasPagarReceberDAL cDAL = new ContasPagarReceberDAL();

            if (c.CodCont == 0)
            {
                throw new Exception("Selecione um contato para atualizar.");
            }

            if (cDAL.PagamentoConta(c) > 0)
            {
                //Este IF verificará se o retorno do método será maior que 0,
                //ou seja, se a atualização foi feita pela classe que acessa o Banco
                //se sim vai mudar para TRUE a variável e retornar para quem chamou este método.
                atualizou = true;
            }
            return atualizou;
        }
    }
}

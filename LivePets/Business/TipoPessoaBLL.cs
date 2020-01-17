using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class TipoPessoaBLL
    {
        public List<TipoPessoa> FindALL()
        {
            TipoPessoaDAL tDAL = new TipoPessoaDAL();
            return tDAL.FindALL();
        }
    }
}

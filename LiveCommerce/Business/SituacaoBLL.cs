using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class SituacaoBLL
    {
        public List<Situacao> FindALL()
        {
            SituacaoDAL FDAL = new SituacaoDAL();
            return FDAL.FindALL();
        }
    }
}

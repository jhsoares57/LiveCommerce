using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class UFBLL
    {
        public List<UF>FindALL()
        {
            UFDAL FDAL = new UFDAL();
            return FDAL.FindALL();
        }
    }
}

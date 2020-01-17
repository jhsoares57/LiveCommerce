using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business.Exceptions
{
   public class CpfInvalidoException: Exception
    {
        public CpfInvalidoException() : base()
        {

        }

        public CpfInvalidoException(string message)
           : base(message)
        {
        }

    }
}

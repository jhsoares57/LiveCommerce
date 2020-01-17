using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business.Exceptions
{
   public class CampoInvalidoException : Exception
    {
        public CampoInvalidoException() : base()
        {

        }

        public CampoInvalidoException(string message)
           : base(message)
        {
        }
    }
}

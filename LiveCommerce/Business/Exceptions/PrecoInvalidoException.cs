using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business.Exceptions
{
    public class PrecoInvalidoException: Exception
    {
        public PrecoInvalidoException() : base()
        {

        }
        public PrecoInvalidoException(string message)
            : base(message)
        {
        }

    }
}

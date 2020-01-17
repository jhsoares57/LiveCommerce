using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business.Exceptions
{
    public class CPF_CNPJException : Exception
    {
        public CPF_CNPJException() : base()
        {

        }

        public CPF_CNPJException(string message)
           : base(message)
        {
        }
    }
}

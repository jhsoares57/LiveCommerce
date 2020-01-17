using System;
using System.Runtime.Serialization;

namespace LiveCommerce.View
{
    [Serializable]
    internal class CpfInvalidoException : Exception
    {
        public CpfInvalidoException()
        {
        }

        public CpfInvalidoException(string message) : base(message)
        {
        }

        public CpfInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CpfInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class TipoPessoa
    {
        private int iDPessoa;

        private string dSPessoa;

        public int IDPessoa { get => iDPessoa; set => iDPessoa = value; }
        public string DSPessoa { get => dSPessoa; set => dSPessoa = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
   public class Situacao
    {
        private int idSituacao;

        private string dsSituacao;

        public string DsSituacao { get => dsSituacao; set => dsSituacao = value; }
        public int IdSituacao { get => idSituacao; set => idSituacao = value; }
    }
}

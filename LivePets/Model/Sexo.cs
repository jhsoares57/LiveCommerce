using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class Sexo
    {
        private int idSexo;

        private string dsSexo;

        public int IdSexo { get => idSexo; set => idSexo = value; }
        public string DsSexo { get => dsSexo; set => dsSexo = value; }
    }
}

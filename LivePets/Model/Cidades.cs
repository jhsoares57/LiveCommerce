using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class Cidades
    {
        private int idCidade;

        private string dsCidade;

        private int idUF;

        public int IdCidade { get => idCidade; set => idCidade = value; }
        public string DsCidade { get => dsCidade; set => dsCidade = value; }
        public int IdUF { get => idUF; set => idUF = value; }
    }
}

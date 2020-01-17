using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class UnidadeMedida
    {
        private int iDMedida;

        private string descricaoMedida;

        public int IDMedida { get => iDMedida; set => iDMedida = value; }
        public string DescricaoMedida { get => descricaoMedida; set => descricaoMedida = value; }
    }
}

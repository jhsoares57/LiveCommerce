using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class ListaGenerica
    {
        private int idLista;
        private int codItem;
        private string descricaoItem;
        private int codTipo;

        public int IdLista { get => idLista; set => idLista = value; }
        public int CodItem { get => codItem; set => codItem = value; }
        public string DescricaoItem { get => descricaoItem; set => descricaoItem = value; }
        public int CodTipo { get => codTipo; set => codTipo = value; }
    }
}

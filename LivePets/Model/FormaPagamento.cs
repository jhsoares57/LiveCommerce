using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class FormaPagamento
    {
        private int idFormaPagamento;

        private string dsFormaPagamento;

        private int financeiro;

        public int IdFormaPagamento { get => idFormaPagamento; set => idFormaPagamento = value; }
        public string DsFormaPagamento { get => dsFormaPagamento; set => dsFormaPagamento = value; }
        public int Financeiro { get => financeiro; set => financeiro = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class PlanoPagamento
    {
        private int idPlanoPagamento;

        private string dsPlanoPagamento;

        private float vlMinimo;

        private int qtParcelas;

        private int idFormaPagamento;

        public int IdFormaPagamento { get => idFormaPagamento; set => idFormaPagamento = value; }
        public int IdPlanoPagamento { get => idPlanoPagamento; set => idPlanoPagamento = value; }
        public string DsPlanoPagamento { get => dsPlanoPagamento; set => dsPlanoPagamento = value; }

        public int QtParcelas { get => qtParcelas; set => qtParcelas = value; }
        public float VlMinimo { get => vlMinimo; set => vlMinimo = value; }
    }
}

using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.DAL
{
    public class PlanoPagamentoDAL
    {
        ConnectionFactory cf;

        public void Insert(PlanoPagamento A)
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            query.AppendLine("INSERT INTO PLANO_DE_PAGAMENTO");
            query.AppendLine("(DS_PLANOPAGAMENTO, VL_MINIMO, QT_PARCELAS, ID_FORMAPAGAMENTO)");
            query.AppendLine("VALUES (@DS_PLANOPAGAMENTO, @VL_MINIMO, @QT_PARCELAS, @ID_FORMAPAGAMENTO)");
            query.AppendLine("SELECT SCOPE_IDENTITY();");
            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("@DS_PLANOPAGAMENTO", A.DsPlanoPagamento);
            cf.Comando.Parameters.AddWithValue("@VL_MINIMO", A.VlMinimo);
            cf.Comando.Parameters.AddWithValue("@QT_PARCELAS", A.QtParcelas);
            cf.Comando.Parameters.AddWithValue("@ID_FORMAPAGAMENTO", A.IdFormaPagamento);

            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();

            A.IdPlanoPagamento = Convert.ToInt32(cf.Comando.ExecuteScalar());
            cf.Conexao.Close();
        }
    }
}

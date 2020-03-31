using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.DAL
{
    public class VendasItensDAL
    {
        //ConnectionFactory cf;

        public void Insert(VendaItens V, ConnectionFactory cf)
        {
            try
            {     
                StringBuilder query = new StringBuilder();
                query.AppendLine(" INSERT INTO VENDA_ITENS");
                query.AppendLine("(ID_PRODUTO, ID_VENDA, VALOR_PRODUTO, QT_PRODUTO, VALOR_TOTAL)");
                query.AppendLine("VALUES (@ID_PRODUTO, @ID_VENDA, @VALOR_PRODUTO, @QT_PRODUTO, @VALOR_TOTAL)");
                query.AppendLine("SELECT SCOPE_IDENTITY();");

                cf.Comando.Parameters.Clear();

                cf.Comando.Parameters.AddWithValue("@ID_PRODUTO", V.IdProduto);
                cf.Comando.Parameters.AddWithValue("@ID_VENDA", V.IdVenda);
                cf.Comando.Parameters.AddWithValue("@VALOR_PRODUTO", V.ValorUnitario);
                cf.Comando.Parameters.AddWithValue("@QT_PRODUTO", V.QtProduto);
                cf.Comando.Parameters.AddWithValue("@VALOR_TOTAL", V.ValorTotal);

                cf.Comando.CommandType = CommandType.Text;
                cf.Comando.CommandText = query.ToString();

                V.IdProduto = Convert.ToInt32(cf.ExecScalar());
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

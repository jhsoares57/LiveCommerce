using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.DAL
{
    public class VendaDAL
    {
        ConnectionFactory cf;

        public void Insert(Venda v)
        {
            try
            {
                cf = new ConnectionFactory();

                StringBuilder query = new StringBuilder();

                query.AppendLine("INSERT INTO VENDA");
                query.AppendLine("(VL_FINAL_VENDA, DT_VENDA, STATUS, HORA_VENDA,  ID_FUNCIONARIO, ID_CLIENTE,  ID_FORMAPAGAMENTO)");
                query.AppendLine("VALUES(@VL_FINAL_VENDA, @DT_VENDA, 'FINALIZADA', @HORA_VENDA, @ID_FUNCIONARIO, @ID_CLIENTE, @ID_FORMAPAGAMENTO)");
                query.AppendLine("SELECT SCOPE_IDENTITY();");

                cf.Comando = cf.Conexao.CreateCommand();

                cf.Comando.Parameters.AddWithValue("@VL_FINAL_VENDA", v.ValorFinalProdutos);
                cf.Comando.Parameters.AddWithValue("@DT_VENDA", v.DataVenda);
                cf.Comando.Parameters.AddWithValue("@HORA_VENDA", v.HoraVenda);
                cf.Comando.Parameters.AddWithValue("@ID_FUNCIONARIO", v.Id_funcionario);
                cf.Comando.Parameters.AddWithValue("@ID_CLIENTE", v.IdCliente);                                
                cf.Comando.Parameters.AddWithValue("@ID_FORMAPAGAMENTO", v.IdPagamento);               


                cf.Comando.CommandType = CommandType.Text;
                cf.Comando.CommandText = query.ToString();

                cf.Conexao.Open();
                cf.IniciarTransacao();

                v.IdVenda = Convert.ToInt32(cf.ExecScalar());

                foreach (VendaItens i in v.ListaVendasItens)
                {
                    i.IdVenda = v.IdVenda;
                    new VendasItensDAL().Insert(i, cf);
                }
                cf.ConfirmarTransacao();
            }
            catch (Exception ex)
            {
                cf.DesfazerTransacao();
                throw ex;
            }
            finally
            {
                cf.Conexao.Close();

            }


        }

        public DataTable FindByDia(string data)
        {
            cf = new ConnectionFactory();
            string query = "USP_VENDAS_DIA";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();

            cf.Comando.Parameters.AddWithValue("@DATA", data);                        

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cf.Comando);

            cf.Conexao.Open();
            da.Fill(dt);
            cf.Conexao.Close();

            return dt;
        }

        public int CancelarVenda(Venda v)
        {
            cf = new ConnectionFactory();
            int linhasAfetadas = 0;

            string query = "USP_STATUS_VENDA";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.Parameters.AddWithValue("@ID", v.IdVenda);
            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();

            linhasAfetadas = cf.Comando.ExecuteNonQuery();

            cf.Conexao.Close();

            return linhasAfetadas;

        }
    }
}

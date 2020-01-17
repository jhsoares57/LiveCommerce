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
    public class FormaPagamentoDAL
    {
        ConnectionFactory cf;

        public void Insert(FormaPagamento c)
        {
            cf = new ConnectionFactory();

            StringBuilder query = new StringBuilder();
            query.AppendLine("INSERT INTO FORMA_DE_PAGAMENTO");
            query.AppendLine("(DS_FORMAPAGAMENTO)");
            query.AppendLine("VALUES (@DS_FORMAPAGAMENTO)");
            query.AppendLine("SELECT SCOPE_IDENTITY();");

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("@DS_FORMAPAGAMENTO", c.DsFormaPagamento);
            // cf.Comando.Parameters.AddWithValue("@DS_USUARIO", c.DsUsuario);
           // cf.Comando.Parameters.AddWithValue("@SENHA_USUARIO", c.Senhausuario);

            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();

            c.IdFormaPagamento = Convert.ToInt32(cf.Comando.ExecuteScalar());
            cf.Conexao.Close();
        }
        public List<FormaPagamento> FindALL()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_FORMAPAGAMENTO, DS_FORMAPAGAMENTO FROM FORMA_DE_PAGAMENTO ";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();

            List<FormaPagamento> lista = new List<FormaPagamento>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                FormaPagamento F = new FormaPagamento();
                F.IdFormaPagamento = Convert.ToInt32(dr["ID_FORMAPAGAMENTO"]);
                F.DsFormaPagamento = Convert.ToString(dr["DS_FORMAPAGAMENTO"]);

                lista.Add(F);
            }

            cf.Conexao.Close();

            return lista;
        }

    }
}
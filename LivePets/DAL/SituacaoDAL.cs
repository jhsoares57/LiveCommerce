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
   public class SituacaoDAL
    {
        ConnectionFactory cf;

        public List<Situacao> FindALL()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_SITUACAO, DS_SITUACAO FROM SITUACAO ";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query;

            cf.Conexao.Open();

            List<Situacao> lista = new List<Situacao>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                Situacao F = new Situacao();
                F.IdSituacao = Convert.ToInt32(dr["ID_SITUACAO"]);
                F.DsSituacao = Convert.ToString(dr["DS_SITUACAO"]);

                lista.Add(F);
            }

            cf.Conexao.Close();

            return lista;

        }
    }
}

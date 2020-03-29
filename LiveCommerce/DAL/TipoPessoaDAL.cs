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
    public class TipoPessoaDAL
    {
        ConnectionFactory cf;
        public List<TipoPessoa> FindALL()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_PESSOA, DS_PESSOA FROM TIPO_PESSOA";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query;

            cf.Conexao.Open();

            List<TipoPessoa> lista = new List<TipoPessoa>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                TipoPessoa T = new TipoPessoa();
                T.IDPessoa= Convert.ToInt32(dr["ID_PESSOA"]);
                T.DSPessoa= Convert.ToString(dr["DS_PESSOA"]);

                lista.Add(T);
            }

            cf.Conexao.Close();

            return lista;

        }
    }
}

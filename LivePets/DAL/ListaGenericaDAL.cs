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
    public class ListaGenericaDAL
    {
         ConnectionFactory cf;
        public List<ListaGenerica> TipoConta()
        {
            cf = new ConnectionFactory();

            string query = "SELECT LTCOD,LTDSC FROM LTGEN WHERE LTTP=1";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query;

            cf.Conexao.Open();

            List<ListaGenerica> lista = new List<ListaGenerica>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                ListaGenerica T = new ListaGenerica();
                T.CodItem = Convert.ToInt32(dr["LTCOD"]);
                T.DescricaoItem = Convert.ToString(dr["LTDSC"]);

                lista.Add(T);
            }

            cf.Conexao.Close();

            return lista;
        }
    }
}

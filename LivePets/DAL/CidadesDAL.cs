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
    public class CidadesDAL
    {
        ConnectionFactory cf;

        public List<Cidades> FindByID(int idUF )
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            query.AppendLine ("SELECT ID_CIDADE, DS_CIDADE , ID_UF FROM CIDADE WHERE ID_UF =    @ID_UF  ");

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("@ID_UF", idUF);   
            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();
            cf.Conexao.Open();



            List<Cidades> lista = new List<Cidades>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                Cidades c = new Cidades();
                c.IdCidade = Convert.ToInt32(dr["ID_CIDADE"]);
                c.DsCidade = Convert.ToString(dr["DS_CIDADE"]);
                c.IdUF = Convert.ToInt32(dr["ID_UF"]);
                lista.Add(c);
            }

            cf.Conexao.Close();

            return lista;
        }
    }
}

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
    public class UFDAL
    {
        ConnectionFactory cf;

        public List<UF>FindALL()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_UF, DS_UF FROM UF ";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query;

            cf.Conexao.Open();

            List<UF> lista = new List<UF>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                UF F = new UF();
                F.IdUF = Convert.ToInt32(dr["ID_UF"]);
                F.DsUF = Convert.ToString(dr["DS_UF"]);

                lista.Add(F);
            }

            cf.Conexao.Close();

            return lista;

        }
    }
}

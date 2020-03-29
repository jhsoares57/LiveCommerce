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
    public class SexoDAL
    {
        ConnectionFactory cf;

        public List<Sexo> FindALL()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_SEXO, DS_SEXO FROM SEXO ";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();

            List<Sexo> lista = new List<Sexo>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                Sexo F = new Sexo();
                F.IdSexo = Convert.ToInt32(dr["ID_SEXO"]);
                F.DsSexo = Convert.ToString(dr["DS_SEXO"]);

                lista.Add(F);
            }

            cf.Conexao.Close();

            return lista;

        }
    }
}

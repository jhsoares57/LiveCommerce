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
    public class UnidadeMedidaDAL
    {
        ConnectionFactory cf;

        public List<UnidadeMedida> FindALL()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_UNIDADE_MEDIDA, DS_UNIDADE_MEDIDA FROM UNIDADE_MEDIDA";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query;

            cf.Conexao.Open();

            List<UnidadeMedida> lista = new List<UnidadeMedida>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                UnidadeMedida U = new UnidadeMedida();
                U.IDMedida = Convert.ToInt32(dr["ID_UNIDADE_MEDIDA"]);
                U.DescricaoMedida = Convert.ToString(dr["DS_UNIDADE_MEDIDA"]);

                lista.Add(U);
            }

            cf.Conexao.Close();

            return lista;

        }
    }
}

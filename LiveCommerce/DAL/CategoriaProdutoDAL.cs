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
    public class CategoriaProdutoDAL
    {
        ConnectionFactory cf;

        public List<CategoriaProduto> FindByDSCategoriaProduto()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_CATEGORIA_PRODUTO, DS_CATEGORIA_PRODUTO FROM CATEGORIA_PRODUTO ";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query;

            cf.Conexao.Open();

            List<CategoriaProduto> lista = new List<CategoriaProduto>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                CategoriaProduto c = new CategoriaProduto();
                c.IdCategoriaProduto = Convert.ToInt32(dr["ID_CATEGORIA_PRODUTO"]);
                c.DsCategoriaProduto = Convert.ToString(dr["DS_CATEGORIA_PRODUTO"]);

                lista.Add(c);
            }

            cf.Conexao.Close();

            return lista;
        }
    }
}

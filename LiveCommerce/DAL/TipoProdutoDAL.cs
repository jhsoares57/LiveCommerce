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
    public class TipoProdutoDAL
    {
        ConnectionFactory cf;

        public List<TipoProduto> FindALL()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_TIPO, DS_TIPO FROM TIPO_PRODUTO ";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query;

            cf.Conexao.Open();

            List<TipoProduto> lista = new List<TipoProduto>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                TipoProduto c = new TipoProduto();
                c.IDTipoProduto= Convert.ToInt32(dr["ID_TIPO"]);
                c.DescricaoTipoProduto = Convert.ToString(dr["DS_TIPO"]);

                lista.Add(c);
            }

            cf.Conexao.Close();

            return lista;
        }
        
    }
}

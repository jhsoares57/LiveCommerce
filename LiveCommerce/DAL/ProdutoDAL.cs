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
    public class ProdutoDAL
    {
        ConnectionFactory cf;

        public void Insert(Produto p)
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            query.AppendLine("INSERT INTO PRODUTO");
            query.AppendLine("(CD_BARRAS_PRODUTO, NM_PRODUTO, DT_CADASTRO_PRODUTO, VL_UNITARIO_PRODUTO_VENDA,VALOR_COMPRA_PRODUTO, LUCRO_PORCENTO_PRODUTO, QT_PRODUTO, ID_UNIDADE_MEDIDA, ID_CATEGORIA_PRODUTO,");
            query.AppendLine("ID_FORMA_COMPRA, ID_FORNECEDOR, ID_TIPO,REF_PRODUTO)");
            query.AppendLine("VALUES (@CD_BARRAS_PRODUTO, @NM_PRODUTO, @DT_CADASTRO_PRODUTO, @VL_UNITARIO_PRODUTO_VENDA,@VALOR_COMPRA_PRODUTO, @LUCRO_PORCENTO_PRODUTO, @QT_PRODUTO, @ID_UNIDADE_MEDIDA, @ID_CATEGORIA_PRODUTO,");
            query.AppendLine("@ID_FORMA_COMPRA, @ID_FORNECEDOR, @ID_TIPO,@REF_PRODUTO)");
            query.AppendLine("SELECT SCOPE_IDENTITY();");

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("@CD_BARRAS_PRODUTO", p.CDBarras);
            cf.Comando.Parameters.AddWithValue("@NM_PRODUTO", p.NomeProduto);
            cf.Comando.Parameters.AddWithValue("@DT_CADASTRO_PRODUTO", p.DTCadastro);
            cf.Comando.Parameters.AddWithValue("@VL_UNITARIO_PRODUTO_VENDA", p.ValorUnitarioProduto);
            cf.Comando.Parameters.AddWithValue("@VALOR_COMPRA_PRODUTO", p.ValorCompra);
            cf.Comando.Parameters.AddWithValue("@LUCRO_PORCENTO_PRODUTO", p.LucroProduto);
            cf.Comando.Parameters.AddWithValue("@QT_PRODUTO", p.QuantidadeProduto);
            cf.Comando.Parameters.AddWithValue("@ID_UNIDADE_MEDIDA", p.UnidadeMedida);
            cf.Comando.Parameters.AddWithValue("@ID_CATEGORIA_PRODUTO", p.CategoriaProduto);
            cf.Comando.Parameters.AddWithValue("@ID_FORMA_COMPRA", p.FormaCompra);
            cf.Comando.Parameters.AddWithValue("@ID_FORNECEDOR", p.IdFornecedor);
            cf.Comando.Parameters.AddWithValue("@ID_TIPO", p.IdTipoProduto);
            cf.Comando.Parameters.AddWithValue("@REF_PRODUTO", p.Referencia);


            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();

            p.Id = Convert.ToInt32(cf.Comando.ExecuteScalar());
            cf.Conexao.Close();
        }

        public int Update(Produto P)
        {
            try
            {
                cf = new ConnectionFactory();
                StringBuilder query = new StringBuilder();

                int linhasAfetadas = 0;

                query.AppendLine(" UPDATE PRODUTO SET ");
                query.AppendLine("CD_BARRAS_PRODUTO = @CD_BARRAS_PRODUTO,");
                query.AppendLine("DT_CADASTRO_PRODUTO = @DT_CADASTRO,");
                query.AppendLine("NM_PRODUTO = @NM_PRODUTO,");
                query.AppendLine("VL_UNITARIO_PRODUTO_VENDA = @VL_UNITARIO_PRODUTO,");
                query.AppendLine("LUCRO_PORCENTO_PRODUTO = @LUCRO_PORCENTO_PRODUTO,");
                query.AppendLine("QT_PRODUTO = @QT_PRODUTO,");
                query.AppendLine("ID_UNIDADE_MEDIDA = @ID_UNIDADE_MEDIDA,");
                query.AppendLine("ID_CATEGORIA_PRODUTO = @ID_CATEGORIA_PRODUTO,");
                query.AppendLine("ID_FORMA_COMPRA = @ID_FORMA_COMPRA,");
                query.AppendLine("ID_FORNECEDOR = @ID_FORNECEDOR,");
                query.AppendLine("ID_TIPO = @ID_TIPO,");
                query.AppendLine("REF_PRODUTO = @REF_PRODUTO");
                query.AppendLine("WHERE ID_PRODUTO = @ID_PRODUTO");

                cf.Comando = cf.Conexao.CreateCommand();

                cf.Comando.Parameters.AddWithValue("@CD_BARRAS_PRODUTO", P.CDBarras);
                cf.Comando.Parameters.AddWithValue("@DT_CADASTRO", P.DTCadastro);
                cf.Comando.Parameters.AddWithValue("@NM_PRODUTO", P.NomeProduto);
                cf.Comando.Parameters.AddWithValue("@VL_UNITARIO_PRODUTO", P.ValorUnitarioProduto);
                cf.Comando.Parameters.AddWithValue("@VALOR_COMPRA_PRODUTO", P.ValorCompra);
                cf.Comando.Parameters.AddWithValue("@LUCRO_PORCENTO_PRODUTO", P.LucroProduto);
                cf.Comando.Parameters.AddWithValue("@QT_PRODUTO", P.QuantidadeProduto);
                cf.Comando.Parameters.AddWithValue("@ID_UNIDADE_MEDIDA", P.UnidadeMedida);
                cf.Comando.Parameters.AddWithValue("@ID_CATEGORIA_PRODUTO", P.CategoriaProduto);
                cf.Comando.Parameters.AddWithValue("@ID_FORMA_COMPRA", P.FormaCompra);
                cf.Comando.Parameters.AddWithValue("@ID_FORNECEDOR", P.IdFornecedor);
                cf.Comando.Parameters.AddWithValue("@ID_TIPO", P.IdTipoProduto);
                cf.Comando.Parameters.AddWithValue("@ID_PRODUTO", P.Id);
                cf.Comando.Parameters.AddWithValue("@REF_PRODUTO", P.Referencia);

                cf.Comando.CommandType = CommandType.Text;
                cf.Comando.CommandText = query.ToString();
                cf.Conexao.Open();

                linhasAfetadas = cf.Comando.ExecuteNonQuery();
                cf.Conexao.Close();

                return linhasAfetadas;
            }
            catch(Exception EX)
            {
                throw EX;
            }
        }

        public List<Produto> FindLikeOld(string termo)
        {
            //Consulta select com inner join
            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT ID_PRODUTO, NM_PRODUTO, VL_UNITARIO_PRODUTO_VENDA, QT_PRODUTO FROM PRODUTO WHERE (NM_PRODUTO like @termo or ID_PRODUTO like @termo)");

            cf = new ConnectionFactory();
            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();

            cf.Comando.Parameters.AddWithValue("@termo", "%" + termo + "%");

            //Cria uma lista, que armazenárá os resultados da consulta  
            List<Produto> listaProduto = new List<Produto>();

            cf.Conexao.Open();//Abre a conexão
            SqlDataReader reader = cf.Comando.ExecuteReader();//Executando o comando

            while (reader.Read())
            {
                Produto p = new Produto();//Instanciando o objeto da iteração
                //Preenchimento das propriedades a partir do que retornou no banco.
                p.Id = Convert.ToInt32(reader["ID_PRODUTO"]);
                p.NomeProduto = reader["NM_PRODUTO"].ToString();                

                listaProduto.Add(p);//Adicionando o objeto para a lista
            }
            //Fechando a conexão
            cf.Conexao.Close();

            //Retornando a lista já carregada.
            return listaProduto;
        }


        public DataTable FindLike(string termo)
        {
            string query = "SELECT ID_PRODUTO [ID], NM_PRODUTO [NOME DO PRODUTO], VL_UNITARIO_PRODUTO_VENDA [VALOR ], QT_PRODUTO [QUANTIDADE] FROM PRODUTO WHERE (NM_PRODUTO like @termo or ID_PRODUTO like @termo)";

            cf = new ConnectionFactory();
            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query;
            cf.Comando.Parameters.AddWithValue("@termo", "%" + termo + "%");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cf.Comando);

            cf.Conexao.Open();
            da.Fill(dt);
            cf.Conexao.Close();

            return dt;
        }

        public DataTable FindAll(string termo)
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT ID_PRODUTO [ID], CD_BARRAS_PRODUTO AS 'CODIGO DE BARRAS', DT_CADASTRO_PRODUTO AS 'DATA', NM_PRODUTO AS 'NOME PRODUTO', ID_TIPO AS 'ID TIPO' , ID_FORNECEDOR AS 'ID DO FORNECEDOR' , VL_UNITARIO_PRODUTO_VENDA AS 'VALOR', LUCRO_PORCENTO_PRODUTO AS 'LUCRO' , VALOR_COMPRA_PRODUTO AS 'VALOR DE COMPRA', ID_UNIDADE_MEDIDA AS 'ID UNIDADE DE MEDIDA', ID_CATEGORIA_PRODUTO AS 'ID CATEGORIA',");
            query.AppendLine("ID_FORMA_COMPRA AS 'ID FORMA DE COMPRA', QT_PRODUTO AS 'QUANTIDADE', REF_PRODUTO AS 'REFERENCIA' FROM PRODUTO WHERE (NM_PRODUTO like @termo or ID_PRODUTO like @termo OR REF_PRODUTO LIKE @termo)");

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();
            cf.Comando.Parameters.AddWithValue("@termo", "%" + termo + "%");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cf.Comando);

            cf.Conexao.Open();
            da.Fill(dt);
            cf.Conexao.Close();

            return dt;

        }

        public int Delete(int id)
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            int linhasAfetadas = 0;

            query.AppendLine("UPDATE FROM PRODUTO");
            query.AppendLine("WHERE ID_DEPENDENTE = @ID_DEPENDENTE");

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("ID_DEPENDENTE", id);

            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();
            cf.Conexao.Open();

            linhasAfetadas = cf.Comando.ExecuteNonQuery();
            cf.Conexao.Close();

            return linhasAfetadas;

        }

        public Produto FindById(int id)
        {
            //Consulta select com inner join
            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT ID_PRODUTO, NM_PRODUTO, VL_UNITARIO_PRODUTO_VENDA, QT_PRODUTO FROM PRODUTO WHERE ID_PRODUTO = @ID");

            cf = new ConnectionFactory();
            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();

            cf.Comando.Parameters.AddWithValue("@ID", id);

            //Cria um objeto nulo
            Produto p = null;

            cf.Conexao.Open();//Abre a conexão
            SqlDataReader reader = cf.Comando.ExecuteReader();//Executando o comando

            //Se contiver registro, vai entrar aqui...
            if (reader.Read())
            {
                //E instanciar um Produto para poder inserir as colunas do banco em cada propriedade do objeto
                p = new Produto();//Instanciando o objeto da iteração
                //Preenchimento das propriedades a partir do que retornou no banco.
                p.Id = Convert.ToInt32(reader["ID_PRODUTO"]);
                p.NomeProduto = reader["NM_PRODUTO"].ToString();
                p.ValorUnitarioProduto = Convert.ToDecimal(reader["VL_UNITARIO_PRODUTO_VENDA"]);
            }
            //Fechando a conexão
            cf.Conexao.Close();

            //Retornando a lista já carregada.
            return p;
        }
    }
}

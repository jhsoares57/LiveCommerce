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
    public class ClienteDAL
    {
        ConnectionFactory cf;

        public void Insert(Cliente C)
        {
            try
            {
                cf = new ConnectionFactory();

                StringBuilder query = new StringBuilder();
                query.AppendLine("INSERT INTO CLIENTE");
                query.AppendLine("(DATA_CADASTRO, NM_CLIENTE,  CPF_CLIENTE, RG_CLIENTE, DT_NASCIMENTO_CLIENTE, ");
                query.AppendLine(" ENDERECO_CLIENTE, NUMERO_ENDERECO_CLIENTE, BAIRRO_ENDERECO_CLIENTE, CEP_ENDERECO_CLIENTE, CELULAR_CLIENTE,");
                query.AppendLine("ID_UF, ID_SITUACAO ,ID_CIDADE,ID_TIPO_PESSOA) ");
                query.AppendLine("VALUES (@DATA_CADASTRO,  @NM_CLIENTE, @CPF_CLIENTE, @RG_CLIENTE, @DT_NASCIMENTO_CLIENTE,");
                query.AppendLine("@ENDERECO_CLIENTE, @NUMERO_ENDERECO_CLIENTE, @BAIRRO_ENDERECO_CLIENTE, @CEP_ENDERECO_CLIENTE, @CELULAR_CLIENTE, @ID_UF, @ID_SITUACAO , @ID_CIDADE, @ID_TIPO_PESSOA ) ");
                query.AppendLine("SELECT SCOPE_IDENTITY();");

                cf.Comando = cf.Conexao.CreateCommand();

                cf.Comando.Parameters.AddWithValue("@DATA_CADASTRO", C.DataCadastro);
                cf.Comando.Parameters.AddWithValue("@NM_CLIENTE", C.NomeCliente);      
                cf.Comando.Parameters.AddWithValue("@CPF_CLIENTE", C.CpfCliente);
                cf.Comando.Parameters.AddWithValue("@RG_CLIENTE", C.RgCliente);
                cf.Comando.Parameters.AddWithValue("@DT_NASCIMENTO_CLIENTE", C.DataNascimento);
                cf.Comando.Parameters.AddWithValue("@ENDERECO_CLIENTE", C.Endereco);
                cf.Comando.Parameters.AddWithValue("@NUMERO_ENDERECO_CLIENTE", C.NumeroEndereco);
                cf.Comando.Parameters.AddWithValue("@BAIRRO_ENDERECO_CLIENTE", C.BairroEndereco);
                cf.Comando.Parameters.AddWithValue("@CEP_ENDERECO_CLIENTE", C.CepEndereco);
                cf.Comando.Parameters.AddWithValue("@CELULAR_CLIENTE", C.CelularCliente);
                cf.Comando.Parameters.AddWithValue("@ID_UF", C.UfEndereco);
                cf.Comando.Parameters.AddWithValue("@ID_SITUACAO", C.Situacao);
                cf.Comando.Parameters.AddWithValue("@ID_CIDADE", C.CidadeEndereco);
                cf.Comando.Parameters.AddWithValue("@ID_TIPO_PESSOA", C.TipoPessoa);
                cf.Comando.CommandType = CommandType.Text;
                cf.Comando.CommandText = query.ToString();

                cf.Conexao.Open();
                cf.IniciarTransacao();

                C.ID = Convert.ToInt32(cf.ExecScalar());
                cf.ConfirmarTransacao();
            }
            catch (Exception ex)
            {
                cf.DesfazerTransacao();
                throw ex;
            }
            finally
            {
                cf.Conexao.Close();

            }

        }
        public DataTable FindLikeOld(string termo1)
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_CLIENTE, NM_CLIENTE, CPF_CLIENTE FROM CLIENTE WHERE(NM_CLIENTE like @termo1 or ID_CLIENTE like @termo1) ";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();


            cf.Comando.Parameters.AddWithValue("@termo1", "%" + termo1 + "%");

            //Cria uma lista, que armazenárá os resultados da consulta  
            List<Cliente> lista = new List<Cliente>();

           

            //Executando o comando
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cf.Comando);

            cf.Conexao.Open();
            da.Fill(dt);
            cf.Conexao.Close();

            return dt;
        }
        public DataTable FindLike(string termo1)
        {
            string query = "SELECT ID_CLIENTE [ID], NM_CLIENTE [NOME DO CLIENTE], CPF_CLIENTE [CPF ], DT_NASCIMENTO_CLIENTE [DATA NASCIMENTO], ENDERECO_CLIENTE [ENDEREÇO], NUMERO_ENDERECO_CLIENTE [NÚMERO], BAIRRO_ENDERECO_CLIENTE [BAIRRO], CEP_ENDERECO_CLIENTE [CEP], ID_UF [UF], ID_SITUACAO [SITUAÇÃO], DATA_CADASTRO [DATA CADASTRO], ID_CIDADE [CIDADE],RG_CLIENTE [RG],CELULAR_CLIENTE [CELULAR], ID_TIPO_PESSOA [TIPO_CLIENTE] FROM CLIENTE WHERE (NM_CLIENTE like @termo1 or ID_CLIENTE like @termo1)";

            cf = new ConnectionFactory();
            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query;
            cf.Comando.Parameters.AddWithValue("@termo1", "%" + termo1 + "%");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cf.Comando);

            cf.Conexao.Open();  
            da.Fill(dt);
            cf.Conexao.Close();

            return dt;
        }

        public int Update(Cliente c)
        {
            try
            {
                cf = new ConnectionFactory();
                StringBuilder query = new StringBuilder();

                int linhasAfetadas = 0;

                query.AppendLine(" UPDATE CLIENTE SET ");
                query.AppendLine(" DATA_CADASTRO = @DATA_CADASTRO,");
                query.AppendLine(" NM_CLIENTE = @NM_CLIENTE, ");
                query.AppendLine(" CPF_CLIENTE = @CPF_CLIENTE, ");
                query.AppendLine(" RG_CLIENTE = @RG_CLIENTE,");
                query.AppendLine(" DT_NASCIMENTO_CLIENTE = @DT_NASCIMENTO,");
                query.AppendLine(" ENDERECO_CLIENTE = @ENDERECO_CLIENTE,");
                query.AppendLine(" NUMERO_ENDERECO_CLIENTE = @NUMERO_ENDERECO_CLIENTE,");
                query.AppendLine(" BAIRRO_ENDERECO_CLIENTE = @BAIRRO_ENDERECO_CLIENTE,");
                query.AppendLine(" CEP_ENDERECO_CLIENTE = @CEP_ENDERECO_CLIENTE, ");
                query.AppendLine(" CELULAR_CLIENTE = @CELULAR_CLIENTE, ");
                query.AppendLine(" ID_UF = @ID_UF,");
                query.AppendLine(" ID_SITUACAO = @ID_SITUACAO,");
                query.AppendLine(" ID_CIDADE = @ID_CIDADE"); 
                query.AppendLine(" ID_TIPO_PESSOA = @ID_TIPO_PESSOA");
                query.AppendLine(" WHERE ID_CLIENTE = @ID_CLIENTE");

                cf.Comando = cf.Conexao.CreateCommand();

                cf.Comando.Parameters.AddWithValue("@DATA_CADASTRO", c.DataCadastro);
                cf.Comando.Parameters.AddWithValue("@NM_CLIENTE", c.NomeCliente);
                cf.Comando.Parameters.AddWithValue("@CPF_CLIENTE", c.CpfCliente);
                cf.Comando.Parameters.AddWithValue("@RG_CLIENTE", c.RgCliente);
                cf.Comando.Parameters.AddWithValue("@DT_NASCIMENTO", c.DataNascimento);
                cf.Comando.Parameters.AddWithValue("@ENDERECO_CLIENTE", c.Endereco);
                cf.Comando.Parameters.AddWithValue("@NUMERO_ENDERECO_CLIENTE", c.NumeroEndereco);
                cf.Comando.Parameters.AddWithValue("@BAIRRO_ENDERECO_CLIENTE", c.BairroEndereco);
                cf.Comando.Parameters.AddWithValue("@CEP_ENDERECO_CLIENTE", c.CepEndereco);
                cf.Comando.Parameters.AddWithValue("@CELULAR_CLIENTE", c.CelularCliente);
                cf.Comando.Parameters.AddWithValue("@ID_UF", c.UfEndereco);
                cf.Comando.Parameters.AddWithValue("@ID_SITUACAO", c.Situacao);
                cf.Comando.Parameters.AddWithValue("@ID_CIDADE", c.CidadeEndereco);
                cf.Comando.Parameters.AddWithValue("@ID_CLIENTE", c.ID);
                cf.Comando.Parameters.AddWithValue("@ID_TIPO_PESSOA", c.TipoPessoa);

                cf.Comando.CommandType = CommandType.Text;
                cf.Comando.CommandText = query.ToString();
                cf.Conexao.Open();

                linhasAfetadas = cf.Comando.ExecuteNonQuery();

                cf.Conexao.Close();

                return linhasAfetadas;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(int ID)
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            int linhasAfetadas = 0;

            query.AppendLine("UPDATE CLIENTE SET ID_SITUACAO = 2");
            query.AppendLine("WHERE ID_CLIENTE = @ID_CLIENTE");

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("ID_CLIENTE", ID);

            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();
            cf.Conexao.Open();

            linhasAfetadas = cf.Comando.ExecuteNonQuery();
            cf.Conexao.Close();

            return linhasAfetadas;

        }

        public Cliente FindById(int id)
        {
            cf = new ConnectionFactory();
            string query = "SELECT ID_CLIENTE, NM_CLIENTE, CPF_CLIENTE FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE  ";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();

            cf.Comando.Parameters.AddWithValue("@ID_CLIENTE", id);

            //Cria um objeto nulo
            Cliente c = null;

            cf.Conexao.Open();//Abre a conexão

            //Executando o comando
            SqlDataReader dr = cf.Comando.ExecuteReader();

            if (dr.Read())
            {
                c = new Cliente();//Instanciando o objeto 
                //Preenchimento das propriedades a partir do que retornou no banco.
                c.ID = Convert.ToInt32(dr["ID_CLIENTE"]);
                c.NomeCliente = Convert.ToString(dr["NM_CLIENTE"]);
                c.CpfCliente = Convert.ToString(dr["CPF_CLIENTE"]);
            }
            //Fechando a conexão
            cf.Conexao.Close();

            //Retornando a lista já carregada.
            return c;
        }

        public List<Cliente> FindNome()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_CLIENTE,NM_CLIENTE FROM CLIENTE";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query;

            cf.Conexao.Open();

            List<Cliente> lista = new List<Cliente>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                Cliente F = new Cliente();
                F.ID = Convert.ToInt32(dr["ID_CLIENTE"]);
                F.NomeCliente = Convert.ToString(dr["NM_CLIENTE"]);

                lista.Add(F);
            }

            cf.Conexao.Close();

            return lista;
        }
    }
}

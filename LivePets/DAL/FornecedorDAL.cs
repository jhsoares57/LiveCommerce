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
    public class FornecedorDAL
    {
        ConnectionFactory cf;

        public void Insert(Fornecedor F)
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            query.AppendLine("INSERT INTO FORNECEDOR");
            query.AppendLine("(RAZAO, NOME_FANTASIA,DATA_CADASTRO, CPF_CNPJ_FORNECEDOR,IE, END_FORNECEDOR, END_BAIRRO_FORNECEDOR, END_NUMERO_FORNECEDOR, END_CEP_FORNECEDOR, TELEFONE_FORNECEDOR, CELULAR_FORNECEDOR, EMAIL_FORNECEDOR,");
            query.AppendLine("ID_UF, ID_SITUACAO, ID_CIDADE, ID_TIPO_PESSOA)");
            query.AppendLine("VALUES (@RAZAO, @NOME_FANTASIA, @DATA_CADASTRO, @CPF_CNPJ_FORNECEDOR, @IE, @END_FORNECEDOR, @END_BAIRRO_FORNECEDOR, @END_NUMERO_FORNECEDOR, @END_CEP_FORNECEDOR, @TELEFONE_FORNECEDOR, @CELULAR_FORNECEDOR, @EMAIL_FORNECEDOR,");
            query.AppendLine("@ID_UF, @ID_SITUACAO, @ID_CIDADE, @ID_TIPO_PESSOA)");
            query.AppendLine("SELECT SCOPE_IDENTITY();");

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("@RAZAO", F.Razao);
            cf.Comando.Parameters.AddWithValue("@NOME_FANTASIA", F.NomeFantasia);
            cf.Comando.Parameters.AddWithValue("@DATA_CADASTRO", F.DataCadastro);
            cf.Comando.Parameters.AddWithValue("@CPF_CNPJ_FORNECEDOR", F.CpfcnpjFornecedor);
            cf.Comando.Parameters.AddWithValue("@IE", F.Ie);
            cf.Comando.Parameters.AddWithValue("@END_FORNECEDOR", F.EnderecoFornecedor);
            cf.Comando.Parameters.AddWithValue("@END_BAIRRO_FORNECEDOR", F.EnderecoBairroFornecedor);
            cf.Comando.Parameters.AddWithValue("@END_NUMERO_FORNECEDOR", F.EnderevoNumeroFornecedor);
            cf.Comando.Parameters.AddWithValue("@END_CEP_FORNECEDOR", F.EnderecoCepFornecedor);
            cf.Comando.Parameters.AddWithValue("@TELEFONE_FORNECEDOR", F.TelefoneFornecedor);
            cf.Comando.Parameters.AddWithValue("@CELULAR_FORNECEDOR", F.CelularFornecdor);
            cf.Comando.Parameters.AddWithValue("@EMAIL_FORNECEDOR", F.EmailFornecedor);
            cf.Comando.Parameters.AddWithValue("@ID_UF", F.UfFornecedor);
            cf.Comando.Parameters.AddWithValue("@ID_SITUACAO", F.IDSituacao);
            cf.Comando.Parameters.AddWithValue("@ID_CIDADE", F.EnderecoCidadeFornecedor);
            cf.Comando.Parameters.AddWithValue("@ID_TIPO_PESSOA", F.TipoPessoa);

            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();

            F.IdFornecedor = Convert.ToInt32(cf.Comando.ExecuteScalar());
            cf.Conexao.Close();
        }
        public int Update(Fornecedor F)
        {
            try
            {
                cf = new ConnectionFactory();
                StringBuilder query = new StringBuilder();

                int linhasAfetadas = 0;

                query.AppendLine(" UPDATE FORNECEDOR SET ");
                query.AppendLine(" RAZAO = @RAZAO, ");
                query.AppendLine(" NOME_FANTASIA = @NOME_FANTASIA,");
                query.AppendLine(" DATA_CADASTRO = @DATA_CADASTRO,");
                query.AppendLine(" CPF_CNPJ_FORNECEDOR = @CPF_CNPJ_FORNECEDOR,");
                query.AppendLine(" IE = @IE,");
                query.AppendLine(" END_FORNECEDOR = @END_FORNECEDOR,");
                query.AppendLine(" END_BAIRRO_FORNECEDOR = @END_BAIRRO_FORNECEDOR,");
                query.AppendLine(" END_NUMERO_FORNECEDOR = @END_NUMERO_FORNECEDOR,");
                query.AppendLine(" END_CEP_FORNECEDOR = @END_CEP_FORNECEDOR,");
                query.AppendLine(" TELEFONE_FORNECEDOR = @TELEFONE_FORNECEDOR,");
                query.AppendLine(" CELULAR_FORNECEDOR = @CELULAR_FORNECEDOR,");
                query.AppendLine(" EMAIL_FORNECEDOR = @EMAIL_FORNECEDOR,");
                query.AppendLine(" ID_UF = @ID_UF, ");
                query.AppendLine(" ID_SITUACAO = @ID_SITUACAO,");
                query.AppendLine(" ID_CIDADE = @ID_CIDADE,");
                query.AppendLine(" ID_TIPO_PESSOA = @ID_TIPO_PESSOA");
                query.AppendLine(" WHERE ID_FORNECEDOR = @ID_FORNECEDOR ");

                cf.Comando = cf.Conexao.CreateCommand();

                cf.Comando.Parameters.AddWithValue("@RAZAO", F.Razao);
                cf.Comando.Parameters.AddWithValue("@NOME_FANTASIA", F.NomeFantasia);
                cf.Comando.Parameters.AddWithValue("@DATA_CADASTRO", F.DataCadastro);
                cf.Comando.Parameters.AddWithValue("@CPF_CNPJ_FORNECEDOR", F.CpfcnpjFornecedor);
                cf.Comando.Parameters.AddWithValue("@IE", F.Ie);
                cf.Comando.Parameters.AddWithValue("@END_FORNECEDOR", F.EnderecoFornecedor);
                cf.Comando.Parameters.AddWithValue("@END_BAIRRO_FORNECEDOR", F.EnderecoBairroFornecedor);
                cf.Comando.Parameters.AddWithValue("@END_NUMERO_FORNECEDOR", F.EnderevoNumeroFornecedor);
                cf.Comando.Parameters.AddWithValue("@END_CEP_FORNECEDOR", F.EnderecoCepFornecedor);
                cf.Comando.Parameters.AddWithValue("@TELEFONE_FORNECEDOR", F.TelefoneFornecedor);
                cf.Comando.Parameters.AddWithValue("@CELULAR_FORNECEDOR", F.CelularFornecdor);
                cf.Comando.Parameters.AddWithValue("@EMAIL_FORNECEDOR", F.EmailFornecedor);
                cf.Comando.Parameters.AddWithValue("@ID_UF", F.UfFornecedor);
                cf.Comando.Parameters.AddWithValue("@ID_SITUACAO", F.IDSituacao);
                cf.Comando.Parameters.AddWithValue("@ID_CIDADE", F.EnderecoCidadeFornecedor);
                cf.Comando.Parameters.AddWithValue("@ID_FORNECEDOR", F.IdFornecedor);
                cf.Comando.Parameters.AddWithValue("@ID_TIPO_PESSOA", F.TipoPessoa);

                cf.Comando.CommandType = CommandType.Text;
                cf.Comando.CommandText = query.ToString();
                cf.Conexao.Open();

                linhasAfetadas = cf.Comando.ExecuteNonQuery();
                cf.Conexao.Close();

                return linhasAfetadas;
            }
            catch (Exception EX)
            {
                throw EX;
            }

        }

        public List<Fornecedor> FindLikeOld(string termo1)
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_FORNECEDOR, RAZAO FROM FORNECEDOR WHERE(RAZAO like @termo1 or ID_FORNECEDOR like @termo1 or NOME_FANTASIA like @termo1) ";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();


            cf.Comando.Parameters.AddWithValue("@termo1", "%" + termo1 + "%");

            //Cria uma lista, que armazenárá os resultados da consulta  
            List<Fornecedor> lista = new List<Fornecedor>();

            cf.Conexao.Open();//Abre a conexão

            //Executando o comando
            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                Fornecedor F = new Fornecedor();//Instanciando o objeto da iteração
                //Preenchimento das propriedades a partir do que retornou no banco.
                F.IdFornecedor = Convert.ToInt32(dr["ID_FORNECEDOR"]);
                F.Razao = Convert.ToString(dr["RAZAO"]);
                F.NomeFantasia = Convert.ToString(dr["NOME_FANTASIA"]);

                lista.Add(F);//Adicionando o objeto para a lista
            }
            //Fechando a conexão
            cf.Conexao.Close();

            //Retornando a lista já carregada.
            return lista;
        }

        public DataTable FindLike(string termo1)
        {
            string query = "SELECT ID_FORNECEDOR [ID], DATA_CADASTRO [DATA CADASTRO], ID_SITUACAO [SITUAÇÃO], RAZAO [RAZÃO SOCIAL], NOME_FANTASIA [NOME FANTASIA], CPF_CNPJ_FORNECEDOR [CPF/CNPJ ], IE [INSCRIÇÃO ESTADUAL], ID_UF [UF], ID_CIDADE [CIDADE], END_CEP_FORNECEDOR [CEP], END_FORNECEDOR [ENDEREÇO], END_BAIRRO_FORNECEDOR [BAIRRO], END_NUMERO_FORNECEDOR [NÚMERO], TELEFONE_FORNECEDOR [TELEFONE], CELULAR_FORNECEDOR [CELULAR], EMAIL_FORNECEDOR [EMAIL], ID_TIPO_PESSOA[PESSOA] FROM FORNECEDOR WHERE (RAZAO like @termo1 or ID_FORNECEDOR like @termo1 or NOME_FANTASIA like @termo1)";

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
        public List<Fornecedor> FindNome()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_FORNECEDOR, NOME_FANTASIA FROM FORNECEDOR ";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query;

            cf.Conexao.Open();

            List<Fornecedor> lista = new List<Fornecedor>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                Fornecedor F = new Fornecedor();
                F.IdFornecedor = Convert.ToInt32(dr["ID_FORNECEDOR"]);
                F.NomeFantasia = Convert.ToString(dr["NOME_FANTASIA"]);

                lista.Add(F);
            }

            cf.Conexao.Close();

            return lista;
        }

        //Exclusão logica
        public int Delete(int IdFornecedor)
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            int linhasAfetadas = 0;

            query.AppendLine("UPDATE FORNECEDOR SET ID_SITUACAO = 2");
            query.AppendLine("WHERE ID_FORNECEDOR = @ID_FORNECEDOR");

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("ID_FORNECEDOR", IdFornecedor);

            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();
            cf.Conexao.Open();

            linhasAfetadas = cf.Comando.ExecuteNonQuery();
            cf.Conexao.Close();

            return linhasAfetadas;

        }
    }
    //public Fornecedor FindByID(int ID, string nome, string fantasia)
    //{
    //    cf = new ConnectionFactory();
    //    StringBuilder query = new StringBuilder();

    //    query.AppendLine(" SELECT * FROM FORNECEDOR WHERE (ID_FORNECEDOR = @ID OR RAZAO like @NOME OR NOME_FANTASIA like @FANTASIA )");

    //    cf.Comando = cf.Conexao.CreateCommand();
    //    cf.Comando.CommandType = CommandType.Text;
    //    cf.Comando.CommandText = query.ToString();

    //    cf.Comando.Parameters.AddWithValue("@ID", ID);
    //    cf.Comando.Parameters.AddWithValue("@NOME", nome);
    //    cf.Comando.Parameters.AddWithValue("@FANTASIA", fantasia);

    //    Fornecedor F = null;

    //    cf.Conexao.Open();
    //    SqlDataReader reader = cf.Comando.ExecuteReader();

    //    if (reader.Read())
    //    {
    //        F = new Fornecedor();

    //        F.IdFornecedor = Convert.ToInt32(reader["ID_FORNECEDOR"]);
    //        F.Razao = reader["RAZAO"].ToString();
    //        F.NomeFantasia = reader["NOME_FANTASIA"].ToString();
    //        F.DataCadastro = Convert.ToDateTime(reader["DATA_CADASTRO"]);
    //        F.CpfcnpjFornecedor = reader["CPF_CNPJ_FORNECEDOR"].ToString();
    //        F.;
    //    }

    //    cf.Conexao.Close();

    //    return F;
    //}
}


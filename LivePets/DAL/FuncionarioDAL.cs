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
    public class FuncionarioDAL
    {
        ConnectionFactory cf;

        public void Insert(Funcionario F)
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            query.AppendLine("INSERT INTO FUNCIONARIO");
            query.AppendLine("(NM_FUNCIONARIO, CPF_FUNCIONARIO, RG_FUNCIONARIO, END_FUNCIONARIO, TEL_FUNCIONARIO, EMAIL_FUNCIONARIO,  DT_NASCIMENTO_FUNCIONARIO,");
            query.AppendLine(" BAIRRO_ENDERECO_FUNCIONARIO, NUMERO_ENDERECO_FUNCIONARIO, SALARIO_BASE_FUNCIONARIO, CEP_FUNCIONARIO, ID_SITUACAO,");
            query.AppendLine(" ID_UF,ID_SEXO, ID_CIDADE  )");
            query.AppendLine("VALUES (@NM_FUNCIONARIO, @CPF_FUNCIONARIO, @RG_FUNCIONARIO, @END_FUNCIONARIO, @TEL_FUNCIONARIO, @EMAIL_FUNCIONARIO,  @DT_NASCIMENTO_FUNCIONARIO,");
            query.AppendLine(" @BAIRRO_ENDERECO_FUNCIONARIO, @NUMERO_ENDERECO_FUNCIONARIO, @SALARIO_BASE_FUNCIONARIO, @CEP_FUNCIONARIO, @ID_SITUACAO,");
            query.AppendLine(" @ID_UF, @ID_SEXO, @ID_CIDADE )");
            query.AppendLine("SELECT SCOPE_IDENTITY();");

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("@NM_FUNCIONARIO", F.NmFuncionario);
            cf.Comando.Parameters.AddWithValue("@CPF_FUNCIONARIO", F.CfpFuncionario);
            cf.Comando.Parameters.AddWithValue("@RG_FUNCIONARIO", F.RGFuncionario);
            cf.Comando.Parameters.AddWithValue("@END_FUNCIONARIO", F.EndFuncionario);
            cf.Comando.Parameters.AddWithValue("@TEL_FUNCIONARIO", F.TelFuncionario);
            cf.Comando.Parameters.AddWithValue("@EMAIL_FUNCIONARIO", F.EmailFuncionario);            
            cf.Comando.Parameters.AddWithValue("@DT_NASCIMENTO_FUNCIONARIO", F.DataNascimento);
            cf.Comando.Parameters.AddWithValue("@BAIRRO_ENDERECO_FUNCIONARIO", F.BairroEndereco);
            cf.Comando.Parameters.AddWithValue("@NUMERO_ENDERECO_FUNCIONARIO", F.NumeroEndereco);
            cf.Comando.Parameters.AddWithValue("@SALARIO_BASE_FUNCIONARIO", F.SalarioBase);
            cf.Comando.Parameters.AddWithValue("@CEP_FUNCIONARIO", F.CEPFuncionario);
            cf.Comando.Parameters.AddWithValue("@ID_SITUACAO", F.IdSituacao);
            cf.Comando.Parameters.AddWithValue("@ID_UF", F.IdUF);
            cf.Comando.Parameters.AddWithValue("@ID_SEXO", F.IdSexo);
            cf.Comando.Parameters.AddWithValue("@ID_CIDADE", F.CidadeEndereco);

            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();

            F.IdFuncionario = Convert.ToInt32(cf.Comando.ExecuteScalar());
            cf.Conexao.Close();
        }
        public List<Funcionario> FindAll()
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_FUNCIONARIO, NM_FUNCIONARIO FROM FUNCIONARIO ";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.Text;

            cf.Comando.CommandText = query;

            cf.Conexao.Open();

            List<Funcionario> lista = new List<Funcionario>();

            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                Funcionario F = new Funcionario();
                F.IdFuncionario = Convert.ToInt32(dr["ID_FUNCIONARIO"]);
                F.NmFuncionario = Convert.ToString(dr["NM_FUNCIONARIO"]);

                lista.Add(F);
            }

            cf.Conexao.Close();

            return lista;
        }

        //Inicia a pesquisa no gridview
        public List<Funcionario> FindLikeFunc( string termo1)
        {
            cf = new ConnectionFactory();

            string query = "SELECT ID_FUNCIONARIO, NM_FUNCIONARIO FROM FUNCIONARIO WHERE(NM_FUNCIONARIO like @termo1 or ID_FUNCIONARIO like @termo1) ";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();


            cf.Comando.Parameters.AddWithValue("@termo1", "%" + termo1 + "%");

            //Cria uma lista, que armazenárá os resultados da consulta  
            List<Funcionario> lista = new List<Funcionario>();

            cf.Conexao.Open();//Abre a conexão

            //Executando o comando
            SqlDataReader dr = cf.Comando.ExecuteReader();

            while (dr.Read())
            {
                Funcionario F = new Funcionario();//Instanciando o objeto da iteração
                //Preenchimento das propriedades a partir do que retornou no banco.
                F.IdFuncionario = Convert.ToInt32(dr["ID_FUNCIONARIO"]);
                F.NmFuncionario = Convert.ToString(dr["NM_FUNCIONARIO"]);

                lista.Add(F);//Adicionando o objeto para a lista
            }
            //Fechando a conexão
            cf.Conexao.Close();

            //Retornando a lista já carregada.
            return lista;
        }
        public DataTable FindLike(string termo1)
        {
            string query = "SELECT ID_FUNCIONARIO [ID], NM_FUNCIONARIO [NOME DO FUNCIONARIO], CPF_FUNCIONARIO [CPF ], RG_FUNCIONARIO [RG], END_FUNCIONARIO [ENDEREÇO], TEL_FUNCIONARIO [TELEFONE], EMAIL_FUNCIONARIO [E-MAIL], DT_NASCIMENTO_FUNCIONARIO [DATA DE NASCIMENTO], BAIRRO_ENDERECO_FUNCIONARIO [BAIRRO], NUMERO_ENDERECO_FUNCIONARIO [NÚMERO], SALARIO_BASE_FUNCIONARIO [SALÁRIO],  ID_UF [UF], ID_SITUACAO [SITUAÇÃO],  ID_SEXO [SEXO], ID_CIDADE [CIDADE], CEP_FUNCIONARIO [CEP] FROM FUNCIONARIO WHERE (NM_FUNCIONARIO like @termo1 or ID_FUNCIONARIO like @termo1)";

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
        public int Update(Funcionario F)
        {
            try
            {
                cf = new ConnectionFactory();
                StringBuilder query = new StringBuilder();

                int linhasAfetadas = 0;

                query.AppendLine(" UPDATE FUNCIONARIO SET ");
                query.AppendLine(" NM_FUNCIONARIO = @NM_FUNCIONARIO, ");
                query.AppendLine(" CPF_FUNCIONARIO = @CPF_FUNCIONARIO, ");
                query.AppendLine(" RG_FUNCIONARIO = @RG_FUNCIONARIO,");
                query.AppendLine(" END_FUNCIONARIO = @END_FUNCIONARIO, ");
                query.AppendLine(" TEL_FUNCIONARIO = @TEL_FUNCIONARIO, ");
                query.AppendLine(" EMAIL_FUNCIONARIO = @EMAIL_FUNCIONARIO, ");
                query.AppendLine(" DT_NASCIMENTO_FUNCIONARIO = @DT_NASCIMENTO_FUNCIONARIO, ");
                query.AppendLine(" BAIRRO_ENDERECO_FUNCIONARIO = @BAIRRO_ENDERECO_FUNCIONARIO, ");
                query.AppendLine(" NUMERO_ENDERECO_FUNCIONARIO = @NUMERO_ENDERECO_FUNCIONARIO, ");
                query.AppendLine(" SALARIO_BASE_FUNCIONARIO = @SALARIO_BASE_FUNCIONARIO, ");
                query.AppendLine(" CEP_FUNCIONARIO = @CEP_FUNCIONARIO,");
                query.AppendLine(" ID_UF = @ID_UF, ");
                query.AppendLine(" ID_SITUACAO = @ID_SITUACAO, ");
                query.AppendLine(" ID_SEXO = @ID_SEXO, ");
                query.AppendLine(" ID_CIDADE = @ID_CIDADE");
                query.AppendLine(" WHERE ID_FUNCIONARIO = @ID_FUNCIONARIO");

                cf.Comando = cf.Conexao.CreateCommand();

                cf.Comando.Parameters.AddWithValue("@NM_FUNCIONARIO", F.NmFuncionario);
                cf.Comando.Parameters.AddWithValue("@CPF_FUNCIONARIO", F.CfpFuncionario);
                cf.Comando.Parameters.AddWithValue("@RG_FUNCIONARIO", F.RGFuncionario);
                cf.Comando.Parameters.AddWithValue("@END_FUNCIONARIO", F.EndFuncionario);
                cf.Comando.Parameters.AddWithValue("@TEL_FUNCIONARIO", F.TelFuncionario);
                cf.Comando.Parameters.AddWithValue("@EMAIL_FUNCIONARIO", F.EmailFuncionario);
                cf.Comando.Parameters.AddWithValue("@DT_NASCIMENTO_FUNCIONARIO", F.DataNascimento);
                cf.Comando.Parameters.AddWithValue("@BAIRRO_ENDERECO_FUNCIONARIO", F.BairroEndereco);
                cf.Comando.Parameters.AddWithValue("@NUMERO_ENDERECO_FUNCIONARIO", F.NumeroEndereco);
                cf.Comando.Parameters.AddWithValue("@SALARIO_BASE_FUNCIONARIO", F.SalarioBase);
                cf.Comando.Parameters.AddWithValue("@CEP_FUNCIONARIO", F.CEPFuncionario);
                cf.Comando.Parameters.AddWithValue("@ID_SITUACAO", F.IdSexo);
                cf.Comando.Parameters.AddWithValue("@ID_UF", F.IdUF);
                cf.Comando.Parameters.AddWithValue("@ID_SEXO", F.IdSexo);
                cf.Comando.Parameters.AddWithValue("@ID_CIDADE", F.CidadeEndereco);
                cf.Comando.Parameters.AddWithValue("@ID_FUNCIONARIO", F.IdFuncionario);

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
        public int Delete(int IdFuncionario)
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            int linhasAfetadas = 0;

            query.AppendLine("UPDATE FUNCIONARIO SET ID_SITUACAO = 2");
            query.AppendLine("WHERE ID_FUNCIONARIO = @ID_FUNCIONARIO");

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("ID_FUNCIONARIO", IdFuncionario);

            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();
            cf.Conexao.Open();

            linhasAfetadas = cf.Comando.ExecuteNonQuery();
            cf.Conexao.Close();

            return linhasAfetadas;

        }
    }
}

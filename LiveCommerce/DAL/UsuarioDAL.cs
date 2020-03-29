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
    public class UsuarioDAL
    {
        ConnectionFactory cf;

        public void Insert(Login c)
        {
            cf = new ConnectionFactory();
            StringBuilder query = new StringBuilder();
            query.AppendLine("INSERT INTO USUARIO");
            query.AppendLine("(NM_USUARIO,  DS_USUARIO ,SENHA_USUARIO, ID_FUNCIONARIO)");
            query.AppendLine("VALUES (@NM_USUARIO, @DS_USUARIO, @SENHA_USUARIO, @ID_FUNCIONARIO)");
            query.AppendLine("SELECT SCOPE_IDENTITY();");

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.Parameters.AddWithValue("@NM_USUARIO", c.NmUsuario);
            cf.Comando.Parameters.AddWithValue("@DS_USUARIO", c.DsUsuario);
            cf.Comando.Parameters.AddWithValue("@SENHA_USUARIO", c.Senhausuario);
            cf.Comando.Parameters.AddWithValue("@ID_FUNCIONARIO", c.IDFuncionario);

            cf.Comando.CommandType = CommandType.Text;
            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();

            c.IdUsuario = Convert.ToInt32(cf.Comando.ExecuteScalar());
            cf.Conexao.Close();
        }

        public List<Funcionario>FindAll()
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
        public Login FindByLogin(string nmUsuario, string senhausuario)
        {
            Login U = null;

            cf = new ConnectionFactory();

            // string query = "SELECT NM_USUARIO,SENHA_USUARIO   FROM LOGINN ";
            string query = "USP_USUARIOS_SEL ";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.StoredProcedure;

            cf.Comando.CommandText = query;

            cf.Comando.Parameters.AddWithValue("@LOGIN", nmUsuario);
            cf.Comando.Parameters.AddWithValue("@SENHA", senhausuario);
            cf.Conexao.Open();

            

            SqlDataReader dr = cf.Comando.ExecuteReader();

            if (dr.Read())
            {
                 U = new Login();
                U.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                U.NmUsuario = Convert.ToString(dr["NM_USUARIO"]);
                U.Senhausuario = Convert.ToString(dr["SENHA_USUARIO"]);
                U.DsUsuario = Convert.ToString(dr["DS_USUARIO"]);

            }

            cf.Conexao.Close();

            return U;
        }
    }
}

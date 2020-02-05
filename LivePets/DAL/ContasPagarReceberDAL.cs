using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class ContasPagarReceberDAL
    {
        ConnectionFactory cf;
        public void Insert (ContasPagarReceber c)
        {
            string query = "LV_INSERIR_CONT_V1";

            //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
            cf = new ConnectionFactory();

            //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
            cf.Comando = cf.Conexao.CreateCommand();

            //Abaixo os parametros que no momento da execução serão substituídos pelos valor das propriedades
            //cf.Comando.Parameters.AddWithValue("@ID_CLINTE", c.Id);
            cf.Comando.Parameters.AddWithValue("@CTPCONT", c.CtpCont);
            cf.Comando.Parameters.AddWithValue("@CDTLANC", c.CdtLanc);
            cf.Comando.Parameters.AddWithValue("@CCODORI", c.CcodOri);
            cf.Comando.Parameters.AddWithValue("@CVLRCNT", c.CvlrCnt);
            cf.Comando.Parameters.AddWithValue("@@CDTPAG", c.DdtPag);
            cf.Comando.Parameters.AddWithValue("@@CDTVCTO", c.CdtVcto);
            cf.Comando.Parameters.AddWithValue("@COBS", c.Cobs);

            cf.Comando.Parameters.AddWithValue("@ID_OUT", 0).Direction = ParameterDirection.Output;

            //CommandType indica que o Comando será via procedure no banco de dados
            cf.Comando.CommandType = CommandType.StoredProcedure;

            //CommandText: Propriedade do objeto command que receberá o texto do Comando a ser executado.
            cf.Comando.CommandText = query.ToString();

            //Abre a conexão 
            cf.Conexao.Open();
            c.CodCont = 0;//Define o ID inicialmente como 0.

            cf.Comando.ExecuteNonQuery();//Execução do Comando no Banco de dados        
            object o = cf.Comando.Parameters["@ID_OUT"].Value;//Recuperando o ID salvo (que deverá ser > 0).
            cf.Conexao.Close();

            if (o != null)
                c.CodCont = Convert.ToInt32(o);
        }
    }
}

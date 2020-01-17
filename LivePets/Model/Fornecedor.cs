using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class Fornecedor
    {
        private int idFornecedor;

        private string dSFornecedor;

        private  string razao;

        private string nomeFantasia;

        private string cpfcnpjFornecedor;

        private string ie;

        private string enderecoFornecedor;

        private string enderecoBairroFornecedor;

        private string enderecoNumeroFornecedor;

        private int enderecoCidadeFornecedor;

        private int ufFornecedor;

        private DateTime dataCadastro;

        private string enderecoCepFornecedor;

        private string telefoneFornecedor;

        private string celularFornecdor;

        private string emailFornecedor;

        private int iDSituacao;

        private int tipoPessoa;

        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public string Razao { get => razao; set => razao = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string CpfcnpjFornecedor { get => cpfcnpjFornecedor; set => cpfcnpjFornecedor = value; }
        public string Ie { get => ie; set => ie = value; }
        public string EnderecoFornecedor { get => enderecoFornecedor; set => enderecoFornecedor = value; }
        public string EnderecoBairroFornecedor { get => enderecoBairroFornecedor; set => enderecoBairroFornecedor = value; }
        public string EnderevoNumeroFornecedor { get => enderecoNumeroFornecedor; set => enderecoNumeroFornecedor = value; }        
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public string EnderecoCepFornecedor { get => enderecoCepFornecedor; set => enderecoCepFornecedor = value; }
        public string TelefoneFornecedor { get => telefoneFornecedor; set => telefoneFornecedor = value; }
        public string CelularFornecdor { get => celularFornecdor; set => celularFornecdor = value; }
        public string EmailFornecedor { get => emailFornecedor; set => emailFornecedor = value; }
        public int UfFornecedor { get => ufFornecedor; set => ufFornecedor = value; }
        public int EnderecoCidadeFornecedor { get => enderecoCidadeFornecedor; set => enderecoCidadeFornecedor = value; }
        public int IDSituacao { get => iDSituacao; set => iDSituacao = value; }
        public string DSFornecedor { get => dSFornecedor; set => dSFornecedor = value; }
        public int TipoPessoa { get => tipoPessoa; set => tipoPessoa = value; }
    }
}

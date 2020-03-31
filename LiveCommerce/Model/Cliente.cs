using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class Cliente
    {
        private int iD;

        
        private DateTime dataCadastro;

        private int situacao;

        private string pessoa;

        private string nomeCliente;

        private string celularCliente;

        private DateTime dataNascimento;

        private string endereco;

        private int numeroEndereco;

        private string bairroEndereco;

        private string cepEndereco;

        private int ufEndereco;

        private int cidadeEndereco;

        private string cpfCliente;

        private string rgCliente;

        private int tipoPessoa;



        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public string Pessoa { get => pessoa; set => pessoa = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        
        public string Endereco { get => endereco; set => endereco = value; }
        public int NumeroEndereco { get => numeroEndereco; set => numeroEndereco = value; }
        public string BairroEndereco { get => bairroEndereco; set => bairroEndereco = value; }
        public string CepEndereco { get => cepEndereco; set => cepEndereco = value; }
        public int ID { get => iD; set => iD = value; }
        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public string RgCliente { get => rgCliente; set => rgCliente = value; }
        public string CelularCliente { get => celularCliente; set => celularCliente = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int Situacao { get => situacao; set => situacao = value; }
        public int UfEndereco { get => ufEndereco; set => ufEndereco = value; }
        public int CidadeEndereco { get => cidadeEndereco; set => cidadeEndereco = value; }
        public int TipoPessoa { get => tipoPessoa; set => tipoPessoa = value; }
    }
}

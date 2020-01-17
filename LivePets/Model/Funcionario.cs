using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class Funcionario
    {
        private int idFuncionario;

        private string rGFuncionario;

        private string nmFuncionario;

        private string cfpFuncionario;

        private string endFuncionario;

        private string telFuncionario;

        private string emailFuncionario;

        private float cmFuncionario;

        private DateTime dataNascimento;

        private string bairroEndereco;

        private int numeroEndereco;

        private int cidadeEndereco;

        private string cEPFuncionario;

        private float salarioBase;

        private int idSituacao;

        private int idUF;

        private int idSexo;

        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string NmFuncionario { get => nmFuncionario; set => nmFuncionario = value; }
        public string CfpFuncionario { get => cfpFuncionario; set => cfpFuncionario = value; }
        public string EndFuncionario { get => endFuncionario; set => endFuncionario = value; }
        public string TelFuncionario { get => telFuncionario; set => telFuncionario = value; }
        public string EmailFuncionario { get => emailFuncionario; set => emailFuncionario = value; }
        public float CmFuncionario { get => cmFuncionario; set => cmFuncionario = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string BairroEndereco { get => bairroEndereco; set => bairroEndereco = value; }
        public int NumeroEndereco { get => numeroEndereco; set => numeroEndereco = value; }
        public float SalarioBase { get => salarioBase; set => salarioBase = value; }
        public int IdSituacao { get => idSituacao; set => idSituacao = value; }
        public int IdUF { get => idUF; set => idUF = value; }
        public int IdSexo { get => idSexo; set => idSexo = value; }
        public int CidadeEndereco { get => cidadeEndereco; set => cidadeEndereco = value; }
        public string RGFuncionario { get => rGFuncionario; set => rGFuncionario = value; }
        public string CEPFuncionario { get => cEPFuncionario; set => cEPFuncionario = value; }
    }
}

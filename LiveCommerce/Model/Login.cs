using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
    public class Login
    {
        private int idUsuario;

        private string nmUsuario;

        private string dsUsuario;

        private string senhausuario;

        private int iDFuncionario;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NmUsuario { get => nmUsuario; set => nmUsuario = value; }
        public string DsUsuario { get => dsUsuario; set => dsUsuario = value; }
        public string Senhausuario { get => senhausuario; set => senhausuario = value; }
        public int IDFuncionario { get => iDFuncionario; set => iDFuncionario = value; }
    }
}

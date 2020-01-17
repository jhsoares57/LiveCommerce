using LiveCommerce.DAL;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Business
{
    public class UsuarioBLL
    {
        public bool Insert(Login c)
        {
            bool salvou = false;
            new UsuarioDAL().Insert(c);
            return salvou;

        }
        public List<Funcionario> FindAll()
        {
            UsuarioDAL UserDAL = new UsuarioDAL();
            return UserDAL.FindAll();
        }
        
        public Login FindByLogin(string nmUsuario, string senhaUsuario)
        {
            UsuarioDAL uDAL = new UsuarioDAL();
            return uDAL.FindByLogin(nmUsuario, senhaUsuario);
        }
    }
}

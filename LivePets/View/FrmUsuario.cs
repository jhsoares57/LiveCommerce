using Library.Utils;
using LiveCommerce.Business;
using LiveCommerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCommerce.View
{
    public partial class FrmUsuario : Form
    {
        UsuarioBLL usuarioService = new UsuarioBLL();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnSairCadastroUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {

            if (txtSenhaUsuario.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("Confirmação de senha invalida");
            }

            else
            { 
                try
                {           
                    Login L = new Login();
                    L.NmUsuario = txtUsuarioCadastroUsuario.Text;
                    L.Senhausuario = Criptografia.GerarMD5(txtSenhaUsuario.Text);
                    L.DsUsuario = gbxPermissao.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
                    L.IDFuncionario = Convert.ToInt32(cbxUsuarioFuncionario.SelectedValue);

                    usuarioService.Insert(L);

                    MessageBox.Show("Usuario inserido com sucesso");

                }

                 catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void CarregarFuncionario()
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();
            listaFuncionario.Add(new Funcionario() { IdFuncionario = 0, NmFuncionario = "SELECIONE" });
            listaFuncionario.AddRange(usuarioService.FindAll());
            cbxUsuarioFuncionario.DataSource = listaFuncionario;
            cbxUsuarioFuncionario.ValueMember = "idFuncionario";
            cbxUsuarioFuncionario.DisplayMember = "nmFuncionario";
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }
    }
}

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
    public partial class FrmLogin : Form
    {
        UsuarioBLL usuarioService = new UsuarioBLL();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtLoginUsuario.Text) || string.IsNullOrEmpty(txtLoginSenha.Text))
            {
                MessageBox.Show("Digite Usuário e Senha!");
                txtLoginUsuario.Focus();
                return;
            }
            // Login l = new Login();
            //  l.NmUsuario = txtLoginUsuario.Text;
            // l.Senhausuario = txtLoginSenha.Text;

            // var user = "live";
            // var senha = "teste";
            //if()
            //else
            //{ 

            //if(user == txtLoginUsuario.Text && senha == txtLoginSenha.Text)
            //{
            //    this.Hide();
            //    FrmPaginaInicial inicial = new FrmPaginaInicial();
            //    inicial.Show();
            //}
            //else
            //{
            //   MessageBox.Show("Verificar usuario e senha");
            //    txtLoginSenha.Clear();
            //    txtLoginUsuario.Clear();
            //    txtLoginUsuario.Focus();
            //    return;
            //}
            //}
            try
            {
                UsuarioBLL uService = new UsuarioBLL();
                Login usuario = new Login();

                usuario = uService.FindByLogin(txtLoginUsuario.Text, Criptografia.GerarMD5(txtLoginSenha.Text));

                if(usuario != null)
                {
                    this.Hide();
                    FrmPaginaInicial inicial = new FrmPaginaInicial();
                    inicial.Show();
                }
                else
                {
                    throw new Exception("Usuario Incorreto");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSairLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
           
        }

    }
}

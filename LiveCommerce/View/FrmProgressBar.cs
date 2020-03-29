using LiveCommerce.DAL;
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
    public partial class FrmProgressBar : Form
    {
        public FrmProgressBar()
        {
            InitializeComponent();
        }

        private void FrmProgressBar_Load(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarIniciar.Value < 100)
            {
                progressBarIniciar.Value = progressBarIniciar.Value + 10;
            }
            if (progressBarIniciar.Value == 100)
                {
                try
                {
                    bool conexaoOK = new ConnectionFactory().TestarConexao();

                    if (conexaoOK)
                    {
                        timer1.Stop();
                        FrmLogin Login = new FrmLogin();
                        Login.Show();
                    }
                
                }
                catch (Exception)
                {
                    timer1.Stop(); // para o relógio em caso de erro
                    FrmConfigurarAcesso fAcesso = new FrmConfigurarAcesso();
                    fAcesso.Show();
                    //MessageBox.Show("Problemas de conexão com o banco de dados!                           Entre em contato com suporte!", "Mensagem do Sistema - Ds Tecnologia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //this.Dispose(); // encerra o sistema
                }
                Visible = (false);
        }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

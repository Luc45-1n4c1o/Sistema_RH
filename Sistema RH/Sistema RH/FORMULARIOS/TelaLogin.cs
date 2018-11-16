using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_RH.NEGOCIOS;

namespace Sistema_RH.Formulários
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        public string usuario;
        public string senha;
        private void btnLogar_Click(object sender, EventArgs e)
        {
            
            usuario = txtUser.Text;
            senha = txtPwd.Text;
            Autenticacao.login(usuario, senha);
            
            this.Visible = false;
            if (Autenticacao.situacao() == true)
            {
                TelaPrincipal telaprincipal = new TelaPrincipal();
                telaprincipal.ShowDialog();
            }
            //falta chamar o form login várias e várias vezes se a senha estiver errada, o que não está acontecendo no momento - comment by inacio
            else
            {
                MessageBox.Show("login ou senha estão errados.");
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Deseja fechar?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

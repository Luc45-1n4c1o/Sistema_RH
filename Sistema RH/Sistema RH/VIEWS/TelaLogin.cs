using System;
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

            if(senha.Length < 4 || senha.Length > 16)
            {
                MessageBox.Show("A senha não pode ser menor do que 4 caracteres\n e nem maior do que 16.");
            }

            Autenticacao.login(usuario, senha);//estou chamando esse método e passando o usuario e senha como paramentro
            
            this.Visible = false;
            if (Autenticacao.situacao() == true)
            {
                TelaPrincipal telaprincipal = new TelaPrincipal();
                telaprincipal.ShowDialog();
            }

            //mostra o form de login caso os dados inseridos não seja compatíveis com os do banco de dados
            else
            {
                MessageBox.Show("login ou senha estão errados.");
                txtUser.Text = "";
                txtPwd.Text = "";
                this.Visible = true;
                txtUser.Focus();
                
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Deseja fechar?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();
            Application.Exit();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogar;
        }
    }
}

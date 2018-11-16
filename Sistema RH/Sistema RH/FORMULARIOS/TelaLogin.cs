using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Visible = false;
            if (usuario == "lucas" && senha == "dudu")
            {
                TelaPrincipal telaprincipal = new TelaPrincipal();
                telaprincipal.ShowDialog();
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

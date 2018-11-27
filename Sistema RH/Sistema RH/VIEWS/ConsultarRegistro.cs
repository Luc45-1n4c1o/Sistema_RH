using Sistema_RH.DADOS;
using System;
using System.Windows.Forms;

namespace Sistema_RH.FORMULARIOS
{
    public partial class ConsultarRegistro : Form
    {
        public ConsultarRegistro()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Primeiramente verifica a existencia do cpf no banco,
            //caso encontrado o método queryDadosCPF retorna esses dados no form Editar

            string cpf = mskInformeCpf.Text;
            this.Visible = false;
            DAOConsultarRegistro pesquisaNoRegistro = new DAOConsultarRegistro();
            pesquisaNoRegistro.RealizarConsultaPorCPF(cpf);
            
            if (pesquisaNoRegistro.statusDoCpf() == true)
            {

                DAORetornaCadastro daoteste = new DAORetornaCadastro();
                daoteste.queryDadosCPF(cpf);
              
            }
            else
            {
                MessageBox.Show("CPF não encontrado no registro!");
                mskInformeCpf.Text = "";
                this.Visible = true;
                mskInformeCpf.Focus();

            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConsultarRegistro_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnPesquisar;
        }
    }
}

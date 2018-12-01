using Sistema_RH.Classes;
using System;
using System.Windows.Forms;
using Sistema_RH.DADOS;

namespace Sistema_RH.FORMULARIOS
{
    public partial class Folha : Form
    {
        public Folha()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            FolhadePagamento payment = new FolhadePagamento();
            payment.Razaosocial = txtRazaoSocial.Text;
            payment.Cnpj = mskCnpj.Text;
            payment.Nomefuncionario = txtFuncionario.Text;
            payment.Salariobase = txtSalarioBase.Text; //Convert.ToDecimal(txtSalarioBase.Text); //Replace(',','.') método replace, tipo_de_conversão(txt_valor.Text.Replace(',','.'));
            payment.Departamento = txtDepartamento.Text;
            payment.Observacoes = txtObservacoes.Text;

            DAOFolhadePagamento FolhaDePagamento = new DAOFolhadePagamento();
            FolhaDePagamento.CadastrarPayment(payment.Razaosocial, payment.Cnpj, payment.Nomefuncionario, payment.Salariobase, payment.Departamento, payment.Observacoes);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Deseja sair do formulário de Folha de Pagamento?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();
           
        }
    }
}

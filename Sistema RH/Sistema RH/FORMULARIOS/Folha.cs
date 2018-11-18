using Sistema_RH.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            payment.Salariobase = Convert.ToDecimal(txtSalarioBase.Text);
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

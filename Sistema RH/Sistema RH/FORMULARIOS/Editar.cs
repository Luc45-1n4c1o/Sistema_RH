using Sistema_RH.NEGOCIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_RH.FORMULARIOS
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtNome2.Text;          
            funcionario.Sexo = txtSexo2.Text;
            funcionario.Departamento = txtDepartamento2.Text;
            funcionario.Funcao = txtFunção2.Text;
            funcionario.Estadocivil = txtEstadoCivil2.Text;
            funcionario.Admissão = Convert.ToDateTime(mskDataAdmissão2.Text);
            funcionario.Datanascimento = Convert.ToDateTime(mskDatadeNascimento2.Text);
            funcionario.Cpf = mskCPF2.Text;
            funcionario.Telefone = mskTelefone2.Text;
            funcionario.Email = txtEmail2.Text;
            funcionario.Rg = mskRG2.Text;
            funcionario.CarteiraTrabalho = mskCarteira2.Text;
        }
    }
}

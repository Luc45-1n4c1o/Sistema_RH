using Sistema_RH.DADOS;
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
    public partial class ConsultarRegistro : Form
    {
        public ConsultarRegistro()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Acrecentar os demais códigos
            string cpf = mskInformeCpf.Text;
            this.Visible = false;
            DAOConsultarRegistro pesquisaNoRegistro = new DAOConsultarRegistro();
            pesquisaNoRegistro.RealizarConsultaPorCPF(cpf);
            
            if (pesquisaNoRegistro.statusDoCpf() == true)
            {
                Editar editar = new Editar();
                editar.txtNome2.Text = "lucas";//tentativa de trazer os dados(vindo do banco) referente ao titular do cpf cujo foi realizada a consulta.
                editar.ShowDialog();
                
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
    }
}

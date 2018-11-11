using Sistema_RH.Classes;
using Sistema_RH.FORMULARIOS;
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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void folhaDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Folha folha = new Folha();
            folha.ShowDialog();
        }

        private void editarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarRegistro consulta = new ConsultarRegistro();
            consulta.ShowDialog();
        }
    }
}

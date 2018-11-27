using Sistema_RH.FORMULARIOS;
using System;
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

        private void Sair(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void calcularSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalarioLiquido salarioLiquido = new SalarioLiquido();
            salarioLiquido.ShowDialog();
        }
    }
}

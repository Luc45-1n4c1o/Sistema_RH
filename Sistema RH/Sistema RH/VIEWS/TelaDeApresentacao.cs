using Sistema_RH.Formulários;
using System;
using System.Windows.Forms;

namespace Sistema_RH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = progressBar1.Value + 10; // incremento da barra de progresso.
            }
            catch
            {
                timer1.Enabled = false; // Para o relógio
                this.Visible = false; // fechar o formulário
                TelaLogin telalogin = new TelaLogin(); // Instancia do formulario Tela de Login
                telalogin.ShowDialog(); // Comando para abrir o novo formulário (FRMLOGIN) automaticamente
            }
        }
    }
}

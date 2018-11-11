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
            this.Visible = false;
            Editar editar = new Editar();
            editar.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

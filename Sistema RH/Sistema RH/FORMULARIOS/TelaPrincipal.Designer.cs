namespace Sistema_RH.Formulários
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folhaDePagamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularSalarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionárioToolStripMenuItem,
            this.editarRegistroToolStripMenuItem,
            this.folhaDePagamentoToolStripMenuItem1,
            this.calcularSalarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            this.cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            this.cadastrarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            this.cadastrarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFuncionárioToolStripMenuItem_Click);
            // 
            // editarRegistroToolStripMenuItem
            // 
            this.editarRegistroToolStripMenuItem.Name = "editarRegistroToolStripMenuItem";
            this.editarRegistroToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.editarRegistroToolStripMenuItem.Text = "Editar Registro";
            this.editarRegistroToolStripMenuItem.Click += new System.EventHandler(this.editarRegistroToolStripMenuItem_Click);
            // 
            // folhaDePagamentoToolStripMenuItem1
            // 
            this.folhaDePagamentoToolStripMenuItem1.Name = "folhaDePagamentoToolStripMenuItem1";
            this.folhaDePagamentoToolStripMenuItem1.Size = new System.Drawing.Size(128, 20);
            this.folhaDePagamentoToolStripMenuItem1.Text = "Folha de Pagamento";
            this.folhaDePagamentoToolStripMenuItem1.Click += new System.EventHandler(this.folhaDePagamentoToolStripMenuItem1_Click);
            // 
            // calcularSalarioToolStripMenuItem
            // 
            this.calcularSalarioToolStripMenuItem.Name = "calcularSalarioToolStripMenuItem";
            this.calcularSalarioToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.calcularSalarioToolStripMenuItem.Text = "Calcular Salario";
            this.calcularSalarioToolStripMenuItem.Click += new System.EventHandler(this.calcularSalarioToolStripMenuItem_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 489);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos_Humanos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sair);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folhaDePagamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularSalarioToolStripMenuItem;
    }
}
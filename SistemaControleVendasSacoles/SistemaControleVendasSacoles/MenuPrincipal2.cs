using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaControleVendasSacoles
{
    public partial class MenuPrincipal2 : Form
    {
        public MenuPrincipal2()
        {
            InitializeComponent();
        }

        private void mnuArquivoNovoAzul_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            Form frmAzul = new Form();

            // Atribui um titulo ao formulário
            frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show(); 
        }

        private void MenuPrincipal2_Load(object sender, EventArgs e)
        {

        }

        private void mnuArquivoNovo_Click(object sender, EventArgs e)
        {
            CadastroSacoles Form = new CadastroSacoles();
            Form.Show();
        }

    }
}

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
    public partial class JanelaEstoque : Form
    {
        public JanelaEstoque()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            CadastroSacoles Form = new CadastroSacoles();
            Form.Show();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            AlterareExcluir Form = new AlterareExcluir();
            Form.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta Form3 = new Consulta();
            Form3.Show();
        }

        private void btnaltera_Click(object sender, EventArgs e)
        {
            AlterareExcluir Form = new AlterareExcluir();
            Form.Show();
        }




    }
}

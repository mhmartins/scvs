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
    public partial class ConsultaPorGrafico : Form
    {
        public ConsultaPorGrafico()
        {
            InitializeComponent();
        }

        private void btnConsultaAno_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarMes_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 47)
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 47)
            {
                e.Handled = true;
            }
        }
    }
}

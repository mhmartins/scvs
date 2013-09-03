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
    public partial class graficos : Form
    {
        public graficos()
        {
            InitializeComponent();
        }

        private void graficos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teste_chart1.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter.Fill(this.teste_chart1.sacoles);

        }
    }
}

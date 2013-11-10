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
            // TODO: This line of code loads data into the 'grafoEstCremoso.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter1.Fill(this.grafoEstCremoso.sacoles);
            // TODO: This line of code loads data into the 'grafo_Estoque.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter.Fill(this.grafo_Estoque.sacoles);
        }
    }
}

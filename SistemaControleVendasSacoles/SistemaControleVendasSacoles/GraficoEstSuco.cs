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
    public partial class GraficoEstSuco : Form
    {
        public GraficoEstSuco()
        {
            InitializeComponent();
        }

        private void GraficoEstSuco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grafoEstSuco.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter.Fill(this.grafoEstSuco.sacoles);

        }
    }
}

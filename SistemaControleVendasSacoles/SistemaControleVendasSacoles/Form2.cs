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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_rr_sacolesDataSet1.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter.Fill(this.banco_rr_sacolesDataSet1.sacoles);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

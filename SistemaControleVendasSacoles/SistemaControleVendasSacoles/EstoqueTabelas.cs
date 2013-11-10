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
    public partial class EstoqueTabelas : Form
    {
        public EstoqueTabelas()
        {
            InitializeComponent();
        }

        private void EstoqueTabelas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueSuco.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter1.Fill(this.estoqueSuco.sacoles);
            // TODO: This line of code loads data into the 'estoqueCremoso.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter.Fill(this.estoqueCremoso.sacoles);
            //this.sacolesDataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 18);
            //this.sacolesDataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 18);
            //this.sacolesDataGridView1.ClearSelection();
            //this.sacolesDataGridView.ClearSelection();
        }
    }
}

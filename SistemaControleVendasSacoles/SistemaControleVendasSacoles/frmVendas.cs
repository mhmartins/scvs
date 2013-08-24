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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void sacolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sacolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_rr_sacolesDataSet);

        }

        private void vendas_sacolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendas_sacolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_rr_sacolesDataSet);

        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_rr_sacolesDataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.banco_rr_sacolesDataSet.usuarios);
            // TODO: This line of code loads data into the 'banco_rr_sacolesDataSet.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter.Fill(this.banco_rr_sacolesDataSet.sacoles);
            // TODO: This line of code loads data into the 'banco_rr_sacolesDataSet.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.banco_rr_sacolesDataSet.vendas);
            // TODO: This line of code loads data into the 'banco_rr_sacolesDataSet.vendas_sacoles' table. You can move, or remove it, as needed.
            this.vendas_sacolesTableAdapter.Fill(this.banco_rr_sacolesDataSet.vendas_sacoles);

        }
    }
}

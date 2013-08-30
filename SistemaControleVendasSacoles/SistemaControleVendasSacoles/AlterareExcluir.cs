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
    public partial class AlterareExcluir : Form
    {
        public AlterareExcluir()
        {
            InitializeComponent();
        }

        private void sacolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sacolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_rr_sacolesDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_rr_sacolesDataSet1.tipo' table. You can move, or remove it, as needed.
            this.tipoTableAdapter.Fill(this.banco_rr_sacolesDataSet1.tipo);
            // TODO: This line of code loads data into the 'banco_rr_sacolesDataSet1.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter.Fill(this.banco_rr_sacolesDataSet1.sacoles);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
{
this.Validate();
this.sacolesBindingSource.EndEdit();
this.tableAdapterManager.UpdateAll(this.banco_rr_sacolesDataSet1);
}
catch (Exception)
{
MessageBox.Show("Não é possível deletar.\nHá relacionados.", "Erro ao Excluir", MessageBoxButtons.OK,
MessageBoxIcon.Error);
this.sacolesTableAdapter.Fill(this.banco_rr_sacolesDataSet1.sacoles);
}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sacolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_rr_sacolesDataSet1);
        }

        private void sacolesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }







    }
}

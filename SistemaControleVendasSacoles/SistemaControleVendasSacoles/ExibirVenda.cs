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
    public partial class ExibirVenda : Form
    {
        public ExibirVenda()
        {
            InitializeComponent();
        }

        private void vendasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.exibir_venda);

        }

        private void ExibirVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exibir_venda.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.exibir_venda.usuarios);
            // TODO: This line of code loads data into the 'exibir_venda.sacoles' table. You can move, or remove it, as needed.
            this.ProdutosTableAdapter.Fill(this.exibir_venda.sacoles);
            // TODO: This line of code loads data into the 'exibir_venda.vendas_sacoles' table. You can move, or remove it, as needed.
            this.vendas_sacolesTableAdapter.Fill(this.exibir_venda.vendas_sacoles);
            // TODO: This line of code loads data into the 'exibir_venda.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.exibir_venda.vendas);

        }
    }
}

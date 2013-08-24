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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //textBox1.Text = DateTime.Now.ToLongTimeString();
            //textBox2.Text = DateTime.Now.ToLongDateString();
         // textBox1.Text = DateTime.Now.ToShortTimeString();
         // textBox2.Text = DateTime.Now.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void vendas_sacolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendas_sacolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void vendas_sacolesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vendas_sacolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.banco.vendas);
            // TODO: This line of code loads data into the 'banco.vendas_sacoles' table. You can move, or remove it, as needed.
            this.vendas_sacolesTableAdapter.Fill(this.banco.vendas_sacoles);
            // TODO: This line of code loads data into the 'banco.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.banco.vendas);
            // TODO: This line of code loads data into the 'banco.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.banco.vendas);
            // TODO: This line of code loads data into the 'banco.vendas_sacoles' table. You can move, or remove it, as needed.
            this.vendas_sacolesTableAdapter.Fill(this.banco.vendas_sacoles);

        }

        private void sacoles_idsacolesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vendas_sacolesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.vendas_sacolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void sacoles_idsacolesComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class vend : Form
    {
        public vend()
        {
            InitializeComponent();
        }

        private void vendasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void vend_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter.Fill(this.banco.sacoles);
            // TODO: This line of code loads data into the 'banco.vendas_sacoles' table. You can move, or remove it, as needed.
            this.vendas_sacolesTableAdapter.Fill(this.banco.vendas_sacoles);
            // TODO: This line of code loads data into the 'banco.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.banco.usuarios);
            // TODO: This line of code loads data into the 'banco.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.banco.vendas);

        }

        //Código que pega a data e a hora automaticamente do sistema.
        private void timer1_Tick(object sender, EventArgs e)
        {

            //dataMaskedTextBox.Text=DateTime.Now.ToLongDateString();
            //textBox1.Text = DateTime.Now.ToLongTimeString();
            //textBox2.Text = 
            //textBox1.Text = DateTime.Now.ToShortTimeString();
            // dataMaskedTextBox.Text = DateTime.Now.ToShortDateString();

        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);
        }

        private void dataMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }


    }
}

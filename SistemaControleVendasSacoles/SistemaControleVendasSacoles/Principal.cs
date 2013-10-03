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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JanelaEstoque Form3 = new JanelaEstoque();
            Form3.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Consulta Form4 = new Consulta();
            // Form4.Show();
            MessageBox.Show("Função temporariamente inativa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Vendas tt = new Vendas();
            //tt.Show();
            // MenuPrincipal2 forma = new MenuPrincipal2();
            //forma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telateste venda = new Telateste();
            venda.Show();

            //Telateste frmFilho = new Telateste();
            //frmFilho.MDI_Pai = this;
            //frmFilho.Show();

            //Telateste Form4 = new Telateste();
            //Form4.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }

            // Display a child form to show this is still an MDI application.
            //Telateste frm = new Telateste();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //graficos grafo = new graficos();
            faturamento grafo = new faturamento();
            grafo.MdiParent = this;
            grafo.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //vend Form4 = new vend();
           // Form4.Show();
            ExibirVenda ved = new ExibirVenda();
            ved.MdiParent = this;
            ved.Show();
            //ajustar botão de seleção, para abrir a tela

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telateste newMDIChild = new Telateste();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void gráficoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            graficos frm = new graficos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroSacoles frm = new CadastroSacoles();
            frm.MdiParent = this;
            frm.Show();
        }

        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterareExcluir frm = new AlterareExcluir();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta frm = new Consulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

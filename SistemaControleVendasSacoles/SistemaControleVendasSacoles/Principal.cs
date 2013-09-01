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
            Telateste venda = new Telateste();
            venda.Show();
            //Vendas tt = new Vendas();
            //tt.Show();
            //MenuPrincipal2 forma = new MenuPrincipal2();
            //forma.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vend Form4 = new vend();
            Form4.Show();
            //Telateste Form4 = new Telateste();
            //Form4.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }



    


    }
}

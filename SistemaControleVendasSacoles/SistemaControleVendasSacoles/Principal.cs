using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            PesquisaPersonalizada Form3 = new PesquisaPersonalizada();
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

        string dataSistema = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            dataSistema = DateTime.Now.ToShortDateString();
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
           // faturamento grafo = new faturamento();
           // grafo.MdiParent = this;
           // grafo.Show();

            /*PesquisaPersonalizada dia = new PesquisaPersonalizada();
            dia.MdiParent = this;
            dia.Show();*/

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //vend Form4 = new vend();
           // Form4.Show();
            try
            {
                if (Application.OpenForms["ExibirVenda"] == null)
                {
                    ExibirVenda ved = new ExibirVenda();
                    ved.MdiParent = this;
                    ved.Show();
                }
                //else  
            }
            catch {}
            //ajustar botão de seleção, para abrir a tela

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["Form3"] == null)
                {
                    ConsultarVendasVendedor newMDIChild = new ConsultarVendasVendedor();
                    // Set the Parent Form of the Child window.
                    newMDIChild.MdiParent = this;
                    // Display the new form.
                    newMDIChild.Show();
                }
            }
            catch { }
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["Telateste"] == null)
                {
                    Telateste newMDIChild = new Telateste();
                    // Set the Parent Form of the Child window.
                    newMDIChild.MdiParent = this;
                    // Display the new form.
                    newMDIChild.Show();
                }
            }
            catch { }
        }

        private void gráficoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["CadastroSacoles"] == null)
                {
                    CadastroSacoles frm = new CadastroSacoles();
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
            catch { }
        }

        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["AlterareExcluir"] == null)
                {
                    AlterareExcluir frm = new AlterareExcluir();
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
            catch { }
        }

        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["EstoqueTabelas"] == null)
                {
                    EstoqueTabelas form = new EstoqueTabelas();
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch { }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["Form4"] == null)
                {
                    Form4 frm = new Form4();
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
            catch { }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FatuMes"] == null)
                {
                    FatuMes form = new FatuMes();
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch { }
        }

        private void adicionarProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AdicionaProd form1 = new AdicionaProd();
            //form1.MdiParent = this; 
            //form1.  
            //Form5 form = new Form5();
            //form.MdiParent = this; 
            //form.Show();

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cremosoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["AdicionarProducao"] == null)
                {
                    AdicionarProducao form2 = new AdicionarProducao();
                    form2.MdiParent = this;
                    form2.Show();
                }
            }
            catch { }
        }

        private void sucoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["AdicionaProducaoSuco"] == null)
                {
                    AdicionaProducaoSuco form2 = new AdicionaProducaoSuco();
                    form2.MdiParent = this;
                    form2.Show();
                }
            }
            catch { }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void outrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["PesquisaPersonalizada"] == null)
                {
                    PesquisaPersonalizada form = new PesquisaPersonalizada();
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch { }
        }

        private void saídaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void faturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["faturamento"] == null)
                {
                    faturamento grafo = new faturamento();
                    grafo.MdiParent = this;
                    grafo.Show();
                }
            }
            catch { }
        }

        private void faturamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FatuSemana"] == null)
                {
                    FatuSemana form = new FatuSemana();
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch { }
        }

        private void faturamentoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FatuMes"] == null)
                {
                    FatuMes form = new FatuMes();
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch { }
        }

        private void cremosoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataSistema = DateTime.Now.ToShortDateString();
            string data = "", sDataF = "";
            data = dataSistema;
            DateTime d = Convert.ToDateTime(data);
            sDataF = d.ToString("yyyyMMdd");
            try
            {
                string SQL1 = "INSERT INTO graficovendas SELECT idSacoles,sabor, SUM( quantidade ) AS quant FROM vendas_sacoles INNER JOIN sacoles ON vendas_sacoles.sacoles_idsacoles = sacoles.idSacoles && sacoles.tipo=1 INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas WHERE data = '" + sDataF + "' GROUP BY sacoles.idSacoles ORDER BY quant DESC";
                string SQL_APAGAR = "DELETE FROM graficovendas";
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlCommand comandos = new MySqlCommand(SQL1, combo10);
                MySqlCommand comandodrop = new MySqlCommand(SQL_APAGAR, combo10);
                combo10.Open();
                comandodrop.ExecuteNonQuery();
                comandos.ExecuteNonQuery();
                DataTable dt40 = new DataTable();
                combo10.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro!!" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form4 form = new Form4();
            form.MdiParent = this;
            form.Show();
        }

        private void cremosoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataSistema = DateTime.Now.ToShortDateString();
            string data = "", sDataF = "";
            data = dataSistema;
            DateTime d = Convert.ToDateTime(data);
            sDataF = d.ToString("yyyyMMdd");
            try
            {
                string SQL1 = "INSERT INTO graficovendas SELECT idSacoles,sabor, SUM( quantidade ) AS quant FROM vendas_sacoles INNER JOIN sacoles ON vendas_sacoles.sacoles_idsacoles = sacoles.idSacoles && sacoles.tipo=1 INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas WHERE data BETWEEN DATE_SUB(CURDATE(), INTERVAL 7 DAY) and '" + sDataF + "' GROUP BY sacoles.idSacoles ORDER BY quant DESC";
                string SQL_APAGAR = "DELETE FROM graficovendas";
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlCommand comandos = new MySqlCommand(SQL1, combo10);
                MySqlCommand comandodrop = new MySqlCommand(SQL_APAGAR, combo10);
                combo10.Open();
                comandodrop.ExecuteNonQuery();
                comandos.ExecuteNonQuery();
                DataTable dt40 = new DataTable();
                combo10.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro!!" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form4 form = new Form4();
            form.MdiParent = this;
            form.Show();
        }

        private void cremosoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataSistema = DateTime.Now.ToShortDateString();
            string data = "", sDataF = "";
            data = dataSistema;
            DateTime d = Convert.ToDateTime(data);
            sDataF = d.ToString("yyyyMMdd");
            int ano = DateTime.Now.Year;
            try
            {
                string SQL1 = "INSERT INTO graficovendas SELECT idSacoles,sabor, SUM( quantidade ) AS quant FROM vendas_sacoles INNER JOIN sacoles ON vendas_sacoles.sacoles_idsacoles = sacoles.idSacoles && sacoles.tipo=1 INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas WHERE data BETWEEN DATE_SUB(CURDATE(), INTERVAL 30 DAY) and '" + sDataF + "' GROUP BY sacoles.idSacoles ORDER BY quant DESC";
                string SQL_APAGAR = "DELETE FROM graficovendas";
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlCommand comandos = new MySqlCommand(SQL1, combo10);
                MySqlCommand comandodrop = new MySqlCommand(SQL_APAGAR, combo10);
                combo10.Open();
                comandodrop.ExecuteNonQuery();
                comandos.ExecuteNonQuery();
                DataTable dt40 = new DataTable();
                combo10.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro!!" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form4 form = new Form4();
            form.MdiParent = this;
            form.Show();
        }

        private void cremosoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int anoo = DateTime.Now.Year;
            string ano = anoo.ToString() ;
            try
            {
                string SQL1 = "INSERT INTO graficovendas SELECT idSacoles,sabor, SUM( quantidade ) AS quant FROM vendas_sacoles INNER JOIN sacoles ON vendas_sacoles.sacoles_idsacoles = sacoles.idSacoles && sacoles.tipo=1 INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas WHERE data LIKE '%" + ano + "%' GROUP BY sacoles.idSacoles ORDER BY quant DESC";
                string SQL_APAGAR = "DELETE FROM graficovendas";
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlCommand comandos = new MySqlCommand(SQL1, combo10);
                MySqlCommand comandodrop = new MySqlCommand(SQL_APAGAR, combo10);
                combo10.Open();
                comandodrop.ExecuteNonQuery();
                comandos.ExecuteNonQuery();
                DataTable dt40 = new DataTable();
                combo10.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro!!" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form4 form = new Form4();
            form.MdiParent = this;
            form.Show();
        }

        private void sucoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int anoo = DateTime.Now.Year;
            string ano = anoo.ToString();
            try
            {
                string SQL1 = "INSERT INTO graficovendas SELECT idSacoles,sabor, SUM( quantidade ) AS quant FROM vendas_sacoles INNER JOIN sacoles ON vendas_sacoles.sacoles_idsacoles = sacoles.idSacoles && sacoles.tipo=2 INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas WHERE data LIKE '%" + ano + "%' GROUP BY sacoles.idSacoles ORDER BY quant DESC";
                string SQL_APAGAR = "DELETE FROM graficovendas";
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlCommand comandos = new MySqlCommand(SQL1, combo10);
                MySqlCommand comandodrop = new MySqlCommand(SQL_APAGAR, combo10);
                combo10.Open();
                comandodrop.ExecuteNonQuery();
                comandos.ExecuteNonQuery();
                DataTable dt40 = new DataTable();
                combo10.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro!!" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form4 form = new Form4();
            form.MdiParent = this;
            form.Show();
        }

        private void sucoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dataSistema = DateTime.Now.ToShortDateString();
            string data = "", sDataF = "";
            data = dataSistema;
            DateTime d = Convert.ToDateTime(data);
            sDataF = d.ToString("yyyyMMdd");
            int ano = DateTime.Now.Year;
            try
            {
                string SQL1 = "INSERT INTO graficovendas SELECT idSacoles,sabor, SUM( quantidade ) AS quant FROM vendas_sacoles INNER JOIN sacoles ON vendas_sacoles.sacoles_idsacoles = sacoles.idSacoles && sacoles.tipo=2 INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas WHERE data LIKE '%" + ano + "%' GROUP BY sacoles.idSacoles ORDER BY quant DESC";
                string SQL_APAGAR = "DELETE FROM graficovendas";
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlCommand comandos = new MySqlCommand(SQL1, combo10);
                MySqlCommand comandodrop = new MySqlCommand(SQL_APAGAR, combo10);
                combo10.Open();
                comandodrop.ExecuteNonQuery();
                comandos.ExecuteNonQuery();
                DataTable dt40 = new DataTable();
                combo10.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro!!" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form4 form = new Form4();
            form.MdiParent = this;
            form.Show();
        }

        private void sucoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataSistema = DateTime.Now.ToShortDateString();
            string data = "", sDataF = "";
            data = dataSistema;
            DateTime d = Convert.ToDateTime(data);
            sDataF = d.ToString("yyyyMMdd");
            try
            {
                string SQL1 = "INSERT INTO graficovendas SELECT idSacoles,sabor, SUM( quantidade ) AS quant FROM vendas_sacoles INNER JOIN sacoles ON vendas_sacoles.sacoles_idsacoles = sacoles.idSacoles && sacoles.tipo=2 INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas WHERE data BETWEEN DATE_SUB(CURDATE(), INTERVAL 7 DAY) and '" + sDataF + "' GROUP BY sacoles.idSacoles ORDER BY quant DESC";
                string SQL_APAGAR = "DELETE FROM graficovendas";
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlCommand comandos = new MySqlCommand(SQL1, combo10);
                MySqlCommand comandodrop = new MySqlCommand(SQL_APAGAR, combo10);
                combo10.Open();
                comandodrop.ExecuteNonQuery();
                comandos.ExecuteNonQuery();
                DataTable dt40 = new DataTable();
                combo10.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro!!" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form4 form = new Form4();
            form.MdiParent = this;
            form.Show();
        }

        private void sucoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataSistema = DateTime.Now.ToShortDateString();
            string data = "", sDataF = "";
            data = dataSistema;
            DateTime d = Convert.ToDateTime(data);
            sDataF = d.ToString("yyyyMMdd");
            try
            {
                string SQL1 = "INSERT INTO graficovendas SELECT idSacoles,sabor, SUM( quantidade ) AS quant FROM vendas_sacoles INNER JOIN sacoles ON vendas_sacoles.sacoles_idsacoles = sacoles.idSacoles && sacoles.tipo=2 INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas WHERE data = '" + sDataF + "' GROUP BY sacoles.idSacoles ORDER BY quant DESC";
                string SQL_APAGAR = "DELETE FROM graficovendas";
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlCommand comandos = new MySqlCommand(SQL1, combo10);
                MySqlCommand comandodrop = new MySqlCommand(SQL_APAGAR, combo10);
                combo10.Open();
                comandodrop.ExecuteNonQuery();
                comandos.ExecuteNonQuery();
                DataTable dt40 = new DataTable();
                combo10.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro!!" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form4 form = new Form4();
            form.MdiParent = this;
            form.Show();
        }

        private void faturamentoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FatuMes"] == null)
                {
                    FatuAno form = new FatuAno();
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch { }
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarVendasVendedor form = new ConsultarVendasVendedor();
            form.MdiParent = this;
            form.Show();
        }

        private void cremosoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["graficos"] == null)
                {
                    graficos form = new graficos();
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch { }

        }

        private void sucoToolStripMenuItem5_Click(object sender, EventArgs e)
        {

            try
            {
                if (Application.OpenForms["GraficoEstSuco"] == null)
                {
                    GraficoEstSuco form = new GraficoEstSuco();
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch { }
        }

        private void cremosoToolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }
    }
}

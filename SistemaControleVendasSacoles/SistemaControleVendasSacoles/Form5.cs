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
    public partial class RelatorioSacoles : Form
    {
        public RelatorioSacoles()
        {
            InitializeComponent();
            //inicia DATAGRID 
            dgv.Columns.Add("sabor", "          Sacolés");
            dgv.Columns.Add("quant", "    Quantidade");
            dgv.Columns.Add("total", "        Total");
            //define COLUNAS e LINHA do DATAGRID
            dgv.Columns[0].Width = 250;
            dgv.Columns[1].Width = 80;
            dgv.Columns[2].Width = 129;

        }

        private void RelatorioSacoles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT sabor, SUM( quantidade ) AS quant FROM vendas_sacoles INNER JOIN sacoles ON vendas_sacoles.sacoles_idsacoles = sacoles.idSacoles INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas WHERE data like '%2013%' GROUP BY sacoles.idSacoles ORDER BY quant DESC";
            try
            {
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql40 = new MySqlDataAdapter("select preco, quant from sacoles where idSacoles = '" + cmbxsacolescre.SelectedValue.ToString() + "'", combo10);
                DataTable dt40 = new DataTable();
                //int rt = 0;
                //string lcSQL = "SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1";

                /*   MySqlConnection conn = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                   MySqlCommand command = new MySqlCommand(lcSQL, conn);
                   command.Parameters.AddWithValue("idvendas", rt);
                   conn.Open();
                   MySqlDataReader dr = command.ExecuteReader();
                   while (dr.Read())
                   {
                       dr.GetInt32(0);
                   }
                   */
                sql40.Fill(dt40);
                BindingSource source = new BindingSource();
                source.DataSource = dt40;

                this.tbxValCre.DataBindings.Add("Text", source, "preco", true);
                this.tbxEstCre.DataBindings.Add("Text", source, "quant", true);
                nupdowCre.Maximum = int.Parse(tbxEstCre.Text);
                combo10.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            //$result = mysql_query($query) or die(mysql_error());
        }
    }
}

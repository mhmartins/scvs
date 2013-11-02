using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace SistemaControleVendasSacoles
{
    public partial class FatuAno : Form
    {
        public FatuAno()
        {
            InitializeComponent();
        }
        string dataSistema = "";
        private void FatuAno_Load(object sender, EventArgs e)
        {
            this.label4.DataBindings.Clear();
            int anoo = DateTime.Now.Year;
            string ano = anoo.ToString() ;
            try
            {
                MySqlConnection con = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql = new MySqlDataAdapter("SELECT SUM( total ) AS total FROM faturamento WHERE data LIKE '%" + ano + "%'", con);
                //SELECT DATE_SUB(CURDATE(), INTERVAL 7 DAY);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                BindingSource source = new BindingSource();
                source.DataSource = dt;
                this.label4.DataBindings.Add("Text", source, "total", true);
                string total = label4.Text;
                Decimal tt = Convert.ToDecimal(total);
                String tot = tt.ToString("N", new CultureInfo("pt-BR"));
                tbxFaturamento.Text = ("R$ " + (String.Format("{0:0.00}", tt))).ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                //throw new Exception("Erro de comandos: " + ex.Message);
            }
        }
    }
}

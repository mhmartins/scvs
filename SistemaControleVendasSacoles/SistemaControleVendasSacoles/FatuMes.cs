using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace SistemaControleVendasSacoles
{
    public partial class FatuMes : Form
    {
        public FatuMes()
        {
            InitializeComponent();
        }
        string dataSistema = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            dataSistema = DateTime.Now.ToShortDateString();
        }
        private void FatuMes_Load(object sender, EventArgs e)
        {
            this.label4.DataBindings.Clear();
            dataSistema = DateTime.Now.ToShortDateString();
            string data = "", sDataF = "";
            data = dataSistema;
            DateTime d = Convert.ToDateTime(data);
            sDataF = d.ToString("yyyyMMdd");
            try
            {
                MySqlConnection con = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql = new MySqlDataAdapter("SELECT SUM( total ) AS total FROM faturamento WHERE data BETWEEN DATE_SUB(CURDATE(), INTERVAL 30 DAY) and '" + sDataF + "'", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

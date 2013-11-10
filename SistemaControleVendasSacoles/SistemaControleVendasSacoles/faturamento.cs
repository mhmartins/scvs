using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using MySql.Data.Common;
using System.Collections;
using System.Globalization;
namespace SistemaControleVendasSacoles
{
    public partial class faturamento : Form
    {
        public faturamento()
        {
            InitializeComponent();
        }
        
        string dataSistema = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            dataSistema = DateTime.Now.ToShortDateString();
        }

        private void faturamento_Load(object sender, EventArgs e)
        {
            this.textBox1.DataBindings.Clear();
            dataSistema = DateTime.Now.ToShortDateString();
            string data="",sDataF="";
            data = dataSistema;
            DateTime d = Convert.ToDateTime(data);
            sDataF = d.ToString("yyyyMMdd");
            try
            {
                MySqlConnection con = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql = new MySqlDataAdapter("select total from faturamento where data = '" + sDataF + "'", con);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                BindingSource source = new BindingSource();
                source.DataSource = dt;
                this.textBox1.DataBindings.Add("Text", source, "total", true);
                string total = textBox1.Text;
                Decimal tt = Convert.ToDecimal(total);
                String tot = tt.ToString("N", new CultureInfo("pt-BR"));
                tbxFaturamento.Text = ("R$ " + (String.Format("{0:0.00}",tt))).ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
             //   throw new Exception("Erro de comandos: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

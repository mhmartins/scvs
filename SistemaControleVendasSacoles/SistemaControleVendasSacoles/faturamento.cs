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
            this.tbxFaturamento.DataBindings.Clear();
            dataSistema = DateTime.Now.ToShortDateString();
            MessageBox.Show("TESTE" + dataSistema);
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
                this.tbxFaturamento.DataBindings.Add("Text", source, "total", true);
                string valor = tbxFaturamento.ToString("N", new CultureInfo("en-US"));
                string total = tbxFaturamento.Text;
                MessageBox.Show("Teste " + total);
                tbxFaturamento.Text = ("R$ " + total).ToString();
                MessageBox.Show("oi " + tbxFaturamento.Text);
                con.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
             //   throw new Exception("Erro de comandos: " + ex.Message);
            }
        }

    }
}

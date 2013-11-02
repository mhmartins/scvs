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
    public partial class PesquisaPersonalizada : Form
    {
        public PesquisaPersonalizada()
        {
            InitializeComponent();
            //int mes;
            //for (mes = 1; mes <= 12; mes++)
            //{
            //    comboBox1.Items.Add(new ListViewItem(new DateTime(1,mes, 1).ToString("MMMMMMM"), mes.ToString()));
            //}
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            CadastroSacoles Form = new CadastroSacoles();
            Form.Show();
            this.Close();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            AlterareExcluir Form = new AlterareExcluir();
            Form.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta Form3 = new Consulta();
            Form3.Show();
        }

        private void btnaltera_Click(object sender, EventArgs e)
        {
            AlterareExcluir Form = new AlterareExcluir();
            Form.Show();
            this.Close();
        }

        private void JanelaEstoque_Load(object sender, EventArgs e)
        {
          /*  for (int i = 1; i <= 12; i++)
            {
                DropDownList1.Items.Add(
                    new ListItem(
                        new DateTime(1, i, 1).ToString("MMMM"),
                        i.ToString()));
            }*/
        }

        public string pegadata(string sDataF)
        {
            string data;
            if (textBox2.Text == "")
            {
                    return null;
            }
            else
            {
                DateTime resultado = DateTime.MinValue;
                if (DateTime.TryParse(this.textBox2.Text.Trim(), out resultado))
                {
                    data = textBox2.Text;
                    DateTime d = Convert.ToDateTime(data);
                    sDataF = d.ToString("yyyyMMdd");
                }
                else
                {
                    return null;
                }

            }
            return sDataF;
        }

        public string pegadata2(string sDataF)
        {
            string data;
            if (textBox3.Text == "")
            {
                return null;
            }
            else
            {
                DateTime resultado = DateTime.MinValue;
                if (DateTime.TryParse(this.textBox3.Text.Trim(), out resultado))
                {
                    data = textBox3.Text;
                    DateTime d = Convert.ToDateTime(data);
                    sDataF = d.ToString("yyyyMMdd");
                }
                else
                {
                    return null;
                }

            }
            return sDataF;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //label1.Text = "Datas Selecionadas a partir  de:" + (monthCalendar1.SelectionRange.
           // textBox1.Text = monthCalendar1.SelectionRange.Start.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string variavelmes = "";
            if (comboBox1.Text == "Janeiro")
            {
                variavelmes = "01";
            }
            else if (comboBox1.Text == "Fevereiro")
            {
                variavelmes = "02";
            }
            else if (comboBox1.Text == "Março")
            {
                variavelmes = "03";
            }
            else if (comboBox1.Text == "Abril")
            {
                variavelmes = "04";
            }
            else if (comboBox1.Text == "Maio")
            {
                variavelmes = "05";
            }
            else if (comboBox1.Text == "Junho")
            {
                variavelmes = "06";
            }
            else if (comboBox1.Text == "Julho")
            {
                variavelmes = "07";
            }
            else if (comboBox1.Text == "Agosto")
            {
                variavelmes = "08";
            }
            else if (comboBox1.Text == "Setembro")
            {
                variavelmes = "09";
            }
            else if (comboBox1.Text == "Outubro")
            {
                variavelmes = "10";
            }
            else if (comboBox1.Text == "Novembro")
            {
                variavelmes = "11";
            }
            else if (comboBox1.Text == "Dezembro")
            {
                variavelmes = "12";
            }
            this.labelBruto.DataBindings.Clear();
            this.labelCusto.DataBindings.Clear();
              try
              {
                  labelCusto.Text = "";
                  labelBruto.Text = "";
                  labelLiquido.Text = "";
                  string data = nupdowAno.Text +"-"+ variavelmes;
                  string conecta = "SELECT SUM( total ) AS quant FROM faturamento WHERE LEFT(data,7) ='" + data +"'";
                  string conecusto = "SELECT SUM(total) AS quant1 FROM custo WHERE LEFT(data,7) ='" + data + "'";
                  MySqlConnection combo1 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                  MySqlDataAdapter sql4 = new MySqlDataAdapter(conecta, combo1);
                  MySqlDataAdapter sql = new MySqlDataAdapter(conecusto, combo1);
                  DataTable dt4 = new DataTable();
                  DataTable dt = new DataTable();
                  sql4.Fill(dt4);
                  sql.Fill(dt);
                  //string val = cbxSuco.SelectedValue.ToString();
                  BindingSource source = new BindingSource();
                  BindingSource source1 = new BindingSource();
                  source1.DataSource = dt;
                  source.DataSource = dt4;
                  label4.Visible = true;
                  label8.Visible = true;
                  labelCusto.Visible = true;
                  label6.Visible = true;
                  label11.Visible = true;
                  labelBruto.Visible = true;
                  this.labelCusto.DataBindings.Add("Text", source1, "quant1", true);
                  this.labelBruto.DataBindings.Add("Text", source, "quant", true);
                  string total = labelCusto.Text;

                  if (labelCusto.Text != "")
                  {
                      Decimal tt = Convert.ToDecimal(total);
                      String tot = tt.ToString("N", new CultureInfo("pt-BR"));
                      labelCusto.Text = (String.Format("{0:0.00}", tt)).ToString();
                  }
                  else
                  {
                      label8.Visible = false;
                      labelCusto.Text = "Não há dados para esse período.";
                  }

                  if (labelBruto.Text != "")
                  {
                      string total2 = labelBruto.Text;
                      Decimal tt2 = Convert.ToDecimal(total2);
                      String tot2 = tt2.ToString("N", new CultureInfo("pt-BR"));
                      labelBruto.Text = (String.Format("{0:0.00}", tt2)).ToString();
                  }
                  else
                  {
                      label11.Visible = false;
                      labelBruto.Text = "Não há dados para esse período.";
                  }

                  if (labelBruto.Text != "Não há dados para esse período." && labelCusto.Text != "Não há dados para esse período.")
                  {
                      //MessageBox.Show("ENTROU AQUI no DOIS errado");
                      float custo = float.Parse(labelCusto.Text);
                      float bruto = float.Parse(labelBruto.Text);
                      float liquido = bruto - custo;

                      label5.Visible = true;
                      label12.Visible = true;
                      labelLiquido.Visible = true;

                      labelLiquido.Text = liquido.ToString();
                  }
                  else
                  {
                      //MessageBox.Show("ENTROU AQUI");
                      label5.Visible = false;
                      label12.Visible = false;
                      labelLiquido.Visible = false;
                  }

                  MessageBox.Show("Informações financeiras do mês de " + comboBox1.Text + " de " + nupdowAno.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  //nupdowSuc.Maximum = int.Parse(tbxEstSuc.Text);
                  combo1.Close();
              }
              catch (Exception ex)
              {
                  ex.Message.ToString();
              }
             
            /* $query = "SELECT nome_produto, SUM( quantidade ) AS quant
 FROM pedidos_item
 INNER JOIN pedidos ON pedidos_item.id_pedido = pedidos.id_pedidos
 INNER JOIN produtos ON pedidos_item.id_produto = produtos.id_produto
 WHERE data_entrega BETWEEN '$periodo1' and '$periodo2'
 GROUP BY produtos.id_produto
 ORDER BY quant DESC";
 $result = mysql_query($query) or die(mysql_error());

 echo "Você digitou o período entre $periodo1 e $periodo2";
 echo "<br />";
 echo "<br />";
 while($row = mysql_fetch_array($result)){
 echo "Total ". $row['nome_produto']. " = ". $row['quant'];
 echo "<br />";
 }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<int, string> meses = Enumerable.Range(1, 12).Aggregate(new Dictionary<int, string>(), (dic, outInt) =>
    {
        dic.Add(outInt, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(outInt));
        return dic;
    }
);
        }

        private void btnConsultaPeriodo_Click(object sender, EventArgs e)
        {
            this.labelBruto.DataBindings.Clear();
            this.labelCusto.DataBindings.Clear();
            labelCusto.Text = "";
            labelBruto.Text = "";
            labelLiquido.Text = "";
            string sData = "", sDatax = "";
            string sData1 = pegadata(sData);
            string sData2 = pegadata2(sDatax);
            if (sData1 == null || sData2 == null)
            {
                if (sData1 == null)
                {
                    textBox2.Text = "";
                    MessageBox.Show("Data Inválida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //else
                if (sData2 == null)
                {
                    textBox3.Text = "";
                    MessageBox.Show("Data final Inválida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                TimeSpan date = Convert.ToDateTime(textBox3.Text) - Convert.ToDateTime(textBox2.Text);
                int totalDias = date.Days;
                if (totalDias < 0)
                {
                    MessageBox.Show("Atenção, a Data Inicial é maior que a Data Final.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {


                        string conecta = "SELECT SUM( total ) AS quant FROM faturamento WHERE data BETWEEN '" + sData1 + "' and '" + sData2 + "'";
                        string conecusto = "SELECT SUM( total ) AS quant1 FROM custo WHERE data BETWEEN '" + sData1 + "' and '" + sData2 + "'";
                        MySqlConnection combo1 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                        MySqlDataAdapter sql4 = new MySqlDataAdapter(conecta, combo1);
                        MySqlDataAdapter sql = new MySqlDataAdapter(conecusto, combo1);
                        DataTable dt4 = new DataTable();
                        DataTable dt = new DataTable();
                        sql4.Fill(dt4);
                        sql.Fill(dt);
                        //string val = cbxSuco.SelectedValue.ToString();
                        BindingSource source = new BindingSource();
                        BindingSource source1 = new BindingSource();
                        source1.DataSource = dt;
                        source.DataSource = dt4;
                        //label13.Visible = true;
                        label4.Visible = true;
                        label8.Visible = true;
                        labelCusto.Visible = true;
                        label6.Visible = true;
                        label11.Visible = true;
                        labelBruto.Visible = true;
                        this.labelCusto.DataBindings.Add("Text", source1, "quant1", true);
                        this.labelBruto.DataBindings.Add("Text", source, "quant", true);
                        string total = labelCusto.Text;
                        if (labelCusto.Text != "")
                        {
                            Decimal tt = Convert.ToDecimal(total);
                            String tot = tt.ToString("N", new CultureInfo("pt-BR"));
                            labelCusto.Text = (String.Format("{0:0.00}", tt)).ToString();
                        }
                        else
                        {
                            label8.Visible = false;
                            labelCusto.Text = "Não há dados para esse período.";
                        }
                        if (labelBruto.Text != "")
                        {
                            string total2 = labelBruto.Text;
                            Decimal tt2 = Convert.ToDecimal(total2);
                            String tot2 = tt2.ToString("N", new CultureInfo("pt-BR"));
                            labelBruto.Text = (String.Format("{0:0.00}", tt2)).ToString();
                        }
                        else
                        {
                            label11.Visible = false;
                            labelBruto.Text = "Não há dados para esse período.";
                        }
                        if (labelBruto.Text != "Não há dados para esse período." && labelCusto.Text != "Não há dados para esse período.")
                        {

                            float custo = float.Parse(labelCusto.Text);
                            float bruto = float.Parse(labelBruto.Text);
                            float liquido = bruto - custo;

                            label5.Visible = true;
                            label12.Visible = true;
                            labelLiquido.Visible = true;

                            labelLiquido.Text = (String.Format("{0:0.00}", liquido)).ToString();
                        }

                        else
                        {
                            label5.Visible = false;
                            label12.Visible = false;
                            labelLiquido.Visible = false;
                        }
                        MessageBox.Show("Informações financeiras do período " + textBox2.Text + " a " + textBox3.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //nupdowSuc.Maximum = int.Parse(tbxEstSuc.Text);

                        combo1.Close();
                    }
                    catch (Exception ex)
                    {
                        ex.Message.ToString();
                    }
                }
            }
        }

        private void btnConsultaAno_Click(object sender, EventArgs e)
        {
            labelCusto.Text = "";
            labelBruto.Text = "";
            labelLiquido.Text = "";
            this.labelBruto.DataBindings.Clear();
            this.labelCusto.DataBindings.Clear();
            try
            {
                string conecta = "SELECT SUM( total ) AS quant FROM faturamento WHERE LEFT(data,4) ='" + nupdowANOpesq.Text + "'";
                string conecusto = "SELECT SUM(total) AS quant1 FROM custo WHERE LEFT(data,4) ='" + nupdowANOpesq.Text + "'";
                MySqlConnection combo1 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql4 = new MySqlDataAdapter(conecta, combo1);
                MySqlDataAdapter sql = new MySqlDataAdapter(conecusto, combo1);
                DataTable dt4 = new DataTable();
                DataTable dt = new DataTable();
                sql4.Fill(dt4);
                sql.Fill(dt);
                //string val = cbxSuco.SelectedValue.ToString();
                BindingSource source = new BindingSource();
                BindingSource source1 = new BindingSource();
                source1.DataSource = dt;
                source.DataSource = dt4;
                label4.Visible = true;
                label8.Visible = true;
                labelCusto.Visible = true;
                label6.Visible = true;
                label11.Visible = true;
                labelBruto.Visible = true;
                this.labelCusto.DataBindings.Add("Text", source1, "quant1", true);
                this.labelBruto.DataBindings.Add("Text", source, "quant", true);
                string total = labelCusto.Text;
                if (labelCusto.Text != "")
                {
                    Decimal tt = Convert.ToDecimal(total);
                    String tot = tt.ToString("N", new CultureInfo("pt-BR"));
                    labelCusto.Text = (String.Format("{0:0.00}", tt)).ToString();
                }
                else
                {
                    label8.Visible = false;
                    labelCusto.Text = "Não há dados para esse período.";
                }
                if (labelBruto.Text != "")
                {
                    string total2 = labelBruto.Text;
                    Decimal tt2 = Convert.ToDecimal(total2);
                    String tot2 = tt2.ToString("N", new CultureInfo("pt-BR"));
                    labelBruto.Text = (String.Format("{0:0.00}", tt2)).ToString();
                }
                else
                {
                    label11.Visible = false;
                    labelBruto.Text = "Não há dados para esse período.";
                }
                if (labelBruto.Text != "Não há dados para esse período." && labelCusto.Text != "Não há dados para esse período.")
                {
                    float custo = float.Parse(labelCusto.Text);
                    float bruto = float.Parse(labelBruto.Text);
                    float liquido = bruto - custo;

                    label5.Visible = true;
                    label12.Visible = true;
                    labelLiquido.Visible = true;

                    labelLiquido.Text = (String.Format("{0:0.00}", liquido)).ToString();
                }
                else
                {
                    label5.Visible = false;
                    label12.Visible = false;
                    labelLiquido.Visible = false;
                }

                MessageBox.Show("Informações financeiras do ano de " + nupdowAno.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //nupdowSuc.Maximum = int.Parse(tbxEstSuc.Text);
                combo1.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}

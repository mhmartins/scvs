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
    public partial class ConsultarVendasVendedor : Form
    {
        public ConsultarVendasVendedor()
        {
            InitializeComponent();
            //incia combobox VENDEDOR
            cbxUser.DataSource = LoadUserData();
            cbxUser.ValueMember = "idusuarios";
            cbxUser.DisplayMember = "nome";
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

        private DataView LoadUserData()
        {
            try
            {
                MySqlConnection combo = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql3 = new MySqlDataAdapter("select idusuarios,nome from usuarios", combo);
                DataTable dt3 = new DataTable();
                sql3.Fill(dt3);
                return dt3.DefaultView;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }

        private void btnConsultaAno_Click(object sender, EventArgs e)
        {
            labelQuant.Text = "";
            labelBruto.Text = "";
            this.labelBruto.DataBindings.Clear();
            this.labelQuant.DataBindings.Clear();
            try
            {
                //string conecta = "SELECT SUM( total ) AS quant FROM faturamento WHERE LEFT(data,4) ='" + nupdowANOpesq.Text + "'";
                string sql = "SELECT nome, SUM( quantidade ) AS quant , SUM( valor ) AS valorBruto FROM vendas_sacoles INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas INNER JOIN usuarios on vendas.usuarios_idusuarios = usuarios.idusuarios && usuarios.idusuarios = '" + cbxUser.SelectedValue.ToString() + "'WHERE LEFT(data,4) ='" + nupdowANOpesq.Text + "' GROUP BY usuarios.nome ORDER BY quant DESC;";
                MySqlConnection combo1 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql4 = new MySqlDataAdapter(sql, combo1);
                DataTable dt4 = new DataTable();
                sql4.Fill(dt4);
                //string val = cbxSuco.SelectedValue.ToString();
                BindingSource source = new BindingSource();
                source.DataSource = dt4;
                label4.Visible = true;
                labelQuant.Visible = true;
                label6.Visible = true;
                label11.Visible = true;
                labelBruto.Visible = true;
                this.labelBruto.DataBindings.Add("Text", source, "valorBruto", true);
                this.labelQuant.DataBindings.Add("Text", source, "quant", true);

                string total = labelQuant.Text;
                if (labelQuant.Text == "")
                {
                    labelQuant.Text = "Não há dados para esse período.";
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

                MessageBox.Show("Dados das vendas do vendedor " + cbxUser.Text + " no ano de " + nupdowAno.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //nupdowSuc.Maximum = int.Parse(tbxEstSuc.Text);
                combo1.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void btnConsultarMes_Click(object sender, EventArgs e)
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
            labelQuant.Text = "";
            labelBruto.Text = "";
            this.labelBruto.DataBindings.Clear();
            this.labelQuant.DataBindings.Clear();
            try
            {
                string data = nupdowAno.Text + "-" + variavelmes;
                //string conecta = "SELECT SUM( total ) AS quant FROM faturamento WHERE LEFT(data,4) ='" + nupdowANOpesq.Text + "'";
                string sql = "SELECT nome, SUM( quantidade ) AS quant , SUM( valor ) AS valorBruto FROM vendas_sacoles INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas INNER JOIN usuarios on vendas.usuarios_idusuarios = usuarios.idusuarios && usuarios.idusuarios = '" + cbxUser.SelectedValue.ToString() + "'WHERE LEFT(data,7) ='" + data + "' GROUP BY usuarios.nome ORDER BY quant DESC;";
                MySqlConnection combo1 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql4 = new MySqlDataAdapter(sql, combo1);
                DataTable dt4 = new DataTable();
                sql4.Fill(dt4);
                //string val = cbxSuco.SelectedValue.ToString();
                BindingSource source = new BindingSource();
                source.DataSource = dt4;
                label4.Visible = true;
                labelQuant.Visible = true;
                label6.Visible = true;
                label11.Visible = true;
                labelBruto.Visible = true;
                this.labelBruto.DataBindings.Add("Text", source, "valorBruto", true);
                this.labelQuant.DataBindings.Add("Text", source, "quant", true);

                string total = labelQuant.Text;
                if (labelQuant.Text == "")
                {
                    labelQuant.Text = "Não há dados para esse período.";
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

                MessageBox.Show("Dados das vendas do vendedor " + cbxUser.Text + " no ano de " + nupdowAno.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //nupdowSuc.Maximum = int.Parse(tbxEstSuc.Text);
                combo1.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void btnConsultaPeriodo_Click(object sender, EventArgs e)
        {
            labelQuant.Text = "";
            labelBruto.Text = "";
            this.labelBruto.DataBindings.Clear();
            this.labelQuant.DataBindings.Clear();
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
                        //string conecta = "SELECT SUM( total ) AS quant FROM faturamento WHERE LEFT(data,4) ='" + nupdowANOpesq.Text + "'";
                        string sql = "SELECT nome, SUM( quantidade ) AS quant , SUM( valor ) AS valorBruto FROM vendas_sacoles INNER JOIN vendas ON vendas_sacoles.vendas_idvendas = vendas.idvendas INNER JOIN usuarios on vendas.usuarios_idusuarios = usuarios.idusuarios && usuarios.idusuarios = '" + cbxUser.SelectedValue.ToString() + "' WHERE data BETWEEN '" + sData1 + "' and '" + sData2 + "' GROUP BY usuarios.nome ORDER BY quant DESC;";
                        MySqlConnection combo1 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                        MySqlDataAdapter sql4 = new MySqlDataAdapter(sql, combo1);
                        DataTable dt4 = new DataTable();
                        sql4.Fill(dt4);
                        //string val = cbxSuco.SelectedValue.ToString();
                        BindingSource source = new BindingSource();
                        source.DataSource = dt4;
                        label4.Visible = true;
                        labelQuant.Visible = true;
                        label6.Visible = true;
                        label11.Visible = true;
                        labelBruto.Visible = true;
                        this.labelBruto.DataBindings.Add("Text", source, "valorBruto", true);
                        this.labelQuant.DataBindings.Add("Text", source, "quant", true);

                        string total = labelQuant.Text;
                        if (labelQuant.Text == "")
                        {
                            labelQuant.Text = "Não há dados para esse período.";
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

                        MessageBox.Show("Dados das vendas do vendedor " + cbxUser.Text + " no ano de " + nupdowAno.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

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
    public partial class AdicionaProducaoSuco : Form
    {
        public AdicionaProducaoSuco()
        {
            InitializeComponent();
        }

        private void AdicionaProducaoSuco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adicionaProdSuc.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter.Fill(this.adicionaProdSuc.sacoles);

        }

        public string pegadata(string sDataF)
        {
            string data = DateTime.Now.ToShortDateString();

            DateTime d = Convert.ToDateTime(data);
            sDataF = d.ToString("yyyyMMdd");
            return sDataF;
        }
        //CAMPOS OBRIGATÓRIOS
        private bool CamposObrig()
        {
            bool CampoVazio = false;

            if (String.IsNullOrEmpty(tbxQuantAdd.Text))
            {
                MessageBox.Show("O campo Quantidade deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxQuantAdd.Select();
                CampoVazio = true;
            }
            return CampoVazio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label4.DataBindings.Clear();
            this.label8.DataBindings.Clear();
            string sData = "";
            string sData1 = pegadata(sData);
            bool CamposObrigPreenchidos = CamposObrig();
            if (!CamposObrigPreenchidos)//se o campos estiver preenchido ele entra 
            {
                if (MessageBox.Show("Você tem certeza que deseja inserir essa quantidade de sacolés e esse custo de produção?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    float total = 0;
                    total = float.Parse(precoLabel3.Text) * int.Parse(tbxQuantAdd.Text);//pega o total liquido
                    string Valtotal = total.ToString("N", new CultureInfo("pt-BR"));
                    Valtotal = ("R$ " + Valtotal).ToString();

                    quantTextBox1.Text = (int.Parse(quantTextBox1.Text) + int.Parse(tbxQuantAdd.Text)).ToString();//atualiza a quantidade no estoque
                    float custo = float.Parse(tbxEssencia.Text) + float.Parse(tbxSaco.Text) + float.Parse(tbxOutros.Text) + float.Parse(tbxValAcucar.Text) + float.Parse(tbxValLiga.Text);
                    float fatura = total - custo;

                    string ValFatura = fatura.ToString("N", new CultureInfo("pt-BR"));
                    ValFatura = ("R$ " + ValFatura).ToString();
                    string ValCusto = custo.ToString("N", new CultureInfo("pt-BR")); //CONVERTE O VALOR PARA REAL
                    ValCusto = ("R$ " + ValCusto).ToString(); //CRIA UMA MASCARA

                    MessageBox.Show("A quantidade inserida foi " + tbxQuantAdd.Text + " unidades.\nValor Liquido a Faturar " + Valtotal + "\nCusto de produção estimado em " + ValCusto + "\nLucro estimado da produção " + ValFatura, "Relatório Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        MySqlConnection conexao = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");

                        conexao.Open();
                        MySqlDataAdapter sql1 = new MySqlDataAdapter("select data from custo where data = '" + sData1 + "'", conexao);

                        DataTable dt = new DataTable();
                        sql1.Fill(dt);
                        BindingSource source = new BindingSource();
                        source.DataSource = dt;
                        this.label4.DataBindings.Add("Text", source, "data", true);
                        //this.textBox1.DataBindings.Add("Text", source, "data", true);

                        if (label4.Text == "")//se a DATA for NOVA
                        {
                            string ins = "INSERT into custo(data,total) values ('" + sData1 + "','" + custo.ToString("N", new CultureInfo("en-US")) + "')";
                            MySqlCommand com = new MySqlCommand(ins, conexao);
                            com.ExecuteNonQuery();
                        }
                        else
                        {
                            MySqlDataAdapter sql = new MySqlDataAdapter("select total from custo where data = '" + sData1 + "'", conexao);
                            DataTable dt1 = new DataTable();
                            sql.Fill(dt1);
                            BindingSource source1 = new BindingSource();
                            source1.DataSource = dt1;
                            this.label8.DataBindings.Add("Text", source1, "total", true);
                            //MessageBox.Show(label13.Text);
                            //MessageBox.Show("oi" + custo);

                            float soma = (custo + float.Parse(label8.Text));
                            //MessageBox.Show("Venda " + soma, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string valor2 = soma.ToString("N", new CultureInfo("en-US")); //CONVERTE O VALOR PARA REAL
                            //MessageBox.Show("Venda " + valor2, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string UPDATE = "UPDATE custo SET total = '" + valor2 + "' WHERE data = '" + sData1 + "'";
                            MySqlCommand comandoAtualiza = new MySqlCommand(UPDATE, conexao);
                            comandoAtualiza.ExecuteNonQuery();
                        }
                        string inserir = "UPDATE sacoles SET quant= '" + quantTextBox1.Text + "' WHERE sabor = '" + saborLabel3.Text + "' && tipo = 2 ";
                        MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                        comandos.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro de comandos: " + ex.Message);
                    }
                    tbxQuantAdd.Text = "";
                }
                else
                {
                    return;
                }
            }
        }

        private void tbxQuantAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tbxSaco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void tbxEssencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void tbxValAcucar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void tbxValLiga_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void tbxOutros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }


    }
}

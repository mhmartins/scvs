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
// CTRL+E.F
namespace SistemaControleVendasSacoles
{
    public partial class Telateste : Form
    {
        public Telateste()
        {
            InitializeComponent();
            //incia combobox VENDEDOR
            cbxUser.DataSource = LoadUserData();
            cbxUser.ValueMember = "idusuarios";
            cbxUser.DisplayMember = "nome";
            //inicia combobox CREMOSO
            cmbxsacolescre.DataSource = LoadCremosoData();
            cmbxsacolescre.ValueMember = "idSacoles";
            cmbxsacolescre.DisplayMember = "sabor";
            //inicia combobox SUCO
            cbxSuco.DataSource = LoadSucoData();
            cbxSuco.ValueMember = "idSacoles";
            cbxSuco.DisplayMember = "sabor";
            //inicia DATAGRID 
            dgv.Columns.Add("sabor", "Sacolés");
            dgv.Columns.Add("quant", "Quantidade");
            dgv.Columns.Add("total", "Total");
            //define COLUNAS e LINHA do DATAGRID
            dgv.Columns[0].Width = 250;
            dgv.Columns[1].Width = 80;
            dgv.Columns[2].Width = 129;
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

        private DataView LoadCremosoData()
        {
            try
            {
                MySqlConnection combo = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from sacoles where tipo = 1", combo);
                DataTable dt2 = new DataTable();
                sql.Fill(dt2);

                return dt2.DefaultView;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }

        private DataView LoadSucoData()
        {
            try
            {
                MySqlConnection combo = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from sacoles where tipo = 2", combo);
                DataTable dt = new DataTable();
                sql.Fill(dt);

                return dt.DefaultView;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }

        private void Telateste_Load(object sender, EventArgs e)
        {
            cbxUser.SelectedIndex = -1;
            cmbxsacolescre.SelectedIndex = -1;
            cbxSuco.SelectedIndex = -1;
            this.dgv.DefaultCellStyle.Font = new Font("Tahoma", 20);
        }

        private bool CamposObrig2()
        {
            bool CampoVazio2 = false;

            if (String.IsNullOrEmpty(cbxUser.Text))
            {
                MessageBox.Show("Campo (Vendedor) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxUser.Select();
                CampoVazio2 = true;
            }
            return CampoVazio2;
        }

        private bool CamposObrig()
        {
            bool CampoVazio = false;

            if (String.IsNullOrEmpty(cmbxsacolescre.Text))
            {
                MessageBox.Show("Campo (Sacolé Cremoso) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxsacolescre.Select();
                CampoVazio = true;
            }

            if (nupdowCre.Text == "0")
            {
                MessageBox.Show("Campo (Quantidade) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nupdowCre.Select();
                CampoVazio = true;
            }
            return CampoVazio;
        }

        private bool CamposObrig3()
        {
            bool CampoVazio3 = false;
            if (String.IsNullOrEmpty(cbxSuco.Text))
            {
                MessageBox.Show("Campo (Sacolé Suco) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxSuco.Select();
                CampoVazio3 = true;
            }
            if (nupdowSuc.Text == "0")
            {
                MessageBox.Show("Campo (Quantidade) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nupdowSuc.Select();
                CampoVazio3 = true;
            }
            return CampoVazio3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //textBox1.Text=DateTime.Now.ToLongDateString();
            //textBox1.Text = DateTime.Now.ToLongTimeString();
            //textBox1.Text = DateTime.Now.ToShortTimeString();
            textBox1.Text = DateTime.Now.ToShortDateString();
        }

        private void cmbxsacolescre_SelectedIndexChanged(object sender, EventArgs e)
        {
             this.label13.DataBindings.Clear();
             this.tbxValCre.DataBindings.Clear();
             try
             {
                 MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                 MySqlDataAdapter sql40 = new MySqlDataAdapter("select preco from sacoles where idSacoles = '" + cmbxsacolescre.SelectedValue.ToString() + "'", combo10);
                 DataTable dt40 = new DataTable();
                 sql40.Fill(dt40);
                 BindingSource source = new BindingSource();
                 source.DataSource = dt40;
                 label13.Visible = true;

                 this.tbxValCre.DataBindings.Add("Text", source, "preco", true);
                 this.label13.DataBindings.Add("Text", source, "preco", true);
                 combo10.Close();
             }
               catch (Exception ex)
               {
                   ex.Message.ToString();
               }
             
        }

        private void cbxSuco_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label13.DataBindings.Clear();
            this.tbxValSuc.DataBindings.Clear();
            this.tbxValCre.DataBindings.Clear();
            try
            {
                MySqlConnection combo1 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql4 = new MySqlDataAdapter("select preco from sacoles where idSacoles = '" + cbxSuco.SelectedValue.ToString() + "'", combo1);
                DataTable dt4 = new DataTable();
                sql4.Fill(dt4);
                BindingSource source = new BindingSource();
                source.DataSource = dt4;
                label13.Visible = true;
                this.label13.DataBindings.Add("Text", source, "preco", true);
                this.tbxValSuc.DataBindings.Add("Text", source, "preco", true);
                combo1.Close();
            }
              catch (Exception ex)
              {
                  ex.Message.ToString();
              }
        }

        private void AddCre_Click(object sender, EventArgs e)
        {
            bool CamposObrigPreenchidos = CamposObrig();

            if (!CamposObrigPreenchidos)//se o campos estiver preenchido ele entra 
            {
                this.textBox3.DataBindings.Clear();
                try
                {
                    int quantidade = (int.Parse(nupdowCre.Text));
                    float Resultado = (int.Parse(nupdowCre.Text) * float.Parse(tbxValCre.Text));
                    textBox3.Text = Resultado.ToString("N", new CultureInfo("en-US"));
                    ///textBox2.Text = mktValorCremoso.ToString("C", new CultureInfo("pt-BR"));
                    mktTotal.Text = (float.Parse(mktTotal.Text) + (int.Parse(nupdowCre.Text) * float.Parse(tbxValCre.Text))).ToString();
                    // mktDesc.Text = Resultado.ToString("N", new CultureInfo("pt-BR"));

                    //inicio do SQL
                    MySqlConnection conexao3 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                    //MySqlDataAdapter select = new MySqlDataAdapter("SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1", conexao3);
                    string inserir3 = "INSERT INTO vendas_sacoles(vendas_idvendas,sacoles_idsacoles,quantidade,valor)values('" + textBox2.Text + "','" + cmbxsacolescre.SelectedValue.ToString() + "','" + quantidade + "','" + textBox3.Text + "')";
                    conexao3.Open();
                    //DataTable dt4 = new DataTable();
                    //select.Fill(dt4);
                    // BindingSource source = new BindingSource();
                    //source.DataSource = dt4;
                    // this.textBox2.DataBindings.Add("Text", source, "idvendas", true);
                    MySqlCommand comandos3 = new MySqlCommand(inserir3, conexao3);
                    comandos3.ExecuteNonQuery();
                    conexao3.Close();
                    //Fim do SQL

                    dgv.Rows.Add(cmbxsacolescre.Text, nupdowCre.Text, "R$ " + Resultado);
                    cmbxsacolescre.Text = "";
                    nupdowCre.Text = "0";
                    tbxValCre.Text = "";
                    //textBox2.Text = quantidade.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro de comandos: " + ex.Message);
                }

            }
            else
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Você tem certeza que deseja limpar os campos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //apaga os tbx relacionado abaixo
                    MessageBox.Show("Esta função ainda não esta funcional", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            
            //Code Snippet
            //DateTime.Now.ToShortDateString()
            // DateTime dataConvertida = DateTime.ParseExact(data, "yyyy-MM-dd", null);
            // MessageBox.Show(dataConvertida.ToString());
            // string dataBancoMysql = Convert.ToDateTime(this.textBox1.ToString());
            bool CamposObrigPreenchidos2 = CamposObrig2();
            if (!CamposObrigPreenchidos2)//se o campos estiver preenchido ele entra 
            {
                this.textBox2.DataBindings.Clear();
                try
                {
                    MySqlConnection conexao = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                    conexao.Open();
                    string inserir = "INSERT into vendas(usuarios_idusuarios, data) values ('" + cbxUser.SelectedValue.ToString() + "','22111212')";
                    MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                    MySqlDataAdapter select = new MySqlDataAdapter("SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1", conexao);

                    comandos.ExecuteNonQuery();
                    DataTable dt4 = new DataTable();
                    select.Fill(dt4);
                    BindingSource source = new BindingSource();
                    source.DataSource = dt4;
                    this.textBox2.DataBindings.Add("Text", source, "idvendas", true);

                    conexao.Close();
                    int valid = Convert.ToInt32(cbxUser.SelectedValue);
                    //label13.Visible = true;
                    addSuco.Enabled = true;
                    AddCre.Enabled = true;
                    // mktData.Text = cbxUser.SelectedValue.ToString(); 
                }

                catch (Exception ex)
                {
                    throw new Exception("Erro de comandos: " + ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        private void addSuco_Click(object sender, EventArgs e)
        {
               bool CamposObrigPreenchidos = CamposObrig3();
               if (!CamposObrigPreenchidos)//se o campos estiver preenchido ele entra 
               {
                   try
                   {
                       float Resultado = (int.Parse(nupdowSuc.Text) * float.Parse(tbxValSuc.Text));
                       mktTotal.Text = (float.Parse(mktTotal.Text) + (int.Parse(nupdowSuc.Text) * float.Parse(tbxValSuc.Text))).ToString();
                       dgv.Rows.Add(cbxSuco.Text, nupdowSuc.Text, "R$ " + Resultado);
                       int quantidade = (int.Parse(nupdowSuc.Text));
                       textBox3.Text = Resultado.ToString("N", new CultureInfo("en-US"));
                       //inicio do SQL
                       MySqlConnection conexao3 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                       //MySqlDataAdapter select = new MySqlDataAdapter("SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1", conexao3);
                       string inserir3 = "INSERT INTO vendas_sacoles(vendas_idvendas,sacoles_idsacoles,quantidade,valor)values('" + textBox2.Text + "','" + cbxSuco.SelectedValue.ToString() + "','" + quantidade + "','" + textBox3.Text + "')";
                       conexao3.Open();                       
                       //DataTable dt4 = new DataTable();
                       //select.Fill(dt4);
                       // BindingSource source = new BindingSource();
                       //source.DataSource = dt4;
                       // this.textBox2.DataBindings.Add("Text", source, "idvendas", true);
                       MySqlCommand comandos3 = new MySqlCommand(inserir3, conexao3);
                       comandos3.ExecuteNonQuery();
                       conexao3.Close();
                       //Fim do SQL
                       cbxSuco.Text = "";
                       nupdowSuc.Text = "0";
                       tbxValSuc.Text = "";
                   }
                   catch (Exception ex)
                   {
                       throw new Exception("Erro de comandos: " + ex.Message);
                   }
               }
               else
               {
                   return;
               }           
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            float somadesconto = (float.Parse(mktTotal.Text) - float.Parse(tbxDesc.Text));
            if (somadesconto < 0)
            {
                MessageBox.Show("Valor superior ao valor TOTAL, digite um valor MENOR ou IGUAL ao TOTAL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mktTotal.Text = somadesconto.ToString();
            }
            
        }

        private void cbxSuco_KeyPress(object sender, KeyPressEventArgs e)
        {
            // cbxSuco.DroppedDown = true;
        }

        private void btnFinaVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta função ainda não esta funcional", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}

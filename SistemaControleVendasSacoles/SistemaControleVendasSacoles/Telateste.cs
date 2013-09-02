﻿using System;
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

namespace SistemaControleVendasSacoles
{
    public partial class Telateste : Form
    {
        public Telateste()
        {
            InitializeComponent();

            cbxUser.DataSource = LoadUserData();
            cbxUser.ValueMember = "idusuarios";
            cbxUser.DisplayMember = "nome";

            cmbxsacolescre.DataSource = LoadCremosoData();
            cmbxsacolescre.ValueMember = "idSacoles";
            cmbxsacolescre.DisplayMember = "sabor";

            cbxSuco.DataSource = LoadSucoData();
            cbxSuco.ValueMember = "idSacoles";
            cbxSuco.DisplayMember = "sabor";

            dgv.Columns.Add("sabor", "Sacolés");
            dgv.Columns.Add("quant", "Quantidade");
            dgv.Columns.Add("total", "Total");

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

        private void cmbxsacolescre_SelectedIndexChanged(object sender, EventArgs e)
        {           
            this.label13.DataBindings.Clear();
            this.mktValorCremoso.DataBindings.Clear();
            try
            {
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql40 = new MySqlDataAdapter("select preco from sacoles where idSacoles = '" + cmbxsacolescre.SelectedValue.ToString() + "'", combo10);
                DataTable dt40 = new DataTable();
                sql40.Fill(dt40);
                BindingSource source = new BindingSource();
                source.DataSource = dt40;
                label13.Visible = true;

                this.mktValorCremoso.DataBindings.Add("Text", source, "preco", true);
                //this.label13.DataBindings.Add("Text", source, "preco", true);
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
            this.mskValSuco.DataBindings.Clear();
            this.mktValorCremoso.DataBindings.Clear();
            try
            {
                MySqlConnection combo1 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql4 = new MySqlDataAdapter("select preco from sacoles where idSacoles = '" + cbxSuco.SelectedValue.ToString() + "'", combo1);
                DataTable dt4 = new DataTable();
                sql4.Fill(dt4);
                BindingSource source = new BindingSource();
                source.DataSource = dt4;
                //  label13.Visible = true;
                //   this.label13.DataBindings.Add("Text", source, "preco", true);
                this.mskValSuco.DataBindings.Add("Text", source, "preco", true);
                combo1.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            /*  try
              {
                  MySqlConnection con = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                  MySqlDataAdapter sql9 = new MySqlDataAdapter("select preco from sacoles where idSacoles = '" + cbxSuco.SelectedValue.ToString() + "'", con);
                  DataTable dt9 = new DataTable();
                  sql9.Fill(dt9);
                  BindingSource source2 = new BindingSource();
                  source2.DataSource = dt9;
                  // txtb_endereco.DataBindings.Add("Text", mDataSet, "Cliente.endereco");
                  mskValSuco.DataBindings.Add("Text", source2, "preco", true);
                  mktDesc.DataBindings.Add("Text", source2, "preco", true);
                  con.Close();
              }
              catch (Exception ex)
              {
                  ex.Message.ToString();
              }*/
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

           // if (String.IsNullOrEmpty(tbxvalor.Text))
           // {
              //  MessageBox.Show("Campo (Valor) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // tbxnome.Select();
               // CampoVazio = true;
           // }

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

        private void AddCre_Click(object sender, EventArgs e)
        {
           bool CamposObrigPreenchidos = CamposObrig();

           if (!CamposObrigPreenchidos)//se o campos estiver preenchido ele entra 
           {
               float Resultado = (int.Parse(nupdowCre.Text) * float.Parse(mktValorCremoso.Text));
               mktTotal.Text = (float.Parse(mktTotal.Text) + (int.Parse(nupdowCre.Text) * float.Parse(mktValorCremoso.Text))).ToString();
               dgv.Rows.Add(cmbxsacolescre.Text, nupdowCre.Text, "R$ " + Resultado);
               cmbxsacolescre.Text = "";
               nupdowCre.Text = "0";
               mktValorCremoso.Text = "";
               //tbxvalor.Clear();
               /* try
                {
                    MySqlConnection cone = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                    MySqlDataAdapter selectvenda = new MySqlDataAdapter("SELECT * FROM vendas ORDER BY idvendas DESC LIMIT 1", cone);
                    DataTable dt4 = new DataTable();
                    selectvenda.Fill(dt4);
                    BindingSource source = new BindingSource();
                    source.DataSource = dt4;
                    string message = cbxUser.SelectedValue.ToString();
                    MessageBox.Show(message);
                    $sql_pega_pedido = mysql_query("SELECT * FROM pedidos ORDER BY id_pedidos DESC LIMIT 1");
                }*/
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

                }
            }
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
          //  string caminho = "SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;";
           //Code Snippet
            //DateTime.Now.ToShortDateString()
           // DateTime dataConvertida = DateTime.ParseExact(data, "yyyy-MM-dd", null);
           // MessageBox.Show(dataConvertida.ToString());
           // string dataBancoMysql = Convert.ToDateTime(this.textBox1.ToString());
            bool CamposObrigPreenchidos2 = CamposObrig2();
            if (!CamposObrigPreenchidos2)//se o campos estiver preenchido ele entra 
            {
                try
                {

                    MySqlConnection combouser = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                    // MySqlDataReader leitura;
                    combouser.Open();

                    string inserir = "INSERT into vendas(usuarios_idusuarios, data) values ('" + cbxUser.SelectedValue.ToString() + "','11111111')";
                    MySqlCommand comandos = new MySqlCommand(inserir, combouser);
                    comandos.ExecuteNonQuery();
                    combouser.Close();
                    // int valid = Convert.ToInt32(cbxUser.SelectedValue);
                    //label13.Visible = true;
                    addSuco.Enabled = true;
                    AddCre.Enabled = true;
                    // mktData.Text = cbxUser.SelectedValue.ToString(); 

                    // MySqlDataAdapter sqluse = new MySqlDataAdapter("INSERT into vendas(usuarios_idusuarios, data) values ('" + cbxUser.Text + "','" + mktData.Text + "')");
                    // MySqlCommand sqluse = new MySqlCommand (
                    //  string inserir = "INSERT INTO sacoles(sabor,tipo,quant,quantmin,preco)values('" + sa.Sabor + "','" + sa.Tipo + "','" + sa.Quant + "','" + sa.QuantMin + "','" + sa.Valor + "')";
                    //  MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                    //sqluse.ExecuteNonQuery();
                    //  conexao.Close();
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

   //     private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
      //  {
           /* MySqlConnection combo = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
            MySqlDataAdapter sql3 = new MySqlDataAdapter("select * from usuarios", combo);

            DataTable dt3 = new DataTable();
            sql3.Fill(dt3);
            this.cbxUser.DataSource =dt3;
            this.cbxUser.ValueMember = "idusuario";
            this.cbxUser.DisplayMember = "nome";
            combo.Close();*/


     //   }

        private void cbxUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //mskValCre.Text = cbxUser.SelectedValue.ToString(); 
            //string message = cbxUser.SelectedValue.ToString();

            //MessageBox.Show(message);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //dataMaskedTextBox.Text=DateTime.Now.ToLongDateString();
            //textBox1.Text = DateTime.Now.ToLongTimeString();
            //textBox2.Text = 
            //textBox1.Text = DateTime.Now.ToShortTimeString();
            textBox1.Text = DateTime.Now.ToShortDateString();
        }

        

        private void addSuco_Click(object sender, EventArgs e)
        {
           bool CamposObrigPreenchidos = CamposObrig3();
           if (!CamposObrigPreenchidos)//se o campos estiver preenchido ele entra 
           {
               float Resultado = (int.Parse(nupdowSuc.Text) * float.Parse(mskValSuco.Text));
               mktTotal.Text = (float.Parse(mktTotal.Text) + (int.Parse(nupdowSuc.Text) * float.Parse(mskValSuco.Text))).ToString();
               dgv.Rows.Add(cbxSuco.Text, nupdowSuc.Text, "R$ " + Resultado);
               cbxSuco.Text = "";
               nupdowSuc.Text = "0";
               mskValSuco.Text = "";
           }
           else
           {
               return;
           }
        
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            mktTotal.Text = (float.Parse(mktTotal.Text) - float.Parse(mktDesc.Text)).ToString();
        }

        private void cbxSuco_KeyPress(object sender, KeyPressEventArgs e)
        {
           // cbxSuco.DroppedDown = true;
        }
          /*private void carregaCombox()
          {
              cx.Conectar(); //Método que abre conexão com banco 
              string sql1 = ""; 
              sql1 += " Select idEstado, Estado from Estados ";//instrução SQL 
              DataTable dt = new DataTable(); 
              SqlDataAdapter da1 = new SqlDataAdapter(sql1, cx.c); 
              da1.Fill(dt); 
              cbEstado.DisplayMember = "Estado"; 
              cbEstado.ValueMember = "idEstado"; 
              cbEstado.DataSource = dt;

          }*/
          
    }
}

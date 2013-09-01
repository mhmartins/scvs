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

            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 80;
            dgv.Columns[2].Width = 50;   
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

	                   
        }

       // private MySqlConnection conexao;

        private void cmbxsacolescre_SelectedIndexChanged(object sender, EventArgs e)
        {           
            //   select * from EQUIPAMENTO ORDER BY<br/>
//CASE WHEN [ID_EQUIPAMENTO] = 'ID_EQTO_QUE_EU_SELECIONO' THEN 0 ELSE 1 END, [ID_EQUIPAMENTO
            /*try
            {
                MySqlConnection combo1 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql4 = new MySqlDataAdapter("select preco from sacoles where idSacoles = '" + cmbxsacolescre.SelectedValue.ToString() + "'", combo1);
                DataTable dt4 = new DataTable();
                sql4.Fill(dt4);
                BindingSource source = new BindingSource();
                source.DataSource = dt4;
                // txtb_endereco.DataBindings.Add("Text", mDataSet, "Cliente.endereco");
                tbx3.DataBindings.Add("Text", source, "preco", true);
                combo1.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            */
        }

        private void AddCre_Click(object sender, EventArgs e)
        {
           float Resultado = (int.Parse(nupdowCre.Text) * float.Parse(tbx2.Text));
           tbx3.Text = (float.Parse(tbx3.Text) + (int.Parse(nupdowCre.Text) * float.Parse(tbx2.Text))).ToString();
            dgv.Rows.Add(cmbxsacolescre.Text, nupdowCre.Text ,"R$ " + Resultado );
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
            DateTime.Now.ToShortDateString()
            string dataBancoMysql = Convert.ToDateTime(this.textBox1.ToString());
            try
            {

                MySqlConnection combouser = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                // MySqlDataReader leitura;
                combouser.Open();

                string inserir = "INSERT into vendas(usuarios_idusuarios, data) values ('" + cbxUser.SelectedValue.ToString() + "','" + textBox1.Text + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, combouser);
                comandos.ExecuteNonQuery();
                combouser.Close();
               // int valid = Convert.ToInt32(cbxUser.SelectedValue);

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

        private void cbxSuco_SelectedIndexChanged(object sender, EventArgs e)
        {
           // mktTotal.Text = cbxSuco.SelectedValue.ToString();
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

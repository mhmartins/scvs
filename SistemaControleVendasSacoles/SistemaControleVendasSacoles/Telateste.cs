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
        }

        private DataView LoadUserData()
        {
            MySqlConnection combo = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
            MySqlDataAdapter sql3 = new MySqlDataAdapter("select idusuarios,nome from usuarios", combo);

            DataTable dt3 = new DataTable();
            sql3.Fill(dt3);

            return dt3.DefaultView;
        }

        private void Telateste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendas._vendas' table. You can move, or remove it, as needed.
           // this.vendasTableAdapter.Fill(this.vendas._vendas);
            cbxUser.SelectedIndex = -1;
	           dgv.Columns.Add("srno", "SrNo");
	           dgv.Columns.Add("bookingno", "Booking No");
	           dgv.Columns.Add("bookingdate", "Booking Date");
	 
	           dgv.Columns[0].Width = 50;
	           dgv.Columns[1].Width = 100;
	           dgv.Columns[2].Width = 100;   
	                   
            MySqlConnection combo = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
            MySqlDataAdapter sql = new MySqlDataAdapter("select * from sacoles where tipo = 1", combo);
            MySqlDataAdapter sql2 = new MySqlDataAdapter("select * from sacoles where tipo = 2", combo);
           // MySqlDataAdapter sql3 = new MySqlDataAdapter("select * from usuarios", combo);
          /*  MySqlDataAdapter sql3 = new MySqlDataAdapter("select * from usuarios", combo);

            DataTable dt3 = new DataTable();
            sql3.Fill(dt3);
            this.cbxUser.DataSource = dt3;
            this.cbxUser.ValueMember = "idusuario";
            this.cbxUser.DisplayMember = "nome";*/
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            //DataTable dt3 = new DataTable();
            sql.Fill(dt);
            sql2.Fill(dt2);
            //sql3.Fill(dt3);

            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbxsacolescre.Items.Add(dt.Rows[i]["sabor"]);
                }

                for (int ii = 0; ii < dt2.Rows.Count; ii++)
                {
                    cbxSuco.Items.Add(dt2.Rows[ii]["sabor"]);
                }
               // this.cbxUser.DataSource = dt3;
               // this.cbxUser.ValueMember = "idusuario";
               // this.cbxUser.DisplayMember = "nome";

              //  for (int u = 0; u < dt3.Rows.Count; u++)
              //  {
              //      cbxUser.Items.Add(dt3.Rows[u]["nome"]);
              //  }
            }
            catch (MySqlException erro)
            {
                throw new Exception("Erro de comandos: " + erro.Message);
            }
            finally
            {
                combo.Close();
            }

        }

       // private MySqlConnection conexao;

        private void cmbxsacolescre_SelectedIndexChanged(object sender, EventArgs e)
        {           
            //   select * from EQUIPAMENTO ORDER BY<br/>
//CASE WHEN [ID_EQUIPAMENTO] = 'ID_EQTO_QUE_EU_SELECIONO' THEN 0 ELSE 1 END, [ID_EQUIPAMENTO
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void AddCre_Click(object sender, EventArgs e)
        {
           // dataGridView1.Rows.Insert(cmbxsacolescre.Text, cbxSuco.Text, mskValCre.Text);
            dgv.Rows.Add(cmbxsacolescre.Text, nupdowCre.Text ,mskValCre.Text );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows.add(cmbxsacolescre.Text, cbxSuco.Text, mskValCre.Text);
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
           
            try
            {

               // MySqlConnection combouser = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                // MySqlDataReader leitura;
                //combouser.Open();

                //string inserir = "INSERT into vendas(usuarios_idusuarios, data) values ('" + cbxUser.Text + "','" + 12221111 + "')";
                //MySqlCommand comandos = new MySqlCommand(inserir, combouser);
                //comandos.ExecuteNonQuery();
                //combouser.Close();
               // int valid = Convert.ToInt32(cbxUser.SelectedValue);

                mktData.Text = cbxUser.SelectedValue.ToString(); 
              
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
            //finally
            //{
              //  combouser.Close();
            //}
        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* MySqlConnection combo = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
            MySqlDataAdapter sql3 = new MySqlDataAdapter("select * from usuarios", combo);

            DataTable dt3 = new DataTable();
            sql3.Fill(dt3);
            this.cbxUser.DataSource =dt3;
            this.cbxUser.ValueMember = "idusuario";
            this.cbxUser.DisplayMember = "nome";
            combo.Close();*/
            string message = cbxUser.SelectedValue.ToString();

           MessageBox.Show(message);

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

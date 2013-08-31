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

namespace SistemaControleVendasSacoles
{
    public partial class Telateste : Form
    {
        public Telateste()
        {
            InitializeComponent();
        }

        private void Telateste_Load(object sender, EventArgs e)
        {
            MySqlConnection combo = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
            MySqlDataAdapter sql = new MySqlDataAdapter("select * from sacoles where tipo = 1", combo);
            MySqlDataAdapter sql2 = new MySqlDataAdapter("select * from sacoles where tipo = 2", combo);

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            sql.Fill(dt);
            sql2.Fill(dt2);

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

            }
            catch (MySqlException erro)
            {
                throw new Exception("Erro de comandos: " + erro.Message);
            }
            finally
            {
                combo.Close();
            }
        /*    c.Text = codigoID;
            cmbxsacolescre.Text = 
            txtNome.Text = nome;

            txtEndereco.Text = endereco;

            txtCidade.Text = cidade;

            txtEstado.Text = estado;

            txtCep.Text = cep;

            txtTelefone.Text = telefone;
            */
        }

       // private MySqlConnection conexao;

        private void cmbxsacolescre_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string caminho = "SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;";

           // try
          //  {
               // conexao = new MySqlConnection(caminho);
                // MySqlDataReader leitura;
               // conexao.Open();

               // string inserir = "INSERT INTO sacoles(sabor,tipo,quant,quantmin,preco)values('" + sa.Sabor + "','" + sa.Tipo + "','" + sa.Quant + "','" + sa.QuantMin + "','" + sa.Valor + "')";
               // MySqlCommand comandos = new MySqlCommand(inserir, conexao);
              //  comandos.ExecuteNonQuery();
               // conexao.Close();
           // }

           // catch (Exception ex)
           // {
             //   throw new Exception("Erro de comandos: " + ex.Message);
           // }
           // if (conexao.State == ConnectionState.Open)
           // {


           // }


            
            //   select * from EQUIPAMENTO ORDER BY<br/>
//CASE WHEN [ID_EQUIPAMENTO] = 'ID_EQTO_QUE_EU_SELECIONO' THEN 0 ELSE 1 END, [ID_EQUIPAMENTO
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void AddCre_Click(object sender, EventArgs e)
        {
           // dataGridView1.Rows.Insert(cmbxsacolescre.Text, cbxSuco.Text, mskValCre.Text);
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
        /*  private void carregaCombox()
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

          }
          */
    }
}

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
    public partial class MenuPrincipal2 : Form
    {
        public MenuPrincipal2()
        {
            InitializeComponent();
            GridDesign();
            comboBox1.DataSource = LoadUserData();
            //int ff = GetCodCliente(ff);
            comboBox1.ValueMember = "idusuarios";
            comboBox1.DisplayMember = "nome";
        }
        private DataView LoadUserData()
        {
               MySqlConnection combo = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
               MySqlDataAdapter sql3 = new MySqlDataAdapter("select idusuarios,nome from usuarios", combo);

               DataTable dt3 = new DataTable();
               sql3.Fill(dt3);

               return dt3.DefaultView;
        }
        private void mnuArquivoNovoAzul_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            Form frmAzul = new Form();

            // Atribui um titulo ao formulário
            frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show(); 
        }

        private void MenuPrincipal2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            GridDesign();


        }

        public int GetCodCliente(int Utilizador)
        {
            string lcSQL = "SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1";

            using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;"))
            {
                using (MySqlCommand command = new MySqlCommand(lcSQL, conn))
                {
                    command.Parameters.AddWithValue("idvendas", Utilizador);

                    conn.Open();
                    using (MySqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            return dr.GetInt32(0);
                        }
                    }
                    conn.Close();
                }
            }
            
            return 0;
        }
        
        private void GridDesign()
        {
            dgv.Columns.Add("srno", "Sacolés");
            dgv.Columns.Add("bookingno", "Quantidade");
            dgv.Columns.Add("bookingdate", "Total");

            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 100;
        }
        private void mnuArquivoNovo_Click(object sender, EventArgs e)
        {
            CadastroSacoles Form = new CadastroSacoles();
            Form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string message = comboBox1.SelectedValue.ToString();

            MessageBox.Show(message);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int dal = 0; //dall= 0;
            dal = GetCodCliente(dal);
            MessageBox.Show("APERTOU --> "+dal);

           /* MySqlConnection connection = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
            //string connection = "SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;";
            string sql = "SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            //string id;
            int id;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
                MessageBox.Show("APERTOU --> " + id);
            }
            //string dal = id;
            
          //  this.id.ExecuteScalar();
           /* string MyConString = "SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            try{
                connection.Open();
                Console.WriteLine("Connection
            //dgv.Rows.Add(tbx1.Text, tbx1.Text, tbx1.Text);
         /*   MessageBox.Show("APERTOU");
            int resultado = 0;
            MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
            //string sql = "SELECT cod_cliente FROM clientes WHERE nome_utilizador='ricardo'"
            MySqlCommand select = new MySqlCommand("SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1", combo10);
            MySqlDataReader reader = select.ExecuteReader();
            if (reader.Read())
            {
                resultado = reader.GetInt32(0);
            }
            MessageBox.Show("PASSOU A STRING " + resultado);*/
            /* try
             {
                 MessageBox.Show("ENTROU");
                 MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                 MySqlCommand select = new MySqlCommand("SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1", combo10);
                 MessageBox.Show("PASSOU");

                 // 2. Chama o método  ExecuteScalar para enviar o comando
                 int count = Convert.ToInt32(Convert.ToString(select.ExecuteScalar()));
                 tbx1.Text = count.ToString();
                 combo10.Close();
                 MessageBox.Show("APERTOU "+count);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("ERRO");
                 ex.Message.ToString();
             }
             */
        }

        private void tbx1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

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
            dgv.Rows.Add(tbx1.Text, tbx1.Text, tbx1.Text);
        }

    }
}

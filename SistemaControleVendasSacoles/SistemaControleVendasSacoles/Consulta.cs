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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }
        private MySqlConnection conexao;
        private DataTable pesquisaDatatable;
        private void btnCadastrados_Click(object sender, EventArgs e)
        {
            pesquisaDatatable = new DataTable();
            conexao = new MySqlConnection("SERVER=localhost;" +" DATABASE=banco_rr_sacoles;" +" UID=root;"+"PASSWORD=12345;");
            try
            {

                conexao.Open();
                MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT * FROM sacoles", conexao);
                conexaoAdapter.Fill(pesquisaDatatable);
               // dataGridView1.DataSource = pesquisaDatatable;
                //dataGridView1.DataMember = "sacoles";
                conexao.Close();

            }
            catch
            {
                MessageBox.Show("Impossível estabelecer conexão");
                conexao.Close();
            } 

        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_rr_sacolesDataSet1.tipo' table. You can move, or remove it, as needed.
            this.tipoTableAdapter.Fill(this.banco_rr_sacolesDataSet1.tipo);
            // TODO: This line of code loads data into the 'banco_rr_sacolesDataSet1.sacoles' table. You can move, or remove it, as needed.
            this.sacolesTableAdapter.Fill(this.banco_rr_sacolesDataSet1.sacoles);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 20);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


    }
}

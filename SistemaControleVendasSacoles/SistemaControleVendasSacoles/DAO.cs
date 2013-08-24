using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using MySql.Data.Common;
//Ctrl+E, D --> Formata documento
namespace SistemaControleVendasSacoles
{
    class DAO
    {
        private MySqlConnection conexao;
       /* public void venda()
        {
            string caminho = "SERVER=localhost;" + "DATABASE=banco_rr_sacoles;" + "UID=root;" + "PASSOWORD=12345;";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                string selecionar = "INSERT INTO vendas*/
       // public void atualizavenda(Sacole va)

        public void cadastro(Sacole sa)
        {
            string caminho = "SERVER=localhost;" +" DATABASE=banco_rr_sacoles;" +" UID=root;"+"PASSWORD=12345;";

            try
            {
                conexao = new MySqlConnection(caminho);
               // MySqlDataReader leitura;
                conexao.Open();

                string inserir = "INSERT INTO sacoles(sabor,tipo,quant,quantmin,preco)values('" + sa.Sabor + "','" + sa.Tipo + "','" + sa.Quant + "','" + sa.QuantMin +"','" + sa.Valor + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }

        }
       /* public void login(Usuario us)
        {
             string caminho = "SERVER=localhost;" +" DATABASE=banco_rr_sacoles;" +" UID=root;"+"PASSWORD=037leo;";

            try
            {
                conexao = new MySqlConnection(caminho);
                MySqlDataReader leitura;
                conexao.Open();
                string validar = "SELECT INTO usuarios(nome,senha)values('" + us.Nome + "','" + us.Senha + "')";
                MySqlCommand logando = new MySqlCommand(validar, conexao);
                leitura = logando.ExecuteReader();
                            while (leitura.Read())
            {
                Principal Form2 = new Principal();
                Form2.Show();
            }
           
             leitura.Close();
               conexao.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }

        }*/
        }
    }
//}

   /* private void testBT_Click(object sender, EventArgs e)
        {
            int c = 0;
            
            string selectString = "SELECT user, pass " + "FROM login " + "WHERE user = '" + userTB.Text + "' AND pass = '" + passTB.Text + "'";
            MySqlConnection conDatabase = new MySqlConnection("Data Source=localhost;" + "Database='lp_projecto';" + "Persist Security Info=yes;" + "UserId=root; PWD='';");
                       
            conDatabase.Open();
            
            MySqlDataReader leitura;
            MySqlCommand command = conDatabase.CreateCommand();
            
            command.CommandText = "SELECT user, pass " + "FROM login " + "WHERE user = '" + userTB.Text + "' AND pass = '" + passTB.Text + "'"; //select de //demostração, metes o teu select
            
            
            leitura = command.ExecuteReader();
            while (leitura.Read())
            {
                               textBox1.Text = "YOU ARE LOGGED IN!";
            }
           
             leitura.Close();
  }*/
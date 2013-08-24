using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaControleVendasSacoles
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //boolean para testar os tbx 
        private bool CamposObrig()
        {
            bool CampoVazio = false;

            if (String.IsNullOrEmpty(tbxUser.Text)) 
            {
                MessageBox.Show("O campo (Usuario) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxUser.Select();
                CampoVazio = true;
            }

            if (String.IsNullOrEmpty(tbxSenha.Text))
            {
                MessageBox.Show("O campo (Senha) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxSenha.Select();
                CampoVazio = true;
            }

            return CampoVazio;
        }
        //fim do boolean


        private void button1_Click(object sender, EventArgs e)
        {
           bool CamposObrigPreenchidos = CamposObrig();

           if (!CamposObrigPreenchidos)
           {
               //chamo o método já testando seu retorno

               //preenchendo os parâmetros necessários
               //se retorna true
               if (ValidaUsuario(tbxUser.Text, tbxSenha.Text))
               {
                   //retorno o diálogo ok
                   this.DialogResult = DialogResult.OK;
               }
               else
               {
                   //Senão retorno o dialogo cancel por exemplo
                  // this.DialogResult = DialogResult.Cancel;
                   MessageBox.Show("Usuário ou senha inválidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   tbxSenha.Select();
               }
           }
              
            else
            {
                return;
            }
            
        }
        //Método para validar usuário que recebe duas string
        //como parâmetros que será o usuario e senha
        private bool ValidaUsuario(string usuario, string senha)
        {
            //variável que será testada para
            //informar o retorno
            int retorno = -1;
            ////instância da conexão
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=banco_rr_sacoles;Uid=root;Pwd=12345;");
            //comando sql que dá um count 
            //na tabela se existirem usuario e senha
            //com os dados informados
            string comando = "SELECT COUNT(*) FROM usuarios WHERE nome=@Nome AND senha=@Senha";
            //instância do comando
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            //preenchimento dos parâmetros
            cmd.Parameters.AddWithValue("@Nome", usuario);
            cmd.Parameters.AddWithValue("@Senha", senha);
            //abro conexão
            conn.Open();
            //retorno recebe o resultado do execute scalar
            retorno = Convert.ToInt32(cmd.ExecuteScalar());
            //fecho conexão
            conn.Close();
            //retorno true se retorno for maior que zero
            return retorno > 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                e.Handled = true;

                SendKeys.Send("{tab}");

            }
        }
       /* private void Login_Load(object sender, EventArgs e)
        {
            tbxSenha.GotFocus += tbxSenha_GotFocus;
        }
        void tbxSenha_GotFocus(object sender, EventArgs e)
        {
            tbxSenha.SelectAll();
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            tbxSenha.SelectAll();
        }*/
    }
}

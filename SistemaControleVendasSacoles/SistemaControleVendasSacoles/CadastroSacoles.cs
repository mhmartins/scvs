using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaControleVendasSacoles
{
    public partial class CadastroSacoles : Form
    {
 
        public CadastroSacoles()
        {
            InitializeComponent();
        }
        //boolean para testar os tbx 
        private bool CamposObrig()
        {
            bool CampoVazio = false;

            if (String.IsNullOrEmpty(tbxnome.Text))
            {
                MessageBox.Show("Campo (Nome) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxnome.Select();
                CampoVazio = true;
            }

            if (String.IsNullOrEmpty(tbxquant.Text))
            {
                MessageBox.Show("Campo (Quantidade) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxnome.Select();
                CampoVazio = true;
            }

            if (String.IsNullOrEmpty(tbxvalor.Text))
            {
                MessageBox.Show("Campo (Valor) deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxnome.Select();
                CampoVazio = true;
            }

            return CampoVazio;
        }
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            bool CamposObrigPreenchidos = CamposObrig();

            if (!CamposObrigPreenchidos)//se o campos estiver preenchido ele entra 
            {
                Sacole sa = new Sacole();
                DAO da = new DAO();
                sa.Sabor = tbxnome.Text;
                int nupdow;
                if (nupdowtipo2.Text == "Cremoso")
                {
                    nupdow = 1;
                }
                else
                {
                    nupdow = 2;
                }
                sa.Tipo = nupdow;
                sa.Quant = int.Parse(tbxquant.Text);
                sa.QuantMin = int.Parse(tbxquantmin.Text);
                sa.Valor = tbxvalor.Text;
                da.cadastro(sa);
                MessageBox.Show("Produto cadastrado com sucesso!");

                tbxnome.Text = "";
                //nupdowtipo.Text = "1";
                tbxquant.Text = "";
                //tbxquantmin.Text = "";
                tbxvalor.Text = "";
            }
            else//campo não preenchido
            {
                return;
            }
        }

        private void numerictipo_ValueChanged(object sender, EventArgs e)
        {
            // SELECT nome FROM banco_rr_sacoles.tipo;
        }

        private void cbxtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroSacoles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tipo' table. You can move, or remove it, as needed.
            this.tipoTableAdapter1.Fill(this.banco.tipo);
            // TODO: This line of code loads data into the 'banco_rr_sacolesDataSet1.tipo' table. You can move, or remove it, as needed.
            this.tipoTableAdapter.Fill(this.banco_rr_sacolesDataSet1.tipo);

        }

        private void tbxnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir num. apenas caracteres, backspace e espaço.
            if (!(char.IsLetter(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja limpar os campos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //apaga os tbx relacionado abaixo
                tbxnome.Clear();
                tbxquant.Clear();
                tbxvalor.Clear();
            }
        }

        private void tbxvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num, backspace e virgula
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void tbxquant_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void nupdowtipo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            JanelaEstoque Form = new JanelaEstoque();
            Form.Show();
            this.Close();
        }

    }
}

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
using System.Globalization;
// CTRL+E.F
// colocar o R$ OK
// iniciar o mdi OK
// colorir o layout
// facilidade OK
// desabilitar campos OK
// separar campos OK
// definir parametros para datas do grafico 
// trabalhar no update das tabelas OK
// ajustar telas de excluir e alterar estoque...botões
// organizar grid por tipo(na consulta)
namespace SistemaControleVendasSacoles
{
    public partial class Telateste : Form
    {
        public Telateste()
        {
            InitializeComponent();
            //incia combobox VENDEDOR
            cbxUser.DataSource = LoadUserData();
            cbxUser.ValueMember = "idusuarios";
            cbxUser.DisplayMember = "nome";
            //inicia combobox CREMOSO
            cmbxsacolescre.DataSource = LoadCremosoData();
            cmbxsacolescre.ValueMember = "idSacoles";
            cmbxsacolescre.DisplayMember = "sabor";
            //inicia combobox SUCO
            cbxSuco.DataSource = LoadSucoData();
            cbxSuco.ValueMember = "idSacoles";
            cbxSuco.DisplayMember = "sabor";
            //inicia DATAGRID 
            dgv.Columns.Add("sabor", "          Sacolés");
            dgv.Columns.Add("quant", "    Quantidade");
            dgv.Columns.Add("total", "        Total");
            //define COLUNAS e LINHA do DATAGRID
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
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from sacoles where tipo = 1 && quant != 0 ORDER BY sabor ASC", combo);
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
                //MySqlDataAdapter sql = new MySqlDataAdapter("select * from sacoles where tipo = 2 && quant != 0", combo);
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from sacoles where tipo = 2 && quant != 0 ORDER BY sabor ASC", combo);
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

        /// <summary>
        /// Bora lá que vai
        /// </summary>
        /// <param name="Codigo"></param>
        /// <returns></returns>
        /*public int GetCodSacole(int Codigo, int cod)
        {
            string lcSQL = "select preco from sacoles where idSacoles = '" + cod + "'";

            using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;"))
            {
                using (MySqlCommand command = new MySqlCommand(lcSQL, conn))
                {
                    command.Parameters.AddWithValue("preco", Codigo);

                    conn.Open();
                    using (MySqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            return dr.GetInt32(0);
                        }
                    }
                }
            }

            return 0;
        }*/

        //MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
        //MySqlDataAdapter sql40 = new MySqlDataAdapter("select preco from sacoles where idSacoles = '" + cmbxsacolescre.SelectedValue.ToString() + "'", combo10);
        //DataTable dt40 = new DataTable();

        //PEGA O CÓDIGO DA ULTIMA VENDA
        public int GetCodCliente(int Codigo)
        {
            string lcSQL = "SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1";

            using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;"))
            {
                using (MySqlCommand command = new MySqlCommand(lcSQL, conn))
                {
                    command.Parameters.AddWithValue("idvendas", Codigo);
                    conn.Open();
                    using (MySqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            return dr.GetInt32(0);
                        }
                    }
                }
            }
            return 0;
        }

        //CAMPOS OBRIGATÓRIOS VENDEDOR
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

        //CAMPOS OBRIGATÓRIO SACOLÉ CREMOSO
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
            return CampoVazio;
        }

        //CAMPOS OBRIGATÓRIOS SACOLÉ SUCO
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
        string dataSistema;
        //VARIVÉL DA DATA
        private void timer1_Tick(object sender, EventArgs e)
        {
            //textBox1.Text=DateTime.Now.ToLongDateString();
            //textBox1.Text = DateTime.Now.ToLongTimeString();
            //textBox1.Text = DateTime.Now.ToShortTimeString();
            //textBox1.Text = DateTime.Now.ToShortDateString();
            dataSistema = DateTime.Now.ToShortDateString();       
            
        }


        //COMBOBOX SABOR CREMOSO
        private void cmbxsacolescre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label13.DataBindings.Clear();
            this.tbxValCre.DataBindings.Clear();
            this.tbxEstCre.DataBindings.Clear();
            nupdowCre.Value = 0;
            //textBox3.Text = .ToString("N", new CultureInfo("en-US"));
            int preco = 0;
            tbxValCre.Text = preco.ToString();

            try
            {
                MySqlConnection combo10 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql40 = new MySqlDataAdapter("select preco, quant from sacoles where idSacoles = '" + cmbxsacolescre.SelectedValue.ToString() + "'", combo10);
                DataTable dt40 = new DataTable();
                //int rt = 0;
                //string lcSQL = "SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1";

                /*   MySqlConnection conn = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                   MySqlCommand command = new MySqlCommand(lcSQL, conn);
                   command.Parameters.AddWithValue("idvendas", rt);
                   conn.Open();
                   MySqlDataReader dr = command.ExecuteReader();
                   while (dr.Read())
                   {
                       dr.GetInt32(0);
                   }
                   */
                sql40.Fill(dt40);
                BindingSource source = new BindingSource();
                source.DataSource = dt40;

                this.tbxValCre.DataBindings.Add("Text", source, "preco", true);
                this.tbxEstCre.DataBindings.Add("Text", source, "quant", true);
                nupdowCre.Maximum = int.Parse(tbxEstCre.Text);
                combo10.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }

        //COMBOBOX SABOR SUCO
        private void cbxSuco_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.label13.DataBindings.Clear();
            this.tbxValSuc.DataBindings.Clear();
            this.tbxValCre.DataBindings.Clear();
            this.tbxEstCre.DataBindings.Clear();
            this.tbxEstSuc.DataBindings.Clear();
            nupdowSuc.Value = 0;
            try
            {
                MySqlConnection combo1 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                MySqlDataAdapter sql4 = new MySqlDataAdapter("select preco,quant from sacoles where idSacoles = '" + cbxSuco.SelectedValue.ToString() + "'", combo1);
                DataTable dt4 = new DataTable();
                sql4.Fill(dt4);
                string val = cbxSuco.SelectedValue.ToString();
                BindingSource source = new BindingSource();
                source.DataSource = dt4;
                //label13.Visible = true;

                this.tbxValSuc.DataBindings.Add("Text", source, "preco", true);
                this.tbxEstSuc.DataBindings.Add("Text", source, "quant", true);
                nupdowSuc.Maximum = int.Parse(tbxEstSuc.Text);
                combo1.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }

        float valorTotal = 0;//VARIAVEL GLOBAL!
        int quantSac = 0;//VARIAVEL GLOBAL!     

        //BOTÃO DE ADICIONAR O SABOR CREMOSO
        private void AddCre_Click(object sender, EventArgs e)
        {
            this.textBox5.DataBindings.Clear();
            bool CamposObrigPreenchidos = CamposObrig();
            if (!CamposObrigPreenchidos)//se o campos estiver preenchido ele entra 
            {
                int dal = 0, idvenda = 0;
                idvenda = GetCodCliente(dal);
                this.textBox3.DataBindings.Clear();
                try
                {
                    int quantidade = (int.Parse(nupdowCre.Text)); //RECEBE A QUANTIDADE DO SACOLÉ
                    float Resultado = (int.Parse(nupdowCre.Text) * float.Parse(tbxValCre.Text)); //RECEBE O VALOR
                    //textBox3.Text = Resultado.ToString("N", new CultureInfo("en-US")); //RECEBE O RESULTADO, CONVERTIDO, PARA O BANCO
                    textBox3.Text = Resultado.ToString("N", new CultureInfo("pt-BR"));
                    //mktTotal.Text = (float.Parse(mktTotal.Text) + (int.Parse(nupdowCre.Text) * float.Parse(tbxValCre.Text))).ToString();
                    valorTotal = valorTotal + (int.Parse(nupdowCre.Text) * float.Parse(tbxValCre.Text)); //VALOR TOTAL
                    mktTotal.Text = valorTotal.ToString("N", new CultureInfo("pt-BR")); //CONVERTE O VALOR PARA REAL
                    mktTotal.Text = ("R$ " + mktTotal.Text).ToString(); //CRIA UMA MASCARA        

                    int quantAtual = 0;
                    //inicio do SQL
                    MySqlConnection conexao3 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                    //MySqlDataAdapter select = new MySqlDataAdapter("SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1", conexao3);
                    string inserir3 = "INSERT INTO vendas_sacoles(vendas_idvendas,sacoles_idsacoles,quantidade,valor)values('" + idvenda + "','" + cmbxsacolescre.SelectedValue.ToString() + "','" + quantidade + "','" + textBox3.Text + "')";
                    MySqlDataAdapter sql40 = new MySqlDataAdapter("select quant from sacoles where idSacoles = '" + cmbxsacolescre.SelectedValue.ToString() + "'", conexao3);

                    conexao3.Open();
                    DataTable dt40 = new DataTable();

                    sql40.Fill(dt40);
                    BindingSource source = new BindingSource();
                    source.DataSource = dt40;
                    this.textBox5.DataBindings.Add("Text", source, "quant", true);
                    quantSac = int.Parse(textBox5.Text);
                    quantAtual = quantSac - quantidade;

                    string UPDATE = "UPDATE sacoles SET quant= '" + quantAtual + "' WHERE idSacoles = '" + cmbxsacolescre.SelectedValue.ToString() + "'";
                    MySqlCommand comandoAtualiza = new MySqlCommand(UPDATE, conexao3);
                    comandoAtualiza.ExecuteNonQuery();

                    if (quantAtual <= 5)
                    {
                        MessageBox.Show("Quantidade mínima atingida. Quantida em estoque: " + quantAtual, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //DataTable dt4 = new DataTable();
                    //select.Fill(dt4);
                    //BindingSource source2 = new BindingSource();
                    //source.DataSource = dt4;
                    //this.textBox2.DataBindings.Add("Text", source, "idvendas", true);


                    MySqlCommand comandos3 = new MySqlCommand(inserir3, conexao3);
                    comandos3.ExecuteNonQuery();
                    conexao3.Close();
                    //Fim do SQL
                    dgv.Rows.Add(cmbxsacolescre.Text, nupdowCre.Text, "R$ " + (String.Format("{0:0.00}",Resultado)));
                    cmbxsacolescre.Text = "";
                    nupdowCre.Text = "0";
                    tbxValCre.Text = "";
                    tbxEstCre.Text = "";                    
                    //textBox2.Text = quantidade.ToString();
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

        public string pegadata(string sDataF)
        {
            string data;
            if (textBox1.Text == "")
            {
                data = dataSistema;
                textBox1.Text = dataSistema.ToString();
                DateTime d = Convert.ToDateTime(data);
                sDataF = d.ToString("yyyyMMdd");
            }
            else
            {
                DateTime resultado = DateTime.MinValue;
                if (DateTime.TryParse(this.textBox1.Text.Trim(), out resultado))
                {
                    data = textBox1.Text;
                    DateTime d = Convert.ToDateTime(data);
                    sDataF = d.ToString("yyyyMMdd");
                }
                else
                {
                    return null;
                }

            }
            return sDataF;
        }


        //BOTÃO LIMPAR A TELA
        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Você tem certeza que deseja limpar os campos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //apaga os tbx relacionado abaixo
                    addSuco.Enabled = false;
                    AddCre.Enabled = false;
                    cmbxsacolescre.Enabled = false;
                    cbxSuco.Enabled = false;
                    nupdowCre.Enabled = false;
                    nupdowSuc.Enabled = false;
                    tbxValCre.Enabled = false;
                    tbxValSuc.Enabled = false;
                    cmbxsacolescre.Text = "";
                    nupdowCre.Text = "0";
                    tbxValCre.Text = "";
                    cbxSuco.Text = "";
                    nupdowSuc.Text = "0";
                    tbxValSuc.Text = "";
                    dgv.Rows.Clear();
                    valorTotal = 0;
                    tbxDesc.Text = "";
                    mktTotal.Text = "";
                    tbxEstCre.Text = "";
                    tbxEstSuc.Text = "";
                    MessageBox.Show("Campos apagados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //BOTÃO ADICONAR VENDEDOR
        private void btnIni_Click(object sender, EventArgs e)
        {
            //Code Snippet
            //DateTime data = textBox1.Text;

            //DateTime.Now.ToShortDateString();
           // DateTime dataConvertida = DateTime.ParseExact(data,"yyyy-MM-dd", null);
            //MessageBox.Show(dataConvertida.ToString());
            //MySqlDbType.Datetime = 

            //DateTime d = Convert.ToDateTime(textBox1.Text);
            //string sDataF = d.ToString("yyyyMMdd");
            string sData= "";
            string sData1 = pegadata(sData);
            //MessageBox.Show("DATA = " + sData1);
            if (sData1 == null)
            {
                textBox1.Text = "";
                MessageBox.Show("Data Inválida.","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //string date = textBox1.Text;
                //DateTime dt = Convert.ToDateTime(date);
                //Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt.Year, dt.Month, dt.Day);
                //MessageBox.Show(dt.ToString());
                //string date = "01/08/2008";
                //DateTime dt = Convert.ToDateTime(date);
                //Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt.Year, dt.Month, dt.Day);

                //textBox2.Text = Convert.ToDateTime(this.textBox1.ToString());

                bool CamposObrigPreenchidos2 = CamposObrig2();
                if (!CamposObrigPreenchidos2)//se o campos estiver preenchido ele entra 
                {
                    this.textBox2.DataBindings.Clear();

                    try
                    {
                        MySqlConnection conexao = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                        conexao.Open();
                        string inserir = "INSERT into vendas(usuarios_idusuarios, data) values ('" + cbxUser.SelectedValue.ToString() + "','" + sData1 + "')";
                       // String insVen = "INSERT into vendidosvendedor(idvendedor, data) values ('" + cbxUser.SelectedValue.ToString() + "','" + sData1 + "')";
                        MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                        //MySqlDataAdapter select = new MySqlDataAdapter("SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1", conexao);
                        comandos.ExecuteNonQuery();

                        //DataTable dt4 = new DataTable();
                        //select.Fill(dt4);
                        //BindingSource source = new BindingSource();
                        //source.DataSource = dt4;
                        //this.textBox2.DataBindings.Add("Text", source, "idvendas", true);//vericar se a variavel pode receber dados do databin....

                        conexao.Close();
                        int valid = Convert.ToInt32(cbxUser.SelectedValue);
                        addSuco.Enabled = true;
                        AddCre.Enabled = true;
                        cmbxsacolescre.Enabled = true;
                        cbxSuco.Enabled = true;
                        nupdowCre.Enabled = true;
                        nupdowSuc.Enabled = true;
                        tbxValCre.Enabled = true;
                        tbxValSuc.Enabled = true;
                        btnSomar.Enabled = true;
                        btnFinaVenda.Enabled = true;
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
        }

        //BOTÃO ADICIONAR SABOR SUCO
        private void addSuco_Click(object sender, EventArgs e)
        {
            this.textBox8.DataBindings.Clear();
            bool CamposObrigPreenchidos = CamposObrig3();
            if (!CamposObrigPreenchidos)//se o campos estiver preenchido ele entra 
            {
                int dal = 0, idvenda = 0;
                idvenda = GetCodCliente(dal);
                try
                {
                    int quantAtual = 0;
                    float Resultado = (int.Parse(nupdowSuc.Text) * float.Parse(tbxValSuc.Text));
                    dgv.Rows.Add(cbxSuco.Text, nupdowSuc.Text, "R$ " + (String.Format("{0:0.00}",Resultado)));
                    int quantidade = (int.Parse(nupdowSuc.Text));
                    textBox3.Text = Resultado.ToString("N", new CultureInfo("pt-BR"));

                    valorTotal = valorTotal + (int.Parse(nupdowSuc.Text) * float.Parse(tbxValSuc.Text)); //VALOR TOTAL
                    mktTotal.Text = valorTotal.ToString("N", new CultureInfo("pt-BR")); //CONVERTE O VALOR PARA REAL
                    mktTotal.Text = ("R$ " + mktTotal.Text).ToString(); //CRIA UMA MASCARA 

                    //inicio do SQL
                    MySqlConnection conexao3 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                    string inserir3 = "INSERT INTO vendas_sacoles(vendas_idvendas,sacoles_idsacoles,quantidade,valor)values('" + idvenda + "','" + cbxSuco.SelectedValue.ToString() + "','" + quantidade + "','" + textBox3.Text + "')";
                    MySqlDataAdapter sql40 = new MySqlDataAdapter("select quant from sacoles where idSacoles = '" + cbxSuco.SelectedValue.ToString() + "'", conexao3);
                    conexao3.Open();
                    DataTable dt40 = new DataTable();

                    sql40.Fill(dt40);
                    BindingSource source = new BindingSource();
                    source.DataSource = dt40;
                    this.textBox8.DataBindings.Add("Text", source, "quant", true);
                    quantSac = int.Parse(textBox8.Text);
                    quantAtual = quantSac - quantidade;
                    string UPDATE = "UPDATE sacoles SET quant= '" + quantAtual + "' WHERE idSacoles = '" + cbxSuco.SelectedValue.ToString() + "'";
                    MySqlCommand comandoAtualiza = new MySqlCommand(UPDATE, conexao3);
                    comandoAtualiza.ExecuteNonQuery();
                    if (quantAtual <= 5)
                    {
                        MessageBox.Show("Quantidade mínima atingida. Quantida em estoque: " + quantAtual, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    MySqlCommand comandos3 = new MySqlCommand(inserir3, conexao3);
                    comandos3.ExecuteNonQuery();
                    conexao3.Close();
                    //Fim do SQL
                    cbxSuco.Text = "";
                    nupdowSuc.Text = "0";
                    tbxValSuc.Text = "";
                    tbxEstSuc.Text = "";
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

        //BOTÃO SOMAR O DESCONTO
        private void btnSomar_Click(object sender, EventArgs e)
        {
            float somadesconto = (valorTotal - float.Parse(tbxDesc.Text));
            if (somadesconto < 0)
            {
                MessageBox.Show("Valor superior ao valor TOTAL, digite um valor MENOR ou IGUAL ao TOTAL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                valorTotal = somadesconto;
                mktTotal.Text = valorTotal.ToString("N", new CultureInfo("pt-BR")); //CONVERTE O VALOR PARA REAL
                mktTotal.Text = ("R$ " + mktTotal.Text).ToString(); //CRIA UMA MASCARA
            }

        }

        private void btnFinaVenda_Click(object sender, EventArgs e)
        {
            this.textBox9.DataBindings.Clear();
            this.textBox7.DataBindings.Clear();
            string sData = "";
            string sData1 = pegadata(sData);
            string valor = valorTotal.ToString("N", new CultureInfo("en-US")); //CONVERTE O VALOR PARA REAL
            //MessageBox.Show("Venda " + valor, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                //inicio do SQL
                MySqlConnection conexao3 = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                //MySqlDataAdapter select = new MySqlDataAdapter("SELECT idvendas FROM vendas ORDER BY idvendas DESC LIMIT 1", conexao3);
                MySqlDataAdapter sql40 = new MySqlDataAdapter("select data from faturamento where data = '" + sData1 + "'", conexao3);
                conexao3.Open();
                DataTable dt40 = new DataTable();
                sql40.Fill(dt40);
                BindingSource source = new BindingSource();
                source.DataSource = dt40;
                this.textBox7.DataBindings.Add("Text", source, "data", true);



                if (textBox7.Text == "")//se a DATA for NOVA
                {
                    MySqlConnection conexao = new MySqlConnection("SERVER=localhost;" + " DATABASE=banco_rr_sacoles;" + " UID=root;" + "PASSWORD=12345;");
                    conexao.Open();
                    string inserir = "INSERT into faturamento(data,total) values ('" + sData1 + "','" + valor + "')";
                    MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                    comandos.ExecuteNonQuery();
                    conexao.Close();
                }
                else
                {                    
                    MySqlDataAdapter sql = new MySqlDataAdapter("select total from faturamento where data = '" + sData1 + "'", conexao3);
                    DataTable dt1 = new DataTable();
                    sql.Fill(dt1);
                    BindingSource source1 = new BindingSource();
                    source1.DataSource = dt1;
                    this.textBox9.DataBindings.Add("Text", source1, "total", true);
                    float soma = (float.Parse(textBox9.Text) + valorTotal);
                    //MessageBox.Show("Venda " + soma, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string valor2 = soma.ToString("N", new CultureInfo("en-US")); //CONVERTE O VALOR PARA REAL
                   // MessageBox.Show("Venda " + valor2, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string UPDATE = "UPDATE faturamento SET total = '" + valor2 + "' WHERE data = '" + sData1 + "'";
                    MySqlCommand comandoAtualiza = new MySqlCommand(UPDATE, conexao3);
                    comandoAtualiza.ExecuteNonQuery();
                    
                }
                conexao3.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
            MessageBox.Show("Venda finalizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            addSuco.Enabled = false;
            AddCre.Enabled = false;
            cmbxsacolescre.Enabled = false;
            cbxSuco.Enabled = false;
            nupdowCre.Enabled = false;
            nupdowSuc.Enabled = false;
            tbxValCre.Enabled = false;
            tbxValSuc.Enabled = false;
            cmbxsacolescre.Text = "";
            nupdowCre.Text = "0";
            tbxValCre.Text = "";
            cbxSuco.Text = "";
            nupdowSuc.Text = "0";
            tbxValSuc.Text = "";
            dgv.Rows.Clear();
            valorTotal = 0;
            tbxDesc.Text = "";
            mktTotal.Text = "";
            tbxEstCre.Text = "";
            tbxEstSuc.Text = "";
            textBox7.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 47)
            {
                e.Handled = true;
            }
        }

        private void tbxDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tramento de erro, não é permitido inserir caract. apenas num e backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

    }
}
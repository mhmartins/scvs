using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
//using Root.Reports;


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
            this.dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 20);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Document documento = new Document();
        private void btnGeraPDF_Click(object sender, EventArgs e)
        {
            string texto = "Vamos ver se isso funciona mesmo!\n\n";
            texto += "Mais uma linha de texto aqui\n\n";
            texto += "E mais uma linha\n\n";
            texto += "A última linha";
            
            //string textoo = dataGridView1.ToString();
            //MessageBox.Show(textoo);
            string vArq = "";
            string Data = "Estoque";
            // Abre janela para usuário escolher a pasta onde o arquivo será gerado
            MessageBox.Show(Data);
            FolderBrowserDialog vSalvar = new FolderBrowserDialog();

            // Verifica se o usuário clicou em ok ou cancelar na janela de seleção da pasta

            if (vSalvar.ShowDialog() == DialogResult.Cancel)

                return; // Cancela todo processo

            // Insere na variavel o caminho selecionado pelo usuário e concatena com o nome do arquivo

            vArq = vSalvar.SelectedPath + "\\" + Data.Trim() + ".pdf";
            MessageBox.Show(vArq);
            try
            {
                // cria uma instância de iTextSharp.text.Document
                Document documento = new Document();

                // cria um Writer para o documento
                PdfWriter.GetInstance(documento, new FileStream(vArq, FileMode.Create));

                // abre o documento
                documento.Open();

                // adiciona conteúdo
                documento.Add(new Paragraph(dataGridView1.Text));

                // fecha o documento
                documento.Close();

                MessageBox.Show("Documento PDF criado com sucesso.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            // cria uma instância de iTextSharp.text.Document
            
           // if (documento != null)
             //   MessageBox.Show("Parece que está tudo OK!");
           // else
             //   MessageBox.Show("Algum erro aqui!");
           // Variavel do Nome e caminho do arquivo
            /*
            string vArq = "";
            string Data = "Estoque_" + DateTime.Now.ToShortDateString();
            // Abre janela para usuário escolher a pasta onde o arquivo será gerado

            FolderBrowserDialog vSalvar = new FolderBrowserDialog();

            // Verifica se o usuário clicou em ok ou cancelar na janela de seleção da pasta

            if (vSalvar.ShowDialog() == DialogResult.Cancel)

                return; // Cancela todo processo

            // Insere na variavel o caminho selecionado pelo usuário e concatena com o nome do arquivo

            vArq = vSalvar.SelectedPath + "\\" + Data.Trim() + ".pdf";
            */
            /*try
            {

                // Cria um objeto PDF

                Report vPdf = new Report(new PdfFormatter());

                // Define a fonte que sera usada no relatório PDF

                FontDef vDef = new FontDef(vPdf, FontDef.StandardFont.TimesRoman);

                FontProp vDrop = new FontProp(vDef, 10);

                // Cria uma Nova Pagina

                Page vPage = new Page(vPdf);

                // Escreve no Arquivo

                vPage.AddCB_MM(5, new RepString(vDrop, dataGridView1.Text)); // Centraliza

                // Salvar Arquivo no disco

                vPdf.Save(vArq);

                MessageBox.Show("Arquivo Gerado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }*/

        }





    }
}

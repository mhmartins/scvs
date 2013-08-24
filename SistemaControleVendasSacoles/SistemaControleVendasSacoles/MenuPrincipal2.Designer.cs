namespace SistemaControleVendasSacoles
{
    partial class MenuPrincipal2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mn1 = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivoNovoAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivoNovoVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mn1
            // 
            this.mn1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuWindows});
            this.mn1.Location = new System.Drawing.Point(0, 0);
            this.mn1.Name = "mn1";
            this.mn1.Size = new System.Drawing.Size(811, 24);
            this.mn1.TabIndex = 1;
            this.mn1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivoNovo,
            this.mnuArquivoSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "Arquivo";
            // 
            // mnuArquivoNovo
            // 
            this.mnuArquivoNovo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivoNovoAzul,
            this.mnuArquivoNovoVermelho});
            this.mnuArquivoNovo.Name = "mnuArquivoNovo";
            this.mnuArquivoNovo.Size = new System.Drawing.Size(152, 22);
            this.mnuArquivoNovo.Text = "Novo";
            // 
            // mnuArquivoNovoAzul
            // 
            this.mnuArquivoNovoAzul.Name = "mnuArquivoNovoAzul";
            this.mnuArquivoNovoAzul.Size = new System.Drawing.Size(152, 22);
            this.mnuArquivoNovoAzul.Text = "Azul";
            this.mnuArquivoNovoAzul.Click += new System.EventHandler(this.mnuArquivoNovoAzul_Click);
            // 
            // mnuArquivoNovoVermelho
            // 
            this.mnuArquivoNovoVermelho.Name = "mnuArquivoNovoVermelho";
            this.mnuArquivoNovoVermelho.Size = new System.Drawing.Size(152, 22);
            this.mnuArquivoNovoVermelho.Text = "Vermelho";
            // 
            // mnuArquivoSair
            // 
            this.mnuArquivoSair.Name = "mnuArquivoSair";
            this.mnuArquivoSair.Size = new System.Drawing.Size(152, 22);
            this.mnuArquivoSair.Text = "Sair";
            // 
            // mnuWindows
            // 
            this.mnuWindows.Name = "mnuWindows";
            this.mnuWindows.Size = new System.Drawing.Size(68, 20);
            this.mnuWindows.Text = "Windows";
            // 
            // MenuPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 335);
            this.Controls.Add(this.mn1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mn1;
            this.Name = "MenuPrincipal2";
            this.Text = "MenuPrincipal2";
            this.mn1.ResumeLayout(false);
            this.mn1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip mn1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivoNovo;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivoNovoAzul;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivoNovoVermelho;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem mnuWindows;
    }
}
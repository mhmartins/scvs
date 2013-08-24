namespace SistemaControleVendasSacoles
{
    partial class JanelaEstoque
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
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnaltera = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(578, 238);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(129, 41);
            this.btncadastrar.TabIndex = 0;
            this.btncadastrar.Text = "CADASTRAR";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnaltera
            // 
            this.btnaltera.Location = new System.Drawing.Point(328, 238);
            this.btnaltera.Name = "btnaltera";
            this.btnaltera.Size = new System.Drawing.Size(129, 41);
            this.btnaltera.TabIndex = 1;
            this.btnaltera.Text = "ALTERAR CADASTRO";
            this.btnaltera.UseVisualStyleBackColor = true;
            this.btnaltera.Click += new System.EventHandler(this.btnaltera_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(328, 108);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(129, 41);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(78, 238);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(129, 41);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.Text = "EXCLUIR";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // JanelaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 350);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnaltera);
            this.Controls.Add(this.btncadastrar);
            this.Name = "JanelaEstoque";
            this.Text = "JanelaEstoque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnaltera;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnexcluir;
    }
}
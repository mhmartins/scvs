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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btncadastrar.Location = new System.Drawing.Point(668, 238);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(165, 46);
            this.btncadastrar.TabIndex = 0;
            this.btncadastrar.Text = "CADASTRAR";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnaltera
            // 
            this.btnaltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnaltera.Location = new System.Drawing.Point(418, 220);
            this.btnaltera.Name = "btnaltera";
            this.btnaltera.Size = new System.Drawing.Size(165, 64);
            this.btnaltera.TabIndex = 1;
            this.btnaltera.Text = "ALTERAR CADASTRO";
            this.btnaltera.UseVisualStyleBackColor = true;
            this.btnaltera.Click += new System.EventHandler(this.btnaltera_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnConsultar.Location = new System.Drawing.Point(418, 108);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(165, 46);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnexcluir.Location = new System.Drawing.Point(168, 238);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(165, 46);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.Text = "EXCLUIR";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button1.Location = new System.Drawing.Point(56, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JanelaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnaltera);
            this.Controls.Add(this.btncadastrar);
            this.Name = "JanelaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JanelaEstoque";
            this.Load += new System.EventHandler(this.JanelaEstoque_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnaltera;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button button1;
    }
}
namespace SistemaControleVendasSacoles
{
    partial class CadastroSacoles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxquant = new System.Windows.Forms.TextBox();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxvalor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxquantmin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nupdowtipo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.banco_rr_sacolesDataSet1 = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.tipoTableAdapter();
            this.tableAdapterManager = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipSabor = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupdowtipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Sacolés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sabor:";
            // 
            // tbxnome
            // 
            this.tbxnome.Location = new System.Drawing.Point(325, 129);
            this.tbxnome.Name = "tbxnome";
            this.tbxnome.Size = new System.Drawing.Size(265, 20);
            this.tbxnome.TabIndex = 1;
            this.toolTipSabor.SetToolTip(this.tbxnome, "Insira o sabor do sacolé.");
            this.tbxnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxnome_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantidade:";
            // 
            // tbxquant
            // 
            this.tbxquant.Location = new System.Drawing.Point(325, 184);
            this.tbxquant.Name = "tbxquant";
            this.tbxquant.Size = new System.Drawing.Size(120, 20);
            this.tbxquant.TabIndex = 3;
            this.toolTipSabor.SetToolTip(this.tbxquant, "Insira a quantidade dos Sacolés.");
            this.tbxquant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxquant_KeyPress);
            // 
            // btnCadastra
            // 
            this.btnCadastra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastra.Location = new System.Drawing.Point(546, 277);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(120, 51);
            this.btnCadastra.TabIndex = 5;
            this.btnCadastra.Text = "Cadastrar";
            this.toolTipSabor.SetToolTip(this.btnCadastra, "Para cadastrar clique aqui.");
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(100, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpar";
            this.toolTipSabor.SetToolTip(this.button2, "Clique aqui para limpar os campos do formulário.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(181, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor:";
            // 
            // tbxvalor
            // 
            this.tbxvalor.Location = new System.Drawing.Point(325, 232);
            this.tbxvalor.Name = "tbxvalor";
            this.tbxvalor.Size = new System.Drawing.Size(120, 20);
            this.tbxvalor.TabIndex = 5;
            this.toolTipSabor.SetToolTip(this.tbxvalor, "Insira o valor do sacolé.");
            this.tbxvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxvalor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(178, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quant. Mínima:";
            // 
            // tbxquantmin
            // 
            this.tbxquantmin.Enabled = false;
            this.tbxquantmin.Location = new System.Drawing.Point(325, 208);
            this.tbxquantmin.Name = "tbxquantmin";
            this.tbxquantmin.Size = new System.Drawing.Size(120, 20);
            this.tbxquantmin.TabIndex = 4;
            this.tbxquantmin.Text = "5";
            this.toolTipSabor.SetToolTip(this.tbxquantmin, "Valor pré definido.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(177, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo:";
            // 
            // nupdowtipo
            // 
            this.nupdowtipo.Location = new System.Drawing.Point(325, 155);
            this.nupdowtipo.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupdowtipo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdowtipo.Name = "nupdowtipo";
            this.nupdowtipo.Size = new System.Drawing.Size(37, 20);
            this.nupdowtipo.TabIndex = 13;
            this.toolTipSabor.SetToolTip(this.nupdowtipo, "Escolha o tipo do sacolé.");
            this.nupdowtipo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "1 - Cremoso    2 - Suco";
            // 
            // banco_rr_sacolesDataSet1
            // 
            this.banco_rr_sacolesDataSet1.DataSetName = "banco_rr_sacolesDataSet1";
            this.banco_rr_sacolesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "tipo";
            this.tipoBindingSource.DataSource = this.banco_rr_sacolesDataSet1;
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sacolesitemTableAdapter = null;
            this.tableAdapterManager.sacolesTableAdapter = null;
            this.tableAdapterManager.tipoTableAdapter = this.tipoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "* Todos os campos são obrigatórios.";
            // 
            // CadastroSacoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 402);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nupdowtipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxquantmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxvalor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCadastra);
            this.Controls.Add(this.tbxquant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroSacoles";
            this.Text = "Cadastro de Sacolés - RR Sacolés";
            this.Load += new System.EventHandler(this.CadastroSacoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupdowtipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxquant;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxvalor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxquantmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupdowtipo;
        private System.Windows.Forms.Label label7;
        private banco_rr_sacolesDataSet1 banco_rr_sacolesDataSet1;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private banco_rr_sacolesDataSet1TableAdapters.tipoTableAdapter tipoTableAdapter;
        private banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipSabor;
    }
}
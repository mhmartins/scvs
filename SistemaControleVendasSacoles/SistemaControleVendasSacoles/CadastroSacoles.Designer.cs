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
            this.banco_rr_sacolesDataSet1 = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.tipoTableAdapter();
            this.tableAdapterManager = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipSabor = new System.Windows.Forms.ToolTip(this.components);
            this.banco = new SistemaControleVendasSacoles.banco();
            this.tipoTableAdapter1 = new SistemaControleVendasSacoles.bancoTableAdapters.tipoTableAdapter();
            this.tableAdapterManager1 = new SistemaControleVendasSacoles.bancoTableAdapters.TableAdapterManager();
            this.tipoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nupdowtipo2 = new System.Windows.Forms.ComboBox();
            this.tipoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter1 = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.vendasTableAdapter();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Sacolés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sabor:";
            // 
            // tbxnome
            // 
            this.tbxnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnome.Location = new System.Drawing.Point(459, 107);
            this.tbxnome.Name = "tbxnome";
            this.tbxnome.Size = new System.Drawing.Size(265, 40);
            this.tbxnome.TabIndex = 1;
            this.toolTipSabor.SetToolTip(this.tbxnome, "Insira o sabor do sacolé.");
            this.tbxnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxnome_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantidade:";
            // 
            // tbxquant
            // 
            this.tbxquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxquant.Location = new System.Drawing.Point(459, 221);
            this.tbxquant.Name = "tbxquant";
            this.tbxquant.Size = new System.Drawing.Size(120, 40);
            this.tbxquant.TabIndex = 3;
            this.toolTipSabor.SetToolTip(this.tbxquant, "Insira a quantidade dos Sacolés.");
            this.tbxquant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxquant_KeyPress);
            // 
            // btnCadastra
            // 
            this.btnCadastra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastra.Location = new System.Drawing.Point(727, 435);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(120, 51);
            this.btnCadastra.TabIndex = 5;
            this.btnCadastra.Text = "Cadastrar";
            this.toolTipSabor.SetToolTip(this.btnCadastra, "Para cadastrar clique aqui.");
            this.btnCadastra.UseVisualStyleBackColor = false;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(440, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpar";
            this.toolTipSabor.SetToolTip(this.button2, "Clique aqui para limpar os campos do formulário.");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor:";
            // 
            // tbxvalor
            // 
            this.tbxvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxvalor.Location = new System.Drawing.Point(459, 335);
            this.tbxvalor.Name = "tbxvalor";
            this.tbxvalor.Size = new System.Drawing.Size(120, 40);
            this.tbxvalor.TabIndex = 5;
            this.toolTipSabor.SetToolTip(this.tbxvalor, "Insira o valor do sacolé.");
            this.tbxvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxvalor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quant. Mínima:";
            // 
            // tbxquantmin
            // 
            this.tbxquantmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxquantmin.Location = new System.Drawing.Point(459, 278);
            this.tbxquantmin.Name = "tbxquantmin";
            this.tbxquantmin.Size = new System.Drawing.Size(120, 40);
            this.tbxquantmin.TabIndex = 4;
            this.tbxquantmin.Text = "5";
            this.toolTipSabor.SetToolTip(this.tbxquantmin, "Valor pré definido.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo:";
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
            this.label8.Location = new System.Drawing.Point(239, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "* Todos os campos são obrigatórios.";
            // 
            // banco
            // 
            this.banco.DataSetName = "banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoTableAdapter1
            // 
            this.tipoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.sacolesTableAdapter = null;
            this.tableAdapterManager1.tipoTableAdapter = this.tipoTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = SistemaControleVendasSacoles.bancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usuariosTableAdapter = null;
            this.tableAdapterManager1.vendas_sacolesTableAdapter = null;
            this.tableAdapterManager1.vendasTableAdapter = null;
            // 
            // tipoBindingSource1
            // 
            this.tipoBindingSource1.DataMember = "tipo";
            this.tipoBindingSource1.DataSource = this.banco;
            // 
            // nupdowtipo2
            // 
            this.nupdowtipo2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoBindingSource1, "idtipo", true));
            this.nupdowtipo2.DataSource = this.tipoBindingSource2;
            this.nupdowtipo2.DisplayMember = "tipo";
            this.nupdowtipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdowtipo2.FormattingEnabled = true;
            this.nupdowtipo2.Location = new System.Drawing.Point(459, 164);
            this.nupdowtipo2.Name = "nupdowtipo2";
            this.nupdowtipo2.Size = new System.Drawing.Size(188, 41);
            this.nupdowtipo2.TabIndex = 16;
            this.nupdowtipo2.ValueMember = "idtipo";
            this.nupdowtipo2.SelectedIndexChanged += new System.EventHandler(this.nupdowtipo2_SelectedIndexChanged);
            // 
            // tipoBindingSource2
            // 
            this.tipoBindingSource2.DataMember = "tipo";
            this.tipoBindingSource2.DataSource = this.banco;
            // 
            // vendasTableAdapter1
            // 
            this.vendasTableAdapter1.ClearBeforeFill = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnVoltar.Location = new System.Drawing.Point(154, 427);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 51);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(24, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 18;
            // 
            // CadastroSacoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 533);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.nupdowtipo2);
            this.Controls.Add(this.label8);
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
            this.Location = new System.Drawing.Point(1, 1);
            this.MaximizeBox = false;
            this.Name = "CadastroSacoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Sacolés - RR Sacolés";
            this.Load += new System.EventHandler(this.CadastroSacoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource2)).EndInit();
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
        private banco_rr_sacolesDataSet1 banco_rr_sacolesDataSet1;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private banco_rr_sacolesDataSet1TableAdapters.tipoTableAdapter tipoTableAdapter;
        private banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipSabor;
        private banco banco;
        private bancoTableAdapters.tipoTableAdapter tipoTableAdapter1;
        private bancoTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource tipoBindingSource1;
        private System.Windows.Forms.ComboBox nupdowtipo2;
        private System.Windows.Forms.BindingSource tipoBindingSource2;
        private banco_rr_sacolesDataSet1TableAdapters.vendasTableAdapter vendasTableAdapter1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label7;
    }
}
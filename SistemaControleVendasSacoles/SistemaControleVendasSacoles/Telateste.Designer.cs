namespace SistemaControleVendasSacoles
{
    partial class Telateste
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
            this.AddCre = new System.Windows.Forms.Button();
            this.cmbxsacolescre = new System.Windows.Forms.ComboBox();
            this.vendas_sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new SistemaControleVendasSacoles.banco();
            this.sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxSuco = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskValSuco = new System.Windows.Forms.MaskedTextBox();
            this.addSuco = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mktDesc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.mktTotal = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskValCre = new System.Windows.Forms.MaskedTextBox();
            this.vendas_sacolesTableAdapter = new SistemaControleVendasSacoles.bancoTableAdapters.vendas_sacolesTableAdapter();
            this.tableAdapterManager = new SistemaControleVendasSacoles.bancoTableAdapters.TableAdapterManager();
            this.sacolesTableAdapter = new SistemaControleVendasSacoles.bancoTableAdapters.sacolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCre
            // 
            this.AddCre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCre.Location = new System.Drawing.Point(377, 29);
            this.AddCre.Name = "AddCre";
            this.AddCre.Size = new System.Drawing.Size(104, 37);
            this.AddCre.TabIndex = 0;
            this.AddCre.Text = "Adicionar";
            this.AddCre.UseVisualStyleBackColor = true;
            this.AddCre.Click += new System.EventHandler(this.AddCre_Click);
            // 
            // cmbxsacolescre
            // 
            this.cmbxsacolescre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendas_sacolesBindingSource, "sacoles_idsacoles", true));
            this.cmbxsacolescre.DataSource = this.sacolesBindingSource;
            this.cmbxsacolescre.DisplayMember = "sabor";
            this.cmbxsacolescre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxsacolescre.FormattingEnabled = true;
            this.cmbxsacolescre.Location = new System.Drawing.Point(16, 29);
            this.cmbxsacolescre.Name = "cmbxsacolescre";
            this.cmbxsacolescre.Size = new System.Drawing.Size(209, 33);
            this.cmbxsacolescre.TabIndex = 1;
            this.cmbxsacolescre.ValueMember = "idSacoles";
            this.cmbxsacolescre.SelectedIndexChanged += new System.EventHandler(this.cmbxsacolescre_SelectedIndexChanged);
            // 
            // vendas_sacolesBindingSource
            // 
            this.vendas_sacolesBindingSource.DataMember = "vendas_sacoles";
            this.vendas_sacolesBindingSource.DataSource = this.banco;
            // 
            // banco
            // 
            this.banco.DataSetName = "banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sacolesBindingSource
            // 
            this.sacolesBindingSource.DataMember = "sacoles";
            this.sacolesBindingSource.DataSource = this.banco;
            // 
            // cbxSuco
            // 
            this.cbxSuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSuco.FormattingEnabled = true;
            this.cbxSuco.Items.AddRange(new object[] {
            "TESTANDO",
            "UVA"});
            this.cbxSuco.Location = new System.Drawing.Point(16, 115);
            this.cbxSuco.Name = "cbxSuco";
            this.cbxSuco.Size = new System.Drawing.Size(209, 33);
            this.cbxSuco.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cremoso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suco";
            // 
            // mskValSuco
            // 
            this.mskValSuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValSuco.Location = new System.Drawing.Point(252, 117);
            this.mskValSuco.Mask = "$0.00";
            this.mskValSuco.Name = "mskValSuco";
            this.mskValSuco.Size = new System.Drawing.Size(100, 31);
            this.mskValSuco.TabIndex = 6;
            // 
            // addSuco
            // 
            this.addSuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSuco.Location = new System.Drawing.Point(377, 115);
            this.addSuco.Name = "addSuco";
            this.addSuco.Size = new System.Drawing.Size(104, 37);
            this.addSuco.TabIndex = 7;
            this.addSuco.Text = "Adicionar";
            this.addSuco.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 223);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mktDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSomar);
            this.groupBox1.Controls.Add(this.mktTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(521, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 282);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Financeiros";
            // 
            // mktDesc
            // 
            this.mktDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktDesc.Location = new System.Drawing.Point(192, 33);
            this.mktDesc.Mask = "$__.__";
            this.mktDesc.Name = "mktDesc";
            this.mktDesc.Size = new System.Drawing.Size(100, 31);
            this.mktDesc.TabIndex = 19;
            this.mktDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Desconto na venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "TOTAL";
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(142, 105);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(150, 36);
            this.btnSomar.TabIndex = 17;
            this.btnSomar.Text = "Calcular Total";
            this.btnSomar.UseVisualStyleBackColor = true;
            // 
            // mktTotal
            // 
            this.mktTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktTotal.Location = new System.Drawing.Point(122, 178);
            this.mktTotal.Mask = "$00.00";
            this.mktTotal.Name = "mktTotal";
            this.mktTotal.Size = new System.Drawing.Size(264, 80);
            this.mktTotal.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(462, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(761, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 37);
            this.button5.TabIndex = 11;
            this.button5.Text = "Finalizar Venda";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1025, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor";
            // 
            // mskValCre
            // 
            this.mskValCre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "preco", true));
            this.mskValCre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValCre.Location = new System.Drawing.Point(252, 31);
            this.mskValCre.Mask = "$0.00";
            this.mskValCre.Name = "mskValCre";
            this.mskValCre.Size = new System.Drawing.Size(100, 31);
            this.mskValCre.TabIndex = 15;
            // 
            // vendas_sacolesTableAdapter
            // 
            this.vendas_sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sacolesTableAdapter = this.sacolesTableAdapter;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaControleVendasSacoles.bancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendas_sacolesTableAdapter = this.vendas_sacolesTableAdapter;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // sacolesTableAdapter
            // 
            this.sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // Telateste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 473);
            this.Controls.Add(this.mskValCre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addSuco);
            this.Controls.Add(this.mskValSuco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSuco);
            this.Controls.Add(this.cmbxsacolescre);
            this.Controls.Add(this.AddCre);
            this.Name = "Telateste";
            this.Text = "Tela de Vendas";
            this.Load += new System.EventHandler(this.Telateste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCre;
        private System.Windows.Forms.ComboBox cmbxsacolescre;
        private System.Windows.Forms.ComboBox cbxSuco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskValSuco;
        private System.Windows.Forms.Button addSuco;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mktDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.MaskedTextBox mktTotal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskValCre;
        private banco banco;
        private System.Windows.Forms.BindingSource vendas_sacolesBindingSource;
        private bancoTableAdapters.vendas_sacolesTableAdapter vendas_sacolesTableAdapter;
        private bancoTableAdapters.TableAdapterManager tableAdapterManager;
        private bancoTableAdapters.sacolesTableAdapter sacolesTableAdapter;
        private System.Windows.Forms.BindingSource sacolesBindingSource;

    }
}
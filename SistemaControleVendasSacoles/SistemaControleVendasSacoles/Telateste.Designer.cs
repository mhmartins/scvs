﻿namespace SistemaControleVendasSacoles
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
            this.cbxSuco = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskValSuco = new System.Windows.Forms.MaskedTextBox();
            this.addSuco = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mktTotal = new System.Windows.Forms.MaskedTextBox();
            this.mktDesc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nupdowCre = new System.Windows.Forms.NumericUpDown();
            this.nupdowSuc = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnIni = new System.Windows.Forms.Button();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mktValorCremoso = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdowCre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdowSuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCre
            // 
            this.AddCre.Enabled = false;
            this.AddCre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCre.Location = new System.Drawing.Point(500, 106);
            this.AddCre.Name = "AddCre";
            this.AddCre.Size = new System.Drawing.Size(104, 37);
            this.AddCre.TabIndex = 0;
            this.AddCre.Text = "Adicionar";
            this.toolTip1.SetToolTip(this.AddCre, "Clique para adicionar o sabor");
            this.AddCre.UseVisualStyleBackColor = true;
            this.AddCre.Click += new System.EventHandler(this.AddCre_Click);
            // 
            // cmbxsacolescre
            // 
            this.cmbxsacolescre.DisplayMember = "idSacoles";
            this.cmbxsacolescre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxsacolescre.FormattingEnabled = true;
            this.cmbxsacolescre.Location = new System.Drawing.Point(12, 106);
            this.cmbxsacolescre.Name = "cmbxsacolescre";
            this.cmbxsacolescre.Size = new System.Drawing.Size(209, 33);
            this.cmbxsacolescre.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbxsacolescre, "Selecione um sabor");
            this.cmbxsacolescre.ValueMember = "idSacoles";
            this.cmbxsacolescre.SelectedIndexChanged += new System.EventHandler(this.cmbxsacolescre_SelectedIndexChanged);
            // 
            // cbxSuco
            // 
            this.cbxSuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSuco.FormattingEnabled = true;
            this.cbxSuco.Location = new System.Drawing.Point(12, 194);
            this.cbxSuco.Name = "cbxSuco";
            this.cbxSuco.Size = new System.Drawing.Size(209, 33);
            this.cbxSuco.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbxSuco, "Selecione um sabor");
            this.cbxSuco.SelectedIndexChanged += new System.EventHandler(this.cbxSuco_SelectedIndexChanged);
            this.cbxSuco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSuco_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cremoso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suco";
            // 
            // mskValSuco
            // 
            this.mskValSuco.Enabled = false;
            this.mskValSuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValSuco.Location = new System.Drawing.Point(375, 194);
            this.mskValSuco.Name = "mskValSuco";
            this.mskValSuco.Size = new System.Drawing.Size(100, 31);
            this.mskValSuco.TabIndex = 6;
            this.toolTip1.SetToolTip(this.mskValSuco, "Valor do sacolé");
            // 
            // addSuco
            // 
            this.addSuco.Enabled = false;
            this.addSuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSuco.Location = new System.Drawing.Point(500, 192);
            this.addSuco.Name = "addSuco";
            this.addSuco.Size = new System.Drawing.Size(104, 37);
            this.addSuco.TabIndex = 7;
            this.addSuco.Text = "Adicionar";
            this.toolTip1.SetToolTip(this.addSuco, "Clique para adicionar o sabor");
            this.addSuco.UseVisualStyleBackColor = true;
            this.addSuco.Click += new System.EventHandler(this.addSuco_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mktTotal);
            this.groupBox1.Controls.Add(this.mktDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSomar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(610, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 282);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Financeiros";
            // 
            // mktTotal
            // 
            this.mktTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.mktTotal.Location = new System.Drawing.Point(110, 179);
            this.mktTotal.Name = "mktTotal";
            this.mktTotal.Size = new System.Drawing.Size(264, 80);
            this.mktTotal.TabIndex = 21;
            this.mktTotal.Text = "0";
            this.mktTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.mktTotal, "Valor total da venda");
            // 
            // mktDesc
            // 
            this.mktDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktDesc.Location = new System.Drawing.Point(192, 33);
            this.mktDesc.Name = "mktDesc";
            this.mktDesc.Size = new System.Drawing.Size(100, 31);
            this.mktDesc.TabIndex = 19;
            this.mktDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.mktDesc, "Digite o valor para desconto");
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
            this.toolTip1.SetToolTip(this.btnSomar, "Clique para calcular o total com desconto");
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(512, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "Limpar";
            this.toolTip1.SetToolTip(this.button4, "Clique para limpar todos os campos");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(761, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 37);
            this.button5.TabIndex = 11;
            this.button5.Text = "Finalizar Venda";
            this.toolTip1.SetToolTip(this.button5, "Clique para finalizar a venda");
            this.button5.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1033, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor";
            // 
            // nupdowCre
            // 
            this.nupdowCre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nupdowCre.Location = new System.Drawing.Point(244, 108);
            this.nupdowCre.Name = "nupdowCre";
            this.nupdowCre.Size = new System.Drawing.Size(58, 31);
            this.nupdowCre.TabIndex = 16;
            this.toolTip1.SetToolTip(this.nupdowCre, "Selecione a quantidade");
            // 
            // nupdowSuc
            // 
            this.nupdowSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nupdowSuc.Location = new System.Drawing.Point(244, 192);
            this.nupdowSuc.Name = "nupdowSuc";
            this.nupdowSuc.Size = new System.Drawing.Size(58, 31);
            this.nupdowSuc.TabIndex = 17;
            this.toolTip1.SetToolTip(this.nupdowSuc, "Selecione uma quantidade");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(240, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.Location = new System.Drawing.Point(240, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quantidade";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 244);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(463, 223);
            this.dgv.TabIndex = 28;
            // 
            // btnIni
            // 
            this.btnIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnIni.Location = new System.Drawing.Point(500, 25);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(104, 37);
            this.btnIni.TabIndex = 31;
            this.btnIni.Text = "Adicionar";
            this.toolTip1.SetToolTip(this.btnIni, "Clique para inciar a venda");
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // cbxUser
            // 
            this.cbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(12, 29);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(209, 33);
            this.cbxUser.TabIndex = 32;
            this.toolTip1.SetToolTip(this.cbxUser, "Escolha o seu nome");
            this.cbxUser.SelectedIndexChanged += new System.EventHandler(this.cbxUser_SelectedIndexChanged_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.Location = new System.Drawing.Point(8, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Vendedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.Location = new System.Drawing.Point(240, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Data";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBox1.Location = new System.Drawing.Point(244, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 31);
            this.textBox1.TabIndex = 35;
            this.toolTip1.SetToolTip(this.textBox1, "Data de hoje");
            // 
            // mktValorCremoso
            // 
            this.mktValorCremoso.Enabled = false;
            this.mktValorCremoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.mktValorCremoso.Location = new System.Drawing.Point(375, 108);
            this.mktValorCremoso.Name = "mktValorCremoso";
            this.mktValorCremoso.Size = new System.Drawing.Size(100, 31);
            this.mktValorCremoso.TabIndex = 37;
            this.toolTip1.SetToolTip(this.mktValorCremoso, "Valor do sacolé");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(309, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 38;
            this.label13.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 486);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "18";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(248, 486);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 40;
            // 
            // Telateste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 541);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mktValorCremoso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.btnIni);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nupdowSuc);
            this.Controls.Add(this.nupdowCre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addSuco);
            this.Controls.Add(this.mskValSuco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSuco);
            this.Controls.Add(this.cmbxsacolescre);
            this.Controls.Add(this.AddCre);
            this.Name = "Telateste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Vendas";
            this.Load += new System.EventHandler(this.Telateste_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdowCre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdowSuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mktDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupdowCre;
        private System.Windows.Forms.NumericUpDown nupdowSuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox mktTotal;
        private System.Windows.Forms.MaskedTextBox mktValorCremoso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;

    }
}
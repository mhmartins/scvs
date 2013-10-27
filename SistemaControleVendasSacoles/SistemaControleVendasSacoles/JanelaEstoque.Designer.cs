namespace SistemaControleVendasSacoles
{
    partial class PesquisaPersonalizada
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnConsultarMes = new System.Windows.Forms.Button();
            this.nupdowAno = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nupdowANOpesq = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultaPeriodo = new System.Windows.Forms.Button();
            this.btnConsultaAno = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAte = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelBruto = new System.Windows.Forms.Label();
            this.labelLiquido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCusto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupdowAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdowANOpesq)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mês";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 35);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "11111111";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(205, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 35);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "20131027";
            // 
            // btnConsultarMes
            // 
            this.btnConsultarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMes.Location = new System.Drawing.Point(372, 152);
            this.btnConsultarMes.Name = "btnConsultarMes";
            this.btnConsultarMes.Size = new System.Drawing.Size(126, 35);
            this.btnConsultarMes.TabIndex = 12;
            this.btnConsultarMes.Text = "Consultar";
            this.btnConsultarMes.UseVisualStyleBackColor = true;
            this.btnConsultarMes.Click += new System.EventHandler(this.button2_Click);
            // 
            // nupdowAno
            // 
            this.nupdowAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdowAno.Location = new System.Drawing.Point(226, 149);
            this.nupdowAno.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.nupdowAno.Minimum = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            this.nupdowAno.Name = "nupdowAno";
            this.nupdowAno.Size = new System.Drawing.Size(120, 38);
            this.nupdowAno.TabIndex = 14;
            this.nupdowAno.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox1.Location = new System.Drawing.Point(6, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 39);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Período";
            // 
            // nupdowANOpesq
            // 
            this.nupdowANOpesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdowANOpesq.Location = new System.Drawing.Point(6, 226);
            this.nupdowANOpesq.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.nupdowANOpesq.Minimum = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            this.nupdowANOpesq.Name = "nupdowANOpesq";
            this.nupdowANOpesq.Size = new System.Drawing.Size(120, 38);
            this.nupdowANOpesq.TabIndex = 17;
            this.nupdowANOpesq.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ano";
            // 
            // btnConsultaPeriodo
            // 
            this.btnConsultaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPeriodo.Location = new System.Drawing.Point(372, 67);
            this.btnConsultaPeriodo.Name = "btnConsultaPeriodo";
            this.btnConsultaPeriodo.Size = new System.Drawing.Size(126, 35);
            this.btnConsultaPeriodo.TabIndex = 19;
            this.btnConsultaPeriodo.Text = "Consultar";
            this.btnConsultaPeriodo.UseVisualStyleBackColor = true;
            this.btnConsultaPeriodo.Click += new System.EventHandler(this.btnConsultaPeriodo_Click);
            // 
            // btnConsultaAno
            // 
            this.btnConsultaAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaAno.Location = new System.Drawing.Point(372, 234);
            this.btnConsultaAno.Name = "btnConsultaAno";
            this.btnConsultaAno.Size = new System.Drawing.Size(126, 35);
            this.btnConsultaAno.TabIndex = 20;
            this.btnConsultaAno.Text = "Consultar";
            this.btnConsultaAno.UseVisualStyleBackColor = true;
            this.btnConsultaAno.Click += new System.EventHandler(this.btnConsultaAno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelAte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConsultaAno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConsultaPeriodo);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.nupdowANOpesq);
            this.groupBox1.Controls.Add(this.btnConsultarMes);
            this.groupBox1.Controls.Add(this.nupdowAno);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 291);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o período";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "de";
            // 
            // labelAte
            // 
            this.labelAte.AutoSize = true;
            this.labelAte.Location = new System.Drawing.Point(153, 67);
            this.labelAte.Name = "labelAte";
            this.labelAte.Size = new System.Drawing.Size(46, 29);
            this.labelAte.TabIndex = 21;
            this.labelAte.Text = "até";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.labelBruto);
            this.groupBox2.Controls.Add(this.labelLiquido);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelCusto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(609, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 291);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 29);
            this.label12.TabIndex = 8;
            this.label12.Text = "R$";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "R$";
            this.label11.Visible = false;
            // 
            // labelBruto
            // 
            this.labelBruto.AutoSize = true;
            this.labelBruto.Location = new System.Drawing.Point(53, 143);
            this.labelBruto.Name = "labelBruto";
            this.labelBruto.Size = new System.Drawing.Size(113, 29);
            this.labelBruto.TabIndex = 6;
            this.labelBruto.Text = "resultado";
            this.labelBruto.Visible = false;
            // 
            // labelLiquido
            // 
            this.labelLiquido.AutoSize = true;
            this.labelLiquido.Location = new System.Drawing.Point(53, 223);
            this.labelLiquido.Name = "labelLiquido";
            this.labelLiquido.Size = new System.Drawing.Size(113, 29);
            this.labelLiquido.TabIndex = 5;
            this.labelLiquido.Text = "resultado";
            this.labelLiquido.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "R$";
            this.label8.Visible = false;
            // 
            // labelCusto
            // 
            this.labelCusto.AutoSize = true;
            this.labelCusto.Location = new System.Drawing.Point(53, 73);
            this.labelCusto.Name = "labelCusto";
            this.labelCusto.Size = new System.Drawing.Size(113, 29);
            this.labelCusto.TabIndex = 3;
            this.labelCusto.Text = "resultado";
            this.labelCusto.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lucro Bruto";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lucro Líquido";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Custo de produção estimado";
            this.label4.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(552, 37);
            this.label7.TabIndex = 23;
            this.label7.Text = "Pesquisa Financeira Personalizada";
            // 
            // PesquisaPersonalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 533);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PesquisaPersonalizada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Personalizada";
            this.Load += new System.EventHandler(this.JanelaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupdowAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdowANOpesq)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnConsultarMes;
        private System.Windows.Forms.NumericUpDown nupdowAno;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupdowANOpesq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultaPeriodo;
        private System.Windows.Forms.Button btnConsultaAno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelBruto;
        private System.Windows.Forms.Label labelLiquido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAte;
        private System.Windows.Forms.Label label7;
    }
}
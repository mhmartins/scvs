namespace SistemaControleVendasSacoles
{
    partial class AlterareExcluir
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
            System.Windows.Forms.Label idSacolesLabel;
            System.Windows.Forms.Label saborLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label quantLabel;
            System.Windows.Forms.Label quantminLabel;
            System.Windows.Forms.Label precoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterareExcluir));
            this.banco_rr_sacolesDataSet1 = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1();
            this.sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sacolesTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.sacolesTableAdapter();
            this.tableAdapterManager = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager();
            this.idSacolesLabel1 = new System.Windows.Forms.Label();
            this.saborTextBox = new System.Windows.Forms.TextBox();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantTextBox = new System.Windows.Forms.TextBox();
            this.quantminTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.tipoTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.tipoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            idSacolesLabel = new System.Windows.Forms.Label();
            saborLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            quantLabel = new System.Windows.Forms.Label();
            quantminLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idSacolesLabel
            // 
            idSacolesLabel.AutoSize = true;
            idSacolesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            idSacolesLabel.Location = new System.Drawing.Point(246, 109);
            idSacolesLabel.Name = "idSacolesLabel";
            idSacolesLabel.Size = new System.Drawing.Size(122, 33);
            idSacolesLabel.TabIndex = 1;
            idSacolesLabel.Text = "Código:";
            // 
            // saborLabel
            // 
            saborLabel.AutoSize = true;
            saborLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            saborLabel.Location = new System.Drawing.Point(246, 163);
            saborLabel.Name = "saborLabel";
            saborLabel.Size = new System.Drawing.Size(106, 33);
            saborLabel.TabIndex = 3;
            saborLabel.Text = "Sabor:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            tipoLabel.Location = new System.Drawing.Point(246, 217);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(85, 33);
            tipoLabel.TabIndex = 5;
            tipoLabel.Text = "Tipo:";
            // 
            // quantLabel
            // 
            quantLabel.AutoSize = true;
            quantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            quantLabel.Location = new System.Drawing.Point(246, 271);
            quantLabel.Name = "quantLabel";
            quantLabel.Size = new System.Drawing.Size(184, 33);
            quantLabel.TabIndex = 7;
            quantLabel.Text = "Quantidade:";
            // 
            // quantminLabel
            // 
            quantminLabel.AutoSize = true;
            quantminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            quantminLabel.Location = new System.Drawing.Point(246, 325);
            quantminLabel.Name = "quantminLabel";
            quantminLabel.Size = new System.Drawing.Size(294, 33);
            quantminLabel.TabIndex = 9;
            quantminLabel.Text = "Quantidade Mínima:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            precoLabel.Location = new System.Drawing.Point(246, 379);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(97, 33);
            precoLabel.TabIndex = 11;
            precoLabel.Text = "Valor:";
            // 
            // banco_rr_sacolesDataSet1
            // 
            this.banco_rr_sacolesDataSet1.DataSetName = "banco_rr_sacolesDataSet1";
            this.banco_rr_sacolesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sacolesBindingSource
            // 
            this.sacolesBindingSource.DataMember = "sacoles";
            this.sacolesBindingSource.DataSource = this.banco_rr_sacolesDataSet1;
            // 
            // sacolesTableAdapter
            // 
            this.sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sacolesitemTableAdapter = null;
            this.tableAdapterManager.sacolesTableAdapter = this.sacolesTableAdapter;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // idSacolesLabel1
            // 
            this.idSacolesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "idSacoles", true));
            this.idSacolesLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.idSacolesLabel1.Location = new System.Drawing.Point(585, 109);
            this.idSacolesLabel1.Name = "idSacolesLabel1";
            this.idSacolesLabel1.Size = new System.Drawing.Size(239, 40);
            this.idSacolesLabel1.TabIndex = 2;
            // 
            // saborTextBox
            // 
            this.saborTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "sabor", true));
            this.saborTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saborTextBox.Location = new System.Drawing.Point(585, 160);
            this.saborTextBox.Name = "saborTextBox";
            this.saborTextBox.Size = new System.Drawing.Size(239, 40);
            this.saborTextBox.TabIndex = 4;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sacolesBindingSource, "tipo", true));
            this.tipoComboBox.DataSource = this.tipoBindingSource;
            this.tipoComboBox.DisplayMember = "tipo";
            this.tipoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(585, 214);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(239, 41);
            this.tipoComboBox.TabIndex = 6;
            this.tipoComboBox.ValueMember = "idtipo";
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "tipo";
            this.tipoBindingSource.DataSource = this.banco_rr_sacolesDataSet1;
            // 
            // quantTextBox
            // 
            this.quantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "quant", true));
            this.quantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.quantTextBox.Location = new System.Drawing.Point(585, 268);
            this.quantTextBox.Name = "quantTextBox";
            this.quantTextBox.Size = new System.Drawing.Size(100, 40);
            this.quantTextBox.TabIndex = 8;
            // 
            // quantminTextBox
            // 
            this.quantminTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "quantmin", true));
            this.quantminTextBox.Enabled = false;
            this.quantminTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.quantminTextBox.Location = new System.Drawing.Point(585, 322);
            this.quantminTextBox.Name = "quantminTextBox";
            this.quantminTextBox.Size = new System.Drawing.Size(100, 40);
            this.quantminTextBox.TabIndex = 10;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "preco", true));
            this.precoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.precoTextBox.Location = new System.Drawing.Point(585, 376);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 40);
            this.precoTextBox.TabIndex = 12;
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Editar Cadastro";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button1.Location = new System.Drawing.Point(726, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.sacolesBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.CountItemFormat = "de {0}";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1001, 46);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(91, 43);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(377, 43);
            this.toolStripLabel2.Text = "                                             ";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 46);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 46);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 46);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 46);
            // 
            // AlterareExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 533);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(precoLabel);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(quantminLabel);
            this.Controls.Add(this.quantminTextBox);
            this.Controls.Add(quantLabel);
            this.Controls.Add(this.quantTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(saborLabel);
            this.Controls.Add(this.saborTextBox);
            this.Controls.Add(idSacolesLabel);
            this.Controls.Add(this.idSacolesLabel1);
            this.Name = "AlterareExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cadastro dos Sacolés do Estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private banco_rr_sacolesDataSet1 banco_rr_sacolesDataSet1;
        private System.Windows.Forms.BindingSource sacolesBindingSource;
        private banco_rr_sacolesDataSet1TableAdapters.sacolesTableAdapter sacolesTableAdapter;
        private banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idSacolesLabel1;
        private System.Windows.Forms.TextBox saborTextBox;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.TextBox quantTextBox;
        private System.Windows.Forms.TextBox quantminTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private banco_rr_sacolesDataSet1TableAdapters.tipoTableAdapter tipoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}
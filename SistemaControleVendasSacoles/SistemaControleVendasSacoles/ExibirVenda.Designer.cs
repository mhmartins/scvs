﻿namespace SistemaControleVendasSacoles
{
    partial class ExibirVenda
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
            System.Windows.Forms.Label idvendasLabel;
            System.Windows.Forms.Label usuarios_idusuariosLabel;
            System.Windows.Forms.Label dataLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExibirVenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exibir_venda = new SistemaControleVendasSacoles.exibir_venda();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new SistemaControleVendasSacoles.exibir_vendaTableAdapters.vendasTableAdapter();
            this.tableAdapterManager = new SistemaControleVendasSacoles.exibir_vendaTableAdapters.TableAdapterManager();
            this.ProdutosTableAdapter = new SistemaControleVendasSacoles.exibir_vendaTableAdapters.sacolesTableAdapter();
            this.vendas_sacolesTableAdapter = new SistemaControleVendasSacoles.exibir_vendaTableAdapters.vendas_sacolesTableAdapter();
            this.vendasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idvendasTextBox = new System.Windows.Forms.TextBox();
            this.usuarios_idusuariosComboBox = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vendas_sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendas_sacolesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosTableAdapter = new SistemaControleVendasSacoles.exibir_vendaTableAdapters.usuariosTableAdapter();
            idvendasLabel = new System.Windows.Forms.Label();
            usuarios_idusuariosLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exibir_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingNavigator)).BeginInit();
            this.vendasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idvendasLabel
            // 
            idvendasLabel.AutoSize = true;
            idvendasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idvendasLabel.Location = new System.Drawing.Point(766, 216);
            idvendasLabel.Name = "idvendasLabel";
            idvendasLabel.Size = new System.Drawing.Size(131, 31);
            idvendasLabel.TabIndex = 1;
            idvendasLabel.Text = "idvendas:";
            idvendasLabel.Visible = false;
            // 
            // usuarios_idusuariosLabel
            // 
            usuarios_idusuariosLabel.AutoSize = true;
            usuarios_idusuariosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarios_idusuariosLabel.Location = new System.Drawing.Point(348, 66);
            usuarios_idusuariosLabel.Name = "usuarios_idusuariosLabel";
            usuarios_idusuariosLabel.Size = new System.Drawing.Size(139, 31);
            usuarios_idusuariosLabel.TabIndex = 3;
            usuarios_idusuariosLabel.Text = "Vendedor:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.Location = new System.Drawing.Point(348, 109);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(80, 31);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data:";
            // 
            // exibir_venda
            // 
            this.exibir_venda.DataSetName = "exibir_venda";
            this.exibir_venda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.exibir_venda;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sacolesTableAdapter = this.ProdutosTableAdapter;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaControleVendasSacoles.exibir_vendaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendas_sacolesTableAdapter = this.vendas_sacolesTableAdapter;
            this.tableAdapterManager.vendasTableAdapter = this.vendasTableAdapter;
            // 
            // ProdutosTableAdapter
            // 
            this.ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // vendas_sacolesTableAdapter
            // 
            this.vendas_sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // vendasBindingNavigator
            // 
            this.vendasBindingNavigator.AddNewItem = null;
            this.vendasBindingNavigator.BindingSource = this.vendasBindingSource;
            this.vendasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendasBindingNavigator.CountItemFormat = "de {0}";
            this.vendasBindingNavigator.DeleteItem = null;
            this.vendasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.vendasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendasBindingNavigator.Name = "vendasBindingNavigator";
            this.vendasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendasBindingNavigator.Size = new System.Drawing.Size(1033, 29);
            this.vendasBindingNavigator.TabIndex = 0;
            this.vendasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(379, 26);
            this.toolStripLabel1.Text = "                                                                                 " +
    "                                           ";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 29);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // idvendasTextBox
            // 
            this.idvendasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "idvendas", true));
            this.idvendasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idvendasTextBox.Location = new System.Drawing.Point(901, 213);
            this.idvendasTextBox.Name = "idvendasTextBox";
            this.idvendasTextBox.Size = new System.Drawing.Size(121, 38);
            this.idvendasTextBox.TabIndex = 2;
            this.idvendasTextBox.Visible = false;
            // 
            // usuarios_idusuariosComboBox
            // 
            this.usuarios_idusuariosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendasBindingSource, "usuarios_idusuarios", true));
            this.usuarios_idusuariosComboBox.DataSource = this.usuariosBindingSource;
            this.usuarios_idusuariosComboBox.DisplayMember = "nome";
            this.usuarios_idusuariosComboBox.Enabled = false;
            this.usuarios_idusuariosComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarios_idusuariosComboBox.FormattingEnabled = true;
            this.usuarios_idusuariosComboBox.Location = new System.Drawing.Point(493, 63);
            this.usuarios_idusuariosComboBox.Name = "usuarios_idusuariosComboBox";
            this.usuarios_idusuariosComboBox.Size = new System.Drawing.Size(191, 39);
            this.usuarios_idusuariosComboBox.TabIndex = 4;
            this.usuarios_idusuariosComboBox.ValueMember = "idusuarios";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.exibir_venda;
            // 
            // dataMaskedTextBox
            // 
            this.dataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "data", true));
            this.dataMaskedTextBox.Enabled = false;
            this.dataMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataMaskedTextBox.Location = new System.Drawing.Point(493, 106);
            this.dataMaskedTextBox.Name = "dataMaskedTextBox";
            this.dataMaskedTextBox.Size = new System.Drawing.Size(191, 38);
            this.dataMaskedTextBox.TabIndex = 6;
            // 
            // vendas_sacolesBindingSource
            // 
            this.vendas_sacolesBindingSource.DataMember = "valor";
            this.vendas_sacolesBindingSource.DataSource = this.vendasBindingSource;
            // 
            // vendas_sacolesDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.vendas_sacolesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vendas_sacolesDataGridView.AutoGenerateColumns = false;
            this.vendas_sacolesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vendas_sacolesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.vendas_sacolesDataGridView.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendas_sacolesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.vendas_sacolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendas_sacolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vendas_sacolesDataGridView.DataSource = this.vendas_sacolesBindingSource;
            this.vendas_sacolesDataGridView.Location = new System.Drawing.Point(291, 165);
            this.vendas_sacolesDataGridView.Name = "vendas_sacolesDataGridView";
            this.vendas_sacolesDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.vendas_sacolesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.vendas_sacolesDataGridView.Size = new System.Drawing.Size(450, 277);
            this.vendas_sacolesDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "vendas_sacID";
            this.dataGridViewTextBoxColumn1.HeaderText = "vendas_sacID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "vendas_idvendas";
            this.dataGridViewTextBoxColumn2.HeaderText = "N. da Venda";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 122;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sacoles_idsacoles";
            this.dataGridViewTextBoxColumn3.DataSource = this.ProdutosBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "sabor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sacolés";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "idSacoles";
            this.dataGridViewTextBoxColumn3.Width = 91;
            // 
            // ProdutosBindingSource
            // 
            this.ProdutosBindingSource.DataMember = "sacoles";
            this.ProdutosBindingSource.DataSource = this.exibir_venda;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 117;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 71;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // ExibirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 541);
            this.Controls.Add(this.vendas_sacolesDataGridView);
            this.Controls.Add(idvendasLabel);
            this.Controls.Add(this.idvendasTextBox);
            this.Controls.Add(usuarios_idusuariosLabel);
            this.Controls.Add(this.usuarios_idusuariosComboBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataMaskedTextBox);
            this.Controls.Add(this.vendasBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "ExibirVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar as Vendas Efetuadas";
            this.Load += new System.EventHandler(this.ExibirVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exibir_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingNavigator)).EndInit();
            this.vendasBindingNavigator.ResumeLayout(false);
            this.vendasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private exibir_venda exibir_venda;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private exibir_vendaTableAdapters.vendasTableAdapter vendasTableAdapter;
        private exibir_vendaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendasBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private exibir_vendaTableAdapters.vendas_sacolesTableAdapter vendas_sacolesTableAdapter;
        private System.Windows.Forms.TextBox idvendasTextBox;
        private System.Windows.Forms.ComboBox usuarios_idusuariosComboBox;
        private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
        private System.Windows.Forms.BindingSource vendas_sacolesBindingSource;
        private exibir_vendaTableAdapters.sacolesTableAdapter ProdutosTableAdapter;
        private System.Windows.Forms.DataGridView vendas_sacolesDataGridView;
        private System.Windows.Forms.BindingSource ProdutosBindingSource;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private exibir_vendaTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
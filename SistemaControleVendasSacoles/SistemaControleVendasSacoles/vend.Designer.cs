namespace SistemaControleVendasSacoles
{
    partial class vend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vend));
            this.banco = new SistemaControleVendasSacoles.banco();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new SistemaControleVendasSacoles.bancoTableAdapters.vendasTableAdapter();
            this.tableAdapterManager = new SistemaControleVendasSacoles.bancoTableAdapters.TableAdapterManager();
            this.usuariosTableAdapter = new SistemaControleVendasSacoles.bancoTableAdapters.usuariosTableAdapter();
            this.vendas_sacolesTableAdapter = new SistemaControleVendasSacoles.bancoTableAdapters.vendas_sacolesTableAdapter();
            this.vendasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vendasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idvendasTextBox = new System.Windows.Forms.TextBox();
            this.usuarios_idusuariosComboBox = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vendas_sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sacolesTableAdapter = new SistemaControleVendasSacoles.bancoTableAdapters.sacolesTableAdapter();
            this.vendas_sacolesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SacoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            idvendasLabel = new System.Windows.Forms.Label();
            usuarios_idusuariosLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingNavigator)).BeginInit();
            this.vendasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SacoleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idvendasLabel
            // 
            idvendasLabel.AutoSize = true;
            idvendasLabel.Location = new System.Drawing.Point(139, 49);
            idvendasLabel.Name = "idvendasLabel";
            idvendasLabel.Size = new System.Drawing.Size(79, 13);
            idvendasLabel.TabIndex = 1;
            idvendasLabel.Text = "Venda número:";
            // 
            // usuarios_idusuariosLabel
            // 
            usuarios_idusuariosLabel.AutoSize = true;
            usuarios_idusuariosLabel.Location = new System.Drawing.Point(139, 75);
            usuarios_idusuariosLabel.Name = "usuarios_idusuariosLabel";
            usuarios_idusuariosLabel.Size = new System.Drawing.Size(46, 13);
            usuarios_idusuariosLabel.TabIndex = 3;
            usuarios_idusuariosLabel.Text = "Usuário:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(139, 102);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data:";
            // 
            // banco
            // 
            this.banco.DataSetName = "banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.banco;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sacolesTableAdapter = null;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaControleVendasSacoles.bancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            this.tableAdapterManager.vendas_sacolesTableAdapter = this.vendas_sacolesTableAdapter;
            this.tableAdapterManager.vendasTableAdapter = this.vendasTableAdapter;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // vendas_sacolesTableAdapter
            // 
            this.vendas_sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // vendasBindingNavigator
            // 
            this.vendasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendasBindingNavigator.BindingSource = this.vendasBindingSource;
            this.vendasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vendasBindingNavigatorSaveItem});
            this.vendasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendasBindingNavigator.Name = "vendasBindingNavigator";
            this.vendasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendasBindingNavigator.Size = new System.Drawing.Size(614, 25);
            this.vendasBindingNavigator.TabIndex = 0;
            this.vendasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vendasBindingNavigatorSaveItem
            // 
            this.vendasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendasBindingNavigatorSaveItem.Image")));
            this.vendasBindingNavigatorSaveItem.Name = "vendasBindingNavigatorSaveItem";
            this.vendasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendasBindingNavigatorSaveItem.Text = "Save Data";
            this.vendasBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendasBindingNavigatorSaveItem_Click);
            // 
            // idvendasTextBox
            // 
            this.idvendasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "idvendas", true));
            this.idvendasTextBox.Location = new System.Drawing.Point(244, 46);
            this.idvendasTextBox.Name = "idvendasTextBox";
            this.idvendasTextBox.Size = new System.Drawing.Size(121, 20);
            this.idvendasTextBox.TabIndex = 2;
            // 
            // usuarios_idusuariosComboBox
            // 
            this.usuarios_idusuariosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendasBindingSource, "usuarios_idusuarios", true));
            this.usuarios_idusuariosComboBox.DataSource = this.usuariosBindingSource;
            this.usuarios_idusuariosComboBox.DisplayMember = "nome";
            this.usuarios_idusuariosComboBox.FormattingEnabled = true;
            this.usuarios_idusuariosComboBox.Location = new System.Drawing.Point(244, 72);
            this.usuarios_idusuariosComboBox.Name = "usuarios_idusuariosComboBox";
            this.usuarios_idusuariosComboBox.Size = new System.Drawing.Size(121, 21);
            this.usuarios_idusuariosComboBox.TabIndex = 4;
            this.usuarios_idusuariosComboBox.ValueMember = "idusuarios";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.banco;
            // 
            // dataMaskedTextBox
            // 
            this.dataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "data", true));
            this.dataMaskedTextBox.Location = new System.Drawing.Point(244, 99);
            this.dataMaskedTextBox.Mask = "00/00/0000";
            this.dataMaskedTextBox.Name = "dataMaskedTextBox";
            this.dataMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.dataMaskedTextBox.TabIndex = 6;
            this.dataMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // vendas_sacolesBindingSource
            // 
            this.vendas_sacolesBindingSource.DataMember = "vendas";
            this.vendas_sacolesBindingSource.DataSource = this.vendasBindingSource;
            // 
            // vendasBindingSource1
            // 
            this.vendasBindingSource1.DataMember = "vendas";
            this.vendasBindingSource1.DataSource = this.vendasBindingSource;
            // 
            // sacolesTableAdapter
            // 
            this.sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // vendas_sacolesDataGridView
            // 
            this.vendas_sacolesDataGridView.AutoGenerateColumns = false;
            this.vendas_sacolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendas_sacolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vendas_sacolesDataGridView.DataSource = this.vendas_sacolesBindingSource;
            this.vendas_sacolesDataGridView.Location = new System.Drawing.Point(45, 125);
            this.vendas_sacolesDataGridView.Name = "vendas_sacolesDataGridView";
            this.vendas_sacolesDataGridView.RowHeadersVisible = false;
            this.vendas_sacolesDataGridView.Size = new System.Drawing.Size(548, 220);
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Num. Venda";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sacoles_idsacoles";
            this.dataGridViewTextBoxColumn3.DataSource = this.SacoleBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "sabor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sacolé";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "idSacoles";
            // 
            // SacoleBindingSource
            // 
            this.SacoleBindingSource.DataMember = "sacoles";
            this.SacoleBindingSource.DataSource = this.banco;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 357);
            this.Controls.Add(this.vendas_sacolesDataGridView);
            this.Controls.Add(idvendasLabel);
            this.Controls.Add(this.idvendasTextBox);
            this.Controls.Add(usuarios_idusuariosLabel);
            this.Controls.Add(this.usuarios_idusuariosComboBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataMaskedTextBox);
            this.Controls.Add(this.vendasBindingNavigator);
            this.Name = "vend";
            this.Text = "vend";
            this.Load += new System.EventHandler(this.vend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingNavigator)).EndInit();
            this.vendasBindingNavigator.ResumeLayout(false);
            this.vendasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SacoleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private banco banco;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private bancoTableAdapters.vendasTableAdapter vendasTableAdapter;
        private bancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vendasBindingNavigatorSaveItem;
        private bancoTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.TextBox idvendasTextBox;
        private System.Windows.Forms.ComboBox usuarios_idusuariosComboBox;
        private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private bancoTableAdapters.vendas_sacolesTableAdapter vendas_sacolesTableAdapter;
        private System.Windows.Forms.BindingSource vendas_sacolesBindingSource;
        private System.Windows.Forms.BindingSource vendasBindingSource1;
        private bancoTableAdapters.sacolesTableAdapter sacolesTableAdapter;
        private System.Windows.Forms.DataGridView vendas_sacolesDataGridView;
        private System.Windows.Forms.BindingSource SacoleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Timer timer1;
    }
}